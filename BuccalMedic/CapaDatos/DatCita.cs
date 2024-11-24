using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatCita
    {
        #region Constructor y patron singleton
        static readonly DatCita _instancia = new DatCita();


        public DatCita()
        {
            Debug.WriteLine("Se creo una instancia de DaCita");
        }

        public static DatCita Instancia { get { return DatCita._instancia; } }
        #endregion

        private List<Dictionary<string, string>> ToList(String peziduri, List<SqlParameter> parameters)
        {
            List<Dictionary<string, string>> citas = new List<Dictionary<string, string>>();
            DataTable dataTable = new DataTable();
            SqlConnection conexion = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand(peziduri, conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter parametro in parameters)
            {
                cmd.Parameters.Add(parametro);
            }
            conexion.Open();

            SqlDataReader query = cmd.ExecuteReader();
            dataTable.Load(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow fila in dataTable.Rows)
                {
                    Dictionary<string, string> cita = new Dictionary<string, string>
                    {
                        { "CitaID", fila["CitaId"].ToString() },
                        { "FechaProgramacion", fila["FechaProgramacion"].ToString() },
                        { "NombreOdontologo", fila["Odontologo"].ToString() },
                        { "DNI", fila["DNI"].ToString() },
                        { "NombreCliente", fila["Paciente"].ToString() },
                        { "Tratamiento", fila["Tratamiento"].ToString() },
                        { "Estado", fila["Estado"].ToString() }
                    };
                    citas.Add(cita);
                }
            }
            else
            {
                Debug.WriteLine($"No se encontró ningún registro al listar y filtrar Citas.\nStore procedure: {peziduri}");
            }

            return citas;
        }

        public List<Dictionary<string, string>> ListarCita(string dni = null, string odontologo = null, string paciente = null, DateTime? fecha = null)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            Debug.WriteLine("Filtros agregados: ");
            if (!string.IsNullOrEmpty(dni))
            {
                parameters.Add(new SqlParameter("@DNI", dni));
                Console.Write(" -DNI- ");
            }

            if (!string.IsNullOrEmpty(odontologo))
            {
                parameters.Add(new SqlParameter("@Odontologo", odontologo));
                Console.Write(" -Odontologo- ");
            }

            if (!string.IsNullOrEmpty(paciente)) 
            {
                parameters.Add(new SqlParameter("@Paciente", paciente));
                Console.Write(" -Paciente- ");
            }

            return ToList("spListaCitasFiltradas", parameters);
        }

        /* CITAS ODONTOLOGO */

        private List<Dictionary<string, string>> TCitasOdontologo(String peziduri, List<SqlParameter> parameters)
        {
            List<Dictionary<string, string>> citas = new List<Dictionary<string, string>>();
            DataTable dataTable = new DataTable();
            SqlConnection conexion = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand(peziduri, conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter parametro in parameters)
            {
                cmd.Parameters.Add(parametro);
            }
            conexion.Open();

            SqlDataReader query = cmd.ExecuteReader();
            dataTable.Load(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow fila in dataTable.Rows)
                {
                    Dictionary<string, string> cita = new Dictionary<string, string>
                    {
                        { "Id_Cita", fila["CitaID"].ToString() },
                        { "Fecha_Registro", fila["FechaRegistroCita"].ToString() },
                        { "DNI", fila["DNI"].ToString() },
                        { "NombreCliente", fila["Paciente"].ToString() },
                        { "Tratamiento", fila["Tratamiento"].ToString() },
                        { "Estado", fila["Estado"].ToString() }
                    };
                    citas.Add(cita);
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return citas;
        }

        public List<Dictionary<string, string>> ListarCitaOdontologo(int idEmpleado, string cargo, string dni = null, string paciente = null, DateTime? fecha = null)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Id_Empleado", idEmpleado));
            parameters.Add(new SqlParameter("@Cargo", cargo));

            if (!string.IsNullOrEmpty(dni))
                parameters.Add(new SqlParameter("@DNI", dni));

            if (!string.IsNullOrEmpty(paciente))
                parameters.Add(new SqlParameter("@Paciente", paciente));

            if (fecha.HasValue)
                parameters.Add(new SqlParameter("@FechaRegistro", fecha.Value));

            return TCitasOdontologo("spListaCitasPorOdontologo", parameters);
        }


        // Modificar estado 

        public bool AnularCita(string idCita)
        {
            bool result = false;
            using (SqlConnection conexion = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spAnularCita", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Id_Cita", idCita));

                    conexion.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        // DETALLE CITA
        public Dictionary<string, string> TipoDeCita(string idCita)
        {

            Dictionary<string, string> tipoCita = new Dictionary<string, string>();

            DataTable dataTable = new DataTable();
            SqlConnection conexion = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("spTipoDeCita", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Cita", idCita);

            conexion.Open();

            SqlDataReader query = cmd.ExecuteReader();
            dataTable.Load(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow fila in dataTable.Rows)
                {
                    tipoCita.Add("tipoCita", fila["tipoCita"].ToString());
                    tipoCita.Add("estado", fila["estado"].ToString());

                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return tipoCita;
        }


        public List<Cita> ObtenerCitasPorEmpleado(int id_empleado)
        {
            List<Cita> citas = new List<Cita>();
            SqlCommand comando = null;

            try
            {
                SqlConnection conexion = Conexion.Instancia.Conectar();
                comando = new SqlCommand("sp_BuscarCitasPorEmpleado", conexion); // Nombre del procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdEmpleado", id_empleado);

                conexion.Open();
                SqlDataReader data = comando.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(data);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow fila in dataTable.Rows)
                    {
                        Cita cita = new Cita
                        {
                            CitaID = (fila["CitaID"]).ToString(),
                            EmpleadoID = ((int)fila["EmpleadoID"]),
                            ClienteID = Convert.ToInt32(fila["ClienteID"]),
                            FechaRegistroCita = Convert.ToDateTime(fila["FechaRegistroCita"]),
                            FechaProgramacion = Convert.ToDateTime(fila["FechaProgramacion"]),
                            FechaFinCita = Convert.ToDateTime(fila["Fecha_fin_provisional"]),
                            Estado = fila["Estado"].ToString()
                            // Otros campos de Cita que necesites agregar aquí
                        };

                        citas.Add(cita);
                    }
                }
                else
                {
                    Debug.WriteLine("No se encontraron citas para el empleado especificado.");
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Errorcito: " + e.Message);
            }
            finally
            {
                if (comando != null)
                {
                    comando.Connection.Close();
                }
            }

            return citas;
        }


        public bool InsertarCita(Cita cita)
        {
            SqlCommand comando = null;
            bool resultado = false;

            try
            {
                SqlConnection conexion = Conexion.Instancia.Conectar();
                comando = new SqlCommand("sp_InsertarCita", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Añadir los parámetros necesarios para el procedimiento almacenado
                comando.Parameters.AddWithValue("@Id_Cita", cita.CitaID);
                comando.Parameters.AddWithValue("@Id_cliente", cita.ClienteID);
                comando.Parameters.AddWithValue("@Fecha_registro", cita.FechaRegistroCita);
                comando.Parameters.AddWithValue("@Fecha_inicio", cita.FechaProgramacion);
                comando.Parameters.AddWithValue("@Estado", cita.Estado);
                //comando.Parameters.AddWithValue("@Fecha_fin", cita.Fecha_fin);
                comando.Parameters.AddWithValue("@id_empleado", cita.EmpleadoID);

                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();

                // Verificar si se insertó al menos una fila
                resultado = filasAfectadas > 0;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                if (comando != null)
                {
                    comando.Connection.Close();
                }
            }
            return resultado;
        }

        public List<Dictionary<string, string>> HistorialCitas(int idEmpleado, string tipoCita ,string paciente = null, DateTime? fecha = null, string idcita = null)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@Id_Empleado", idEmpleado));
            parameters.Add(new SqlParameter("@TipoCita", tipoCita));

            if (!string.IsNullOrEmpty(paciente))
                parameters.Add(new SqlParameter("@Nombre", paciente));

            if (fecha.HasValue)
                parameters.Add(new SqlParameter("@Fecha_Registro", fecha.Value));

            if (!string.IsNullOrEmpty(idcita))
                parameters.Add(new SqlParameter("@Id_Cita", idcita));

            List<Dictionary<string, string>> citas = new List<Dictionary<string, string>>();
            DataTable dataTable = new DataTable();
            SqlConnection conexion = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("spHistorialDeCitas", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter parametro in parameters)
            {
                cmd.Parameters.Add(parametro);
            }
            conexion.Open();

            SqlDataReader query = cmd.ExecuteReader();
            dataTable.Load(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow fila in dataTable.Rows)
                {
                    Dictionary<string, string> cita = new Dictionary<string, string>
                    {
                        { "Id_Cita", fila["CitaID"].ToString() },
                        { "Fecha_Registro", fila["FechaRegistroCita"].ToString() },
                        { "Paciente", fila["Paciente"].ToString() },
                  
                    };
                    citas.Add(cita);
                }
            }
            else
            {
                Debug.WriteLine($"No se encontró ningún registro al listar y filtrar Citas.\nStore procedure:spHistorialDeCitas");
            }

            return citas;
        }

        public List<Dictionary<string, string>> HistorialCitas(string tipo, string citaid = null, string paciente = null, DateTime? fecha = null)
        {
            List<Dictionary<string, string>> citas = new List<Dictionary<string, string>>();
            DataTable dataTable = new DataTable();
            SqlConnection conexion = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand();
          
            cmd = new SqlCommand("sp_lista", conexion);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@CitaID", citaid);
            cmd.Parameters.AddWithValue("@Paciente", paciente);
            cmd.Parameters.AddWithValue("@FechaRegistro", fecha);


            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            SqlDataReader query = cmd.ExecuteReader();
            dataTable.Load(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow fila in dataTable.Rows)
                {
                    Dictionary<string, string> cita = new Dictionary<string, string>
                    {
                        { "Id_Cita", fila["CitaID"].ToString() },
                        { "Fecha_Registro", fila["FechaProgramacion"].ToString() },
                        { "Paciente", fila["Paciente"].ToString() },

                    };
                    citas.Add(cita);
                }
            }
            else
            {
                Debug.WriteLine($"No se encontró ningún registro al listar y filtrar Citas.\nStore procedure:spHistorialDeCitas");
            }

            return citas;
        }


    }
}

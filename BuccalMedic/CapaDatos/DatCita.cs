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

        // LISTAR CITAS
        private List<Dictionary<string, string>> ToList(String peziduri)
        {
            List<Dictionary<string, string>> citas = new List<Dictionary<string, string>>();
            DataTable data = Conexion.Instancia.PeziDuri(peziduri);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow fila in data.Rows)
                {
                    Dictionary<string, string> cita = new Dictionary<string, string>
                    {
                        { "Id_Cita", fila["Id_Cita"].ToString() },
                        { "Fecha_Registro", fila["Fecha_Registro"].ToString() },
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
                Debug.WriteLine("El DataTable está vacío.");
            }

            return citas;
        }

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
                        { "Id_Cita", fila["Id_Cita"].ToString() },
                        { "Fecha_Registro", fila["Fecha_Registro"].ToString() },
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
                Debug.WriteLine("El DataTable está vacío.");
            }

            return citas;
        }

        public List<Dictionary<string, string>> ListarCita(string dni = null, string odontologo = null, string paciente = null, DateTime? fecha = null)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(dni))
                parameters.Add(new SqlParameter("@DNI", dni));

            if (!string.IsNullOrEmpty(odontologo))
                parameters.Add(new SqlParameter("@Odontologo", odontologo));

            if (!string.IsNullOrEmpty(paciente))
                parameters.Add(new SqlParameter("@Paciente", paciente));

            if (fecha.HasValue)
                parameters.Add(new SqlParameter("@FechaRegistro", fecha.Value));

            return ToList("spListaCitasFiltradas", parameters);
        }

        // ANULAR CITAS
        public void AnularCita(string idCita)
        {
            using (SqlConnection conn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spAnularCita", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Cita", idCita);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
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
                        { "Id_Cita", fila["Id_Cita"].ToString() },
                        { "Fecha_Registro", fila["Fecha_Registro"].ToString() },
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

        public void ModificarEstado(string idCita)
        {
            using (SqlConnection conexion = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spAtenderCita", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Id_Cita", idCita));

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
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

        public Dictionary<string, string> CitaConsulta(string idCita, string estado)
        {
            Dictionary<string, string> detalleCita = new Dictionary<string, string>();
            DataTable dataTable = new DataTable();
            SqlConnection conexion = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("spDatosCita", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Cita", idCita);
            cmd.Parameters.AddWithValue("@Estado", estado);

            conexion.Open();

            SqlDataReader query = cmd.ExecuteReader();
            dataTable.Load(query);

            if (dataTable.Rows.Count > 0)
            {
                Debug.WriteLine("Si tiene registros");
                foreach (DataRow fila in dataTable.Rows)
                {
                    detalleCita.Add("Id_Cita", fila["Id_Cita"].ToString());
                    detalleCita.Add("Fecha_Registro", fila["Fecha_Registro"].ToString());
                    detalleCita.Add("Odontologo", fila["Odontologo"].ToString());
                    detalleCita.Add("DNI", fila["DNI"].ToString());
                    detalleCita.Add("Paciente", fila["Paciente"].ToString());
                    detalleCita.Add("Estado", fila["Estado"].ToString());

                    if (estado == "ATENDIDO")
                    {
                        detalleCita.Add("Recomendaciones", fila["Recomendaciones"].ToString());
                        detalleCita.Add("Resultado", fila["Resultado"].ToString());
                    }
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return detalleCita;
        }

        public Dictionary<string, string> CitaTratamiento(string idCita, string estado)
        {
            Dictionary<string, string> detalleCita = new Dictionary<string, string>();
            DataTable dataTable = new DataTable();
            SqlConnection conexion = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("spDatosTratamiento", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Cita", idCita);
            cmd.Parameters.AddWithValue("@Estado", estado);

            conexion.Open();

            SqlDataReader query = cmd.ExecuteReader();
            dataTable.Load(query);

            if (dataTable.Rows.Count > 0)
            {
                Debug.WriteLine("Si tiene registros");
                foreach (DataRow fila in dataTable.Rows)
                {
                    detalleCita.Add("Id_Cita", fila["Id_Cita"].ToString());
                    detalleCita.Add("Fecha_Registro", fila["Fecha_Registro"].ToString());
                    detalleCita.Add("Odontologo", fila["Odontologo"].ToString());
                    detalleCita.Add("DNI", fila["DNI"].ToString());
                    detalleCita.Add("Paciente", fila["Paciente"].ToString());
                    detalleCita.Add("Estado", fila["Estado"].ToString());

                    if (estado == "ATENDIDO")
                    {
                        detalleCita.Add("Tratamiento", fila["Tratamiento"].ToString());
                        detalleCita.Add("Procedimiento", fila["Procedimiento"].ToString());
                        detalleCita.Add("Recomendaciones", fila["Recomendaciones"].ToString());
                    }
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return detalleCita;
        }


        public List<string> TratamientosDiagnosticos(string idCita)
        {
            List<string> tratamientos = new List<string>();
            DataTable dataTable = new DataTable();
            SqlConnection conexion = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("spTratamientosDiagnostico", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Cita", idCita);
          

            conexion.Open();

            SqlDataReader query = cmd.ExecuteReader();
            dataTable.Load(query);

            if (dataTable.Rows.Count > 0)
            {
                Debug.WriteLine("Si tiene registros");
                foreach (DataRow fila in dataTable.Rows)
                {
                    tratamientos.Add(fila["Tratamiento"].ToString());
                    
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return tratamientos;
        }
    }
}

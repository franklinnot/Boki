using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatCitaConsulta
    {
        #region Constructor y patron singleton
        static readonly DatCitaConsulta _instancia = new DatCitaConsulta();


        public DatCitaConsulta()
        {
            Debug.WriteLine("Se creo una instancia de DaCita");
        }

        public static DatCitaConsulta Instancia { get { return DatCitaConsulta._instancia; } }
        #endregion

        public bool InsertarCitaConsulta(Cita_consulta cita)
        {
            SqlCommand comando = null;
            bool resultado = false;

            try
            {
                SqlConnection conexion = Conexion.Instancia.Conectar();
                comando = new SqlCommand("sp_InsertarConsulta", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Añadir los parámetros necesarios para el procedimiento almacenado
                comando.Parameters.AddWithValue("@Id_cita", cita.Id_cita);
                comando.Parameters.AddWithValue("@Id_CitaConsulta", cita.Id_citaconsulta);
          
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


        public Dictionary<string, string> DetalleCitaConsulta(string idCita, string estado)
        {
            Dictionary<string, string> detalleCita = new Dictionary<string, string>();
            DataTable dataTable = new DataTable();
            SqlConnection conexion = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("spDatosCita", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Cita", "C0001");
            cmd.Parameters.AddWithValue("@Estado", "PENDIENTE");

            conexion.Open();

            SqlDataReader query = cmd.ExecuteReader();
            dataTable.Load(query);

            if (dataTable.Rows.Count > 0)
            {
                Debug.WriteLine("Si tiene registros");
                foreach (DataRow fila in dataTable.Rows)
                {
                    detalleCita.Add("Id_Cita", fila["CitaID"].ToString());
                    detalleCita.Add("Fecha_Registro", fila["FechaRegistroCita"].ToString());
                    detalleCita.Add("Odontologo", fila["Odontologo"].ToString());
                    detalleCita.Add("DNI", fila["DNI"].ToString());
                    detalleCita.Add("Paciente", fila["Paciente"].ToString());
                    detalleCita.Add("Estado", fila["Estado"].ToString());

                    if (estado == "ATENDIDO")
                    {
                        detalleCita.Add("Recomendaciones", fila["Recomendacion"].ToString());
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


        public string IdConsulta(string idCita)
        {
            string idConsulta = string.Empty;
            DataTable dataTable = new DataTable();
            SqlConnection conexion = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("spIdConsulta", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdCita", idCita);


            conexion.Open();

            SqlDataReader query = cmd.ExecuteReader();
            dataTable.Load(query);

            if (dataTable.Rows.Count > 0)
            {
                Debug.WriteLine("Si tiene registros");
                foreach (DataRow fila in dataTable.Rows)
                {
                    idConsulta = fila["Id_citaconsulta"].ToString();

                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return idConsulta;
        }

        private List<Dictionary<string, string>> ToList(String peziduri, List<SqlParameter> parameters)
        {
            List<Dictionary<string, string>> citaConsultas = new List<Dictionary<string, string>>();
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
                    Dictionary<string, string> citaconsulta = new Dictionary<string, string>
                    {

                        { "Paciente", fila["Paciente"].ToString() },
                        { "Id_citaConsulta", fila["Id_citaConsulta"].ToString() },
                        { "Fecha_Registro", fila["Fecha_Registro"].ToString() },
                    };
                    citaConsultas.Add(citaconsulta);
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return citaConsultas;
        }


    }
}

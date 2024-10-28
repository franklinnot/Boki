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


    }
}

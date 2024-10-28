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


    }
}

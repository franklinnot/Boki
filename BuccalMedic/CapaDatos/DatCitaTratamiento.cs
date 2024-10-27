using CapaEntidad;
using System;
using System.Data;
using System.Data.SqlClient; // Asegúrate de incluir esto
using System.Diagnostics; // Para usar Debug

namespace CapaDatos
{
    public class DatCitaTratamiento
    {
        #region Constructor y patron singleton
        static readonly DatCitaTratamiento _instancia = new DatCitaTratamiento();

        private DatCitaTratamiento()
        {
            Debug.WriteLine("Se creó una instancia de DatAtencion");
        }

        public static DatCitaTratamiento Instancia { get { return DatCitaTratamiento._instancia; } }
        #endregion

        public bool InsertarAtencion(Cita_tratamiento tratamiento)
        {
            SqlCommand comando = null;
            bool resultado = false;

            try
            {
                SqlConnection conexion = Conexion.Instancia.Conectar();
                comando = new SqlCommand("SP_RegistrarAtencion", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Id_citatratamiento", tratamiento.Id_citatratamiento);
                comando.Parameters.AddWithValue("@Id_Cita", tratamiento.Id_cita);
                comando.Parameters.AddWithValue("@Id_Tratamiento", tratamiento.Id_Tratamiento);
                comando.Parameters.AddWithValue("@Procedimiento", tratamiento.Procedimiento);
                comando.Parameters.AddWithValue("@Recomendaciones", tratamiento.Recomendaciones);

                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
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

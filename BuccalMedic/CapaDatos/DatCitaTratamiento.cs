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
    public class DatCitaTratamiento
    {


        #region Constructor y patron singleton
        static readonly DatCitaTratamiento _instancia = new DatCitaTratamiento();


        public DatCitaTratamiento()
        {
            Debug.WriteLine("Se creo una instancia de DaCita");
        }

        public static DatCitaTratamiento Instancia { get { return DatCitaTratamiento._instancia; } }
        #endregion

        public bool InsertarCitaTratamiento(Cita_tratamiento cita)
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
                comando.Parameters.AddWithValue("@Id_CitaTratamiento", cita.Id_citatratamiento);
                comando.Parameters.AddWithValue("@Id_Tratamiento", cita.Id_Tratamiento);

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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class DatDiagnostico
    {
        #region Constructor y patron singleton
        static readonly DatDiagnostico _instancia = new DatDiagnostico();

        private DatDiagnostico()
        {
            Debug.WriteLine("Se creó una instancia de DatDiagnostico");
        }

        public static DatDiagnostico Instancia { get { return DatDiagnostico._instancia; } }
        #endregion

        public bool InsertarDiagnosticos(Diagnostico diagnostico)
        {
            SqlCommand comando = null;
            bool resultado = false;

            try
            {
                SqlConnection conexion = Conexion.Instancia.Conectar();
                comando = new SqlCommand("SP_RegistarDiagnostico", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Añadir los parámetros necesarios para el procedimiento almacenado
                comando.Parameters.AddWithValue("@id_diagnostico", diagnostico.Id_diagnostico);
                comando.Parameters.AddWithValue("@id_citaconsulta", diagnostico.Id_citaconsulta);
                comando.Parameters.AddWithValue("@recomendacion", diagnostico.Recomendaciones);
                comando.Parameters.AddWithValue("@resultado", diagnostico.Resultado);

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

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
    public class DatTratamientoDiagnostico
    {
        #region Constructor y patrón singleton
        static readonly DatTratamientoDiagnostico _instancia = new DatTratamientoDiagnostico();

        // Constructor privado para el patrón singleton
        private DatTratamientoDiagnostico()
        {
            Debug.WriteLine("Se creó una instancia de DatTratamientoDiagnostico");
        }


        public static DatTratamientoDiagnostico Instancia
        {
            get
            {
                return DatTratamientoDiagnostico._instancia;
            }
        }
        #endregion

        public bool InsertarTratamientoDiagnosticos(DiagnosticoTratamiento tratdiag)
        {
            SqlCommand comando = null;
            bool resultado = false;

            try
            {
                SqlConnection conexion = Conexion.Instancia.Conectar();
                comando = new SqlCommand("SP_RegistrartratamientosDiagnosticos", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Añadir los parámetros necesarios para el procedimiento almacenado
                comando.Parameters.AddWithValue("@Id_diagnostico", tratdiag.DiagnosticoID);
                comando.Parameters.AddWithValue("@Id_Tratamiento", tratdiag.TratamientoID);

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

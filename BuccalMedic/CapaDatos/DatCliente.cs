using CapaEntidad;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CapaDatos
{
    public class DatCliente
    {
        #region Constructor y patron singleton
        static readonly DatCliente _instancia = new DatCliente();

        public DatCliente()
        {
            Debug.WriteLine("Se creo una instancia de DatCliente");
        }

        public static DatCliente Instancia { get { return DatCliente._instancia; } }
        #endregion

        public bool InsertarCliente(Cliente cliente)
        {
            SqlCommand comando = null;
            bool resultado = false;

            try
            {
                SqlConnection conexion = Conexion.Instancia.Conectar();
                comando = new SqlCommand("sp_InsertarCliente", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Añadir los parámetros necesarios para el procedimiento almacenado
                comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@Genero", cliente.Genero);
                comando.Parameters.AddWithValue("@Fecha_nacimiento", cliente.Fecha_nacimiento.HasValue ? (object)cliente.Fecha_nacimiento.Value : DBNull.Value);
                comando.Parameters.AddWithValue("@DNI", cliente.DNI);
                comando.Parameters.AddWithValue("@Estado", cliente.Estado);

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

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

        public Cliente BuscarClienteDNI(string dni)
        {
            SqlCommand comando = null;
            Cliente cliente = new Cliente();
            try
            {
                SqlConnection conexion = Conexion.Instancia.Conectar();
                comando = new SqlCommand("sp_BuscarClienteDNI", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@dni_Cliente", dni);

                conexion.Open();
                SqlDataReader data = comando.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(data);
                foreach (DataRow fila in dataTable.Rows)
                {
                    Cliente cli = new Cliente
                    {
                        Id_cliente = Convert.ToInt32(fila["Id_cliente"]),
                        Nombre = fila["Nombre"].ToString(),
                        Genero = fila["Genero"].ToString(),
                        Fecha_nacimiento = (DateTime?)fila["Fecha_nacimiento"],
                        DNI = fila["DNI"].ToString(),
                        Estado = fila["Estado"].ToString()
                    };

                    cliente = cli;
                }   
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

            return cliente;
        }
        public bool BuscarClienteDNI_bool(string dni)
        {

            SqlCommand comando = null;
            try
            {
                using (SqlConnection conexion = Conexion.Instancia.Conectar())
                {
                    comando = new SqlCommand("sp_BuscarClienteDNI", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@dni_Cliente", dni);

                    conexion.Open();
                    using (SqlDataReader data = comando.ExecuteReader())
                    {

                        if (data.HasRows)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);

            }
            finally
            {
                if (comando != null && comando.Connection != null)
                {
                    comando.Connection.Close();
                }
            }

            return false;
        }

    }


}

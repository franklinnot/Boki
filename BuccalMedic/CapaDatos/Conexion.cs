using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {

        private static readonly Conexion _instancia = new Conexion();

        public Conexion() 
        {
            Debug.WriteLine("Se creo una instancia de Conexion");
        }

        public static Conexion Instancia { get { return Conexion._instancia; } }

        public SqlConnection Conectar()
        {
            // Solo cambiar los datos de server o database si falla algo en la conexion
            // Asegurarse antes de cambiar estos datos.
            string server = "localhost";
            string database = "Bucal"; // Asegurarse que la base de datos tenga este nombre

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = $"Data Source={server}; Initial Catalog = {database}; Integrated Security=true; TrustServerCertificate=True;";

            return connection;
        }

        // SOLO APLICABLE PARA PEZIDURIS SIN PARAMETROS, caso contrario debe realizarse desde
        // la propia clase Dat, por ejemplo DatEmpleado

        // No necesitan cambiar este metodo
        // Para que se guien como usarlo, revisen la clase DatEmpleado (capaDatos) y revisen el metodo ToList
        // Lo pueden usar para cualquier clase, tan solo haciendo que devuelva otro tipo de dato y
        // sus columnas coincidan

        // Todos los store procedures estaran y deben estar en el archivo README.md del repositorio
        public DataTable PeziDuri(string peziduri)
        {
            SqlCommand comando = null;
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = Conexion.Instancia.Conectar();
                comando = new SqlCommand(peziduri, connection);
                comando.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader data = comando.ExecuteReader();

                dataTable.Load(data); 
            }
            catch (Exception e)
            {
                Debug.Write($"Me dio amsieda: {e.Message}");
            }
            finally
            {
                if (comando != null)
                {
                    comando.Connection.Close();
                }
            }

            return dataTable;
        }



    }
}

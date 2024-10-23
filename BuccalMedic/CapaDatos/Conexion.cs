using System;
using System.Collections.Generic;
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

        public static Conexion Query { get { return Conexion._instancia; } }

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
    }

}

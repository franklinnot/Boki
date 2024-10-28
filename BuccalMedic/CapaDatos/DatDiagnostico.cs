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
                comando = new SqlCommand("sp_RegistrarDiagnostico", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Añadir los parámetros necesarios para el procedimiento almacenado
                comando.Parameters.AddWithValue("@Id_diagnostico", diagnostico.Id_diagnostico);
                comando.Parameters.AddWithValue("@Id_citaconsulta", diagnostico.Id_citaconsulta);
                comando.Parameters.AddWithValue("@Recomendaciones", diagnostico.Recomendaciones);
                comando.Parameters.AddWithValue("@Resultado", diagnostico.Resultado);

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


        public List<string> Tratamientos_Diagnostico(string idCita)
        {
            List<string> tratamientos = new List<string>();
            DataTable dataTable = new DataTable();
            SqlConnection conexion = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("spTratamientosDiagnostico", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Cita", idCita);


            conexion.Open();

            SqlDataReader query = cmd.ExecuteReader();
            dataTable.Load(query);

            if (dataTable.Rows.Count > 0)
            {
                Debug.WriteLine("Si tiene registros");
                foreach (DataRow fila in dataTable.Rows)
                {
                    tratamientos.Add(fila["Tratamiento"].ToString());

                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return tratamientos;
        }

    }
}

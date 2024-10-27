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
            Debug.WriteLine("Se creo una instancia de DaCitaTratamiento");
        }

        public static DatCitaConsulta Instancia { get { return DatCitaConsulta._instancia; } }
        #endregion

        // LISTAR CITAS

        private List<Dictionary<string, string>> ToList(String peziduri, List<SqlParameter> parameters)
        {
            List<Dictionary<string, string>> citaConsultas = new List<Dictionary<string, string>>();
            DataTable dataTable = new DataTable();
            SqlConnection conexion = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand(peziduri, conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter parametro in parameters)
            {
                cmd.Parameters.Add(parametro);
            }
            conexion.Open();

            SqlDataReader query = cmd.ExecuteReader();
            dataTable.Load(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow fila in dataTable.Rows)
                {
                    Dictionary<string, string> citaconsulta = new Dictionary<string, string>
                    {

                        { "Paciente", fila["Paciente"].ToString() },
                        { "Id_citaConsulta", fila["Id_citaConsulta"].ToString() },
                        { "Fecha_Registro", fila["Fecha_Registro"].ToString() },
                    };
                    citaConsultas.Add(citaconsulta);
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return citaConsultas;
        }

        public List<Dictionary<string, string>> ListarCitaConsulta(string paciente = null, DateTime? fecha = null, string idcita = null)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(paciente))
                parameters.Add(new SqlParameter("@Nombre", paciente));

            if (fecha.HasValue)
                parameters.Add(new SqlParameter("@Fecha_Registro", fecha.Value));

            if (!string.IsNullOrEmpty(idcita))
                parameters.Add(new SqlParameter("@Id_citaConsulta", idcita));

            return ToList("[spListaCitasConsulta]", parameters);
        }

    }
}

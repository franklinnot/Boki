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
            Debug.WriteLine("Se creo una instancia de DaCitaTratamiento");
        }

        public static DatCitaTratamiento Instancia { get { return DatCitaTratamiento._instancia; } }
        #endregion

        // LISTAR CITAS
        private List<Dictionary<string, string>> ToList(String peziduri)
        {
            List<Dictionary<string, string>> citaTratamientos = new List<Dictionary<string, string>>();
            DataTable data = Conexion.Instancia.PeziDuri(peziduri);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow fila in data.Rows)
                {
                    Dictionary<string, string> cita_tratamiento = new Dictionary<string, string>
                    {
                        { "Id_citatratamiento", fila["Id_citatratamiento"].ToString() },
                        { "Id_cita", fila["Id_cita"].ToString() },
                        { "Id_Tratamiento", fila["Id_Tratamiento"].ToString() },
                        { "Procedimiento", fila["Procedimiento"].ToString() },
                        { "Recomendaciones", fila["Recomendaciones"].ToString() },
                    };
                    citaTratamientos.Add(cita_tratamiento);
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return citaTratamientos;
        }

        private List<Dictionary<string, string>> ToList(String peziduri, List<SqlParameter> parameters)
        {
            List<Dictionary<string, string>> citaTratamientos = new List<Dictionary<string, string>>();
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
                    Dictionary<string, string> cita = new Dictionary<string, string>
                    {
                        { "IdCita", fila["Id_cita"].ToString() },
                        { "Paciente", fila["Paciente"].ToString() },
                        { "Fecha_Registro", fila["Fecha_Registro"].ToString() },
                    };
                    citaTratamientos.Add(cita);
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return citaTratamientos;
        }

        public List<Dictionary<string, string>> ListarCitaTratamiento(string idcita = null, string paciente = null, DateTime? fecha = null)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(paciente))
                parameters.Add(new SqlParameter("@Nombre", paciente));

            if (!string.IsNullOrEmpty(idcita))
                parameters.Add(new SqlParameter("@IdCita", idcita));

            if (fecha.HasValue)
                parameters.Add(new SqlParameter("@FechaRegistro", fecha.Value));

            return ToList("spListaCitasTratamientoFiltradas", parameters);
        }
    }
}

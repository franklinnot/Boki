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
    public class DatCita
    {
        #region Constructor y patron singleton
        static readonly DatCita _instancia = new DatCita();


        public DatCita()
        {
            Debug.WriteLine("Se creo una instancia de DaCita");
        }

        public static DatCita Instancia { get { return DatCita._instancia; } }
        #endregion

        // LISTAR CITAS
        private List<Dictionary<string, string>> ToList(String peziduri)
        {
            List<Dictionary<string, string>> citas = new List<Dictionary<string, string>>();
            DataTable data = Conexion.Instancia.PeziDuri(peziduri);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow fila in data.Rows)
                {
                    Dictionary<string, string> cita = new Dictionary<string, string>
                    {
                        { "Id_Cita", fila["Id_Cita"].ToString() },
                        { "Fecha_Registro", fila["Fecha_Registro"].ToString() },
                        { "NombreOdontologo", fila["Odontologo"].ToString() },
                        { "DNI", fila["DNI"].ToString() },
                        { "NombreCliente", fila["Paciente"].ToString() },
                        { "Tratamiento", fila["Tratamiento"].ToString() },
                        { "Estado", fila["Estado"].ToString() }
                    };
                    citas.Add(cita);
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return citas;
        }

        private List<Dictionary<string, string>> ToList(String peziduri, List<SqlParameter> parameters)
        {
            List<Dictionary<string, string>> citas = new List<Dictionary<string, string>>();
            DataTable dataTable = new DataTable();
            SqlConnection conexion = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand(peziduri, conexion);
            
            cmd.CommandType = CommandType.StoredProcedure;

            foreach(SqlParameter parametro in parameters)
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
                        { "Id_Cita", fila["Id_Cita"].ToString() },
                        { "Fecha_Registro", fila["Fecha_Registro"].ToString() },
                        { "NombreOdontologo", fila["Odontologo"].ToString() },
                        { "DNI", fila["DNI"].ToString() },
                        { "NombreCliente", fila["Paciente"].ToString() },
                        { "Tratamiento", fila["Tratamiento"].ToString() },
                        { "Estado", fila["Estado"].ToString() }
                    };
                    citas.Add(cita);
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return citas;
        }

        public List<Dictionary<string, string>> ListarCita(string dni = null, string odontologo = null, string paciente = null, DateTime? fecha = null)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(dni))
                parameters.Add(new SqlParameter("@DNI", dni));

            if (!string.IsNullOrEmpty(odontologo))
                parameters.Add(new SqlParameter("@Odontologo", odontologo));

            if (!string.IsNullOrEmpty(paciente))
                parameters.Add(new SqlParameter("@Paciente", paciente));

            if (fecha.HasValue)
                parameters.Add(new SqlParameter("@FechaRegistro", fecha.Value));

            return ToList("spListaCitasFiltradas", parameters);
        }

        // ANULAR CITAS
        public void AnularCita(int idCita)
        {
           using (SqlConnection conn = Conexion.Instancia.Conectar()) 
           {
                using (SqlCommand cmd = new SqlCommand("spAnularCita", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Cita", idCita); 
                    conn.Open(); 
                    cmd.ExecuteNonQuery();  
                }
           }
        }

        /* CITAS ODONTOLOGO */



    }
}

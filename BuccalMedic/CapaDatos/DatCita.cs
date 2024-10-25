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
                    Dictionary<string, string> cita = new Dictionary<string, string>();

                    cita.Add("Id_Cita", fila["Id_Cita"].ToString());
                    cita.Add("Fecha_Registro", fila["Fecha_Registro"].ToString());
                    cita.Add("NombreOdontologo", fila["Odontologo"].ToString());
                    cita.Add("NombreCliente", fila["Paciente"].ToString());
                    cita.Add("Tratamiento", fila["Tratamiento"].ToString());
                    cita.Add("Estado", fila["Estado"].ToString());

                    citas.Add(cita);
                }

            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return citas;
        }


        public List<Dictionary<string, string>> ListarCita()
        {
            return ToList("spListaCitas");
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
    }
}

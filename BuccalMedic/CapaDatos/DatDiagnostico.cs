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

        private List<Diagnostico> ToList(string peziduri)
        {
            List<Diagnostico> diagnosticos = new List<Diagnostico>();
            DataTable data = Conexion.Instancia.PeziDuri(peziduri);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow fila in data.Rows)
                {
                    Diagnostico diagnostico = new Diagnostico
                    {
                        Id_diagnostico = fila["Id_diagnostico"].ToString(),
                        Id_citaconsulta = fila["Id_citaconsulta"].ToString(),
                        Recomendaciones = fila["Recomendaciones"].ToString(),
                        Resultado = fila["Resultado"].ToString(),
                    };

                    diagnosticos.Add(diagnostico);
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }
            return diagnosticos;
        }

        public List<Diagnostico> ListarDiagnosticos()
        {
            return ToList("SP_Listardiagnostico");
        }

        public bool InsertarDiagnostico(Diagnostico diagn)
        {
            bool inserta = false;
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_RegistarDiagnostico", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_diagnostico", diagn.Id_diagnostico);
                        cmd.Parameters.AddWithValue("@id_citaconsulta", diagn.Id_citaconsulta);
                        cmd.Parameters.AddWithValue("@recomendacion", diagn.Recomendaciones);
                        cmd.Parameters.AddWithValue("@resultado", diagn.Resultado);

                        cn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            inserta = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error: {e.Message}");
            }
            return inserta;
        }
    }
}

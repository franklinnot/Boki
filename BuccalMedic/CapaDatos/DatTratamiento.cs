using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    
    public class DatTratamiento
    {
        #region Constructor y patron singleton
        static readonly DatTratamiento _instancia = new DatTratamiento();


        public DatTratamiento()
        {
            Debug.WriteLine("Se creo una instancia de DatTratamiento");
        }

        public static DatTratamiento Instancia { get { return DatTratamiento._instancia; } }
        #endregion


        private List<Tratamiento> ToList(String peziduri)
        {
            List<Tratamiento> tratamientos = new List<Tratamiento>();
            DataTable data = Conexion.Instancia.PeziDuri(peziduri);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow fila in data.Rows)
                {
                    Tratamiento tratamiento = new Tratamiento
                    {
                        Id_Tratamiento = Convert.ToInt32(fila["Id_Tratamiento"]),
                        Descripcion = fila["Descripcion"].ToString(),
                        Nombre = fila["Nombre"].ToString(),
                        
                    };

                    tratamientos.Add(tratamiento);
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return tratamientos;
        }



        public List<Tratamiento> ListarTratamientos()
        {
            return ToList("sp_ListarTratamiento");
        }
    }
}

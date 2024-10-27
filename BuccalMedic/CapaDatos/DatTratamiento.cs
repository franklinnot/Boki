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
        #region Constructor y patrón singleton
        static readonly DatTratamiento _instancia = new DatTratamiento();

        // Constructor privado para el patrón singleton
        private DatTratamiento()
        {
            Debug.WriteLine("Se creó una instancia de DatTratamiento");
        }


        public static DatTratamiento Instancia
        {
            get
            {
                return DatTratamiento._instancia;
            }
        }
        #endregion

        private List<Tratamiento> ToList(string procedimiento)
        {
            List<Tratamiento> tratamientos = new List<Tratamiento>();
            DataTable data = Conexion.Instancia.PeziDuri(procedimiento); 

            if (data.Rows.Count > 0)
            {
                foreach (DataRow fila in data.Rows)
                {
                    Tratamiento tratamiento = new Tratamiento
                    {
                        Nombre = fila["Nombre"].ToString(),
                        Id_Tratamiento = int.Parse(fila["Id_Tratamiento"].ToString())
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
            return ToList("SP_Cargarchecklistbox");
        }
    }
}

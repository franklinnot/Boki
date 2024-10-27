using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogTratamiento
    {
        #region Constructor y patron singleton
        private static readonly LogTratamiento _instancia = new LogTratamiento();

        public static LogTratamiento Instancia { get { return LogTratamiento._instancia; } }
        #endregion

        public List<Tratamiento> ListarTratamientos()
        {
            return DatTratamiento.Instancia.ListarTratamientos();
        }
        public void InsertaTratamiento(Tratamiento tratamiento)
        {
            DatTratamiento.Instancia.RegistrarTratamientos(tratamiento);
        }
        public void EditaTratamiento(Tratamiento tratamiento)
        {
            DatTratamiento.Instancia.EditarTratamiento(tratamiento);
        }
    }
}

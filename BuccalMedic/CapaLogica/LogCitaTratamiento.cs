using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogCitaTratamiento

    {
        #region Constructor y patron singleton
        private static readonly LogCitaTratamiento _instancia = new LogCitaTratamiento();

        private LogCitaTratamiento() { }

        public static LogCitaTratamiento Instancia { get { return LogCitaTratamiento._instancia; } }
        #endregion

        public bool InsertarAtencion(Cita_tratamiento atenc)
        {
            return DatCitaTratamiento.Instancia.InsertarAtencion(atenc);
        }
    }
}

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

        public static LogCitaTratamiento Instancia { get { return LogCitaTratamiento._instancia; } }
        #endregion


        public bool InsertarCitaTratamiento(Cita_tratamiento cita)
        {
            return DatCitaTratamiento.Instancia.InsertarCitaTratamiento(cita);

        }


        public Dictionary<string, string> DetalleCitaTratamiento(string idCita, string estado)
        {
            return DatCitaTratamiento.Instancia.DetalleCitaTratamiento(idCita, estado);

        }

    }
}

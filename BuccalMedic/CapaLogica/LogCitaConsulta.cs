using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogCitaConsulta
    {

        #region Constructor y patron singleton
        private static readonly LogCitaConsulta _instancia = new LogCitaConsulta();

        public static LogCitaConsulta Instancia { get { return LogCitaConsulta._instancia; } }
        #endregion


        public bool InsertarCitaConsulta(Diagnostico diagnostico)
        {
            return DatCitaConsulta.Instancia.InsertarCitaConsulta(diagnostico);

        }

        public Dictionary<string, string> DetalleCitaConsulta(string idCita, string estado)
        {
            return DatCitaConsulta.Instancia.DetalleCitaConsulta(idCita, estado);

        }

        public string IdConsulta(string idCita)
        {
            return DatCitaConsulta.Instancia.IdConsulta(idCita);
        }

       
    }
}

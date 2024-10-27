using CapaDatos;
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



        public List<Dictionary<string, string>> ListarCitaConsulta(string paciente = null, DateTime? fecha = null, string idcita = null)
        {
            return DatCitaConsulta.Instancia.ListarCitaConsulta(paciente, fecha, idcita);
        }
    }
}

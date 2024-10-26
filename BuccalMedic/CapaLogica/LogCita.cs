using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogCita
    {
        #region Constructor y patron singleton
        private static readonly LogCita _instancia = new LogCita();

        public static LogCita Instancia { get { return LogCita._instancia; } }
        #endregion



        public List<Dictionary<string, string>> ListarCitas(string dni = null, string odontologo = null, string paciente = null, DateTime? fecha = null)
        {
            return DatCita.Instancia.ListarCita(dni, odontologo, paciente, fecha);
        }



        public void Anular(string idCita)
        {
            int id = int.Parse(idCita);
            DatCita.Instancia.AnularCita(id);
        }
    }
}

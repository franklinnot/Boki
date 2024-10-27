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

        public List<Cita> ListarCitasPorEmpleado(int id)
        {
            return DatCita.Instancia.ObtenerCitasPorEmpleado(id);
        }

        public bool InsertarCita(Cita cita)
        {
            return DatCita.Instancia.InsertarCita(cita);
        }
    }
}

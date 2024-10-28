using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogDiagnostico
    {
        #region Constructor y patron singleton
        private static readonly LogDiagnostico _instancia = new LogDiagnostico();

        private LogDiagnostico() { }

        public static LogDiagnostico Instancia { get { return LogDiagnostico._instancia; } }
        #endregion

        public bool InsertarDiagnostico(Diagnostico diagn)
        {
            return DatDiagnostico.Instancia.InsertarDiagnosticos(diagn);
        }

        public List<string> Tratamientos_Diagnostico(string idCita)
        {
            return DatDiagnostico.Instancia.Tratamientos_Diagnostico(idCita);
        }

    }
}

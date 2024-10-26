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

        public List<Diagnostico> ListarDiagnostico()
        {
            return DatDiagnostico.Instancia.ListarDiagnosticos();
        }

        public bool InsertarDiagnostico(Diagnostico diagn)
        {
            return DatDiagnostico.Instancia.InsertarDiagnostico(diagn);
        }
    }
}

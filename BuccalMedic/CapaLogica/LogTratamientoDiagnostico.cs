using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogTratamientoDiagnostico
    {
        #region Constructor y patron singleton
        private static readonly LogTratamientoDiagnostico _instancia = new LogTratamientoDiagnostico();

        private LogTratamientoDiagnostico() { }

        public static LogTratamientoDiagnostico Instancia { get { return LogTratamientoDiagnostico._instancia; } }
        #endregion

        public bool InsertarTratamientoDiagnostico(DiagnosticoTratamiento tratdiag)
        {
            return DatTratamientoDiagnostico.Instancia.InsertarTratamientoDiagnosticos(tratdiag);
        }
    }
}

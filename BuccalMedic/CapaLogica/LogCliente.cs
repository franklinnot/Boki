using CapaEntidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogCliente
    {
        #region Constructor y patron singleton
        private static readonly LogCliente _instancia = new LogCliente();

        public static LogCliente Instancia { get { return LogCliente._instancia; } }
        #endregion
        public bool BuscarClienteDNI_bool(string dni)
        {
            return DatCliente.Instancia.BuscarClienteDNI_bool(dni);
        }
        public Cliente BuscarClienteDNI(string dni)
        {
            return DatCliente.Instancia.BuscarClienteDNI(dni);
        }
    }
}

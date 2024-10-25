using CapaEntidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

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

        public bool InsertarCliente(Cliente cliente) 
        {
            if (BuscarClienteDNI_bool(cliente.DNI)) 
            {
                return false;
            }
            return DatCliente.Instancia.InsertarCliente(cliente);
        }

        public List<Cliente> ListarClientes() 
        {
            return DatCliente.Instancia.ListarClientes();
        }

    }
}

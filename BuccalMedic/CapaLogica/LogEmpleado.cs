using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogEmpleado
    {
        #region Constructor y patron singleton
        private static readonly LogEmpleado _instancia = new LogEmpleado();

        public static LogEmpleado Instancia { get { return LogEmpleado._instancia; } }
        #endregion


        public List<Empleado> ListarEmpleados()
        {
            return DatEmpleado.Instancia.ListarEmpleados();
        }
    }
}

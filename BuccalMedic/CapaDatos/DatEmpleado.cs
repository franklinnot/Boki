using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatEmpleado
    {

        #region Constructor y patron singleton
        static readonly DatEmpleado _instancia = new DatEmpleado();
        readonly Contexto _context;

        public DatEmpleado() 
        {
            _context = new Contexto();
            Debug.WriteLine("Se creo una instancia de DatEmpleado");
        }

        public static DatEmpleado Instancia { get { return DatEmpleado._instancia; } }
        #endregion

        public List<Empleado> ListarEmpleados()
        {
            var empleados = _context.Database.SqlQuery<Empleado>(
                "EXEC sp_ListarClientes").ToList();

            Debug.WriteLine("Se ejecuto el metodo de ListarEmpleados");

            return empleados;
        }
    }
}

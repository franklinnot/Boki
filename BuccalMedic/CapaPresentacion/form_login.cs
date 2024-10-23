using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void form_login_Load(object sender, EventArgs e)
        {
            List<Empleado> empleados = LogEmpleado.Instancia.ListarEmpleados();

            foreach (Empleado empleado in empleados) 
            {
                Debug.WriteLine(empleado.Nombre);
            }

            if (LogEmpleado.Instancia.BuscarEmpleadoId(45)) 
            {
                Debug.WriteLine("El id 45 si existe ,waos");
            }
            else
            {
                Debug.WriteLine("El id 45 no tiene ningun empleado asociado, pipip");
            }

        }



    }
}

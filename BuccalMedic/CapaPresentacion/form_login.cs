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

        }

        private void btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text.Trim();
            string password = txt_password.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Empleado empleado = new Empleado();
            empleado = LogEmpleado.Instancia.BuscarEmpleadoLogin(usuario, password);

            if (empleado != null) 
            {
                //form_principal formPrincipal = new form_principal(empleado);
                //formPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

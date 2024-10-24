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

            Empleado empleado = LogEmpleado.Instancia.BuscarEmpleadoLogin(usuario, password);

            if (empleado != null) 
            {
                form_recepcion form_Recepcion = new form_recepcion(empleado);
                form_Recepcion.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

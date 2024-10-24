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
        public static Empleado empleado;

        public form_login()
        {
            InitializeComponent();
            empleado = new Empleado();
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

            Empleado emp = LogEmpleado.Instancia.BuscarEmpleadoLogin(usuario, password);

            if (emp != null)
            {
                // Hace falta implementar el formulario para el odontologo
                if (emp.Cargo.ToLower() == "recepcionista")
                {
                    form_recepcion form_Recepcion = new form_recepcion();
                    form_Recepcion.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Esta sección aun se encuentra en desarrollo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                empleado = emp;

                // conforme se vaya desarrollando, se ira implementando el codigo para
                // ocultar y volver a mostrar
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

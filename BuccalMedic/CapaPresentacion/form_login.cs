using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            //probar();
            
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

            empleado = LogEmpleado.Instancia.BuscarEmpleadoLogin(usuario, password);
            MessageBox.Show(empleado.Usuario);

            if (!string.IsNullOrEmpty(empleado.Nombre))
            {
                if(empleado.Cargo == "ODONTOLOGO")
                {
                    
                    form_seleccionDoc form_Odontologo = new form_seleccionDoc();
                    form_Odontologo.ShowDialog();

                }

                else if (empleado.Cargo == "RECEPCIONISTA")
                {
                    form_recepcion form_Recepcion = new form_recepcion();
                    form_Recepcion.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cargo desconocido, no se puede abrir el formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void probar()
        {
            string idCita = "C0001";
           
            Dictionary<string, string> datosCita = LogCita.Instancia.TipoDeCita(idCita);
            string tipoCita = datosCita["tipoCita"];
            string estado = datosCita["estado"];
            MessageBox.Show(tipoCita + " " + estado);

            if (tipoCita == "TRATAMIENTO")
            {
                //detalleCita = LogCitaTratamiento.Instancia.DetalleCitaTratamiento(idCita, estado);
            }
            else if (tipoCita == "CONSULTA")
            {

                Dictionary<string,string> detalleCita = LogCitaConsulta.Instancia.DetalleCitaConsulta(idCita, estado);
                foreach(var clave in detalleCita.Keys)
                {
                    MessageBox.Show(clave + " " + detalleCita[clave]);
                }
            }
            else
            {
                MessageBox.Show("Error, codigo cita");
            }

        }

    }
}

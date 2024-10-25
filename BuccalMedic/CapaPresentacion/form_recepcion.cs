using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class form_recepcion : Form
    {
        Empleado empleado;
        public form_recepcion(Empleado emp)
        {
            InitializeComponent();
            MetodosUI.SetPlaceholder(txt_DNI, "DNI");
            MetodosUI.SetPlaceholder(cmb_odontologo,"Odontólogo");
            MetodosUI.SetPlaceholder(cmb_fecha,"Fecha");
            MetodosUI.SetPlaceholder(cmb_horario,"Horario");
            MetodosUI.SetPlaceholder(cmb_tratamiento,"Tratamiento");
            btn_registrarCita.Enabled = false;
            btn_nuevo_cliente.Enabled = false;
            empleado = new Empleado();
            empleado = emp;
        }

        private void form_recepcion_Load(object sender, EventArgs e)
        {

        }

        private void txt_DNI_TextChanged(object sender, EventArgs e)
        {
            string dni = txt_DNI.Text;
            if (dni.Length > 8)
            {
                txt_DNI.Text = txt_DNI.Text.Substring(0, 8);
                txt_DNI.SelectionStart = txt_DNI.Text.Length;
                btn_registrarCita.Enabled = false;

            }
            if (dni.Length < 8)
            {
                lbl_nombreR.Text = "complete DNI";
                btn_registrarCita.Enabled = false;
                
                btn_nuevo_cliente.Enabled = false;
               

            }

            if (dni.Length == 8)
            {
                bool c = LogCliente.Instancia.BuscarClienteDNI_bool(dni);
                if (c)
                {
                    Cliente cliente = LogCliente.Instancia.BuscarClienteDNI(dni);
                    lbl_nombreR.Text = cliente.Nombre;
                    btn_registrarCita.Enabled = true;
                    btn_nuevo_cliente.Enabled = false;
                   

                }
                else
                {
                    lbl_nombreR.Text = "not found";
                    btn_nuevo_cliente.Enabled = true;
                    btn_registrarCita.Enabled = false;
                    

                }

            }
        }
    }
}

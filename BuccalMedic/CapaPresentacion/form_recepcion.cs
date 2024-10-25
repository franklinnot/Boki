using CapaEntidad;
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

            empleado = new Empleado();
            empleado = emp;
        }

        private void form_recepcion_Load(object sender, EventArgs e)
        {

        }

        private void btn_registrarCita_Click(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_cliente_Click(object sender, EventArgs e)
        {

        }
    }
}

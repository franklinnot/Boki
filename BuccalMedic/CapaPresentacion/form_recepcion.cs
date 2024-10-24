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
        public form_recepcion()
        {
            InitializeComponent();
            MetodosUI.SetPlaceholder(txt_DNI, "DNI");
            MetodosUI.SetPlaceholder(cmb_odontologo,"Odontólogo");
            MetodosUI.SetPlaceholder(cmb_fecha,"Fecha");
            MetodosUI.SetPlaceholder(cmb_horario,"Horario");
            MetodosUI.SetPlaceholder(cmb_tratamiento,"Tratamiento");

        }


    }
}

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
    public partial class form_seleccionDoc : Form
    {
        public form_seleccionDoc()
        {
            InitializeComponent();
        }

        private void btn_tratamientod_Click(object sender, EventArgs e)
        {

        }

        private void btn_citasd_Click(object sender, EventArgs e)
        {
            form_citas_odontologo citasOdontologo = new form_citas_odontologo();
            citasOdontologo.ShowDialog();
            
        }

        private void btn_evaluacionesd_Click(object sender, EventArgs e)
        {
            //form_diagnostico form_Diagnostico = new form_diagnostico();
            //form_Diagnostico.ShowDialog();
        }
    }
}

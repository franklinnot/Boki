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
            this.Hide();
            form_tratamientos form_Tratamientos = new form_tratamientos();
            form_Tratamientos.ShowDialog();
            this.Show();
        }

        private void btn_citasd_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_citas_odontologo citasOdontologo = new form_citas_odontologo();
            citasOdontologo.ShowDialog();
            this.Show();
            
        }

        private void btn_evaluacionesd_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_evaluaciones form_Evaluaciones = new form_evaluaciones();
            form_Evaluaciones.ShowDialog();
            this.Show();
        }

        private void btn_intervencionesd_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_cirugias form_Cirugias = new form_cirugias();
            form_Cirugias.ShowDialog();
            this.Show();
        }
    }
}

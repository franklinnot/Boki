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
    public partial class form_cirugias : Form
    {
        public form_cirugias()
        {
            InitializeComponent();
            Form form_login = new Form();
            form_login.Close();
        }

        private void form_evaluaciones_Load(object sender, EventArgs e)
        {
            cirugias_dgv.Columns.Add("IdCita", "IdCita");
            cirugias_dgv.Columns.Add("Cliente", "Cliente");
            cirugias_dgv.Columns.Add("Odontologo", "Odontólogo");
            cirugias_dgv.Columns.Add("Fecha", "Fecha");
            cirugias_dgv.Columns.Add("Estado", "Estado");
            cirugias_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cirugias_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 180, 171);
            cirugias_dgv.EnableHeadersVisualStyles = false;
        }
    }
}

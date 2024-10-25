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
    public partial class form_evaluaciones : Form
    {
        public form_evaluaciones()
        {
            InitializeComponent();
            Form form_login = new Form();
            form_login.Close();
        }

        private void form_evaluaciones_Load(object sender, EventArgs e)
        {
            evaluaciones_dgv.Columns.Add("IdCita", "IdCita");
            evaluaciones_dgv.Columns.Add("Cliente", "Cliente");
            evaluaciones_dgv.Columns.Add("Odontologo", "Odontólogo");
            evaluaciones_dgv.Columns.Add("Fecha", "Fecha");
            evaluaciones_dgv.Columns.Add("Estado", "Estado");
            evaluaciones_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            evaluaciones_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 180, 171);
            evaluaciones_dgv.EnableHeadersVisualStyles = false;
        }
    }
}

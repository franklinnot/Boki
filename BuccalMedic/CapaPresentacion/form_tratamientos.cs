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
    public partial class form_tratamientos : Form
    {
        public form_tratamientos()
        {
            InitializeComponent();
            Form form_login = new Form();
            form_login.Close();
        }

        private void form_tratamientos_Load(object sender, EventArgs e)
        {
            tratamientos_dgv.Columns.Add("Nombre", "Nombre");
            tratamientos_dgv.Columns.Add("Descripcion", "Descripcion");
            tratamientos_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tratamientos_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 180, 171);
            tratamientos_dgv.EnableHeadersVisualStyles = false;
        }
    }
}

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
    public partial class form_cita : Form
    {
        public form_cita()
        {
            InitializeComponent();
            CargarCitas();
        }

        private void CargarCitas()
        {
            foreach(Dictionary<string, string> item in LogCita.Instancia.ListarCitas())
            {    
                string id = item["Id_Cita"].ToString();
                string fecha = DateTime.Parse(item["Fecha_Registro"].ToString()).ToShortDateString();
                string odontologo = item["NombreOdontologo"].ToString();
                string paciente = item["NombreCliente"].ToString();
                string tratamiento = item["Tratamiento"].ToString();
                string estado = item["Estado"].ToString();

                dgv_cita.Rows.Add(id,fecha,odontologo,paciente,tratamiento,estado);
                
            }
        }

        private string selectedCitaId; 
        private void dgv_cita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedCitaId = dgv_cita.Rows[e.RowIndex].Cells["colum_idCita"].Value.ToString();

                dgv_cita.Rows[e.RowIndex].Selected = true;
                dgv_cita.CurrentCell = dgv_cita.Rows[e.RowIndex].Cells[0];
            }
        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedCitaId))
            {
                LogCita.Instancia.Anular(selectedCitaId);
                dgv_cita.Rows.Clear();

                CargarCitas();
                MessageBox.Show("Cita anulada exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una cita para anular.");
            }
        }
    }
}

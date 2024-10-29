using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class form_cita : Form
    {
        public static Dictionary<string,string> detalleCita;
        public static string tipoCita, estado;
        private string selectedCitaId; 
     
        public form_cita()
        {
            InitializeComponent();
            CargarCitas();
            CargarCombobox();

            detalleCita = new Dictionary<string,string>();

        }

        private void CargarCitas(string dni = null, string odontologo = null, string paciente = null, DateTime? fecha = null)
        {
            dgv_cita.Rows.Clear();
            foreach (Dictionary<string, string> item in LogCita.Instancia.ListarCitas(dni, odontologo, paciente, fecha))
            {
                string id = item["Id_Cita"].ToString();
                string fechaC = DateTime.Parse(item["Fecha_Registro"].ToString()).ToShortDateString();
                string odontologoC = item["NombreOdontologo"].ToString();
                string dniC = item["DNI"].ToString();
                string pacienteC = item["NombreCliente"].ToString();
                string tratamiento = item["Tratamiento"].ToString();
                string estado = item["Estado"].ToString();

                dgv_cita.Rows.Add(id, fechaC, odontologoC, dniC, pacienteC, tratamiento, estado);

            }
        }

        private void CargarCombobox()
        {
            var citas = LogCita.Instancia.ListarCitas();

            cmb_dni.Items.Clear();
            foreach (var item in citas)
            {
                if (!cmb_dni.Items.Contains(item["DNI"]))
                {
                    cmb_dni.Items.Add(item["DNI"]);
                }
            }

            cmb_odontologoC.Items.Clear();
            foreach (var item in citas)
            {
                if (!cmb_odontologoC.Items.Contains(item["NombreOdontologo"]))
                {
                    cmb_odontologoC.Items.Add(item["NombreOdontologo"]);
                }
            }

            cmb_pacienteC.Items.Clear();
            foreach (var item in citas)
            {
                if (!cmb_pacienteC.Items.Contains(item["NombreCliente"]))
                {
                    cmb_pacienteC.Items.Add(item["NombreCliente"]);
                }
            }

        }
        
        private void FiltrarCitas()
        {
            string dni = cmb_dni.SelectedItem?.ToString();
            dni = string.IsNullOrEmpty(dni)? null:dni;
            string odontologo = cmb_odontologoC.SelectedItem?.ToString();
            odontologo = string.IsNullOrEmpty(odontologo) ? null : odontologo;
            string paciente = cmb_pacienteC.SelectedItem?.ToString();
            paciente = string.IsNullOrEmpty(paciente) ? null : paciente;

            DateTime? fecha = dtp_fechaC.Checked ? dtp_fechaC.Value : (DateTime?)null;

            CargarCitas(dni,odontologo,paciente,fecha);
        }

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
                string estadoCita = dgv_cita.Rows[dgv_cita.CurrentRow.Index].Cells["colum_estado"].Value.ToString();

                if (estadoCita == "ANULADO")
                {
                    MessageBox.Show("La cita ya ha sido anulada.");
                    return; 
                }

                bool verificar = LogCita.Instancia.AnularCita(selectedCitaId);
                if (verificar) 
                {
                    MessageBox.Show("Cita anulada exitosamente."); 
                    CargarCitas();
                }
                else
                {
                    MessageBox.Show("Error al anular la cita.");
                }                
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una cita para anular.");
            }
        }

        private void btn_detalle_cita_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedCitaId))
            {
                string idCita = dgv_cita.CurrentRow.Cells[0].Value.ToString();
                Dictionary<string,string> datosCita = LogCita.Instancia.TipoDeCita(idCita);
                tipoCita = datosCita["tipoCita"];
                estado = datosCita["estado"];


                if ( tipoCita == "TRATAMIENTO")
                {
                    detalleCita = LogCitaTratamiento.Instancia.DetalleCitaTratamiento(idCita, estado);
                }
                else if (tipoCita == "CONSULTA")
                {
                    detalleCita = LogCitaConsulta.Instancia.DetalleCitaConsulta(idCita, estado);
                }
                else
                {
                    MessageBox.Show("Error, codigo cita");
                }

                form_detalleCita detalleCitaForm = new form_detalleCita();
                detalleCitaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una cita para ver el detalle.");
            }
        }

        private void cmb_dni_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }

        private void cmb_odontologoC_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }

        private void cmb_pacienteC_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }

        private void dtp_fechaC_ValueChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }

        private void form_cita_Load(object sender, EventArgs e)
        {

        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            cmb_dni.SelectedIndex = -1;
            cmb_odontologoC.SelectedIndex = -1;
            cmb_pacienteC.SelectedIndex = -1;
            
            CargarCitas();
        }
    }
}

using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CapaPresentacion
{
    public partial class form_citas_odontologo : Form
    {
        Empleado empleado;

        public form_citas_odontologo()
        {
            InitializeComponent();

            empleado = new Empleado();
            empleado = form_login.empleado;

            CargarCitas(empleado.Id_empleado,empleado.Cargo);
            CargarCombobox();
        }

        private void CargarCitas(int idEmpleado, string cargo ,string dni = null, string paciente = null, DateTime? fecha = null)
        {
            dgv_cita.Rows.Clear();
            foreach (Dictionary<string, string> item in LogCita.Instancia.ListarCitasOdontologo(idEmpleado, cargo, dni, paciente, fecha))
            {
                string id = item["Id_Cita"].ToString();
                string fechaC = DateTime.Parse(item["Fecha_Registro"].ToString()).ToShortDateString();
                string dniC = item["DNI"].ToString();
                string pacienteC = item["NombreCliente"].ToString();
                string tratamiento = item["Tratamiento"].ToString();
                string estado = item["Estado"].ToString();

                dgv_cita.Rows.Add(id, fechaC, dniC, pacienteC, tratamiento, estado);
            }
        }
        private void CargarCombobox()
        {
            var citas = LogCita.Instancia.ListarCitasOdontologo(empleado.Id_empleado, empleado.Cargo);

            cmb_dniRC.Items.Clear();
            foreach (var item in citas)
            {
                cmb_dniRC.Items.Add(item["DNI"]);
            }

            cmb_pacienteRC.Items.Clear();
            foreach (var item in citas)
            {
                if (!cmb_pacienteRC.Items.Contains(item["NombreCliente"]))
                {
                    cmb_pacienteRC.Items.Add(item["NombreCliente"]);
                }
            }

        }

        private void FiltrarCitas()
        {
            string dni = cmb_dniRC.SelectedItem?.ToString();
            dni = string.IsNullOrEmpty(dni) ? null : dni;
            
            string paciente = cmb_pacienteRC.SelectedItem?.ToString();
            paciente = string.IsNullOrEmpty(paciente) ? null : paciente;

            DateTime? fecha = dtp_fechaRC.Checked ? dtp_fechaRC.Value : (DateTime?)null;

            CargarCitas(empleado.Id_empleado, empleado.Cargo, dni, paciente);
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

        private void btn_atender_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedCitaId))
            {
                MessageBox.Show("Por favor, seleccione una cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string estado = dgv_cita.Rows[dgv_cita.CurrentCell.RowIndex].Cells["colum_estado"].Value.ToString();
            string tratamiento = dgv_cita.Rows[dgv_cita.CurrentCell.RowIndex].Cells["colum_tratamiento"].Value.ToString();


            if (estado == "PENDIENTE")
            {
                string idCita = dgv_cita.CurrentRow.Cells[0].Value.ToString();

                if (!string.IsNullOrEmpty(tratamiento))
                {
                    MessageBox.Show("Formulario de Tratamiento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {

                    form_diagnostico form_Diagnostico = new form_diagnostico(idCita);
                    form_Diagnostico.ShowDialog();


                }
                

                dgv_cita.Rows.Clear();
                CargarCitas(empleado.Id_empleado, empleado.Cargo);
            }
            else if (estado == "ATENDIDO")
            {
                MessageBox.Show("La consulta ya ha sido atendida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmb_pacienteRC_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }

        private void cmb_dniRC_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }

        private void dtp_fechaRC_ValueChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            cmb_dniRC.SelectedIndex = -1;
            cmb_pacienteRC.SelectedIndex = -1;

            CargarCombobox();
        }
    }
}

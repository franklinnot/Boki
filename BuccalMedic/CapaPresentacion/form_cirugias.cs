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
    public partial class form_cirugias : Form
    {
        int idEmpleado = form_login.empleado.EmpleadoID;
        string tipoCita = "TRATAMIENTO";
        public form_cirugias()
        {
            InitializeComponent();
            Form form_login = new Form();
            form_login.Close();
            CargarCitas();
            CargarCombobox();
            //para que el datetimepicker no se inicialize con ninguna fecha
            cirugia_dtp_fecha.ShowCheckBox = true;
            cirugia_dtp_fecha.Checked = false;


        }
        private void CargarCitas(DateTime? fecha = null, string paciente = null, string idcita = null)
        {
            cirugias_dgv.Rows.Clear();
            foreach (Dictionary<string, string> item in LogCita.Instancia.HistorialCitas(idEmpleado, tipoCita))
            {
                string id = item["Id_Cita"].ToString();
                string fechaC = DateTime.Parse(item["Fecha_Registro"].ToString()).ToShortDateString();
                string pacienteC = item["Paciente"].ToString();

                cirugias_dgv.Rows.Add(id, pacienteC, fechaC);

            }
        }
        private void CargarCombobox()
        {
            var citas = LogCita.Instancia.HistorialCitas(idEmpleado, tipoCita);

            cirugia_codigocita.Items.Clear();
            foreach (var item in citas)
            {
                if (!cirugia_codigocita.Items.Contains(item["Id_Cita"]))
                {
                    cirugia_codigocita.Items.Add(item["Id_Cita"]);
                }
            }

            cirugia_cmbox_paciente.Items.Clear();
            foreach (var item in citas)
            {
                if (!cirugia_cmbox_paciente.Items.Contains(item["Paciente"]))
                {
                    cirugia_cmbox_paciente.Items.Add(item["Paciente"]);
                }
            }

        }
        private void FiltrarCitas()
        {
            // obtenemos el dato seleccionado de los objetos, si no selecciono nada lo pondremos como null
            string idCita = !string.IsNullOrEmpty(cirugia_codigocita.Text) ? cirugia_codigocita.Text : null;
            string paciente = !string.IsNullOrEmpty(cirugia_cmbox_paciente.Text) ? cirugia_cmbox_paciente.Text : null;
            DateTime? fecha = cirugia_dtp_fecha.Checked ? cirugia_dtp_fecha.Value : (DateTime?)null;

            CargarCitas(fecha, paciente, idCita);
        }

        private string selectedCitaId;
        private void form_cirugias_Load(object sender, EventArgs e)
        {

        }



        private void cirugia_dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }

        private void cirugia_btn_Limpiar_Click(object sender, EventArgs e)
        {
            cirugia_codigocita.Text = null;
            cirugia_cmbox_paciente.Text = null;
            cirugia_dtp_fecha.Text = null;
            CargarCitas();
        }

        private void cirugia_cmbox_paciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }

        private void cirugia_codigocita_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }
    }
}

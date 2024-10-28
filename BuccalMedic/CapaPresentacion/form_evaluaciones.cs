using CapaLogica;
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
        int idEmpleado = form_login.empleado.Id_empleado;
        string tipoCita = "CONSULTA";
        public form_evaluaciones()
        {
            InitializeComponent();
            CargarCitas();
            CargarCombobox();
            //para que el datetimepicker no se inicialize con ninguna fecha
            evaluacion_dtp_fecha.ShowCheckBox = true;
            evaluacion_dtp_fecha.Checked = false;
        }

        private void form_evaluaciones_Load(object sender, EventArgs e)
        {

        }
        private void CargarCitas(string paciente = null, DateTime? fecha = null, string idcita = null)
        {
            evaluaciones_dgv.Rows.Clear();
            foreach (Dictionary<string, string> item in LogCita.Instancia.HistorialCitas(idEmpleado,tipoCita, paciente, fecha, idcita))
            {
                string pacienteC = item["Paciente"].ToString();
                string idConsulta = item["Id_Cita"].ToString();
                string fechaC = DateTime.Parse(item["Fecha_Registro"].ToString()).ToShortDateString();

                evaluaciones_dgv.Rows.Add(idConsulta, pacienteC, fechaC);
            }
        }
        private void CargarCombobox()
        {
            var citas = LogCita.Instancia.HistorialCitas(idEmpleado,tipoCita);


            evaluacion_codigocita.Items.Clear();
            foreach (var item in citas)
            {
                if (!evaluacion_codigocita.Items.Contains(item["Id_Cita"]))
                {
                    evaluacion_codigocita.Items.Add(item["Id_Cita"]);
                }
            }

            evaluacion_cmbox_paciente.Items.Clear();
            foreach (var item in citas)
            {
                if (!evaluacion_cmbox_paciente.Items.Contains(item["Paciente"]))
                {
                    evaluacion_cmbox_paciente.Items.Add(item["Paciente"]);
                }
            }

        }
        private void FiltrarCitas()
        {
            // obtenemos el dato seleccionado de los objetos, si no selecciono nada lo pondremos como null
            string idCita = !string.IsNullOrEmpty(evaluacion_codigocita.Text) ? evaluacion_codigocita.Text: null;
            string paciente = !string.IsNullOrEmpty(evaluacion_cmbox_paciente.Text) ? evaluacion_cmbox_paciente.Text : null;
            DateTime? fecha = evaluacion_dtp_fecha.Checked ? evaluacion_dtp_fecha.Value : (DateTime?)null;

            CargarCitas(paciente, fecha, idCita);
        }

        private void evaluacion_cmbox_paciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }

        private void evaluacion_codigocita_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }

        private void evaluacion_btn_Limpiar_Click(object sender, EventArgs e)
        {
            evaluacion_codigocita.Text = null;
            evaluacion_cmbox_paciente.Text = null;
            evaluacion_dtp_fecha.Text = null;
            CargarCitas();
        }

        private void evaluacion_dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }
    }
}

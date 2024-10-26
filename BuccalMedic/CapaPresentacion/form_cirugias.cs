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
        public form_cirugias()
        {
            InitializeComponent();
            Form form_login = new Form();
            form_login.Close();
            CargarCitas();
            CargarCombobox();


            foreach (Dictionary<string, string> item in LogCitaTratamiento.Instancia.ListarCitaTratamiento("23456789"))
            {
                foreach (var element in item)
                {
                    Debug.WriteLine(element.Key, element.Value);

                }
            }
        }
        private void CargarCitas(DateTime? fecha = null, string paciente = null, string idcita = null)
        {
            cirugias_dgv.Rows.Clear();
            foreach (Dictionary<string, string> item in LogCitaTratamiento.Instancia.ListarCitaTratamiento(idcita, paciente, fecha))
            {
                string id = item["IdCita"].ToString();
                string fechaC = DateTime.Parse(item["Fecha_Registro"].ToString()).ToShortDateString();
                string pacienteC = item["Paciente"].ToString();

                cirugias_dgv.Rows.Add(id, pacienteC, fechaC);

            }
        }
        private void CargarCombobox()
        {
            var citas = LogCitaTratamiento.Instancia.ListarCitaTratamiento();


            cirugia_codigocita.Items.Clear();
            foreach (var item in citas)
            {
                if (!cirugia_codigocita.Items.Contains(item["IdCita"]))
                {
                    cirugia_codigocita.Items.Add(item["IdCita"]);
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
            string idCita = cirugia_codigocita.SelectedItem?.ToString();
            idCita = string.IsNullOrEmpty(idCita) ? null : idCita;

            string paciente = cirugia_cmbox_paciente.SelectedItem?.ToString();
            paciente = string.IsNullOrEmpty(paciente) ? null : paciente;

            DateTime? fecha = cirugia_dtp_fecha.Checked ? cirugia_dtp_fecha.Value : (DateTime?)null;

            CargarCitas(fecha, paciente, idCita);
        }

        private string selectedCitaId;
        private void form_cirugias_Load(object sender, EventArgs e)
        {

        }

        private void cirugia_btn_Consultar_Click(object sender, EventArgs e)
        {
            //ListarCitaTratamiento(string )
            string paciente = cirugia_cmbox_paciente.Text;
            string idcita = cirugia_codigocita.Text;
            CargarCitas(paciente: paciente, idcita: idcita);

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            CargarCitas();
        }

        private void cirugia_dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            FiltrarCitas();
        }
    }
}

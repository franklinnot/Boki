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
    public partial class form_detalleCita : Form
    {

        public static Dictionary<string, string> detalleCita;

        public form_detalleCita()
        {
            InitializeComponent();

            detalleCita = form_cita.detalleCita;
        }

        private void form_detalleCita_Load(object sender, EventArgs e)
        {
            string estado = form_cita.estado;
            string tipoCita = form_cita.tipoCita;

                lbl_idCita.Text = $"DETALLE DE LA CITA - {detalleCita["Id_Cita"]}";
                lbl_estado.Text = estado;
                string fecha = DateTime.Parse(detalleCita["Fecha_Registro"]).ToShortDateString();
                lbl_fechaCita.Text = $"Fecha de cita: {fecha}";
                lbl_odontologo.Text = $"Odontologo: {detalleCita["Odontologo"]}";
                lbl_DNI.Text = $"DNI:{detalleCita["DNI"]}";
                lbl_nombre.Text = $"Nombres Completos: {detalleCita["Paciente"]}";

            if (tipoCita == "CONSULTA")
            {
                grb_tratamiento.Visible = false;
                grb_diagnostico.Visible = true;

                if (estado == "ATENDIDO")
                {
                    lbl_estado.ForeColor = Color.Green;
                    lbl_resultado.Text = $"Resultados:\n{detalleCita["Resultado"]}";
                    lbl_recomendacionD.Text = $"Recomendaciones:\n{detalleCita["Recomendaciones"]}";
                    // tratamientosssss del diagnostico 
                    List<string> tratamientos = new List<string>();
                    tratamientos = LogDiagnostico.Instancia.Tratamientos_Diagnostico(detalleCita["CitaID"]);

                    foreach( string item in tratamientos)
                    {
                        ListViewItem li = new ListViewItem(item);
                        lsv_tratamientos.Items.Add(li);
                    }
                }
                else 
                { 
                    lbl_estado.ForeColor = Color.Red; 
                }

            }
            else if (tipoCita == "TRATAMIENTO")
            {
                grb_tratamiento.Visible = true;
                grb_diagnostico.Visible = false;

                if (estado == "ATENDIDO")
                {
                    lbl_estado.ForeColor = Color.Green;
                    lbl_tratamiento.Text = $"Tratamiento:\n{detalleCita["Tratamiento"]}";
                    lbl_procedimiento.Text = $"Procedimientos Realizados:\n{detalleCita["Procedimiento"]}";
                    lbl_recomendacionT.Text = $"Recomendaciones:\n{detalleCita["Recomendaciones"]}";
                }
                else
                {
                    lbl_estado.ForeColor = Color.Red;
                }

            }
            else 
            {
                MessageBox.Show("Ups...");
            }
        }
    }
}


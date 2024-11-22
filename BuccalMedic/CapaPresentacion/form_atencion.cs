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
    public partial class form_atencion : Form
    {
        Dictionary<string, string> datosCita;
        string idCita;
        public form_atencion(string id_Cita)
        {
            InitializeComponent();
            idCita = id_Cita;
            datosCita = LogCitaTratamiento.Instancia.DetalleCitaTratamiento(id_Cita, "PENDIENTE");
        }

        private void form_atencion_Load(object sender, EventArgs e)
        {
            atencion_txtDNI.Text = datosCita["DNI"].ToString();
            atencion_txtNombres.Text = datosCita["Paciente"].ToString();
            txtTratamiento.Text = datosCita["Tratamiento"].ToString();

        }
        private void LimpiarVariables()
        {
            atencion_txtRecomendaciones.Clear();
            atencion_txtProcedimientos.Clear();
            txtTratamiento.Clear();
        }
       
        private void atencion_btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {               
                Citatratamiento atencion = new Citatratamiento
                {
                    CitaID = idCita,
                    Recomendaciones = atencion_txtRecomendaciones.Text,
                    Procedimiento = atencion_txtProcedimientos.Text
                };

                bool verificar = LogCitaTratamiento.Instancia.InsertarAtencion(atencion);
                if (verificar)
                {
                    MessageBox.Show("se ha registrado correctamente");
                }
                else
                {
                    MessageBox.Show("No fue posible registrar");
                }

                LimpiarVariables();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

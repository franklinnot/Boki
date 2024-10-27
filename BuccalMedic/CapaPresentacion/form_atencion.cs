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
        public form_atencion()
        {
            InitializeComponent();
            CargarTratamientos();
        }

        private void form_atencion_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarVariables()
        {
            atencion_txtRecomendaciones.Clear();
            atencion_txtProcedimientos.Clear();
            atencion_cmbx_tratamiento.SelectedIndex = -1;

        }
        private void CargarTratamientos()
        {
            try
            {
                List<Tratamiento> tratamientos = LogTratamiento.Instancia.ListarTratamientos();
                foreach (var tratamiento in tratamientos)
                {
                    atencion_cmbx_tratamiento.Items.Add(tratamiento.Nombre); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los tratamientos: {ex.Message}");
            }
        }

        static string GenerarIDCitaTratamiento(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] stringChars = new char[length];

            for (int i = 0; i < length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            return new string(stringChars);
        }

        private void atencion_btnRegistrar_Click(object sender, EventArgs e)
        {
            if (atencion_cmbx_tratamiento.SelectedItem == null)
            {
                MessageBox.Show("selecciona un tratamiento");
                return;
            }
            try
            {

                Cita_tratamiento atencion = new Cita_tratamiento
                {
                    Id_citatratamiento = GenerarIDCitaTratamiento(12),
                    Id_cita ="CITA003", // Manteniendo el valor original de Id_cita como string
                    Id_Tratamiento = atencion_cmbx_tratamiento.SelectedIndex + 1, // Asegúrate que este índice corresponde a los IDs en la base de datos
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

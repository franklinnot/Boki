using CapaEntidad;
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
    public partial class form_diagnostico : Form
    {
        public form_diagnostico()
        {
            InitializeComponent();
            Form form_login = new Form();
            form_login.Close();
            CargarTratamientos();
        }
        public void ListarDiagnostico()
        {
            List<Diagnostico> diagnosticos = LogDiagnostico.Instancia.ListarDiagnostico();

            if (diagnosticos.Count > 0)
            {
                // Asignar el primer diagnóstico a los controles del formulario
                Diagnostico d = diagnosticos[0];
                txtrecomendacionesd.Text = d.Recomendaciones;
                txt_resultadod.Text = d.Resultado;
            }
            else
            {
                MessageBox.Show("No se encontraron diagnósticos.");
            }
        }

        private void CargarTratamientos()
        {
            try
            {
                // Obtener la lista de tratamientos
                List<Tratamiento> tratamientos = LogTratamiento.Instancia.ListarTratamientos();

                // Limpiar el CheckedListBox antes de agregar elementos
                chlbtratamientos.Items.Clear();

                // Agregar cada tratamiento al CheckedListBox
                foreach (var tratamiento in tratamientos)
                {
                    chlbtratamientos.Items.Add(tratamiento.Nombre); // Asegúrate de que "Nombre" es la propiedad que quieres mostrar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los tratamientos: {ex.Message}");
            }
        }

        private void btn_citasd_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                Diagnostico d = new Diagnostico
                {
                    // No asignar valores a Id_diagnostico e Id_citaconsulta
                    Recomendaciones = txtrecomendacionesd.Text.Trim(),
                    Resultado = txt_resultadod.Text
                };

                bool resultado = LogDiagnostico.Instancia.InsertarDiagnostico(d);
                if (resultado)
                {
                    MessageBox.Show("Diagnóstico insertado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al insertar el diagnóstico.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            ListarDiagnostico();
        }

        private void LimpiarVariables()
        {
            txtrecomendacionesd.Clear();
            txt_resultadod.Clear();
            // Limpiar otros campos si es necesario
        }
    }
}

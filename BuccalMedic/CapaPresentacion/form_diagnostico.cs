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

        }
    }
}

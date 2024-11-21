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
    public partial class form_tratamientos : Form
    {
        public form_tratamientos()
        {
            InitializeComponent();
            CargarTratamientos();
            // Registra el evento para cargar datos en los textbox al hacer clic en una fila
            tratamientos_dgv.CellClick += tratamientos_dgv_CellContentClick;
        }

        private void form_tratamientos_Load(object sender, EventArgs e)
        {
           
        }
        private void CargarTratamientos()
        {
            tratamientos_dgv.Rows.Clear();
            List<Tratamiento> tratamientos = LogTratamiento.Instancia.ListarTratamientos();
            foreach (var tratamiento in tratamientos)
            {
                tratamientos_dgv.Rows.Add(tratamiento.Id_Tratamiento, tratamiento.Nombre, tratamiento.Descripcion, tratamiento.Precio);
            }
        }
        void limpiarVariables()
        {
            tratamiento_tbx_Nombre_Tratamiento.Text = "";
            tratamiento_tbx_Descripcion.Text = "";
            txt_precio.Text = " ";
        }
        private int idTratamientoSeleccionado = -1;

        private void tratamiento_btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                Tratamiento c = new Tratamiento
                {
                    Nombre = tratamiento_tbx_Nombre_Tratamiento.Text.Trim(),
                    Descripcion = tratamiento_tbx_Descripcion.Text.Trim(),
                    Precio = int.Parse(txt_precio.Text.Trim())
                };
                LogTratamiento.Instancia.InsertaTratamiento(c);

                CargarTratamientos();
                limpiarVariables();

                MessageBox.Show("Tratamiento registrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tratamiento_btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                //verificamos que se haya seleccionado un id 
                if (idTratamientoSeleccionado > 0)
                {
                    Tratamiento tratamiento = new Tratamiento
                    {
                        Id_Tratamiento = idTratamientoSeleccionado,
                        Nombre = tratamiento_tbx_Nombre_Tratamiento.Text.Trim(),
                        Descripcion = tratamiento_tbx_Descripcion.Text.Trim(),
                        Precio = int.Parse(txt_precio.Text.Trim())
                    };

                    LogTratamiento.Instancia.EditaTratamiento(tratamiento);

                    CargarTratamientos();
                    limpiarVariables();
                    idTratamientoSeleccionado = -1;

                    MessageBox.Show("Tratamiento modificado con éxito.");
                }
                else
                {
                    MessageBox.Show("Selecciona un tratamiento para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tratamientos_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = tratamientos_dgv.Rows[e.RowIndex];

                idTratamientoSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["IdTratamiento"].Value);

                tratamiento_tbx_Nombre_Tratamiento.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                tratamiento_tbx_Descripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
                txt_precio.Text = filaSeleccionada.Cells["Precio"].Value.ToString();

            }
        }

        private void tratamiento_btn_Inhabilitar_Click(object sender, EventArgs e)
        {

            // TODAVIA NO HACE NADA 

        }
    }
}

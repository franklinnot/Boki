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
    public partial class form_diagnostico : Form
    {
        Dictionary<string,string> datosCita ;
        string idCita;

        public form_diagnostico(string id_Cita)
        {
            InitializeComponent();
            CargarTratamientos();
            datosCita = LogCitaConsulta.Instancia.DetalleCitaConsulta(id_Cita, "PENDIENTE");
            idCita = id_Cita;
        }
        private void form_diagnostico_Load(object sender, EventArgs e)
        {
            txtDni.Text = datosCita["DNI"].ToString();
            txtNombre.Text = datosCita["Paciente"].ToString();

        }
        private void LimpiarVariables()
        {
            txtrecomendacionesd.Clear();
            txt_resultadod.Clear();
            foreach (int index in chlbtratamientos.CheckedIndices)
                chlbtratamientos.SetItemChecked(index, false);
        }
        private void CargarTratamientos()
        {
            try
            {
                List<Tratamiento> tratamientos = LogTratamiento.Instancia.ListarTratamientos();
                foreach (var tratamiento in tratamientos)
                {
                    chlbtratamientos.Items.Add(tratamiento.NombreTratamiento); // Asegúrate de que "Nombre" es la propiedad que quieres mostrar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los tratamientos: {ex.Message}");
            }
        }
        

        private void btn_registrardiagnosticod_Click_1(object sender, EventArgs e)
        {
            Diagnostico diagnostico = new Diagnostico
            {
                CitaID = idCita,
                Resultado = txt_resultadod.Text,
                Recomendacion = txtrecomendacionesd.Text,
            };


            bool verificar = LogDiagnostico.Instancia.RegistrarResultadoDiagnostico(diagnostico);
            if (verificar)
            {
                MessageBox.Show("Diagnóstico registrado exitosamente.");
            }
            else
            {
                MessageBox.Show("Hubo un error al registrar el diagnóstico");
            }
            
            //Obtener lista con tratamientos marcados
            List<string> tratamientosmarcados = new List<string>();
            // Iterar en los elementos marcados
            foreach (var item in chlbtratamientos.CheckedItems)
            {
                tratamientosmarcados.Add(item.ToString());
            }

            List<Tratamiento> trt = LogTratamiento.Instancia.ListarTratamientos();
            List<Tratamiento> tratamientosFiltrados = trt.FindAll(t => tratamientosmarcados.Contains(t.NombreTratamiento));

            foreach (Tratamiento item in tratamientosFiltrados)
            {
                DiagnosticoTratamiento tratamientodiag = new DiagnosticoTratamiento();
                tratamientodiag.TratamientoID = item.TratamientoID;
                tratamientodiag.DiagnosticoID = LogDiagnostico.Instancia.CodigoDiagnostico(idCita);
                MessageBox.Show($"CODIGO DE DIAGNOSTICO: {tratamientodiag.DiagnosticoID}");
                bool verificax = LogTratamientoDiagnostico.Instancia.InsertarTratamientoDiagnostico(tratamientodiag);
                if (verificax)
                {
                    Debug.WriteLine($"Se inserto el tratamiento: {item.NombreTratamiento}, con el diagnostico {tratamientodiag.DiagnosticoID}");
                }
                else
                {
                    Debug.WriteLine($"Hubo un error al registrar los tratamiendos recomendados en el diagnóstico.");
                    
                }
            }
            LimpiarVariables();
            this.Close();
        }

    }
}

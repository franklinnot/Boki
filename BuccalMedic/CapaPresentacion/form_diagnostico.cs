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
        public form_diagnostico()
        {
            InitializeComponent();
            Form form_login = new Form();
            form_login.Close();
            CargarTratamientos();

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
                    chlbtratamientos.Items.Add(tratamiento.Nombre); // Asegúrate de que "Nombre" es la propiedad que quieres mostrar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los tratamientos: {ex.Message}");
            }
        }
        
        static string GenerarIDDiagnostico(int length)
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

        private void btn_registrardiagnosticod_Click_1(object sender, EventArgs e)
        {
            Diagnostico diagnostico = new Diagnostico
            {
                Id_diagnostico = GenerarIDDiagnostico(12),
                Id_citaconsulta = "abc6",
                Resultado = txt_resultadod.Text,
                Recomendaciones = txtrecomendacionesd.Text,
            };


            bool verificar = LogDiagnostico.Instancia.InsertarDiagnostico(diagnostico);
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
            List<Tratamiento> tratamientosFiltrados = trt.FindAll(t => tratamientosmarcados.Contains(t.Nombre));

            foreach (Tratamiento item in tratamientosFiltrados)
            {
                Tratamiento_diagnostico tratamientodiag = new Tratamiento_diagnostico();
                tratamientodiag.Id_Tratamiento = item.Id_Tratamiento;
                tratamientodiag.Id_diagnostico = diagnostico.Id_diagnostico;
     
                bool verificax = LogTratamientoDiagnostico.Instancia.InsertarTratamientoDiagnostico(tratamientodiag);
                if (verificax)
                {
                    Debug.WriteLine($"Se inserto el tratamiento: {item.Nombre}, con el diagnostico {diagnostico.Id_diagnostico}");
                }
                else
                {
                    Debug.WriteLine($"Hubo un error al registrar los tratamiendos recomendados en el diagnóstico.");
                }
            }
            LimpiarVariables();
        }
    }
}

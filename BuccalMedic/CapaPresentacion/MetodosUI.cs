using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CapaPresentacion
{
    public class MetodosUI
    {
        public  static void SetPlaceholder(Control control, string placeholder)
        {
            
            if(control is DateTimePicker dateTimePicker)
            {
                dateTimePicker.Format = DateTimePickerFormat.Custom;
                dateTimePicker.CustomFormat = $"'{placeholder}'";
                dateTimePicker.ForeColor = Color.Gray;

                dateTimePicker.Enter += (sender, e) =>
                {
                    if (dateTimePicker.CustomFormat == $"'{placeholder}'")
                    {
                        // Restablecer al formato estándar cuando el usuario hace clic
                        dateTimePicker.Format = DateTimePickerFormat.Short;
                        dateTimePicker.ForeColor = Color.Black;
                    }
                };

                dateTimePicker.Leave += (sender, e) =>
                {
                    // Si no se ha seleccionado una fecha, restablecer el placeholder
                    if (dateTimePicker.Value == dateTimePicker.MinDate)
                    {
                        dateTimePicker.Format = DateTimePickerFormat.Custom;
                        dateTimePicker.CustomFormat = $"'{placeholder}'";
                        dateTimePicker.ForeColor = Color.Gray;
                    }
                };

                // Inicializar el valor del DateTimePicker para que coincida con el estado "vacío"
                dateTimePicker.Value = dateTimePicker.MinDate;
            }
            else
            {
                control.ForeColor = Color.Gray;
                control.Text = placeholder;

                control.Enter += (sender, e) =>
                {
                    if (control.Text == placeholder)
                    {
                        control.Text = "";
                        control.ForeColor = Color.Black; // Cambiar a color normal cuando el usuario escriba
                    }
                };

                control.Leave += (sender, e) =>
                {
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        control.Text = placeholder;
                        control.ForeColor = Color.Gray; // Placeholder color
                    }
                };
            }

            
            
        }
    }
}

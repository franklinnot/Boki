using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public class MetodosUI
    {
        public  static void SetPlaceholder(Control control, string placeholder)
        {
            // Verificamos si el control es un TextBox
            if (control is TextBox textBox)
            {
                textBox.ForeColor = Color.Gray;
                textBox.Text = placeholder;

                textBox.Enter += (sender, e) =>
                {
                    if (textBox.Text == placeholder)
                    {
                        textBox.Text = "";
                        textBox.ForeColor = Color.Black; // Cambiar a color normal cuando el usuario escriba
                    }
                };

                textBox.Leave += (sender, e) =>
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Text = placeholder;
                        textBox.ForeColor = Color.Gray; // Placeholder color
                    }
                };
            }
            // Verificamos si el control es un ComboBox
            else if (control is ComboBox comboBox)
            {
                comboBox.ForeColor = Color.Gray;
                comboBox.Text = placeholder;

                comboBox.Enter += (sender, e) =>
                {
                    if (comboBox.Text == placeholder)
                    {
                        comboBox.Text = "";
                        comboBox.ForeColor = Color.Black; // Cambiar a color normal cuando el usuario escriba
                    }
                };

                comboBox.Leave += (sender, e) =>
                {
                    if (string.IsNullOrWhiteSpace(comboBox.Text))
                    {
                        comboBox.Text = placeholder;
                        comboBox.ForeColor = Color.Gray; // Placeholder color
                    }
                };
            }
        }
    }
}

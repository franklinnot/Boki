using CapaEntidad;
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
    public partial class form_registroCliente : Form
    {

        public form_registroCliente()
        {
            InitializeComponent();

            #region placeholders para los combobox
            MetodosUI.SetPlaceholder(txt_DNI,"DNI");
            MetodosUI.SetPlaceholder(txt_NombreCliente,"Nombre y Apellidos");
            MetodosUI.SetPlaceholder(txt_Telefono, "Telefóno");
            MetodosUI.SetPlaceholder(txt_Direccion,"Dirección");
            MetodosUI.SetPlaceholder(cmb_genero,"Género");
            MetodosUI.SetPlaceholder(dtp_fecha_nacimiento,"Fecha de Nacimiento");
            #endregion

        }

        private void btn_registrar_Cliente_Click(object sender, EventArgs e)
        {
            string dni = txt_DNI.Text.Trim();
            string nombre = txt_NombreCliente.Text.Trim();
            string genero = cmb_genero.SelectedItem.ToString();
            string telefono = txt_Telefono.Text.Trim();
            DateTime fecha_nacimieto = dtp_fecha_nacimiento.Value;

            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(genero) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Cliente cliente = new Cliente
            {
                DNI = dni,
                Nombre = nombre,
                Genero = genero,
                Estado = "ACTIVO",
                Fecha_nacimiento = fecha_nacimieto
            };



        }
    }
}

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
    public partial class form_registroCliente : Form
    {

        public form_registroCliente()
        {
            InitializeComponent();
            LimpiarInputs();
        }

        public void LimpiarInputs() 
        {
            MetodosUI.SetPlaceholder(txt_DNI,"DNI");
            MetodosUI.SetPlaceholder(txt_NombreCliente,"Nombre y Apellidos");
            MetodosUI.SetPlaceholder(txt_Direccion,"Dirección");
            MetodosUI.SetPlaceholder(cmb_genero,"Género");
            MetodosUI.SetPlaceholder(dtp_fecha_nacimiento,"Fecha de Nacimiento");

            ListarClientes();
        }

        public void ListarClientes() 
        {
            dgv_clientes.Rows.Clear();
            List<Cliente> clientes = LogCliente.Instancia.ListarClientes();
            foreach (var cliente in clientes)
            {
                dgv_clientes.Rows.Add(cliente.DNI, cliente.Nombre, cliente.Fecha_nacimiento.Value.ToShortDateString(), cliente.Genero, cliente.Estado);
            }
        }

        private void btn_registrar_Cliente_Click(object sender, EventArgs e)
        {
            string dni = txt_DNI.Text.Trim();
            string nombre = txt_NombreCliente.Text.Trim();
            string genero = cmb_genero.SelectedItem.ToString();
            DateTime fecha_nacimieto = DateTime.Parse(dtp_fecha_nacimiento.Value.ToShortDateString());

            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(genero) || string.IsNullOrEmpty(genero))
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

            bool verificar_registro = LogCliente.Instancia.InsertarCliente(cliente);

            if (!verificar_registro) 
            {
                MessageBox.Show("El DNI ingresado ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LimpiarInputs();
                ListarClientes();
                MessageBox.Show("Cliente registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_modificar_Cliente_Click(object sender, EventArgs e)
        {

        }
    }
}

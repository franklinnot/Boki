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
        }

        private void form_registroCliente_Load(object sender, EventArgs e)
        {
            LimpiarInputs();
            btn_modificar_Cliente.Enabled = false;
            btn_inhabilitar_cliente.Enabled = false;
            btn_registrar_Cliente.Enabled = false;
        }

        public void LimpiarInputs() 
        {
            MetodosUI.SetPlaceholder(txt_DNI,"DNI");
            MetodosUI.SetPlaceholder(txt_NombreCliente,"Nombre y Apellidos");
            MetodosUI.SetPlaceholder(cmb_genero,"Género");
            MetodosUI.SetPlaceholder(dtp_fecha_nacimiento,"Fecha de Nacimiento");
            dtp_fecha_nacimiento.Value = DateTime.Now;


            ListarClientes();
        }

        public void LimpiarInputs_NDni() 
        {
            MetodosUI.SetPlaceholder(txt_NombreCliente, "Nombre y Apellidos");
            MetodosUI.SetPlaceholder(cmb_genero, "Género");
            MetodosUI.SetPlaceholder(dtp_fecha_nacimiento, "Fecha de Nacimiento");
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
            dni = string.IsNullOrEmpty(dni) || dni == "DNI" ? null : dni;

            string nombre = txt_NombreCliente.Text.Trim();
            nombre = string.IsNullOrEmpty(nombre) || nombre == "Nombre y Apellidos" ? null : nombre;

            string genero = cmb_genero.Text.Trim();
            genero = string.IsNullOrEmpty(genero) || genero == "Género" ? null : genero;

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
                MessageBox.Show("Cliente registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarInputs();
            }

        }

        private void btn_modificar_Cliente_Click(object sender, EventArgs e)
        {
            string dni = txt_DNI.Text.Trim();
            dni = dni == "DNI" || string.IsNullOrEmpty(dni) ? "" : dni;

            string nombre = txt_NombreCliente.Text.Trim();
            nombre = nombre == "Nombre y Apellidos" || string.IsNullOrEmpty(nombre) ? "" : nombre;
            DateTime fecha_nacimieto = DateTime.Parse(dtp_fecha_nacimiento.Value.ToShortDateString());

            if (dni == "" && (nombre == "" || string.IsNullOrEmpty(fecha_nacimieto.ToString()))) 
            {
                MessageBox.Show("Debes ingresar el DNI del cliente y llenar su campo a modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente cliente = new Cliente 
            {
                DNI = dni,
                Nombre = nombre,
                Fecha_nacimiento = fecha_nacimieto,
                Estado = ""
            };

            bool verificar_modificacion = LogCliente.Instancia.ModificarCliente(cliente);
            if (verificar_modificacion)
            {
                MessageBox.Show("Cliente modificado correctamente", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarInputs_NDni();
            }
            else
            {
                MessageBox.Show("El DNI ingresado no se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_DNI_TextChanged(object sender, EventArgs e)
        {
            string dni = txt_DNI.Text.Trim();
            int resultado;
            bool verificar_tipodato = int.TryParse(dni, out resultado);
            if (dni.Length == 8 && verificar_tipodato)
            {
                btn_modificar_Cliente.Enabled = true;
                btn_inhabilitar_cliente.Enabled = true;
                btn_registrar_Cliente.Enabled = true;
            }
            else 
            {
                btn_modificar_Cliente.Enabled = false;
                btn_inhabilitar_cliente.Enabled = false;
                btn_registrar_Cliente.Enabled = false;
            }
        }

        private void btn_inhabilitar_cliente_Click(object sender, EventArgs e)
        {
            string dni = txt_DNI.Text.Trim();
            dni = dni == "DNI" || string.IsNullOrEmpty(dni) ? "" : dni;

            if (dni == "")
            {
                MessageBox.Show("Debes ingresar el DNI del cliente a inhabilitar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente cliente = new Cliente
            {
                DNI = dni,
                Nombre = "",
                Fecha_nacimiento = DateTime.Now,
                Estado = "INHABILITADO"
            };

            bool verificar_modificacion = LogCliente.Instancia.ModificarCliente(cliente);
            if (verificar_modificacion)
            {
                MessageBox.Show("Cliente inhabilitado correctamente", "Inhabilitación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarInputs_NDni();
            }
            else
            {
                MessageBox.Show("El DNI ingresado no se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








    }
}

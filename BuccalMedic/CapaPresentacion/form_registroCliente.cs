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
            MetodosUI.SetPlaceholder(txt_DNI,"DNI");
            MetodosUI.SetPlaceholder(txt_NombreCliente,"Nombre y Apellidos");
            MetodosUI.SetPlaceholder(txt_Telefono, "Telefóno");
            MetodosUI.SetPlaceholder(txt_Direccion,"Dirección");
            MetodosUI.SetPlaceholder(cmb_genero,"Género");
            MetodosUI.SetPlaceholder(dtp_registroCliente,"Fecha de Nacimiento");
        }

        
    }
}

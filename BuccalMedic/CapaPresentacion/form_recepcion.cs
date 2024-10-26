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
    public partial class form_recepcion : Form
    {
        Empleado empleado;

        public form_recepcion()
        {
            InitializeComponent();
            #region placeholders de txt y comboboxs
            MetodosUI.SetPlaceholder(txt_DNI, "DNI");
            MetodosUI.SetPlaceholder(cmb_odontologo,"Odontólogo");
            MetodosUI.SetPlaceholder(dtp_registroCitas,"Fecha");
            MetodosUI.SetPlaceholder(cmb_horario,"Horario");
            MetodosUI.SetPlaceholder(cmb_tratamiento,"Tratamiento");
            #endregion
            
            btn_registrarCita.Enabled = false;
            btn_nuevo_cliente.Enabled = true;
            
            empleado = form_login.empleado;
        }

        private void form_recepcion_Load(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_cliente_Click(object sender, EventArgs e)
        {
            form_registroCliente form_RegistroCliente = new form_registroCliente();
            form_RegistroCliente.ShowDialog();

        }

        public void getTratamientos(ComboBox comboBox)
        {
           
            comboBox.Items.Clear();

           
            List<Tratamiento> listaTratamientos = LogTratamiento.Instancia.ListarTratamientos();

            
            foreach (var tratamiento in listaTratamientos)
            {
                comboBox.Items.Add(tratamiento.Nombre);
            }

           
        }

        public void getOdontologos(ComboBox comboBox)
        {

            comboBox.Items.Clear();


            List<Empleado> empleado = LogEmpleado.Instancia.ListarOdontologos();


            foreach (var emp in empleado)
            {
                comboBox.Items.Add(emp.Nombre);
            }


        }



        private void txt_DNI_TextChanged(object sender, EventArgs e)
        {
            string dni = txt_DNI.Text;
            if (dni.Length > 8)
            {
                txt_DNI.Text = txt_DNI.Text.Substring(0, 8);
                txt_DNI.SelectionStart = txt_DNI.Text.Length;
                btn_registrarCita.Enabled = false;

            }
            if (dni.Length < 8)
            {
                lbl_nombreR.Text = "complete DNI";
                btn_registrarCita.Enabled = false;
                
                btn_nuevo_cliente.Enabled = false;
               

            }

            if (dni.Length == 8)
            {
                bool c = LogCliente.Instancia.BuscarClienteDNI_bool(dni);
                if (c)
                {
                    Cliente cliente = LogCliente.Instancia.BuscarClienteDNI(dni);
                    lbl_nombreR.Text = cliente.Nombre;
                    btn_registrarCita.Enabled = true;
                    btn_nuevo_cliente.Enabled = false;
                   

                }
                else
                {
                    lbl_nombreR.Text = "not found";
                    btn_nuevo_cliente.Enabled = true;
                    btn_registrarCita.Enabled = false;
                    

                }

            }
        }


        public static List<Tuple<TimeSpan, TimeSpan>> GenerarHorasDia()
        {
            var horas = new List<Tuple<TimeSpan, TimeSpan>>();
            try
            {
                for (int i = 0; i < 24; i++)
                {
                    TimeSpan horaInicio = new TimeSpan(i, 0, 0); 
                    TimeSpan horaFin = new TimeSpan(i + 1, 0, 0); 
                    horas.Add(new Tuple<TimeSpan, TimeSpan>(horaInicio, horaFin));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}");
            }
            return horas;
        }



        public static void getHorarios(ComboBox comboBox)
        {
            var horas = GenerarHorasDia();
            foreach (var hora in horas)
            {
                comboBox.Items.Add($"{hora.Item1} - {hora.Item2}");
            }
        }
        private void cmb_tratamiento_MouseClick_1(object sender, MouseEventArgs e)
        {
            getTratamientos(cmb_tratamiento);
        }

        private void btn_registrarCita_Click(object sender, EventArgs e)
        {
            
            MetodosUI.SetPlaceholder(cmb_tratamiento, "Tratamiento");
            MetodosUI.SetPlaceholder(cmb_odontologo, "Odontólogo");

        }

        private void cmb_odontologo_MouseClick(object sender, MouseEventArgs e)
        {
            getOdontologos(cmb_odontologo);
        }

        private void cmb_odontologo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void dtp_registroCitas_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                List<Empleado> empleados = LogEmpleado.Instancia.ListarOdontologos();
                foreach (var emp in empleados)
                {
                    if (emp.Nombre == cmb_odontologo.SelectedItem?.ToString())
                    {
                        List<Cita> listCitas = LogCita.Instancia.ListarCitasPorEmpleado(emp.Id_empleado);

                        var horas = GenerarHorasDia();
                        cmb_horario.Items.Clear(); 

                        DateTime fechaSeleccionada = dtp_registroCitas.Value.Date;
                        DateTime fechaBase = new DateTime(1, 1, 1);

                        foreach (var hora in horas)
                        {
                            DateTime fechaHoraInicio = fechaBase.Add(hora.Item1);
                            DateTime fechaHoraFin = fechaBase.Add(hora.Item2);

                            foreach (var cita in listCitas)
                            {
                                if (fechaSeleccionada == cita.Fecha_inicio.Value.Date)
                                {
                                    if ((cita.Fecha_inicio.Value.TimeOfDay != fechaHoraInicio.TimeOfDay) && (cita.Fecha_fin.Value.TimeOfDay != fechaHoraFin.TimeOfDay))
                                    {
                                        cmb_horario.Items.Add($"{hora.Item1:hh\\:mm} - {hora.Item2:hh\\:mm}");
                                    }
                                }
                                
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}");
            }
        }



    }
}

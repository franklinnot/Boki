using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class form_recepcion : Form
    {

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
            btn_nuevo_cliente.Enabled = false;

            getTratamientos(cmb_tratamiento);
            getOdontologos(cmb_odontologo);
        }

        private void btn_nuevo_cliente_Click(object sender, EventArgs e)
        {
            form_registroCliente form_RegistroCliente = new form_registroCliente();
            form_RegistroCliente.ShowDialog();

        }

        private void btn_registrarCita_Click(object sender, EventArgs e)
        {
            //para id_cliente
            Cliente cliente = LogCliente.Instancia.BuscarClienteDNI(txt_DNI.Text.Trim());
            int id_cliente = cliente.Id_cliente;

            //para id_empleado
            Empleado emp = LogEmpleado.Instancia.BuscarEmpleadoNombre(cmb_odontologo.SelectedItem.ToString());
            int id_empleado = emp.Id_empleado;

            //para la fecha inicio
            DateTime fechaSeleccionada = dtp_registroCitas.Value.Date; 
            string intervalo = cmb_horario.SelectedItem.ToString(); 
            string[] horas = intervalo.Split('-');
            TimeSpan horaInicio = TimeSpan.Parse(horas[0].Trim()); 
            DateTime Fecha_inicio = fechaSeleccionada + horaInicio;

            Cita cita = new Cita
            {
                Id_cliente = id_cliente,
                Id_cita = GenerarStringAleatorio(10),
                id_empleado = id_empleado,
                Fecha_inicio = Fecha_inicio,
                Estado = "PENDIENTE",
                Fecha_Registro = DateTime.Now
            };



            bool verificar_registro = LogCita.Instancia.InsertarCita(cita);

            if (!verificar_registro)
            {
                MessageBox.Show("La cita no se ingresado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbx_tratamiento.Checked)
                {
                    Cita_tratamiento citaTratamiento = new Cita_tratamiento();
                    citaTratamiento.Id_citatratamiento = GenerarStringAleatorio(12);
                    citaTratamiento.Id_cita = cita.Id_cita;
                    List<Tratamiento> tratamientos = LogTratamiento.Instancia.ListarTratamientos();
                    Tratamiento tr = tratamientos.Find(x => x.Nombre == cmb_tratamiento.SelectedItem.ToString());
                    int idTratamiento = tr.Id_Tratamiento; 
                    citaTratamiento.Id_Tratamiento = idTratamiento;
                    
                    LogCitaTratamiento.Instancia.InsertarCitaTratamiento(citaTratamiento);
                }
                else
                {
                    Cita_consulta citaConsulta = new Cita_consulta();
                    citaConsulta.Id_citaconsulta = GenerarStringAleatorio(12);
                    citaConsulta.Id_cita = cita.Id_cita;
                    LogCitaConsulta.Instancia.InsertarCitaConsulta(citaConsulta);
                }
                LimpiarCampos();
                MessageBox.Show("La cita se ha registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_mostrar_citas_Click(object sender, EventArgs e)
        {
            form_cita form_Cita = new form_cita();
            form_Cita.ShowDialog();
        }

        private void txt_DNI_TextChanged(object sender, EventArgs e)
        {
            string dni = txt_DNI.Text.Trim();

            if (dni.Length == 8)
            {
                bool c = LogCliente.Instancia.BuscarClienteDNI_bool(dni);
                if (c)
                {
                    Cliente cliente = LogCliente.Instancia.BuscarClienteDNI(dni);
                    txt_nombreCliente.Text = cliente.Nombre;
                    btn_registrarCita.Enabled = true;
                    btn_nuevo_cliente.Enabled = false;
                   

                }
                else
                {
                    txt_nombreCliente.Text = "not found";
                    btn_nuevo_cliente.Enabled = true;
                    btn_registrarCita.Enabled = false;
                }
            }
            else
            {
                txt_nombreCliente.Text = "complete DNI";
                btn_registrarCita.Enabled = false;
                btn_nuevo_cliente.Enabled = false;
            }
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

                            bool agregarIntervalo = true;

                            foreach (var cita in listCitas)
                            {
                                if (fechaSeleccionada == cita.Fecha_inicio.Value.Date)
                                {
                                    if ((cita.Fecha_inicio.Value.TimeOfDay == fechaHoraInicio.TimeOfDay) &&
                                        (cita.Fecha_fin.Value.TimeOfDay == fechaHoraFin.TimeOfDay))
                                    {
                                        agregarIntervalo = false;
                                        break;
                                    }
                                }
                            }

                            if (agregarIntervalo)
                            {
                                cmb_horario.Items.Add($"{hora.Item1:hh\\:mm} - {hora.Item2:hh\\:mm}");
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


            List<Empleado> empleados = LogEmpleado.Instancia.ListarOdontologos();


            foreach (var emp in empleados)
            {
                comboBox.Items.Add(emp.Nombre);
            }


        }

        public static string GenerarStringAleatorio(int tamañoMaximo)
        {
            Random random = new Random();
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(caracteres, tamañoMaximo)
                                         .Select(s => s[random.Next(s.Length)])
                                         .ToArray());
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
            comboBox.Items.Clear();
            var horas = GenerarHorasDia();
            foreach (var hora in horas)
            {
                comboBox.Items.Add($"{hora.Item1} - {hora.Item2}");
            }
        }

        public void LimpiarCampos()
        {
            MetodosUI.SetPlaceholder(txt_DNI, "DNI");
            MetodosUI.SetPlaceholder(cmb_odontologo, "Odontólogo");
            MetodosUI.SetPlaceholder(dtp_registroCitas, "Fecha");
            MetodosUI.SetPlaceholder(cmb_horario, "Horario");
            MetodosUI.SetPlaceholder(cmb_tratamiento, "Tratamiento");
        }




    }
}

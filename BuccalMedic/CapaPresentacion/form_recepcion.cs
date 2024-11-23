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
            Placeholders();
            dtp_registroCitas.MinDate = DateTime.Now;
            getTratamientos(cmb_tratamiento);
            getOdontologos(cmb_odontologo);
        }

        private void Placeholders() {
            MetodosUI.SetPlaceholder(txt_DNI, "DNI");
            MetodosUI.SetPlaceholder(cmb_odontologo, "Odontólogo");
            MetodosUI.SetPlaceholder(dtp_registroCitas, "Fecha");
            MetodosUI.SetPlaceholder(cmb_horario, "Horario");
            MetodosUI.SetPlaceholder(cmb_tratamiento, "Tratamiento");
            cmb_tratamiento.SelectedIndex = -1;
        }

        private void btn_nuevo_cliente_Click(object sender, EventArgs e)
        {
            form_registroCliente form_RegistroCliente = new form_registroCliente();
            form_RegistroCliente.ShowDialog();

        }

        private void btn_registrarCita_Click(object sender, EventArgs e)
        {
            string tratamiento = string.IsNullOrEmpty(cmb_tratamiento.SelectedItem?.ToString()) ? null : cmb_tratamiento.SelectedItem?.ToString();
            /* Validaciones */
            if (string.IsNullOrEmpty(txt_DNI.Text.Trim()) || txt_DNI.Text.Trim() == "DNI" ||
                string.IsNullOrEmpty(cmb_odontologo.Text.Trim()) || cmb_odontologo.Text.Trim() == "Odontólogo" ||
                string.IsNullOrEmpty(cmb_horario.Text.Trim()) || cmb_horario.Text.Trim() == "Horario")
            {
                MessageBox.Show("Debes llenar todos los campos correctamente.");
                return;
            }
            if (cbx_tratamiento.Checked && (string.IsNullOrEmpty(tratamiento) || tratamiento == "Tratamiento"))
            {
                MessageBox.Show("Para registrar una cita de tipo de tratamiento debes seleccionar uno del combobox.");
                return;
            }

            //para id_cliente
            Cliente cliente = LogCliente.Instancia.BuscarClienteDNI(txt_DNI.Text.Trim());
            if (cliente.Nombre == null) {
                MessageBox.Show("Primero debe registrar al paciente.");
                return;
            }
            int id_cliente = cliente.ClienteID;

            //para id_empleado
            Empleado emp = LogEmpleado.Instancia.BuscarEmpleadoNombre(cmb_odontologo.SelectedItem.ToString());
            int id_empleado = emp.EmpleadoID;

            //para la fecha inicio
            DateTime fechaSeleccionada = dtp_registroCitas.Value.Date; 
            string intervalo = cmb_horario.SelectedItem.ToString(); 
            string[] horas = intervalo.Split('-');
            TimeSpan horaInicio = TimeSpan.Parse(horas[0].Trim()); 
            DateTime Fecha_Programada = fechaSeleccionada + horaInicio;
            string idcito = $"{id_cliente}_{id_empleado}_{Fecha_Programada:dd/MM/yy}_{Fecha_Programada:HH:mm}";
            Cita cita = new Cita
            {
                ClienteID = id_cliente,
                CitaID = $"CIT_{idcito}",
                EmpleadoID = id_empleado,
                FechaProgramacion = Fecha_Programada,
                Estado = "PENDIENTE",
                FechaRegistroCita = DateTime.Now
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
                    Citatratamiento citaTratamiento = new Citatratamiento();
                    citaTratamiento.CitaID = cita.CitaID;
                    List<Tratamiento> tratamientos = LogTratamiento.Instancia.ListarTratamientos();
                    Tratamiento tr = tratamientos.Find(x => x.NombreTratamiento == tratamiento);
                    citaTratamiento.TratamientoID = tr.TratamientoID;
                    LogCitaTratamiento.Instancia.InsertarCitaTratamiento(citaTratamiento);
                }
                else
                {
                    Diagnostico diagnostico = new Diagnostico();
                    diagnostico.DiagnosticoID = $"DIAG_{idcito}";
                    diagnostico.CitaID = cita.CitaID;
                    LogCitaConsulta.Instancia.InsertarCitaConsulta(diagnostico);
                }
                LimpiarCampos();
                Placeholders();
                MessageBox.Show("La cita se ha registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_mostrar_citas_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_cita form_Cita = new form_cita();
            form_Cita.ShowDialog();
            this.Show();
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
                   

                }
            }
            else
            {
                txt_nombreCliente.Text = "complete DNI";
            }
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
                        List<Cita> listCitas = LogCita.Instancia.ListarCitasPorEmpleado(emp.EmpleadoID);
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
                                if (fechaSeleccionada == cita.FechaProgramacion.Date)
                                {
                                    if ((cita.FechaProgramacion.TimeOfDay == fechaHoraInicio.TimeOfDay) &&
                                        (cita.FechaFinCita.Value.TimeOfDay == fechaHoraFin.TimeOfDay))
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
                comboBox.Items.Add(tratamiento.NombreTratamiento);
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

        public static string GenerarStringAleatorio(string textoInicial)
        {
            Random random = new Random();
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            string caracteresAleatorios = new string(Enumerable.Repeat(caracteres, 3)
                                                               .Select(s => s[random.Next(s.Length)])
                                                               .ToArray());

            string idGenerado = textoInicial + caracteresAleatorios;

            return idGenerado;
        }


        public static List<Tuple<TimeSpan, TimeSpan>> GenerarHorasDia()
        {
            var horas = new List<Tuple<TimeSpan, TimeSpan>>();
            try
            {
                for (int i = 8; i <= 18; i++)
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

        public void LimpiarCampos()
        {
            MetodosUI.SetPlaceholder(txt_DNI, "DNI");
            MetodosUI.SetPlaceholder(cmb_odontologo, "Odontólogo");
            MetodosUI.SetPlaceholder(dtp_registroCitas, "Fecha");
            MetodosUI.SetPlaceholder(cmb_horario, "Horario");
            MetodosUI.SetPlaceholder(cmb_tratamiento, "Tratamiento");
            cbx_tratamiento.Checked = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Placeholders();
            dtp_registroCitas.MinDate = DateTime.Now;
            getTratamientos(cmb_tratamiento);
            getOdontologos(cmb_odontologo);
        }
    }
}

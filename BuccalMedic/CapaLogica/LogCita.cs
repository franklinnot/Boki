using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogCita
    {
        #region Constructor y patron singleton
        private static readonly LogCita _instancia = new LogCita();

        public static LogCita Instancia { get { return LogCita._instancia; } }
        #endregion



        public List<Dictionary<string, string>> ListarCitas(string dni = null, string odontologo = null, string paciente = null, DateTime? fecha = null)
        {
            return DatCita.Instancia.ListarCita(dni, odontologo, paciente, fecha);
        }


        public void Anular(string idCita)
        {
            //int id = int.Parse(idCita);
            DatCita.Instancia.AnularCita(idCita);
        }

        public List<Dictionary<string, string>> ListarCitasOdontologo(int idEmpleado, string cargo ,string dni = null, string paciente = null, DateTime? fecha = null)
        {
            return DatCita.Instancia.ListarCitaOdontologo(idEmpleado,cargo, dni,paciente,fecha);
        }

        public void Modificar(string idCita)
        {
            //int id = int.Parse(idCita);
            DatCita.Instancia.ModificarEstado(idCita);
        }
        

        public Dictionary<string,string> TipoDeCita(string idCita)
        {
            return DatCita.Instancia.TipoDeCita(idCita);
        }

        public Dictionary<string,string> CitaConsulta(string idCita, string estado)
        {
            return DatCita.Instancia.CitaConsulta(idCita, estado);

        }

        public Dictionary<string, string> CitaTratamiento(string idCita, string estado)
        {
            return DatCita.Instancia.CitaTratamiento(idCita, estado);

        }

        public List<string> TratamientosDiagnostico(string idCita)
        {
            return DatCita.Instancia.TratamientosDiagnosticos(idCita);
        }

        public List<Cita> ListarCitasPorEmpleado(int id)
        {
            return DatCita.Instancia.ObtenerCitasPorEmpleado(id);
        }

        public bool InsertarCita(Cita cita)
        {
            return DatCita.Instancia.InsertarCita(cita);
        }
    }
}

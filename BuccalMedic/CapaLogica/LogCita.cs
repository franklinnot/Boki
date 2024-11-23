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

        public List<Dictionary<string, string>> ListarCitasOdontologo(int idEmpleado, string cargo ,string dni = null, string paciente = null, DateTime? fecha = null)
        {
            return DatCita.Instancia.ListarCitaOdontologo(idEmpleado,cargo, dni,paciente,fecha);
        }


        public bool AnularCita(string idCita)
        {
            return DatCita.Instancia.AnularCita(idCita);
        }

        public Dictionary<string,string> TipoDeCita(string idCita)
        {
            return DatCita.Instancia.TipoDeCita(idCita);
        }


        public List<Cita> ListarCitasPorEmpleado(int id)
        {
            return DatCita.Instancia.ObtenerCitasPorEmpleado(id);
        }

        public bool InsertarCita(Cita cita)
        {
            return DatCita.Instancia.InsertarCita(cita);
        }

        public List<Dictionary<string, string>> HistorialCitas(int idEmpleado, string tipoCita, string paciente = null, DateTime? fecha = null, string idcita = null)
        {
            return DatCita.Instancia.HistorialCitas(idEmpleado,tipoCita,paciente,fecha,idcita);
        }

        public List<Dictionary<string, string>> HistorialCitas(string tipo)
        {
            return DatCita.Instancia.HistorialCitas(tipo);
        }


    }
}

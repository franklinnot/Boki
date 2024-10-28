using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatCitaTratamiento
    {


        #region Constructor y patron singleton
        static readonly DatCitaTratamiento _instancia = new DatCitaTratamiento();


        public DatCitaTratamiento()
        {
            Debug.WriteLine("Se creo una instancia de DaCita");
        }

        public static DatCitaTratamiento Instancia { get { return DatCitaTratamiento._instancia; } }
        #endregion

        public bool InsertarCitaTratamiento(Cita_tratamiento cita)
        {
            SqlCommand comando = null;
            bool resultado = false;

            try
            {
                SqlConnection conexion = Conexion.Instancia.Conectar();
                comando = new SqlCommand("sp_InsertarCitaTratamiento", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Añadir los parámetros necesarios para el procedimiento almacenado
                comando.Parameters.AddWithValue("@Id_cita", cita.Id_cita);
                comando.Parameters.AddWithValue("@Id_CitaTratamiento", cita.Id_citatratamiento);
                comando.Parameters.AddWithValue("@Id_Tratamiento", cita.Id_Tratamiento);

                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();

                // Verificar si se insertó al menos una fila
                resultado = filasAfectadas > 0;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                if (comando != null)
                {
                    comando.Connection.Close();
                }
            }
            return resultado;
        }

        public Dictionary<string, string> DetalleCitaTratamiento(string idCita, string estado)
        {
            Dictionary<string, string> detalleCita = new Dictionary<string, string>();
            DataTable dataTable = new DataTable();
            SqlConnection conexion = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand("spDatosTratamiento", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Cita", idCita);
            cmd.Parameters.AddWithValue("@Estado", estado);

            conexion.Open();

            SqlDataReader query = cmd.ExecuteReader();
            dataTable.Load(query);

            if (dataTable.Rows.Count > 0)
            {
                Debug.WriteLine("Si tiene registros");
                foreach (DataRow fila in dataTable.Rows)
                {
                    detalleCita.Add("Id_Cita", fila["Id_Cita"].ToString());
                    detalleCita.Add("Fecha_Registro", fila["Fecha_Registro"].ToString());
                    detalleCita.Add("Odontologo", fila["Odontologo"].ToString());
                    detalleCita.Add("DNI", fila["DNI"].ToString());
                    detalleCita.Add("Paciente", fila["Paciente"].ToString());
                    detalleCita.Add("Estado", fila["Estado"].ToString());
                    detalleCita.Add("Tratamiento", fila["Tratamiento"].ToString());

                    if (estado == "ATENDIDO")
                    {
                        detalleCita.Add("Procedimiento", fila["Procedimiento"].ToString());
                        detalleCita.Add("Recomendaciones", fila["Recomendaciones"].ToString());
                    }
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return detalleCita;
        }

        public bool InsertarAtencion(Cita_tratamiento tratamiento)
        {
            SqlCommand comando = null;
            bool resultado = false;

            try
            {
                SqlConnection conexion = Conexion.Instancia.Conectar();
                comando = new SqlCommand("SP_RegistrarAtencion", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Id_Cita", tratamiento.Id_cita);
                comando.Parameters.AddWithValue("@Procedimiento", tratamiento.Procedimiento);
                comando.Parameters.AddWithValue("@Recomendaciones", tratamiento.Recomendaciones);

                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                resultado = filasAfectadas > 0;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                if (comando != null)
                {
                    comando.Connection.Close();
                }
            }
            return resultado;
        }
        private List<Dictionary<string, string>> ToList(String peziduri, List<SqlParameter> parameters)
        {
            List<Dictionary<string, string>> citaTratamientos = new List<Dictionary<string, string>>();
            DataTable dataTable = new DataTable();
            SqlConnection conexion = Conexion.Instancia.Conectar();
            SqlCommand cmd = new SqlCommand(peziduri, conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter parametro in parameters)
            {
                cmd.Parameters.Add(parametro);
            }
            conexion.Open();

            SqlDataReader query = cmd.ExecuteReader();
            dataTable.Load(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow fila in dataTable.Rows)
                {
                    Dictionary<string, string> cita = new Dictionary<string, string>
                    {
                        { "IdCita", fila["Id_cita"].ToString() },
                        { "Paciente", fila["Paciente"].ToString() },
                        { "Fecha_Registro", fila["Fecha_Registro"].ToString() },
                    };
                    citaTratamientos.Add(cita);
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return citaTratamientos;
        }

        public List<Dictionary<string, string>> ListarCitaTratamiento(string idcita = null, string paciente = null, DateTime? fecha = null)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(paciente))
                parameters.Add(new SqlParameter("@Nombre", paciente));

            if (!string.IsNullOrEmpty(idcita))
                parameters.Add(new SqlParameter("@IdCita", idcita));

            if (fecha.HasValue)
                parameters.Add(new SqlParameter("@FechaRegistro", fecha.Value));

            return ToList("spListaCitasTratamientoFiltradas", parameters);
        }
    }
}

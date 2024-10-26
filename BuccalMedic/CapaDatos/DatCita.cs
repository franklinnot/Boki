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
    public class DatCita
    {
        #region Constructor y patron singleton
        static readonly DatCita _instancia = new DatCita();


        public DatCita()
        {
            Debug.WriteLine("Se creo una instancia de DatCita");
        }

        public static DatCita Instancia { get { return DatCita._instancia; } }
        #endregion
        public List<Cita> ObtenerCitasPorEmpleado(int id_empleado)
        {
            List<Cita> citas = new List<Cita>();
            SqlCommand comando = null;

            try
            {
                SqlConnection conexion = Conexion.Instancia.Conectar();
                comando = new SqlCommand("sp_BuscarCitasPorEmpleado", conexion); // Nombre del procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdEmpleado", id_empleado);

                conexion.Open();
                SqlDataReader data = comando.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(data);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow fila in dataTable.Rows)
                    {
                        Cita cita = new Cita
                        {
                            Id_cita = (fila["Id_cita"]).ToString(),
                            id_empleado = ((int)fila["id_empleado"]),
                            Id_cliente = Convert.ToInt32(fila["Id_cliente"]),
                            Fecha_Registro = Convert.ToDateTime(fila["Fecha_Registro"]),
                            Fecha_inicio = Convert.ToDateTime(fila["Fecha_inicio"]),
                            Fecha_fin = Convert.ToDateTime(fila["Fecha_fin_provisional"]),
                            Estado = fila["Estado"].ToString()
                            // Otros campos de Cita que necesites agregar aquí
                        };

                        citas.Add(cita);
                    }
                }
                else
                {
                    Debug.WriteLine("No se encontraron citas para el empleado especificado.");
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }
            finally
            {
                if (comando != null)
                {
                    comando.Connection.Close();
                }
            }

            return citas;
        }

    }
}

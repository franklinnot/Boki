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
    public class DatTratamiento
    {
        #region Constructor y patrón singleton
        static readonly DatTratamiento _instancia = new DatTratamiento();

        // Constructor privado para el patrón singleton
        private DatTratamiento()
        {
            Debug.WriteLine("Se creó una instancia de DatTratamiento");
        }


        public static DatTratamiento Instancia
        {
            get
            {
                return DatTratamiento._instancia;
            }
        }
        #endregion
        private List<Tratamiento> ToList(string procedimiento)
        {
            List<Tratamiento> tratamientos = new List<Tratamiento>();
            DataTable data = Conexion.Instancia.PeziDuri(procedimiento);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow fila in data.Rows)
                {
                    Tratamiento tratamiento = new Tratamiento
                    {
                        Id_Tratamiento = int.Parse(fila["Id_Tratamiento"].ToString()),
                        Nombre = fila["Nombre"].ToString(),
                        Descripcion = fila["Descripcion"].ToString()

                    };
                    tratamientos.Add(tratamiento);
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }
            return tratamientos;
        }
        public List<Tratamiento> ListarTratamientos()
        {
            return ToList("spListarTratamientos");
        }

        //dfdfdfdfd

        public Boolean RegistrarTratamientos(Tratamiento tratamiento)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarTratamientos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", tratamiento.Descripcion);
                cmd.Parameters.AddWithValue("@nombre", tratamiento.Nombre);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarTratamiento(Tratamiento tratamiento)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarTratamiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTratamiento", tratamiento.Id_Tratamiento);
                cmd.Parameters.AddWithValue("@descripcion", tratamiento.Descripcion);
                cmd.Parameters.AddWithValue("@nombre", tratamiento.Nombre);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
    }
}

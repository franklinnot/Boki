﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatEmpleado
    {

        #region Constructor y patron singleton
        static readonly DatEmpleado _instancia = new DatEmpleado();


        public DatEmpleado()
        {
            Debug.WriteLine("Se creo una instancia de DatEmpleado");
        }

        public static DatEmpleado Instancia { get { return DatEmpleado._instancia; } }
        #endregion

        // Este es un metodo que se puede replicar para practicamente todas las entidades
        // Solo necesita devolver el tipo de dato coincidente junto a sus atributos especificos
        private List<Empleado> ToList(String peziduri)
        {
            List<Empleado> empleados = new List<Empleado>();
            DataTable data = Conexion.PeziDuri(peziduri);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow fila in data.Rows)
                {
                    Empleado empleado = new Empleado
                    {
                        Id_empleado = Convert.ToInt32(fila["Id_empleado"]),
                        Usuario = fila["Usuario"].ToString(),
                        Password = fila["Password"].ToString(),
                        Cargo = fila["Cargo"].ToString(),
                        Nombre = fila["Nombre"].ToString()
                    };

                    empleados.Add(empleado);
                }
            }
            else
            {
                Debug.WriteLine("El DataTable está vacío.");
            }

            return empleados;
        }


        public List<Empleado> ListarEmpleados()
        {      
            return ToList("sp_ListarEmpleados");
        }


    }
}

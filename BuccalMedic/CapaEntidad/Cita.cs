namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("Cita")]
    public partial class Cita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cita()
        {
            Cita_consulta = new HashSet<Cita_consulta>();
            Cita_tratamiento = new HashSet<Cita_tratamiento>();
        }

        public DateTime? Fecha_Registro { get; set; }

        [Key]
        [StringLength(16)]
        public string Id_cita { get; set; }

        public int Id_cliente { get; set; }

        public DateTime? Fecha_inicio { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        public DateTime? Fecha_fin { get; set; }

        public int id_empleado { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita_consulta> Cita_consulta { get; set; }

        public virtual Empleado Empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita_tratamiento> Cita_tratamiento { get; set; }
    }
}

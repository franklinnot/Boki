namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cita")]
    public partial class Cita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cita()
        {
            Citatratamientoes = new HashSet<Citatratamiento>();
            Diagnosticoes = new HashSet<Diagnostico>();
        }

        [StringLength(50)]
        public string CitaID { get; set; }

        public int ClienteID { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        public DateTime FechaProgramacion { get; set; }

        public int EmpleadoID { get; set; }

        public DateTime? FechaFinCita { get; set; }

        public DateTime FechaRegistroCita { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Empleado Empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Citatratamiento> Citatratamientoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diagnostico> Diagnosticoes { get; set; }
    }
}

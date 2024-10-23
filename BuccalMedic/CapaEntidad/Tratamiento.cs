namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tratamiento")]
    public partial class Tratamiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tratamiento()
        {
            Cita_tratamiento = new HashSet<Cita_tratamiento>();
            Tratamiento_diagnostico = new HashSet<Tratamiento_diagnostico>();
        }

        [Key]
        public int Id_Tratamiento { get; set; }

        [StringLength(128)]
        public string Descripcion { get; set; }

        [StringLength(128)]
        public string Nombre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita_tratamiento> Cita_tratamiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tratamiento_diagnostico> Tratamiento_diagnostico { get; set; }
    }
}

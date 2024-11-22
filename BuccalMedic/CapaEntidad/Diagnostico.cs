namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Diagnostico")]
    public partial class Diagnostico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Diagnostico()
        {
            DiagnosticoTratamientoes = new HashSet<DiagnosticoTratamiento>();
        }

        [StringLength(50)]
        public string DiagnosticoID { get; set; }

        [Required]
        [StringLength(50)]
        public string CitaID { get; set; }

        [StringLength(250)]
        public string Resultado { get; set; }

        [StringLength(250)]
        public string Recomendacion { get; set; }

        public virtual Cita Cita { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiagnosticoTratamiento> DiagnosticoTratamientoes { get; set; }
    }
}

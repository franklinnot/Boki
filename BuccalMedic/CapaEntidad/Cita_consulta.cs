namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cita_consulta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cita_consulta()
        {
            Diagnosticoes = new HashSet<Diagnostico>();
        }

        [Key]
        [StringLength(16)]
        public string Id_citaconsulta { get; set; }

        [Required]
        [StringLength(16)]
        public string Id_cita { get; set; }

        public virtual Cita Cita { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diagnostico> Diagnosticoes { get; set; }
    }
}

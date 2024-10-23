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
            Tratamiento_diagnostico = new HashSet<Tratamiento_diagnostico>();
        }

        [Key]
        [StringLength(16)]
        public string Id_diagnostico { get; set; }

        [Required]
        [StringLength(16)]
        public string Id_citaconsulta { get; set; }

        [StringLength(256)]
        public string Recomendaciones { get; set; }

        [StringLength(256)]
        public string Resultado { get; set; }

        public virtual Cita_consulta Cita_consulta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tratamiento_diagnostico> Tratamiento_diagnostico { get; set; }
    }
}

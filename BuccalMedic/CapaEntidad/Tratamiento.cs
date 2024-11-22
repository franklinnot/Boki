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
            Citatratamientoes = new HashSet<Citatratamiento>();
            DiagnosticoTratamientoes = new HashSet<DiagnosticoTratamiento>();
        }

        [Required]
        [StringLength(100)]
        public string NombreTratamiento { get; set; }

        public int TratamientoID { get; set; }

        [Required]
        [StringLength(240)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string estado { get; set; }

        [Column(TypeName = "money")]
        public decimal Precio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Citatratamiento> Citatratamientoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiagnosticoTratamiento> DiagnosticoTratamientoes { get; set; }
    }
}

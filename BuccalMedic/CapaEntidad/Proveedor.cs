namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proveedor")]
    public partial class Proveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedor()
        {
            Ordencompras = new HashSet<Ordencompra>();
        }

        public int ProveedorID { get; set; }

        [Required]
        [StringLength(50)]
        public string RazonSocial { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(50)]
        public string Ruc { get; set; }

        [Required]
        [StringLength(50)]
        public string Correo { get; set; }

        [Required]
        [StringLength(50)]
        public string Telefono { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ordencompra> Ordencompras { get; set; }
    }
}

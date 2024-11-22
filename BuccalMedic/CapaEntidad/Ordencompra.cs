namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ordencompra")]
    public partial class Ordencompra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ordencompra()
        {
            DetalleOrdenCompras = new HashSet<DetalleOrdenCompra>();
            Notaingresoes = new HashSet<Notaingreso>();
        }

        [StringLength(50)]
        public string OrdencompraID { get; set; }

        public int ProveedorID { get; set; }

        public int EmpleadoID { get; set; }

        public DateTime FechaDeRegistro { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Column(TypeName = "money")]
        public decimal? Monto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleOrdenCompra> DetalleOrdenCompras { get; set; }

        public virtual Empleado Empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notaingreso> Notaingresoes { get; set; }

        public virtual Proveedor Proveedor { get; set; }
    }
}

namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pedidoimplemento")]
    public partial class Pedidoimplemento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedidoimplemento()
        {
            DetallePedidoes = new HashSet<DetallePedido>();
        }

        [StringLength(50)]
        public string PedidoimplementoID { get; set; }

        public int OdontologoID { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime? FechaEntrega { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePedido> DetallePedidoes { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}

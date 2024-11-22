namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetalleOrdenCompra")]
    public partial class DetalleOrdenCompra
    {
        public int DetalleOrdenCompraID { get; set; }

        [Required]
        [StringLength(50)]
        public string OrdencompraID { get; set; }

        public int ImplementoID { get; set; }

        public virtual Implemento Implemento { get; set; }

        public virtual Ordencompra Ordencompra { get; set; }
    }
}

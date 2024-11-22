namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetallePedido")]
    public partial class DetallePedido
    {
        public int DetallePedidoID { get; set; }

        [Required]
        [StringLength(50)]
        public string PedidoimplementoID { get; set; }

        public int ImplementoID { get; set; }

        public int Cantidad { get; set; }

        public virtual Implemento Implemento { get; set; }

        public virtual Pedidoimplemento Pedidoimplemento { get; set; }
    }
}

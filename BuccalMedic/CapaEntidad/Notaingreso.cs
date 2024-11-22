namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notaingreso")]
    public partial class Notaingreso
    {
        public int NotaingresoID { get; set; }

        [Required]
        [StringLength(50)]
        public string OrdencompraID { get; set; }

        public DateTime FechaRegistro { get; set; }

        public virtual Ordencompra Ordencompra { get; set; }
    }
}

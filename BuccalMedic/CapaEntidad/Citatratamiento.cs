namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Citatratamiento")]
    public partial class Citatratamiento
    {
        public int CitatratamientoID { get; set; }

        [StringLength(50)]
        public string CitaID { get; set; }

        public int TratamientoID { get; set; }

        [StringLength(50)]
        public string Procedimiento { get; set; }

        [StringLength(50)]
        public string Recomendaciones { get; set; }

        public virtual Cita Cita { get; set; }

        public virtual Tratamiento Tratamiento { get; set; }
    }
}

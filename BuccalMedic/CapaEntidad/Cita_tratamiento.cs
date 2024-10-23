namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cita_tratamiento
    {
        [Key]
        [StringLength(16)]
        public string Id_citatratamiento { get; set; }

        [Required]
        [StringLength(16)]
        public string Id_cita { get; set; }

        public int Id_Tratamiento { get; set; }

        [StringLength(512)]
        public string Procedimiento { get; set; }

        [StringLength(512)]
        public string Recomendaciones { get; set; }

        public virtual Cita Cita { get; set; }

        public virtual Tratamiento Tratamiento { get; set; }
    }
}

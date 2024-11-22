namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiagnosticoTratamiento")]
    public partial class DiagnosticoTratamiento
    {
        public int DiagnosticoTratamientoID { get; set; }

        public int TratamientoID { get; set; }

        [Required]
        [StringLength(50)]
        public string DiagnosticoID { get; set; }

        public virtual Diagnostico Diagnostico { get; set; }

        public virtual Tratamiento Tratamiento { get; set; }
    }
}

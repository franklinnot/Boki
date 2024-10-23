namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tratamiento_diagnostico
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Tratamiento_Diagnostico { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Tratamiento { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(16)]
        public string Id_diagnostico { get; set; }

        public virtual Diagnostico Diagnostico { get; set; }

        public virtual Tratamiento Tratamiento { get; set; }
    }
}

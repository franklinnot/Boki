namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            Citas = new HashSet<Cita>();
            Ordencompras = new HashSet<Ordencompra>();
            Pedidoimplementoes = new HashSet<Pedidoimplemento>();
        }

        public int EmpleadoID { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string DNI { get; set; }

        [StringLength(50)]
        public string Telefono { get; set; }

        [StringLength(50)]
        public string FechaNacimiento { get; set; }

        [StringLength(50)]
        public string Genero { get; set; }

        [StringLength(50)]
        public string Cargo { get; set; }

        [StringLength(50)]
        public string Usuario { get; set; }

        [StringLength(50)]
        public string Contraseña { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita> Citas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ordencompra> Ordencompras { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedidoimplemento> Pedidoimplementoes { get; set; }
    }
}

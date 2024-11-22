using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CapaEntidad
{
    public partial class model : DbContext
    {
        public model()
            : base("name=modelito")
        {
        }

        public virtual DbSet<Cita> Citas { get; set; }
        public virtual DbSet<Citatratamiento> Citatratamientoes { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetalleOrdenCompra> DetalleOrdenCompras { get; set; }
        public virtual DbSet<DetallePedido> DetallePedidoes { get; set; }
        public virtual DbSet<Diagnostico> Diagnosticoes { get; set; }
        public virtual DbSet<DiagnosticoTratamiento> DiagnosticoTratamientoes { get; set; }
        public virtual DbSet<Empleado> Empleadoes { get; set; }
        public virtual DbSet<Implemento> Implementoes { get; set; }
        public virtual DbSet<Notaingreso> Notaingresoes { get; set; }
        public virtual DbSet<Ordencompra> Ordencompras { get; set; }
        public virtual DbSet<Pedidoimplemento> Pedidoimplementoes { get; set; }
        public virtual DbSet<Proveedor> Proveedors { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tratamiento> Tratamientoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cita>()
                .Property(e => e.CitaID)
                .IsUnicode(false);

            modelBuilder.Entity<Cita>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Cita>()
                .HasMany(e => e.Diagnosticoes)
                .WithRequired(e => e.Cita)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Citatratamiento>()
                .Property(e => e.CitaID)
                .IsUnicode(false);

            modelBuilder.Entity<Citatratamiento>()
                .Property(e => e.Procedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Citatratamiento>()
                .Property(e => e.Recomendaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.DNI)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Citas)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DetalleOrdenCompra>()
                .Property(e => e.OrdencompraID)
                .IsUnicode(false);

            modelBuilder.Entity<DetallePedido>()
                .Property(e => e.PedidoimplementoID)
                .IsUnicode(false);

            modelBuilder.Entity<Diagnostico>()
                .Property(e => e.DiagnosticoID)
                .IsUnicode(false);

            modelBuilder.Entity<Diagnostico>()
                .Property(e => e.CitaID)
                .IsUnicode(false);

            modelBuilder.Entity<Diagnostico>()
                .Property(e => e.Resultado)
                .IsUnicode(false);

            modelBuilder.Entity<Diagnostico>()
                .Property(e => e.Recomendacion)
                .IsUnicode(false);

            modelBuilder.Entity<Diagnostico>()
                .HasMany(e => e.DiagnosticoTratamientoes)
                .WithRequired(e => e.Diagnostico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiagnosticoTratamiento>()
                .Property(e => e.DiagnosticoID)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.DNI)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.FechaNacimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Contraseña)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Citas)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Ordencompras)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Pedidoimplementoes)
                .WithRequired(e => e.Empleado)
                .HasForeignKey(e => e.OdontologoID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Implemento>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Implemento>()
                .Property(e => e.Marca)
                .IsUnicode(false);

            modelBuilder.Entity<Implemento>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Implemento>()
                .HasMany(e => e.DetalleOrdenCompras)
                .WithRequired(e => e.Implemento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Implemento>()
                .HasMany(e => e.DetallePedidoes)
                .WithRequired(e => e.Implemento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Notaingreso>()
                .Property(e => e.OrdencompraID)
                .IsUnicode(false);

            modelBuilder.Entity<Ordencompra>()
                .Property(e => e.OrdencompraID)
                .IsUnicode(false);

            modelBuilder.Entity<Ordencompra>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Ordencompra>()
                .Property(e => e.Monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ordencompra>()
                .HasMany(e => e.DetalleOrdenCompras)
                .WithRequired(e => e.Ordencompra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ordencompra>()
                .HasMany(e => e.Notaingresoes)
                .WithRequired(e => e.Ordencompra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pedidoimplemento>()
                .Property(e => e.PedidoimplementoID)
                .IsUnicode(false);

            modelBuilder.Entity<Pedidoimplemento>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Pedidoimplemento>()
                .HasMany(e => e.DetallePedidoes)
                .WithRequired(e => e.Pedidoimplemento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Ruc)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.Ordencompras)
                .WithRequired(e => e.Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tratamiento>()
                .Property(e => e.NombreTratamiento)
                .IsUnicode(false);

            modelBuilder.Entity<Tratamiento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Tratamiento>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<Tratamiento>()
                .Property(e => e.Precio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tratamiento>()
                .HasMany(e => e.Citatratamientoes)
                .WithRequired(e => e.Tratamiento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tratamiento>()
                .HasMany(e => e.DiagnosticoTratamientoes)
                .WithRequired(e => e.Tratamiento)
                .WillCascadeOnDelete(false);
        }
    }
}

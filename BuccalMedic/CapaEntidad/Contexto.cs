using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CapaEntidad
{
    public partial class Contexto : DbContext
    {
        public Contexto()
            : base("Data Source=localhost;Initial Catalog=Bucal;Integrated Security=True;TrustServerCertificate=True")
        {
        }

        public virtual DbSet<Cita> Citas { get; set; }
        public virtual DbSet<Cita_consulta> Cita_consulta { get; set; }
        public virtual DbSet<Cita_tratamiento> Cita_tratamiento { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Diagnostico> Diagnosticos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Tratamiento> Tratamientos { get; set; }
        public virtual DbSet<Tratamiento_diagnostico> Tratamiento_diagnostico { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cita>()
                .Property(e => e.Id_cita)
                .IsUnicode(false);

            modelBuilder.Entity<Cita>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Cita>()
                .HasMany(e => e.Cita_consulta)
                .WithRequired(e => e.Cita)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cita>()
                .HasMany(e => e.Cita_tratamiento)
                .WithRequired(e => e.Cita)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cita_consulta>()
                .Property(e => e.Id_citaconsulta)
                .IsUnicode(false);

            modelBuilder.Entity<Cita_consulta>()
                .Property(e => e.Id_cita)
                .IsUnicode(false);

            modelBuilder.Entity<Cita_consulta>()
                .HasMany(e => e.Diagnosticoes)
                .WithRequired(e => e.Cita_consulta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cita_tratamiento>()
                .Property(e => e.Id_citatratamiento)
                .IsUnicode(false);

            modelBuilder.Entity<Cita_tratamiento>()
                .Property(e => e.Id_cita)
                .IsUnicode(false);

            modelBuilder.Entity<Cita_tratamiento>()
                .Property(e => e.Procedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Cita_tratamiento>()
                .Property(e => e.Recomendaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.DNI)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Citas)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Diagnostico>()
                .Property(e => e.Id_diagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<Diagnostico>()
                .Property(e => e.Id_citaconsulta)
                .IsUnicode(false);

            modelBuilder.Entity<Diagnostico>()
                .Property(e => e.Recomendaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Diagnostico>()
                .Property(e => e.Resultado)
                .IsUnicode(false);

            modelBuilder.Entity<Diagnostico>()
                .HasMany(e => e.Tratamiento_diagnostico)
                .WithRequired(e => e.Diagnostico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Citas)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tratamiento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Tratamiento>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Tratamiento>()
                .HasMany(e => e.Cita_tratamiento)
                .WithRequired(e => e.Tratamiento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tratamiento>()
                .HasMany(e => e.Tratamiento_diagnostico)
                .WithRequired(e => e.Tratamiento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tratamiento_diagnostico>()
                .Property(e => e.Id_diagnostico)
                .IsUnicode(false);
        }
    }
}

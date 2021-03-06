using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Datos
{
    public partial class ParcialContext : DbContext
    {
        public ParcialContext()
            : base("name=ParcialContext")
        {
        }

        public virtual DbSet<Acciones> Acciones { get; set; }
        public virtual DbSet<Permiso> Permisos { get; set; }
        public virtual DbSet<PermisosAccione> PermisosAcciones { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acciones>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Acciones>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<Acciones>()
                .Property(e => e.Controller)
                .IsUnicode(false);

            modelBuilder.Entity<Acciones>()
                .HasMany(e => e.PermisosAcciones)
                .WithRequired(e => e.Accione)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Permiso>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Permiso>()
                .HasMany(e => e.PermisosAcciones)
                .WithRequired(e => e.Permiso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Permiso>()
                .HasMany(e => e.Usuarios)
                .WithRequired(e => e.Permiso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Direcci?n)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);
        }
    }
}

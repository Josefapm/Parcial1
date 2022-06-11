using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Datos
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {

        }

        public virtual DbSet<Acciones> Acciones { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<PermisosAcciones> PermisosAcciones { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acciones>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Acciones>()
                .Property(e => e.Accion)
                .IsUnicode(false);

            modelBuilder.Entity<Acciones>()
                .Property(e => e.Controller)
                .IsUnicode(false);

            modelBuilder.Entity<Acciones>()
                .HasMany(e => e.PermisosAcciones)
                .WithRequired(e => e.Acciones)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Permisos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Permisos>()
                .HasMany(e => e.PermisosAcciones)
                .WithRequired(e => e.Permisos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Permisos>()
                .HasMany(e => e.Usuarios)
                .WithRequired(e => e.Permisos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.FechaDeAlta)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Dirección)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);
        }
    }
}

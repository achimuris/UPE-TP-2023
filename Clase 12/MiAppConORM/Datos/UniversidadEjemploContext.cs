using System;
using System.Collections.Generic;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Datos
{
    public partial class UniversidadEjemploContext : DbContext
    {
        public UniversidadEjemploContext()
        {
        }

        public UniversidadEjemploContext(DbContextOptions<UniversidadEjemploContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carrera> Carreras { get; set; } = null!;
        public virtual DbSet<Materium> Materia { get; set; } = null!;
        public virtual DbSet<Perfil> Perfils { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=UniversidadEjemplo;Data Source=.\\SQLEXPRESS");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.HasKey(e => e.IdCarrera);

                entity.ToTable("Carrera");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Materium>(entity =>
            {
                entity.HasKey(e => e.IdMateria);

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdCarreraNavigation)
                    .WithMany(p => p.Materia)
                    .HasForeignKey(d => d.IdCarrera)
                    .HasConstraintName("FK_Materia_Carrera");
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.HasKey(e => e.IdPerfil);

                entity.ToTable("Perfil");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("Usuario");

                entity.Property(e => e.Clave)
                    .HasMaxLength(50)
                    .HasColumnName("clave");

                entity.Property(e => e.NombreDeUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("nombreDeUsuario");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Perfil");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

﻿// <auto-generated />
using System;
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Datos.Migrations
{
    [DbContext(typeof(UniversidadEjemploContext))]
    [Migration("20230605232628_BBDD_Inicial")]
    partial class BBDD_Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entidades.Carrera", b =>
                {
                    b.Property<int>("IdCarrera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCarrera"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdCarrera");

                    b.ToTable("Carrera", (string)null);
                });

            modelBuilder.Entity("Entidades.Materium", b =>
                {
                    b.Property<int>("IdMateria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMateria"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("IdCarrera")
                        .HasColumnType("int");

                    b.HasKey("IdMateria");

                    b.HasIndex("IdCarrera");

                    b.ToTable("Materia");
                });

            modelBuilder.Entity("Entidades.Perfil", b =>
                {
                    b.Property<int>("IdPerfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPerfil"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdPerfil");

                    b.ToTable("Perfil", (string)null);
                });

            modelBuilder.Entity("Entidades.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"), 1L, 1);

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("clave");

                    b.Property<int>("IdPerfil")
                        .HasColumnType("int");

                    b.Property<string>("NombreDeUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nombreDeUsuario");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdPerfil");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("Entidades.Materium", b =>
                {
                    b.HasOne("Entidades.Carrera", "IdCarreraNavigation")
                        .WithMany("Materia")
                        .HasForeignKey("IdCarrera")
                        .HasConstraintName("FK_Materia_Carrera");

                    b.Navigation("IdCarreraNavigation");
                });

            modelBuilder.Entity("Entidades.Usuario", b =>
                {
                    b.HasOne("Entidades.Perfil", "IdPerfilNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdPerfil")
                        .IsRequired()
                        .HasConstraintName("FK_Usuario_Perfil");

                    b.Navigation("IdPerfilNavigation");
                });

            modelBuilder.Entity("Entidades.Carrera", b =>
                {
                    b.Navigation("Materia");
                });

            modelBuilder.Entity("Entidades.Perfil", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}

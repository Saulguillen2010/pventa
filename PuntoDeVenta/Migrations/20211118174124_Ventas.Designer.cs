﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PuntoDeVenta.Models;

namespace PuntoDeVenta.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211118174124_Ventas")]
    partial class Ventas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("PuntoDeVenta.Models.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ApellidoMaterno")
                        .HasColumnType("text");

                    b.Property<string>("ApellidoPaterno")
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<string>("RFC")
                        .HasColumnType("text");

                    b.Property<string>("Sexo")
                        .HasColumnType("text");

                    b.Property<int>("VentaId")
                        .HasColumnType("integer");

                    b.Property<int?>("VentasId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VentasId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("PuntoDeVenta.Models.Empleados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ApellidoMaterno")
                        .HasColumnType("text");

                    b.Property<string>("ApellidoPaterno")
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<string>("RFC")
                        .HasColumnType("text");

                    b.Property<string>("Sexo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("PuntoDeVenta.Models.Productos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("integer");

                    b.Property<string>("Marca")
                        .HasColumnType("text");

                    b.Property<double>("PrecioCompra")
                        .HasColumnType("double precision");

                    b.Property<double>("PrecioVenta")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("PuntoDeVenta.Models.Ventas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("PuntoDeVenta.Models.Clientes", b =>
                {
                    b.HasOne("PuntoDeVenta.Models.Ventas", "Ventas")
                        .WithMany("Clientes")
                        .HasForeignKey("VentasId");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("PuntoDeVenta.Models.Ventas", b =>
                {
                    b.Navigation("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
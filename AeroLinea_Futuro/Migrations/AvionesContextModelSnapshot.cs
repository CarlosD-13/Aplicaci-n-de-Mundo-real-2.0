﻿// <auto-generated />
using AeroLinea_Futuro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AeroLinea_Futuro.Migrations
{
    [DbContext(typeof(AvionesContext))]
    partial class AvionesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AeroLinea_Futuro.Models.Aviones", b =>
                {
                    b.Property<int>("AvionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("AvionID");

                    b.ToTable("Aviones");
                });
#pragma warning restore 612, 618
        }
    }
}

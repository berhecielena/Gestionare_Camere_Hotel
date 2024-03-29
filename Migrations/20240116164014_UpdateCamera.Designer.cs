﻿// <auto-generated />
using System;
using Gestionare_Camere_Hotel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gestionare_Camere_Hotel.Migrations
{
    [DbContext(typeof(Gestionare_Camere_HotelContext))]
    [Migration("20240116164014_UpdateCamera")]
    partial class UpdateCamera
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Gestionare_Camere_Hotel.Models.Angajati", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CamereID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumarTelefon")
                        .HasColumnType("int");

                    b.Property<string>("Tura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CamereID");

                    b.ToTable("Angajati");
                });

            modelBuilder.Entity("Gestionare_Camere_Hotel.Models.Camere", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Camere");
                });

            modelBuilder.Entity("Gestionare_Camere_Hotel.Models.Etaj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CamereID")
                        .HasColumnType("int");

                    b.Property<int>("NumarEtaj")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CamereID");

                    b.ToTable("Etaj");
                });

            modelBuilder.Entity("Gestionare_Camere_Hotel.Models.TipCamera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CamereID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CamereID");

                    b.ToTable("TipCamera");
                });

            modelBuilder.Entity("Gestionare_Camere_Hotel.Models.Angajati", b =>
                {
                    b.HasOne("Gestionare_Camere_Hotel.Models.Camere", "Camere")
                        .WithMany()
                        .HasForeignKey("CamereID");

                    b.Navigation("Camere");
                });

            modelBuilder.Entity("Gestionare_Camere_Hotel.Models.Etaj", b =>
                {
                    b.HasOne("Gestionare_Camere_Hotel.Models.Camere", "Camere")
                        .WithMany("Etaje")
                        .HasForeignKey("CamereID");

                    b.Navigation("Camere");
                });

            modelBuilder.Entity("Gestionare_Camere_Hotel.Models.TipCamera", b =>
                {
                    b.HasOne("Gestionare_Camere_Hotel.Models.Camere", "Camere")
                        .WithMany("TipCamere")
                        .HasForeignKey("CamereID");

                    b.Navigation("Camere");
                });

            modelBuilder.Entity("Gestionare_Camere_Hotel.Models.Camere", b =>
                {
                    b.Navigation("Etaje");

                    b.Navigation("TipCamere");
                });
#pragma warning restore 612, 618
        }
    }
}

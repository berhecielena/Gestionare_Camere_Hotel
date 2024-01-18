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
    [Migration("20240117114636_test5")]
    partial class test5
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumarTelefon")
                        .HasColumnType("int");

                    b.Property<string>("Tura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Angajati");
                });

            modelBuilder.Entity("Gestionare_Camere_Hotel.Models.Camere", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AngajatiID")
                        .HasColumnType("int");

                    b.Property<int?>("CameraID")
                        .HasColumnType("int");

                    b.Property<int?>("EtajId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipCameraID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AngajatiID");

                    b.HasIndex("CameraID");

                    b.HasIndex("EtajId");

                    b.HasIndex("TipCameraID");

                    b.ToTable("Camere");
                });

            modelBuilder.Entity("Gestionare_Camere_Hotel.Models.Etaj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("NumarEtaj")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Etaj");
                });

            modelBuilder.Entity("Gestionare_Camere_Hotel.Models.TipCamera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipCamera");
                });

            modelBuilder.Entity("Gestionare_Camere_Hotel.Models.Camere", b =>
                {
                    b.HasOne("Gestionare_Camere_Hotel.Models.Angajati", "Angajat")
                        .WithMany("Camere")
                        .HasForeignKey("AngajatiID");

                    b.HasOne("Gestionare_Camere_Hotel.Models.Camere", "Camera")
                        .WithMany()
                        .HasForeignKey("CameraID");

                    b.HasOne("Gestionare_Camere_Hotel.Models.Etaj", null)
                        .WithMany("Camere")
                        .HasForeignKey("EtajId");

                    b.HasOne("Gestionare_Camere_Hotel.Models.TipCamera", "TipCamera")
                        .WithMany("Camere")
                        .HasForeignKey("TipCameraID");

                    b.Navigation("Angajat");

                    b.Navigation("Camera");

                    b.Navigation("TipCamera");
                });

            modelBuilder.Entity("Gestionare_Camere_Hotel.Models.Angajati", b =>
                {
                    b.Navigation("Camere");
                });

            modelBuilder.Entity("Gestionare_Camere_Hotel.Models.Etaj", b =>
                {
                    b.Navigation("Camere");
                });

            modelBuilder.Entity("Gestionare_Camere_Hotel.Models.TipCamera", b =>
                {
                    b.Navigation("Camere");
                });
#pragma warning restore 612, 618
        }
    }
}

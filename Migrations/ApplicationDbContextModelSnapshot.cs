﻿// <auto-generated />
using System;
using MediMitra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MediMitra.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MediMitra.Models.BookingVaccination", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VaccinationId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.ToTable("bookingVaccinations");
                });

            modelBuilder.Entity("MediMitra.Models.RegisterModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Otp")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("registerModels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "khanalvaidurga71@gmail.com",
                            Otp = 0,
                            Password = "$2a$11$LpGJHMEOQHKbwDLtD/S6se8GsrVByYtim6RTao7r4OPnRk3gt0XWG",
                            Role = "Admin",
                            Username = "Durga Khanal"
                        },
                        new
                        {
                            Id = 2,
                            Email = "sumildumre555@gmail.com",
                            Otp = 0,
                            Password = "$2a$11$eL6CZwg.QuOqbQTokOMGne0Fy.3PLoqgTXhOl/9avzBNRhTwnMETC",
                            Role = "Moderator",
                            Username = "Sunil Dumre"
                        },
                        new
                        {
                            Id = 3,
                            Email = "bhushaltilak9@gmail.com",
                            Otp = 0,
                            Password = "$2a$11$uMk7DwzX64SxWVbvkoYid.181g8xRntfZPZDbXmAdGu7/NEkaZs2y",
                            Role = "Moderator",
                            Username = "Tilak Bhusal"
                        });
                });

            modelBuilder.Entity("MediMitra.Models.Vaccination", b =>
                {
                    b.Property<int>("VaccinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VaccinationId"));

                    b.Property<string>("AgeGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VaccinationDose")
                        .HasColumnType("int");

                    b.Property<string>("VaccinationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VaccinationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VaccinationId");

                    b.ToTable("vaccinations");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using workshop.wwwapi.Data;

#nullable disable

namespace workshop.wwwapi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240613083912_AppointmentId")]
    partial class AppointmentId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("workshop.wwwapi.Models.Appointment", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("integer")
                        .HasColumnName("doctor_id");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer")
                        .HasColumnName("patient_id");

                    b.Property<DateTime>("Booking")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("bookings");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.HasKey("DoctorId", "PatientId");

                    b.HasIndex("PatientId");

                    b.ToTable("appointments");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            PatientId = 1,
                            Booking = new DateTime(2024, 6, 13, 8, 39, 11, 588, DateTimeKind.Utc).AddTicks(1504),
                            Id = 0
                        },
                        new
                        {
                            DoctorId = 2,
                            PatientId = 2,
                            Booking = new DateTime(2024, 6, 13, 8, 39, 11, 588, DateTimeKind.Utc).AddTicks(1508),
                            Id = 0
                        },
                        new
                        {
                            DoctorId = 3,
                            PatientId = 3,
                            Booking = new DateTime(2024, 6, 13, 8, 39, 11, 588, DateTimeKind.Utc).AddTicks(1509),
                            Id = 0
                        },
                        new
                        {
                            DoctorId = 4,
                            PatientId = 4,
                            Booking = new DateTime(2024, 6, 13, 8, 39, 11, 588, DateTimeKind.Utc).AddTicks(1510),
                            Id = 0
                        },
                        new
                        {
                            DoctorId = 1,
                            PatientId = 4,
                            Booking = new DateTime(2024, 6, 13, 8, 39, 11, 588, DateTimeKind.Utc).AddTicks(1511),
                            Id = 0
                        },
                        new
                        {
                            DoctorId = 2,
                            PatientId = 3,
                            Booking = new DateTime(2024, 6, 13, 8, 39, 11, 588, DateTimeKind.Utc).AddTicks(1512),
                            Id = 0
                        },
                        new
                        {
                            DoctorId = 3,
                            PatientId = 2,
                            Booking = new DateTime(2024, 6, 13, 8, 39, 11, 588, DateTimeKind.Utc).AddTicks(1513),
                            Id = 0
                        },
                        new
                        {
                            DoctorId = 4,
                            PatientId = 1,
                            Booking = new DateTime(2024, 6, 13, 8, 39, 11, 588, DateTimeKind.Utc).AddTicks(1515),
                            Id = 0
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("full_name");

                    b.HasKey("Id");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "John Doe"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Jane Doe"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "John Smith"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Jane Smith"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("full_name");

                    b.Property<string>("Gender")
                        .HasColumnType("text")
                        .HasColumnName("gender");

                    b.HasKey("Id");

                    b.ToTable("patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "annadrijver.nl",
                            FullName = "Anna Drijver",
                            Gender = "A"
                        },
                        new
                        {
                            Id = 2,
                            Email = "tomcruise.nl",
                            FullName = "Tom Cruise",
                            Gender = "A"
                        },
                        new
                        {
                            Id = 3,
                            Email = "georginaverbaan.nl",
                            FullName = "Gerogina Verbaan",
                            Gender = "A"
                        },
                        new
                        {
                            Id = 4,
                            Email = "daanschuurmans.nl",
                            FullName = "Daan Schuurmans",
                            Gender = "A"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Appointment", b =>
                {
                    b.HasOne("workshop.wwwapi.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("workshop.wwwapi.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Patient", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}

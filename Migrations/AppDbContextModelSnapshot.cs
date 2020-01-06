﻿// <auto-generated />
using System;
using HealthyTooth.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealthyTooth.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthyTooth.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            ImagePath = "doctor1.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            Name = "Christy Brown",
                            ServiceDescription = "Ortodoncja"
                        },
                        new
                        {
                            DoctorId = 2,
                            ImagePath = "doctor2.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            Name = "Klay Smith",
                            ServiceDescription = "Implantologia"
                        },
                        new
                        {
                            DoctorId = 3,
                            ImagePath = "doctor3.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            Name = "Brittany Collins",
                            ServiceDescription = "Protetyka"
                        });
                });

            modelBuilder.Entity("HealthyTooth.Models.Visit", b =>
                {
                    b.Property<int>("VisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VisitDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VisitPlaced")
                        .HasColumnType("datetime2");

                    b.HasKey("VisitId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("HealthyTooth.Models.VisitDetail", b =>
                {
                    b.Property<int>("VisitDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.HasKey("VisitDetailId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("VisitId");

                    b.ToTable("VisitDetails");
                });

            modelBuilder.Entity("HealthyTooth.Models.VisitSummaryItem", b =>
                {
                    b.Property<int>("VisitSummaryItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("VisitSummaryId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VisitSummaryItemId");

                    b.HasIndex("DoctorId");

                    b.ToTable("VisitSummaryItems");
                });

            modelBuilder.Entity("HealthyTooth.Models.VisitDetail", b =>
                {
                    b.HasOne("HealthyTooth.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthyTooth.Models.Visit", "Visit")
                        .WithMany("VisitDetails")
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HealthyTooth.Models.VisitSummaryItem", b =>
                {
                    b.HasOne("HealthyTooth.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using EdFi.Roster.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EdFi.Roster.Data.Migrations.ChangeQueryDb
{
    [DbContext(typeof(ChangeQueryDbContext))]
    partial class ChangeQueryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("EdFi.Roster.Models.ApiLogEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("ErrorMessage")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LogDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Method")
                        .HasColumnType("TEXT");

                    b.Property<string>("StatusCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Uri")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ApiLogEntries");
                });

            modelBuilder.Entity("EdFi.Roster.Models.ApiSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<string>("RootUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Secret")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ApiSettings");
                });

            modelBuilder.Entity("EdFi.Roster.Models.ChangeQuery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("ChangeVersion")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ResourceType")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ChangeQueries");
                });

            modelBuilder.Entity("EdFi.Roster.Models.RosterLocalEducationAgencyResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResourceId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RosterLocalEducationAgenciesResource");
                });

            modelBuilder.Entity("EdFi.Roster.Models.RosterSchoolResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResourceId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RosterSchoolsResource");
                });

            modelBuilder.Entity("EdFi.Roster.Models.RosterSectionResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResourceId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RosterSectionsResource");
                });

            modelBuilder.Entity("EdFi.Roster.Models.RosterStaffResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResourceId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RosterStaffResource");
                });

            modelBuilder.Entity("EdFi.Roster.Models.RosterStudentResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResourceId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RosterStudentsResource");
                });
#pragma warning restore 612, 618
        }
    }
}

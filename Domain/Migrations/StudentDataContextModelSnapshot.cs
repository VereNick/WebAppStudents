﻿// <auto-generated />
using System;
using Domain.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(StudentDataContext))]
    partial class StudentDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Domain.Entities.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<int>("DocumentType");

                    b.Property<int>("Gender");

                    b.Property<string>("Number");

                    b.Property<string>("Seria");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Domain.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Teacher");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Domain.Entities.LocalCity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName");

                    b.Property<int>("RegionId");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Domain.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameRegion");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("Domain.Entities.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("ApartmentNumber");

                    b.Property<string>("Email");

                    b.Property<string>("Fathername");

                    b.Property<string>("Grade");

                    b.Property<int?>("Group1Id");

                    b.Property<int?>("Group2Id");

                    b.Property<int?>("Group3Id");

                    b.Property<int?>("LocalCityId");

                    b.Property<int?>("MainDocumentId");

                    b.Property<string>("MedPolis");

                    b.Property<string>("Name");

                    b.Property<string>("Parent1");

                    b.Property<string>("Parent1Phone");

                    b.Property<string>("Parent2");

                    b.Property<string>("Parent2Phone");

                    b.Property<string>("Phone");

                    b.Property<string>("SNILS");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("Group1Id");

                    b.HasIndex("Group2Id");

                    b.HasIndex("Group3Id");

                    b.HasIndex("LocalCityId");

                    b.HasIndex("MainDocumentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Domain.Entities.Group", b =>
                {
                    b.HasOne("Domain.Entities.Department", "Department")
                        .WithMany("Groups")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.LocalCity", b =>
                {
                    b.HasOne("Domain.Entities.Region", "Region")
                        .WithMany("Cities")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.School", b =>
                {
                    b.HasOne("Domain.Entities.LocalCity", "City")
                        .WithMany()
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.HasOne("Domain.Entities.Group", "Group1")
                        .WithMany()
                        .HasForeignKey("Group1Id");

                    b.HasOne("Domain.Entities.Group", "Group2")
                        .WithMany()
                        .HasForeignKey("Group2Id");

                    b.HasOne("Domain.Entities.Group", "Group3")
                        .WithMany()
                        .HasForeignKey("Group3Id");

                    b.HasOne("Domain.Entities.LocalCity", "LocalCity")
                        .WithMany()
                        .HasForeignKey("LocalCityId");

                    b.HasOne("Domain.Entities.Document", "MainDocument")
                        .WithMany()
                        .HasForeignKey("MainDocumentId");
                });
#pragma warning restore 612, 618
        }
    }
}

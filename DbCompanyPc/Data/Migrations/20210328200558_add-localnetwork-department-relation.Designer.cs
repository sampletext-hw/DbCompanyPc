﻿// <auto-generated />
using System;
using DbCompanyPc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DbCompanyPc.Data.Migrations
{
    [DbContext(typeof(CompanyPcMsContext))]
    [Migration("20210328200558_add-localnetwork-department-relation")]
    partial class addlocalnetworkdepartmentrelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DbCompanyPc.Models.Computer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NetworkId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NetworkId");

                    b.HasIndex("RoomId");

                    b.ToTable("Computers");
                });

            modelBuilder.Entity("DbCompanyPc.Models.ComputerToPartElement", b =>
                {
                    b.Property<int>("ComputerId")
                        .HasColumnType("int");

                    b.Property<int>("PartElementId")
                        .HasColumnType("int");

                    b.HasKey("ComputerId", "PartElementId");

                    b.HasIndex("PartElementId");

                    b.ToTable("ComputerToPartElements");
                });

            modelBuilder.Entity("DbCompanyPc.Models.ComputerToSoftElement", b =>
                {
                    b.Property<int>("ComputerId")
                        .HasColumnType("int");

                    b.Property<int>("SoftElementId")
                        .HasColumnType("int");

                    b.HasKey("ComputerId", "SoftElementId");

                    b.HasIndex("SoftElementId");

                    b.ToTable("ComputerToSoftElements");
                });

            modelBuilder.Entity("DbCompanyPc.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DbCompanyPc.Models.DepartmentRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ParentId");

                    b.ToTable("DepartmentRelations");
                });

            modelBuilder.Entity("DbCompanyPc.Models.LocalNetwork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Mask")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("LocalNetworks");
                });

            modelBuilder.Entity("DbCompanyPc.Models.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PartType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarrantyReasons")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("DbCompanyPc.Models.PartElement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PartId")
                        .HasColumnType("int");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("WarrantyDuration")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("PartId");

                    b.HasIndex("ProducerId");

                    b.ToTable("PartElements");
                });

            modelBuilder.Entity("DbCompanyPc.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("DbCompanyPc.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("DbCompanyPc.Models.Soft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SoftType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Softs");
                });

            modelBuilder.Entity("DbCompanyPc.Models.SoftElement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LicenseExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<int>("SoftId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProducerId");

                    b.HasIndex("SoftId");

                    b.ToTable("SoftElements");
                });

            modelBuilder.Entity("DbCompanyPc.Models.Computer", b =>
                {
                    b.HasOne("DbCompanyPc.Models.LocalNetwork", "Network")
                        .WithMany("Computers")
                        .HasForeignKey("NetworkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbCompanyPc.Models.Room", "Room")
                        .WithMany("Computers")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Network");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DbCompanyPc.Models.ComputerToPartElement", b =>
                {
                    b.HasOne("DbCompanyPc.Models.Computer", "Computer")
                        .WithMany()
                        .HasForeignKey("ComputerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbCompanyPc.Models.PartElement", "PartElement")
                        .WithMany()
                        .HasForeignKey("PartElementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Computer");

                    b.Navigation("PartElement");
                });

            modelBuilder.Entity("DbCompanyPc.Models.ComputerToSoftElement", b =>
                {
                    b.HasOne("DbCompanyPc.Models.Computer", "Computer")
                        .WithMany()
                        .HasForeignKey("ComputerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbCompanyPc.Models.SoftElement", "SoftElement")
                        .WithMany()
                        .HasForeignKey("SoftElementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Computer");

                    b.Navigation("SoftElement");
                });

            modelBuilder.Entity("DbCompanyPc.Models.DepartmentRelation", b =>
                {
                    b.HasOne("DbCompanyPc.Models.Department", "Department")
                        .WithMany("ParentOf")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DbCompanyPc.Models.Department", "Parent")
                        .WithMany("ChildOf")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("DbCompanyPc.Models.LocalNetwork", b =>
                {
                    b.HasOne("DbCompanyPc.Models.Department", "Department")
                        .WithMany("LocalNetworks")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DbCompanyPc.Models.PartElement", b =>
                {
                    b.HasOne("DbCompanyPc.Models.Part", "Part")
                        .WithMany("PartElements")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbCompanyPc.Models.Producer", "Producer")
                        .WithMany("PartElements")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Part");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("DbCompanyPc.Models.SoftElement", b =>
                {
                    b.HasOne("DbCompanyPc.Models.Producer", "Producer")
                        .WithMany("SoftElements")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbCompanyPc.Models.Soft", "Soft")
                        .WithMany("SoftElements")
                        .HasForeignKey("SoftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producer");

                    b.Navigation("Soft");
                });

            modelBuilder.Entity("DbCompanyPc.Models.Department", b =>
                {
                    b.Navigation("ChildOf");

                    b.Navigation("LocalNetworks");

                    b.Navigation("ParentOf");
                });

            modelBuilder.Entity("DbCompanyPc.Models.LocalNetwork", b =>
                {
                    b.Navigation("Computers");
                });

            modelBuilder.Entity("DbCompanyPc.Models.Part", b =>
                {
                    b.Navigation("PartElements");
                });

            modelBuilder.Entity("DbCompanyPc.Models.Producer", b =>
                {
                    b.Navigation("PartElements");

                    b.Navigation("SoftElements");
                });

            modelBuilder.Entity("DbCompanyPc.Models.Room", b =>
                {
                    b.Navigation("Computers");
                });

            modelBuilder.Entity("DbCompanyPc.Models.Soft", b =>
                {
                    b.Navigation("SoftElements");
                });
#pragma warning restore 612, 618
        }
    }
}

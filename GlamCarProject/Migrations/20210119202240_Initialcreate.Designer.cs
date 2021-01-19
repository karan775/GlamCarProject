﻿// <auto-generated />
using System;
using GlamCarProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GlamCarProject.Migrations
{
    [DbContext(typeof(GlamCarProjectContext))]
    [Migration("20210119202240_Initialcreate")]
    partial class Initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GlamCarProject.Models.CarSale", b =>
                {
                    b.Property<int>("CarSaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AgreedAmount")
                        .HasColumnType("float");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SalePersonId")
                        .HasColumnType("int");

                    b.HasKey("CarSaleId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SalePersonId");

                    b.ToTable("CarSale");
                });

            modelBuilder.Entity("GlamCarProject.Models.Center", b =>
                {
                    b.Property<int>("CenterNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpeningDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CenterNo");

                    b.ToTable("Center");
                });

            modelBuilder.Entity("GlamCarProject.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("GlamCarProject.Models.SalePerson", b =>
                {
                    b.Property<int>("SalePersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CenterNo")
                        .HasColumnType("int");

                    b.Property<int?>("CentersCenterNo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isSenior")
                        .HasColumnType("bit");

                    b.HasKey("SalePersonId");

                    b.HasIndex("CentersCenterNo");

                    b.ToTable("SalePerson");
                });

            modelBuilder.Entity("GlamCarProject.Models.CarSale", b =>
                {
                    b.HasOne("GlamCarProject.Models.Customer", "Customers")
                        .WithMany("CarSales")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GlamCarProject.Models.SalePerson", "SalePersons")
                        .WithMany("CarSales")
                        .HasForeignKey("SalePersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GlamCarProject.Models.SalePerson", b =>
                {
                    b.HasOne("GlamCarProject.Models.Center", "Centers")
                        .WithMany("SalePersons")
                        .HasForeignKey("CentersCenterNo");
                });
#pragma warning restore 612, 618
        }
    }
}
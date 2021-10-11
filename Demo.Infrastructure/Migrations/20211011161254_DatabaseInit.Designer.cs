﻿// <auto-generated />
using System;
using Demo.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Demo.Infrastructure.Migrations
{
    [DbContext(typeof(DemoContext))]
    [Migration("20211011161254_DatabaseInit")]
    partial class DatabaseInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "6.0.0-preview.3.21201.2");

            modelBuilder.Entity("Demo.Domain.Guitar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateManufactured")
                        .HasColumnType("datetime");

                    b.Property<int>("GuitarType")
                        .HasColumnType("int");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MaxNumberOfStrings")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Guitar");
                });

            modelBuilder.Entity("Demo.Domain.GuitarString", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateRestrung")
                        .HasColumnType("datetime");

                    b.Property<string>("Gauge")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("GuitarId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Tuning")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GuitarId");

                    b.ToTable("GuitarString");
                });

            modelBuilder.Entity("Demo.Domain.GuitarString", b =>
                {
                    b.HasOne("Demo.Domain.Guitar", null)
                        .WithMany("GuitarStrings")
                        .HasForeignKey("GuitarId");
                });

            modelBuilder.Entity("Demo.Domain.Guitar", b =>
                {
                    b.Navigation("GuitarStrings");
                });
#pragma warning restore 612, 618
        }
    }
}

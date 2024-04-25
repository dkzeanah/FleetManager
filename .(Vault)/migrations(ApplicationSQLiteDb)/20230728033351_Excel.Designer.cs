﻿// <auto-generated />
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp1.Migrations.ApplicationSQLiteDb
{
    [DbContext(typeof(ApplicationSQLiteDbContext))]
    [Migration("20230728033351_Excel")]
    partial class Excel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("BlazorApp1.CarModels.Blank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("String")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Blanks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Item 1",
                            String = "This is item 1 data"
                        });
                });

            modelBuilder.Entity("BlazorApp1.CarModels.ExcelDataRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ExcelDataRecords");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            Data = "On Model Creating Record"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
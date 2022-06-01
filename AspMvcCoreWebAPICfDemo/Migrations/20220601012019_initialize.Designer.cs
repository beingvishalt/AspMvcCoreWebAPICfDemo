﻿// <auto-generated />
using AspMvcCoreWebAPICfDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspMvcCoreWebAPICfDemo.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220601012019_initialize")]
    partial class initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspMvcCoreWebAPICfDemo.Models.Product", b =>
                {
                    b.Property<int>("ProductCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductCode");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductCode = 1,
                            ProductName = "Speaker",
                            ProductPrice = 30000.00m
                        },
                        new
                        {
                            ProductCode = 2,
                            ProductName = "Desktop",
                            ProductPrice = 30000.00m
                        },
                        new
                        {
                            ProductCode = 3,
                            ProductName = "Laptops",
                            ProductPrice = 25000.00m
                        },
                        new
                        {
                            ProductCode = 4,
                            ProductName = "Gaming Pc's",
                            ProductPrice = 60000.00m
                        },
                        new
                        {
                            ProductCode = 5,
                            ProductName = "Servers",
                            ProductPrice = 100000.00m
                        },
                        new
                        {
                            ProductCode = 6,
                            ProductName = "Tablets",
                            ProductPrice = 5000.00m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Ex.Composite.SideMenuSample.Models.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ex.Composite.SideMenuSample.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240803082629_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ex.Composite.SideMenuSample.Models.Entities.CategoryComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryComponents");

                    b.HasDiscriminator().HasValue("CategoryComponent");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Ex.Composite.SideMenuSample.Models.Entities.Category", b =>
                {
                    b.HasBaseType("Ex.Composite.SideMenuSample.Models.Entities.CategoryComponent");

                    b.HasDiscriminator().HasValue("Category");
                });

            modelBuilder.Entity("Ex.Composite.SideMenuSample.Models.Entities.CategoryItem", b =>
                {
                    b.HasBaseType("Ex.Composite.SideMenuSample.Models.Entities.CategoryComponent");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("CategoryItem");
                });

            modelBuilder.Entity("Ex.Composite.SideMenuSample.Models.Entities.CategoryComponent", b =>
                {
                    b.HasOne("Ex.Composite.SideMenuSample.Models.Entities.Category", null)
                        .WithMany("MenuItems")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Ex.Composite.SideMenuSample.Models.Entities.Category", b =>
                {
                    b.Navigation("MenuItems");
                });
#pragma warning restore 612, 618
        }
    }
}

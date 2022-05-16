﻿// <auto-generated />
using System;
using AsykShop.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AsykShop.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AsykShop.Core.Models.Asyk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AsykAvailable");

                    b.Property<string>("AsykImage");

                    b.Property<string>("AsykLongDesc")
                        .IsRequired();

                    b.Property<string>("AsykName")
                        .IsRequired();

                    b.Property<int>("AsykPrice");

                    b.Property<string>("AsykShortDesc")
                        .IsRequired();

                    b.Property<int>("CategoryId");

                    b.Property<bool>("isFavorAsyk");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Asyk");
                });

            modelBuilder.Entity("AsykShop.Core.Models.AsykShopCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AsykShopCartIdItem");

                    b.Property<int?>("AsyktarId");

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.HasIndex("AsyktarId");

                    b.ToTable("AsykShopCartItem");
                });

            modelBuilder.Entity("AsykShop.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription");

                    b.Property<string>("CategoryName");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("AsykShop.Core.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("AsykShop.Core.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AsykId");

                    b.Property<int>("OrderId");

                    b.Property<long>("Price");

                    b.HasKey("Id");

                    b.HasIndex("AsykId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("AsykShop.Core.Models.Asyk", b =>
                {
                    b.HasOne("AsykShop.Core.Models.Category", "Category")
                        .WithMany("asyktar")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AsykShop.Core.Models.AsykShopCartItem", b =>
                {
                    b.HasOne("AsykShop.Core.Models.Asyk", "Asyktar")
                        .WithMany()
                        .HasForeignKey("AsyktarId");
                });

            modelBuilder.Entity("AsykShop.Core.Models.OrderDetail", b =>
                {
                    b.HasOne("AsykShop.Core.Models.Asyk", "asyk")
                        .WithMany()
                        .HasForeignKey("AsykId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsykShop.Core.Models.Order", "order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using AsykShop.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AsykShop.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20211221050009_AsykShopCart")]
    partial class AsykShopCart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("AsykLongDesc");

                    b.Property<string>("AsykName");

                    b.Property<int>("AsykPrice");

                    b.Property<string>("AsykShortDesc");

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

                    b.Property<string>("AsykShopCartId");

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
#pragma warning restore 612, 618
        }
    }
}

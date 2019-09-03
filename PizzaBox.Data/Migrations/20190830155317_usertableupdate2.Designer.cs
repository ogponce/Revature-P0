﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaBox.Data;

namespace PizzaBox.Data.Migrations
{
    [DbContext(typeof(PizzaBoxDbContext))]
    [Migration("20190830155317_usertableupdate2")]
    partial class usertableupdate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaBox.Domain.Models.Crust", b =>
                {
                    b.Property<int>("CrustId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("CrustId");

                    b.ToTable("Crust");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<int?>("LocationId1");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.HasKey("LocationId");

                    b.HasIndex("LocationId1");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LocationId");

                    b.Property<decimal>("TotalPrice");

                    b.Property<int?>("UserId");

                    b.HasKey("OrderId");

                    b.HasIndex("LocationId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.Property<int>("PizzaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CrustId");

                    b.Property<int?>("LocationId");

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId");

                    b.Property<int?>("SizeId");

                    b.Property<decimal>("TotalPrice");

                    b.HasKey("PizzaId");

                    b.HasIndex("CrustId");

                    b.HasIndex("LocationId");

                    b.HasIndex("OrderId");

                    b.HasIndex("SizeId");

                    b.ToTable("Pizza");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("SizeId");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Topping", b =>
                {
                    b.Property<int>("ToppingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("PizzaId");

                    b.Property<decimal>("Price");

                    b.HasKey("ToppingId");

                    b.HasIndex("PizzaId");

                    b.ToTable("Topping");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Location", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Location")
                        .WithMany("Locations")
                        .HasForeignKey("LocationId1");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Location", "l")
                        .WithMany("Orders")
                        .HasForeignKey("LocationId");

                    b.HasOne("PizzaBox.Domain.Models.User", "u")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Crust", "Crust")
                        .WithMany()
                        .HasForeignKey("CrustId");

                    b.HasOne("PizzaBox.Domain.Models.Location")
                        .WithMany("PizzasOrdered")
                        .HasForeignKey("LocationId");

                    b.HasOne("PizzaBox.Domain.Models.Order")
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderId");

                    b.HasOne("PizzaBox.Domain.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Topping", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Pizza")
                        .WithMany("Toppings")
                        .HasForeignKey("PizzaId");
                });
#pragma warning restore 612, 618
        }
    }
}

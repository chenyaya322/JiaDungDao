﻿// <auto-generated />
using System;
using JiaDungDao.Connection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JiaDungDao.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Back_End.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("isValid")
                        .HasColumnType("bit");

                    b.Property<string>("m_account")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("m_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("m_birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("m_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("m_imgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("m_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("m_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("m_role")
                        .HasColumnType("int");

                    b.HasKey("MemberId");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("Back_End.Models.Menu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RestaurantID")
                        .HasColumnType("int");

                    b.Property<string>("m_item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("m_price")
                        .HasColumnType("int");

                    b.Property<string>("m_type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MenuID");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Back_End.Models.Order", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("o_count")
                        .HasColumnType("int");

                    b.Property<string>("o_item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("o_price")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Back_End.Models.OrderTitle", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RestaurantID")
                        .HasColumnType("int");

                    b.Property<string>("m_account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("o_createtime")
                        .HasColumnType("datetime2");

                    b.Property<int>("o_total")
                        .HasColumnType("int");

                    b.Property<string>("r_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("OrderTitle");
                });

            modelBuilder.Entity("Back_End.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("m_account")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("r_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("r_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("r_tel")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("RestaurantID");

                    b.ToTable("Restaurant");
                });
#pragma warning restore 612, 618
        }
    }
}

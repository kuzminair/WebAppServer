﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppServer;

#nullable disable

namespace WebAppServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240121105328_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("WebAppServer.Models.OS", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Oss");
                });

            modelBuilder.Entity("WebAppServer.Models.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ServerModelId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Validity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Servers");
                });

            modelBuilder.Entity("WebAppServer.Models.ServerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MadeYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameCompany")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Speed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TypeServer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ServersModels");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewServer_V2.Models;

namespace NewServer_V2.Migrations
{
    [DbContext(typeof(ParkingDbContext))]
    [Migration("20190510044927_newRelation2")]
    partial class newRelation2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewServer_V2.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Input");

                    b.Property<string>("LicensePlate");

                    b.Property<DateTime>("Output");

                    b.Property<string>("Owner");

                    b.Property<int>("PlaceId");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("NewServer_V2.Models.Connection", b =>
                {
                    b.Property<int>("ConId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId");

                    b.Property<int>("PlaceId");

                    b.HasKey("ConId");

                    b.ToTable("Conections");
                });

            modelBuilder.Entity("NewServer_V2.Models.Place", b =>
                {
                    b.Property<int>("PlaceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlaceNumber");

                    b.Property<bool>("State");

                    b.HasKey("PlaceId");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("NewServer_V2.Models.Car", b =>
                {
                    b.HasOne("NewServer_V2.Models.Place", "Place")
                        .WithMany("Records")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

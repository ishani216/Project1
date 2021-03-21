﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project1.Models;

namespace Project1.Migrations
{
    [DbContext(typeof(TripContext))]
    partial class TripContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Project1.Models.Trip", b =>
                {
                    b.Property<int>("TripID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Accommodation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccommodationEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccommodationPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ThingToDo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThingToDo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThingToDo3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TripID");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            TripID = 1,
                            Accommodation = "Kingston Hotel",
                            AccommodationEmail = "help@kingston.com",
                            AccommodationPhone = "5551234",
                            Destination = "Cleveland",
                            EndDate = new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ThingToDo1 = "Eat cake"
                        },
                        new
                        {
                            TripID = 2,
                            Accommodation = "Beachy Hotel",
                            AccommodationEmail = "help@beachy.com",
                            AccommodationPhone = "5554312",
                            Destination = "Miami",
                            EndDate = new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ThingToDo1 = "Swim in ocean"
                        },
                        new
                        {
                            TripID = 3,
                            Accommodation = "Valley Hotel",
                            AccommodationEmail = "help@valley.com",
                            AccommodationPhone = "5551212",
                            Destination = "Las Vegas",
                            EndDate = new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ThingToDo1 = "Visit Area51",
                            ThingToDo2 = "See a show"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

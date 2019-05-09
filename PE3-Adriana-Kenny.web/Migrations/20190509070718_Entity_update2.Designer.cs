﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PE3_Adriana_Kenny.web.Data;

namespace PE3_Adriana_Kenny.web.Migrations
{
    [DbContext(typeof(BookingContext))]
    [Migration("20190509070718_Entity_update2")]
    partial class Entity_update2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PE3_Adriana_Kenny.web.Entities.Booking", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CheckInDate");

                    b.Property<DateTime>("CheckOutDate");

                    b.Property<long>("ClientId");

                    b.Property<int>("NmbrOfPeople")
                        .HasMaxLength(1);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("PE3_Adriana_Kenny.web.Entities.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("PE3_Adriana_Kenny.web.Entities.Client", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Community")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Surname");

                    b.Property<int>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("PE3_Adriana_Kenny.web.Entities.Hotel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<long>("CityId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("NmbrOfRooms");

                    b.Property<string>("Photo");

                    b.Property<int>("Stars")
                        .HasMaxLength(1);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("PE3_Adriana_Kenny.web.Entities.Room", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BookingId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(350);

                    b.Property<long>("HotelId");

                    b.Property<decimal>("PriceNight");

                    b.Property<long>("RoomtypeId");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("HotelId");

                    b.HasIndex("RoomtypeId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("PE3_Adriana_Kenny.web.Entities.Roomtype", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Roomtypes");
                });

            modelBuilder.Entity("PE3_Adriana_Kenny.web.Entities.Booking", b =>
                {
                    b.HasOne("PE3_Adriana_Kenny.web.Entities.Client", "Client")
                        .WithMany("Bookings")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PE3_Adriana_Kenny.web.Entities.Hotel", b =>
                {
                    b.HasOne("PE3_Adriana_Kenny.web.Entities.City", "City")
                        .WithMany("Hotels")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PE3_Adriana_Kenny.web.Entities.Room", b =>
                {
                    b.HasOne("PE3_Adriana_Kenny.web.Entities.Booking", "Booking")
                        .WithMany("Rooms")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PE3_Adriana_Kenny.web.Entities.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PE3_Adriana_Kenny.web.Entities.Roomtype", "Roomtype")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomtypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

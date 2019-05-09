using Microsoft.EntityFrameworkCore;
using PE3_Adriana_Kenny.web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE3_Adriana_Kenny.web.Data
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options) : base(options)
        {
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client>Clients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Roomtype> Roomtypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            DataSeeder.Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}

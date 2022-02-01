using Microsoft.EntityFrameworkCore;
using OFBusTransportationManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.Context
{
   public class OfBusTransportationManagementSystemDbContext : DbContext
   {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=BusManagementSystemDb;user=root;password=p1h2a3r4o5u6k7");
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<User> Users { get; set; }
   }
}

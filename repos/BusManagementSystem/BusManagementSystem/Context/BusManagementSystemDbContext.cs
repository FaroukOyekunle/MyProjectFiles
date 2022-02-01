using BusManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Context
{
   public class BusManagementSystemDbContext : DbContext
   {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=BusManagementSystemDb;user=root;password=p1h2a3r4o5u6k7");
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Trip> TripsDto { get; set; }

        public DbSet<Bus> Buses { get; set; }

        public DbSet<Booking> Bookings { get; set; 
        
        
        }
   }
}

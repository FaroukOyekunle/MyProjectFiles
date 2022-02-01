using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDemo.Entities;

namespace WebApplicationDemo.Context
{
    public class WebApplicationDemoContext: DbContext
    {
        public WebApplicationDemoContext(DbContextOptions<WebApplicationDemoContext> options)
            : base(options)
        {
        }
        //its is been used for writing fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}

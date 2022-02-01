using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationApITest.Entities;

namespace WebApplicationApITest.Context
{
    public class WebApplicationAPITestContext: DbContext
    {
        public WebApplicationAPITestContext(DbContextOptions<WebApplicationAPITestContext> options)
         : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


        public DbSet<ChiefJudge> ChiefJudges { get; set; }
    }
}

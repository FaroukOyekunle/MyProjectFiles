using Microsoft.EntityFrameworkCore;
using System;
using WebAppDemo.Entities;

namespace WebAppDemo.Context
{
    public class WebAppDemoContext :DbContext
    {
         public WebAppDemoContext(DbContextOptions<WebAppDemoContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {    
        }


       public DbSet<ChiefJudge> ChiefJudges { get; set; }
       public DbSet<MailClient> MailClients { get; set; }
       public DbSet<Case> Cases { get; set; }
       public DbSet<ChiefJudgeCase> ChiefJudgeCases { get; set; }
    }
}
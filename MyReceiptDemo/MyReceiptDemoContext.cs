using Microsoft.EntityFrameworkCore;

namespace MyReceiptDemo
{
    public class MyReceiptDemoContext: DbContext
    {
         public MyReceiptDemoContext(DbContextOptions<MyReceiptDemoContext> options)
         : base(options)
        {
        }
       
         public DbSet<Item> Items { get; set; }
    }
}
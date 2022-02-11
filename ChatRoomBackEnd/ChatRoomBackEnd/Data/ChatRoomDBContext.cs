using ChatRoomBackEnd.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChatRoomBackEnd.Data
{
    public class ChatRoomDBContext : DbContext
    {
        public ChatRoomDBContext(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<User>()
               .HasKey(u => u.UserName);
           
           modelBuilder.Entity<User>().Property(u => u.UserName)
               .IsRequired()
               .HasMaxLength(20);

           modelBuilder.Entity<User>().Property(u => u.Password)
               .IsRequired();
           
           modelBuilder.Entity<User>()
               .HasMany(u => u.Chats)
               .WithOne(m => m.User)
               .HasForeignKey(m => m.UserName);
        }
        
        public DbSet<User> Users { get; set; }
        
        public DbSet<Chat> Chats { get; set; }
    }
}
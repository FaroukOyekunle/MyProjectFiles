using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Context.EfConfigurations
{
    public class AuthorEntityTypeConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");

            builder.HasKey(b => b.Id);

            builder.Property(u => u.FirstName)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(b => b.LastName)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.HasMany(b => b.BookAuthors)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}

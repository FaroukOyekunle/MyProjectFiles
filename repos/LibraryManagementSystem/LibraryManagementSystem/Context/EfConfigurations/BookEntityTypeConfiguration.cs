using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Context.EfConfigurations
{
    public class BookEntityTypeConfiguration: IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");

            builder.HasKey(b => b.Id);

            builder.Property(u => u.Title)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(b => b.BookPDF)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(b => b.Price)
               .HasColumnType("decimal(18,2)");

            builder.HasIndex(b => b.ISBN)
                .IsUnique();

            builder.HasMany(b => b.BookAuthors)
                .WithOne(b => b.Book)
                .HasForeignKey(b => b.BookId).OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(b => b.BookCategories)
                .WithOne(b => b.Book)
                .HasForeignKey(b => b.BookId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}


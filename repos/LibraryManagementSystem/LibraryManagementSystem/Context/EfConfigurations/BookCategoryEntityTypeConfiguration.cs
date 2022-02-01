using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Context.EfConfigurations
{
    public class BookCategoryEntityTypeConfiguration: IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.ToTable("BookCategories");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.BookId)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(u => u.CategoryId)
               .HasColumnType("int")
               .IsRequired();
        }
    }
}

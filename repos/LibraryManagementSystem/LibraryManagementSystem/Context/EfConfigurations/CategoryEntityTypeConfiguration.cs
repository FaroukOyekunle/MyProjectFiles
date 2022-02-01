using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Context.EfConfigurations
{
    public class CategoryEntityTypeConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(b => b.Id);

            builder.Property(u => u.Name)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.HasIndex(b => b.Name)
               .IsUnique();

            builder.HasMany(b => b.BookCategories)
                .WithOne(b => b.Category)
                .HasForeignKey(b => b.CategoryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}

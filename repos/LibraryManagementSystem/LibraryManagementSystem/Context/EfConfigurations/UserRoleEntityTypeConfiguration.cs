using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Context.EfConfigurations
{
    public class UserRoleEntityTypeConfiguration: IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("BookRole");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.UserId)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(u => u.RoleId)
               .HasColumnType("int")
               .IsRequired();
        }
    }
}

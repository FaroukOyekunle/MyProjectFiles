using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Entities;

namespace WebAppDemo.Context.EfConfigurations
{
    public class ChiefJudgeEntityTypeConfiguration: IEntityTypeConfiguration<ChiefJudge>
    {
        public void Configure(EntityTypeBuilder<ChiefJudge> builder)
        {
            throw new NotImplementedException();
        }

    }
}

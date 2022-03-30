using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProJect.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.EF.DbConfiguration
{
    public class TransactionLinesConfig : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLines");
            builder.HasKey(line => line.ID);
            builder.Property(line => line.ID).HasDefaultValueSql("NEWID()");

            builder.Property(line => line.Price).HasPrecision(9, 2);
            builder.Property(line => line.PricePerHour).HasPrecision(9, 2);
            builder.Property(line => line.Hours).HasPrecision(2, 2);
        }
    }
}

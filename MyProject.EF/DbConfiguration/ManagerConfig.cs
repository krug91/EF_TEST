using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProJect.DTO;

namespace MyProject.EF.DbConfiguration
{
    public class ManagerConfig : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.ToTable("Managers");
            builder.HasKey(manager => manager.ID);
            builder.Property(manager => manager.ID).HasDefaultValueSql("NEWID()");

            builder.Property(manager => manager.SalaryPerMonth).HasPrecision(9, 2);
            builder.HasMany(manager => manager.Transactions).WithOne(transaction => transaction.Manager).HasForeignKey(transaction => transaction.ManagerID);
        }
    }
}

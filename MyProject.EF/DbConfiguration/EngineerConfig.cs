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
    public class EngineerConfig : IEntityTypeConfiguration<Engineer>
    {
        public void Configure(EntityTypeBuilder<Engineer> builder)
        {
            builder.ToTable("Engineers");
            builder.HasKey(engineer => engineer.ID);
            builder.Property(engineer => engineer.ID).HasDefaultValueSql("NEWID()");

            builder.Property(engineer => engineer.SalaryPerMonth).HasPrecision(9, 2);
            builder.HasOne(engineer => engineer.Manager).WithMany(manager => manager.Engineers).HasForeignKey(engineer => engineer.ManagerID);
            builder.HasMany(engineer => engineer.TransactionLines).WithOne(line => line.Engineer).HasForeignKey(line => line.EngineerID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}

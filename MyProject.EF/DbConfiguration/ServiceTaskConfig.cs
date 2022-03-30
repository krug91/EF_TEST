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
    public class ServiceTaskConfig : IEntityTypeConfiguration<ServiceTask>
    {
        public void Configure(EntityTypeBuilder<ServiceTask> builder)
        {
            builder.ToTable("ServiceTasks");
            builder.HasKey(task => task.ID);
            builder.Property(task => task.ID).HasDefaultValueSql("NEWID()");

            builder.Property(task => task.Hours).HasPrecision(2, 2);
            builder.HasMany(task => task.TransactionLines).WithOne(line => line.ServiceTask).HasForeignKey(line => line.ServiceTaskID).OnDelete(DeleteBehavior.Restrict);

        }
    }
}

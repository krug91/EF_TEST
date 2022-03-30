using Microsoft.EntityFrameworkCore;
using MyProject.EF.DbConfiguration;
using MyProJect.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.EF.MyProjectDbContext
{
    public class MyProjectDBContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionLine> TransactionLines { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ServiceTask> ServiceTasks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ManagerConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new TransactionConfig());
            modelBuilder.ApplyConfiguration(new TransactionLinesConfig());
            modelBuilder.ApplyConfiguration(new EngineerConfig());
            modelBuilder.ApplyConfiguration(new CarConfig());
            modelBuilder.ApplyConfiguration(new ServiceTaskConfig());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var connStr = @"Data Source=localhost; Initial Catalog=test; Integrated Security=true;";

            optionsBuilder.UseSqlServer(connStr);
        }
    }
}

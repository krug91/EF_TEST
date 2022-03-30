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
    public class TransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");
            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.ID).HasDefaultValueSql("NEWID()");

            builder.Property(transaction => transaction.TotalPrice).HasPrecision(9,2);
            builder.HasMany(transaction => transaction.TransactionLines).WithOne(transactionLines => transactionLines.Transaction).HasForeignKey(transactionLine => transactionLine.TransactionID);
            builder.HasOne(transaction => transaction.Manager).WithMany(manager => manager.Transactions).HasForeignKey(transaction => transaction.ManagerID).OnDelete(DeleteBehavior.no);
            builder.HasOne(transaction => transaction.Customer).WithMany(customer => customer.Transactions).HasForeignKey(transaction => transaction.CustomerID);
            builder.HasOne(transaction => transaction.Car).WithMany(car => car.Transactions).HasForeignKey(transaction => transaction.CarID);
        }
    }
}

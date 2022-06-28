using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EfInMemory
{
    public class EfInMemoryContext : DbContext, IStockTrackingDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("TestDb");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Cart> Carts { get; set; }
        //public DbSet<SaleWinForm> SalesWinForms { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerBalance> CustomerBalances { get; set; }
        public DbSet<CustomerPayment> CustomerPayments { get; set; }
        public DbSet<BonusCard> BonusCards { get; set; }
        public DbSet<Debt> Debts { get; set; }
        //public DbSet<OperationClaimForForms> OperationClaimsForForms { get; set; }
        //public DbSet<UserOperationClaimForForms> UserOperationClaimsForForms { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        //public DbSet<MacAddres> MacAddresses { get; set; }
        // public DbSet<FormSetting> FormSettings { get; set; }
        public DbSet<BonusCardOperation> BonusCardOperations { get; set; }

        public DbSet<BarcodeNumber> BarcodeNumbers { get; set; }
    }
}

using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.ForForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{           
    public class StockTrackingProjectContext : DbContext,IStockTrackingDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          //optionsBuilder.UseSqlServer(@"Server=DESKTOP-N8AGODS\MSSQLSERVER66;Database=StockTracking;Trusted_Connection=true");
          optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSqlLocalDb;Database=StockTracking;Trusted_Connection=true"); //menim T-SQL
          //optionsBuilder.UseNpgsql(@"Server=localhost;Database=TapSat;Port=5432;User Id=postgres;Password=Cabiw****"); //menim Postgre
          //optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=StockTracking;Trusted_Connection=true"); //Murad & Seymur
          //optionsBuilder.UseSqlServer(@"Server=DESKTOP-HE06A4P\SQLEXPRESS;Database=StockTracking;Trusted_Connection=true"); //Murad IphoneShop
          //optionsBuilder.UseSqlServer(@"Server=DESKTOP-2AFSH3V\SQLEXPRESS;Database=StockTracking;Trusted_Connection=true"); //Narmobile
          //optionsBuilder.UseSqlServer(@"Server=DESKTOP-77IJ791\SQLEXPRESS;Database=StockTracking;Trusted_Connection=true"); //Rauf Kontakt Tel
          //optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=StockTracking;Trusted_Connection=true"); //Asim Kassa Tel
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerBalance> CustomerBalances { get; set; }
        public DbSet<CustomerPayment> CustomerPayments { get; set; }
        public DbSet<BonusCard> BonusCards { get; set; }
        public DbSet<Debt> Debts { get; set; }
        public DbSet<OperationClaimForForms> OperationClaimsForForms { get; set; }
        public DbSet<UserOperationClaimForForms> UserOperationClaimsForForms { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<MacAddres> MacAddresses { get; set; }
        public DbSet<FormSetting> FormSettings { get; set; }
        public DbSet<BonusCardOperation> BonusCardOperations { get; set; }

        public DbSet<BarcodeNumber> BarcodeNumbers { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}

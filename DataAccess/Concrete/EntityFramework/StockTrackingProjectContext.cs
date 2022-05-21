﻿using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text; 

namespace DataAccess.Concrete.EntityFramework
{
    public class StockTrackingProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-N8AGODS\MSSQLSERVER66;Database=StockTracking;Trusted_Connection=true");
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSqlLocalDb;Database=StockTracking;Trusted_Connection=true"); //menim
           //optionsBuilder.UseSqlServer(@"Server=DESKTOP-1FKP1NM\SQLEXPRESS;Database=StockTracking;Trusted_Connection=true"); //Murad IphoneShop
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<SaleWinForm> SalesWinForms { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerBalance> CustomerBalances { get; set; }
        public DbSet<CustomerPayment> CustomerPayments { get; set; }
        public DbSet<BonusCard> BonusCards { get; set; }
        public DbSet<Debt> Debts { get; set; }
        public DbSet<OperationClaimForForms> OperationClaimsForForms { get; set; }
        public DbSet<UserOperationClaimForForms> UserOperationClaimsForForms { get; set; }
        public DbSet<MacAddres> MacAddresses { get; set; }
        public DbSet<FormSetting> FormSettings { get; set; }

        public DbSet<BarcodeNumber> BarcodeNumbers { get; set; }
    }
}

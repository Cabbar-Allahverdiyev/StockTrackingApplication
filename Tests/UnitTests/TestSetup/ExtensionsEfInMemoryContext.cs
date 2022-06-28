using DataAccess.Concrete.EfInMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.UnitTests.TestSetup
{
    public static class ExtensionsEfInMemoryContext
    {
        public static void AddProducts(this EfInMemoryContext context)
        {
            context.Products.AddRange(new Product[]
            {
                new Product()
                {
                    ProductName="L29",
                    BarcodeNumber="1234567891111",
                    BrandId=2,
                    CategoryId=2,
                    SupplierId=1,
                    Description="",
                    Discontinued=true,
                    LastModifiedDate=DateTime.Now,
                    PurchasePrice=2,
                    UnitPrice=4,
                    UnitsInStock=4,
                    QuantityPerUnit="1x"
                },
                 new Product()
                {
                    ProductName="Blutuz Nausnik",
                    BarcodeNumber="1234567891112",
                    BrandId=2,
                    CategoryId=1,
                    SupplierId=1,
                    Description="",
                    Discontinued=true,
                    LastModifiedDate=DateTime.Now,
                    PurchasePrice=4,
                    UnitPrice=10,
                    UnitsInStock=2,
                    QuantityPerUnit="1x"
                },
                  new Product()
                {
                    ProductName="Adapter Typ-c",
                    BarcodeNumber="1234567891113",
                    BrandId=1,
                    CategoryId=1,
                    SupplierId=1,
                    Description="",
                    Discontinued=true,
                    LastModifiedDate=DateTime.Now,
                    PurchasePrice=8,
                    UnitPrice=16,
                    UnitsInStock=3,
                    QuantityPerUnit="1x"
                }
            });
        }

        public static void AddBrands(this EfInMemoryContext context)
        {
            context.AddRange(new Brand[]
            {
                new Brand() { BrandName="Samsung"},
                new Brand() { BrandName="Iphone"},
                new Brand() { BrandName="Huawei"}
            });
        }

        public static void AddCategories(this EfInMemoryContext context)
        {
            context.AddRange(new Category[]
            {
                new Category() { CategoryName="Adapter"},
                new Category() { CategoryName="Nausnik"},
                new Category() { CategoryName="Kabro"}
            });
        }
        public static void AddSuppliers(this EfInMemoryContext context)
        {
            context.AddRange(new Supplier[]
            {
                new Supplier() { 
                    ContactName="Kerim",
                    CompanyName="Superphone",
                    Address="Gence",
                    City="Gence",
                    Email="",
                    IsSupplierActive=true,
                    Phone="0554567898"
                    ,WhenWillCome="4-6"
                },
                new Supplier() { 
                    ContactName="Vasif",
                    CompanyName="NGN",
                    Address="28 may",
                    City="Baki",
                    Email="",
                    IsSupplierActive=true,
                    Phone="0551234565"
                    ,WhenWillCome="2-6"
                },
                new Supplier() { 
                    ContactName="Ferit",
                    CompanyName="ABCD",
                    Address="Baki",
                    City="Baki",
                    Email="",
                    IsSupplierActive=true,
                    Phone="0554567888"
                    ,WhenWillCome="4-6"
                },
                
            });
        }
    }
}

using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            List<Product> products = new List<Product>();
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                UnitsInStock = 3,

                PurchasePrice = decimal.Parse("2,50"),//al
                UnitPrice = 6,//sat
                ProductName = "A03s silikon",
                BarcodeNumber = "2004706000003",
                QuantityPerUnit = "1x1",
                Description = "min5"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                UnitsInStock = 3,

                PurchasePrice = decimal.Parse("3,50"),//al
                UnitPrice = 8,//sat
                ProductName = "A03s louis vuittion",
                BarcodeNumber = "2004706000003",
                QuantityPerUnit = "1x1",
                Description = "min7"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                UnitsInStock = 3,

                PurchasePrice = decimal.Parse("2,50"),//al
                UnitPrice = 6,//sat
                ProductName = "A03s qara kamera qoruyucu",
                BarcodeNumber = "2004597000007",
                QuantityPerUnit = "1x1",
                Description = "min5"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                UnitsInStock = 2,

                PurchasePrice = decimal.Parse("2"),//al
                UnitPrice = 5,//sat
                ProductName = "A03s sade",
                BarcodeNumber = "2004489000009",
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                UnitsInStock = 6,

                PurchasePrice = decimal.Parse("2,50"),//al
                UnitPrice = 6,//sat
                ProductName = "A12 silikon",
                BarcodeNumber = "2004697000006",
                QuantityPerUnit = "1x1",
                Description = "min5"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                UnitsInStock = 3,

                PurchasePrice = decimal.Parse("2"),//al
                UnitPrice = 5,//sat
                ProductName = "A12 sade qara",
                BarcodeNumber = "2004488000000",
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("1,50"),//al
                UnitPrice = 5,//sat
                ProductName = "A12 seffaf",

                UnitsInStock = 3,

                BarcodeNumber = "2004810000005",
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("3,50"),//al
                UnitPrice = 8,//sat
                ProductName = "A12 louis vuittion",

                UnitsInStock = 2,

                BarcodeNumber = "2004716000000",
                QuantityPerUnit = "1x1",
                Description = "min7"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("6"),//al
                UnitPrice = 12,//sat
                ProductName = "A12 chanel gold zerli",

                UnitsInStock = 1,

                BarcodeNumber = "2004585000002",
                QuantityPerUnit = "1x1",
                Description = "min10"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2"),//al
                UnitPrice = 5,//sat
                ProductName = "A53 sade qara",

                UnitsInStock = 3,

                BarcodeNumber = "2004666000006",
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2"),//al
                UnitPrice = 5,//sat
                ProductName = "A53 deri ",

                UnitsInStock = 2,//eded

                BarcodeNumber = "2004848000008",
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("1,5"),//al
                UnitPrice = 5,//sat
                ProductName = "A53 seffaf",

                UnitsInStock = 3,

                BarcodeNumber = "2004831000008",
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2,50"),//al
                UnitPrice = 6,//sat
                ProductName = "A53 seffaf qara",

                UnitsInStock = 2,

                BarcodeNumber = "2004670000009",
                QuantityPerUnit = "1x1",
                Description = "min5"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("3,5"),//al
                UnitPrice = 8,//sat
                ProductName = "A53 new skin",

                UnitsInStock = 2,

                BarcodeNumber = "2004892000009",
                QuantityPerUnit = "1x1",
                Description = "min7"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2,5"),//al
                UnitPrice = 6,//sat
                ProductName = "A32 silikon",

                UnitsInStock = 3,

                BarcodeNumber = "2004699000004",
                QuantityPerUnit = "1x1",
                Description = "min5"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("3,5"),//al
                UnitPrice = 8,//sat
                ProductName = "A32 louis vuittion",

                UnitsInStock = 2,

                BarcodeNumber = "2004713000003",
                QuantityPerUnit = "1x1",
                Description = "min7"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2"),//al
                UnitPrice = 5,//sat
                ProductName = "A32 deri",

                UnitsInStock = 2,

                BarcodeNumber = "2004842000004",
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("1,5"),//al
                UnitPrice = 5,//sat
                ProductName = "A32 seffaf",

                UnitsInStock = 2,

                BarcodeNumber = "2004811000004",
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2"),//al
                UnitPrice = 5,//sat
                ProductName = "A73 deri",

                UnitsInStock = 2,

                BarcodeNumber = "2004850000003",
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2,5"),//al
                UnitPrice = 5,//sat
                ProductName = "A13 deri",

                UnitsInStock = 2,

                BarcodeNumber = "2004832000007",
                QuantityPerUnit = "1x1",
                Description = "min5"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("1,5"),//al
                UnitPrice = 5,//sat
                ProductName = "A13 seffaf",

                UnitsInStock = 3,

                BarcodeNumber = "2004828000004",
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("3,5"),//al
                UnitPrice = 8,//sat
                ProductName = "A13 new skin",

                UnitsInStock = 1,

                BarcodeNumber = "2004889000005",
                QuantityPerUnit = "1x1",
                Description = "min7"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("3,5"),//al
                UnitPrice = 8,//sat
                ProductName = "A52 luice vuittion",

                UnitsInStock = 2,

                BarcodeNumber = "2004719000007",
                QuantityPerUnit = "1x1",
                Description = "min7"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2,5"),//al
                UnitPrice = 6,//sat
                ProductName = "A52 silikon",

                UnitsInStock = 2,

                BarcodeNumber = "2004700000009",
                QuantityPerUnit = "1x1",
                Description = "min5"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("1,5"),//al
                UnitPrice = 5,//sat
                ProductName = "A52 seffaf",

                UnitsInStock = 2,

                BarcodeNumber = "2004812000003" ,
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2"),//al
                UnitPrice = 5,//sat
                ProductName = "A52 deri",

                UnitsInStock = 2,

                BarcodeNumber = "2004835000004" ,
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2"),//al
                UnitPrice = 5,//sat
                ProductName = "A33 deri",

                UnitsInStock =1 ,

                BarcodeNumber = "2004844000002",
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("1,5"),//al
                UnitPrice = 5,//sat
                ProductName = "A33 seffaf",

                UnitsInStock = 2,

                BarcodeNumber = "2004830000009" ,
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("3,5"),//al
                UnitPrice =8 ,//sat
                ProductName = "A33 new skin",

                UnitsInStock =2 ,

                BarcodeNumber = "2004890000001" ,
                QuantityPerUnit = "1x1",
                Description = "min7"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2,5"),//al
                UnitPrice = 6,//sat
                ProductName = "A22 slikon",

                UnitsInStock = 2,

                BarcodeNumber = "2004705000004" ,
                QuantityPerUnit = "1x1",
                Description = "min5"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2,5"),//al
                UnitPrice = 5,//sat
                ProductName = "A23 deri",

                UnitsInStock = 2,

                BarcodeNumber = "2004843000003" ,
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("1,5"),//al
                UnitPrice = 5,//sat
                ProductName = "A23 seffaf",

                UnitsInStock = 2,

                BarcodeNumber = "2004829000003" ,
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("3,5"),//al
                UnitPrice = 8,//sat
                ProductName = "A23 new skin",

                UnitsInStock =2 ,

                BarcodeNumber = "2004891000000" ,
                QuantityPerUnit = "1x1",
                Description = "min7"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2,5"),//al
                UnitPrice = 6,//sat
                ProductName = "A10 slikon",

                UnitsInStock = 2,

                BarcodeNumber = "2004696000007",
                QuantityPerUnit = "1x1",
                Description = "min5"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2"),//al
                UnitPrice = 5,//sat
                ProductName = "A10 deri",

                UnitsInStock = 1,

                BarcodeNumber = "2004847000009" ,
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("1,5"),//al
                UnitPrice = 5,//sat
                ProductName = "A10 seffaf",

                UnitsInStock = 1,

                BarcodeNumber = "2002267900000" ,
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2,5"),//al
                UnitPrice = 6,//sat
                ProductName = "A02 S slikon",

                UnitsInStock = 2,

                BarcodeNumber = "2004695000008" ,
                QuantityPerUnit = "1x1",
                Description = "min5"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2"),//al
                UnitPrice = 5,//sat
                ProductName = "A02 S sade qara",

                UnitsInStock = 2,

                BarcodeNumber = "2004494000001" ,
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("1,5"),//al
                UnitPrice = 5,//sat
                ProductName = "A12 seffaf",

                UnitsInStock = 1,

                BarcodeNumber = "2004814000001" ,
                QuantityPerUnit = "1x1",
                Description = "min4"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2,5"),//al
                UnitPrice = 6,//sat
                ProductName = "A03 Core slikon",

                UnitsInStock =4 ,

                BarcodeNumber = "2004701000008" ,
                QuantityPerUnit = "1x1",
                Description = "min5"
            });
            products.Add(new Product()
            {
                CategoryId = 1006,
                BrandId = 1,//sams
                SupplierId = 4,

                PurchasePrice = decimal.Parse("2"),//al
                UnitPrice = 5,//sat
                ProductName = "A03 Core deri",

                UnitsInStock = 2,

                BarcodeNumber = "2004833000006" ,
                QuantityPerUnit = "1x1",
                Description = "min4"
            });


            foreach (var product in products)
            {
                IResult result = productManager.Add(product);
                if (!result.Success)
                {
                    Console.WriteLine(product.ProductName+result.Message);
                }

            }

            //Console.WriteLine(brandManager.Add(brand).Message);
            //Console.WriteLine(brandManager.GetById(brand.Id).Data.BrandName);

            //Console.WriteLine("She said, \"You deserve a treat!\" ");
            // UserManager userManager = new UserManager(new EfUserDal());
            // ProductManager productManager = new ProductManager(new EfProductDal());
            //SupplierManager supplierManager = new SupplierManager(new EfSupplierDal());
            //EfSupplierDal efSupplierDal = new EfSupplierDal();

            //foreach (var p in supplierManager.GetAll().Data)
            //{
            //    Console.WriteLine(p.CompanyName);
            //}
            // User user = new User();
            //user.FirstName= userManager.GetUserDetail(2).Data.FirstName;
            // Console.WriteLine(user.FirstName);
            //Console.WriteLine(50%7);


            // keep this function call here



        }
    }
}

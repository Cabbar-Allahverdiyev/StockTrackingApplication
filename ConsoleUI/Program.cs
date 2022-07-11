using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand=new Brand() { BrandName="redmi"};
            Console.WriteLine(brandManager.Add(brand).Message);

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

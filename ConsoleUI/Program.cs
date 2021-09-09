using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // UserManager userManager = new UserManager(new EfUserDal());
            // ProductManager productManager = new ProductManager(new EfProductDal());
            SupplierManager supplierManager = new SupplierManager(new EfSupplierDal());
            EfSupplierDal efSupplierDal = new EfSupplierDal();
            var get = efSupplierDal.GetAll();    

            foreach (var s in get)
            {
                Console.WriteLine(s.CompanyName);
            }
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

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
            //SupplierManager supplierManager = new SupplierManager(new EfSupplierDal());
            //EfSupplierDal efSupplierDal = new EfSupplierDal();
            CartManager _cartManager = new CartManager(new EfCartDal());
            var get = _cartManager.GetByCartBarcodeNumber(2);

            if (get==null)
            {
                 Console.WriteLine(get.Message);
                return;
            }
            Console.WriteLine(get.Message);
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

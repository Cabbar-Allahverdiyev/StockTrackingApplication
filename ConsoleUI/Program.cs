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
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var p in productManager.GetProductViewDetails().Data)
            {
                Console.WriteLine(p.MehsulAdi);
            }
            // User user = new User();
            //user.FirstName= userManager.GetUserDetail(2).Data.FirstName;
            // Console.WriteLine(user.FirstName);
            //Console.WriteLine(50%7);


            // keep this function call here



        }
    }
}

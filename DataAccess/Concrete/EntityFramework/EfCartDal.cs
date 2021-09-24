using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCartDal : EfEntityRepositoryBase<Cart, StockTrackingProjectContext>
                               , ICartDal
    {
        public CartAddDto GetCartAddDetailByBarcodeNumber(int barcodeNumber)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from c in context.Carts
                             join p in context.Products.Where(product => product.BarcodeNumber == barcodeNumber) on c.ProductId equals p.Id
                             select new CartAddDto
                             {
                                 CartId = c.Id,
                                 ProductId = c.ProductId,
                                 UserId = c.UserId,
                                 BarcodeNumber = p.BarcodeNumber,
                                 SoldPrice = c.SoldPrice,
                                 Quantity = c.Quantity,
                                 TotalPrice = c.TotalPrice,
                                 CartDate = c.CartDate
                             };



                return result.SingleOrDefault();

            }
        }
        public CartAddDto GetCartAddDetailByProductId(int productId)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from c in context.Carts
                             join p in context.Products.Where(product => product.Id == productId) on c.ProductId equals p.Id
                             select new CartAddDto
                             {
                                 CartId = c.Id,
                                 ProductId = c.ProductId,
                                 UserId = c.UserId,
                                 BarcodeNumber = p.BarcodeNumber,
                                 SoldPrice = c.SoldPrice,
                                 Quantity = c.Quantity,
                                 TotalPrice = c.TotalPrice,
                                 CartDate = c.CartDate
                             };



                return result.SingleOrDefault();

            }
        }

        public CartDto GetCartDtoDetailByProductId(int productId)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from c in context.Carts
                             join p in context.Products.Where(product => product.Id == productId) on c.ProductId equals p.Id
                             join u in context.Users on c.UserId equals u.Id
                             select new CartDto
                             {
                                 CartId = c.Id,
                                 ProductId = c.ProductId,
                                 ProductName = p.ProductName,
                                 BarcodeNumber = p.BarcodeNumber,
                                 UnitPrice=p.UnitPrice,
                                 UserId = c.UserId,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 SoldPrice = c.SoldPrice,
                                 Quantity = c.Quantity,
                                 TotalPrice = c.TotalPrice,
                                 CartDate = c.CartDate
                             };



                return result.SingleOrDefault();

            }
        }
    }
}

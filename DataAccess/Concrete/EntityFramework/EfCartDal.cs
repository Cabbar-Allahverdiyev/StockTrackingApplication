using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.CartDtos;
using System.Linq.Expressions;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCartDal : EfEntityRepositoryBase<Cart, StockTrackingProjectContext>
                               , ICartDal
    {


        public CartAddDto GetCartAddDetailByBarcodeNumber(string barcodeNumber)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from c in context.Carts
                             join p in context.Products.Where(product => product.BarcodeNumber.Equals(barcodeNumber)) on c.ProductId equals p.Id
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
                                 UnitPrice = p.UnitPrice,
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

        public List<CartViewDto> GetAllCartViewDetails(Expression<Func<CartViewDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from c in context.Carts
                             join p in context.Products on c.ProductId equals p.Id
                             join u in context.Users on c.UserId equals u.Id
                             join category in context.Categories on p.CategoryId equals category.Id
                             select new CartViewDto
                             {
                                 Id = c.Id,
                                 ProductId = c.ProductId,
                                 MehsulAdi = p.ProductName,
                                 Kateqoriya = category.CategoryName,
                                 UserId = c.UserId,
                                 //AlisQiymeti = p.PurchasePrice,
                                 //Istifadeci = $"{u.FirstName} {u.LastName}",
                                 Qiymet = c.SoldPrice,
                                 Miqdar = c.Quantity,
                                 Cem = c.TotalPrice,
                                 Aciqlama = p.Description,
                                 CartDate = c.CartDate
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public List<CartDtoForReceipt> GetAllCartDtoForReceipt(Expression<Func<CartDtoForReceipt, bool>> filter = null)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from c in context.Carts
                             join p in context.Products on c.ProductId equals p.Id
                             select new CartDtoForReceipt
                             {
                                 CartId = c.Id,
                                 ProductId = c.ProductId,
                                 UserId = c.UserId,
                                 ProductName = p.ProductName,
                                 SoldPrice = c.SoldPrice,
                                 Quantity = c.Quantity,
                                 TotalPrice = c.TotalPrice,

                             };



                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}

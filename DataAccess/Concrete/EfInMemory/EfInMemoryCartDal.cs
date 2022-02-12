using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs.CartDtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EfInMemory
{
    public class EfInMemoryCartDal : EfEntityRepositoryBase<Cart, InMemoryStocktrackingProjctContext>
                               , ICartDal
    {
        public List<CartViewDto> GetAllCartViewDetails(Expression<Func<CartViewDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext efContext = new StockTrackingProjectContext())
            {
                using (InMemoryStocktrackingProjctContext inMemoryContext = new InMemoryStocktrackingProjctContext())
                {
                    var result = from c in inMemoryContext.Carts
                                 join p in efContext.Products on c.ProductId equals p.Id
                                 join u in efContext.Users on c.UserId equals u.Id
                                 select new CartViewDto
                                 {
                                     Id = c.Id,
                                     ProductId = c.ProductId,
                                     MehsulAdi = p.ProductName,
                                     UserId = c.UserId,
                                     Istifadeci = $"{u.FirstName} {u.LastName}",
                                     Qiymet = c.SoldPrice,
                                     Miqdar = c.Quantity,
                                     Cem = c.TotalPrice,
                                     CartDate = c.CartDate
                                 };

                    return filter == null ? result.ToList() : result.Where(filter).ToList();
                }
            }
        }

        public CartAddDto GetCartAddDetailByBarcodeNumber(string barcodeNumber)
        {
            throw new NotImplementedException();
        }

        public CartAddDto GetCartAddDetailByProductId(int productId)
        {
            throw new NotImplementedException();
        }

        public CartDto GetCartDtoDetailByProductId(int productId)
        {
            throw new NotImplementedException();
        }
    }
}

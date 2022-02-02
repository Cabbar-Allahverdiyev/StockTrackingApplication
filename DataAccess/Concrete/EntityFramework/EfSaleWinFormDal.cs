using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSaleWinFormDal : EfEntityRepositoryBase<SaleWinForm, StockTrackingProjectContext>
                               , ISaleWinFormDal
    {
        public List<SaleWinFormDto> GetAllWinFormDtoDetails(Expression<Func<SaleWinFormDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from s in context.SalesWinForms
                             join p in context.Products on s.ProductId equals p.Id
                             join u in context.Users on s.UserId equals u.Id
                             orderby s.SellDate descending
                             select new SaleWinFormDto
                             {
                                 SaleId = s.Id,
                                 ProductId = s.ProductId,
                                 MehsulAdi = p.ProductName,
                                 Istifadeci = $"{u.FirstName} {u.LastName}",
                                 SatilanQiymet = s.SoldPrice,
                                 Miqdar = s.Quantity,
                                 Cem = s.SoldPrice * s.Quantity,
                                 Tarix = s.SellDate

                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }

        }
    }
}


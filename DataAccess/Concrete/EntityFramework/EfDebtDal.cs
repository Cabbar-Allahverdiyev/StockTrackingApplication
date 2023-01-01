using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using Entities.DTOs.DebtDtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDebtDal : EfEntityRepositoryBase<Debt, StockTrackingProjectContext>
                               , IDebtDal
    {
        public List<DebtDto> GetAllDebtDetail(Expression<Func<DebtDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from d in context.Debts
                             join c in context.Customers on d.CustomerId equals c.Id
                             join p in context.Products on d.ProductId equals p.Id
                             select new DebtDto
                             {
                                 Id = c.Id,
                                 CustomerId = c.Id,
                                 FirstName = c.FirstName,
                                 LastName = c.LastName,
                                 ProductId= p.Id,
                                 ProductName = p.ProductName,
                                 Quantity = d.Quantity,
                                 SoldPrice = d.SoldPrice,
                                 Date = d.Date
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}

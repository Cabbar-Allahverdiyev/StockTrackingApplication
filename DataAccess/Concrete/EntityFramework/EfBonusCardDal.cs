using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.BonusCardDtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBonusCardDal : EfEntityRepositoryBase<BonusCard, StockTrackingProjectContext>
                               , IBonusCardDal
    {
        public List<BonusCardForFormsDto> GetBonusCardDetails(Expression<Func<BonusCardForFormsDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext context=new StockTrackingProjectContext())
            {
                var result = from bonuses in context.BonusCards
                             join customers in context.Customers on bonuses.CustomerId equals customers.Id
                             select new BonusCardForFormsDto
                             {
                                 BonusCardId = bonuses.Id,
                                 BarkodNomresi = bonuses.BarcodeNumber,
                                 Ad = customers.FirstName,
                                 Soyad = customers.LastName,
                                 Balans = bonuses.Balance,
                                 MusteriGuzesti = bonuses.InterestAdvantage
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}

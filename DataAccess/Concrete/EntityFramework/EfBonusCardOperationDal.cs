using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.BonusCardOperationDto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using DataAccess.Constants.Messages;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBonusCardOperationDal : EfEntityRepositoryBase<BonusCardOperation, StockTrackingProjectContext>
                                        , IBonusCardOperationDal
    {
        public List<BonusCardOperationForFormsDto> GetAllBonusCardOperationForFormsDto(Expression<Func<BonusCardOperationForFormsDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from operation in context.BonusCardOperations
                             join bonusCard in context.BonusCards on operation.BonusCardId equals bonusCard.Id
                             join user in context.Users on operation.UserId equals user.Id
                             join customer in context.Customers on bonusCard.CustomerId equals customer.Id
                             select new BonusCardOperationForFormsDto
                             {
                                 OperationId=operation.Id,
                                 Satici=$"{user.FirstName} {user.LastName}",
                                 Musteri=$"{customer.FirstName} {customer.LastName}",
                                 BonusKartNomresi=bonusCard.BarcodeNumber,
                                 Mebleg=operation.Value,
                                 Tarix=operation.Date,
                                 EmeliyyatVeziyyeti=operation.IsIncreasedBalance
                                 ?BonusCardOperationDalMessages.BonusMade
                                 :BonusCardOperationDalMessages.BonusCardSale,
                                 Status=operation.Status

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public BonusCardOperationForFormsDto GetBonusCardOperationForFormsDto(Expression<Func<BonusCardOperationForFormsDto, bool>> filter)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from operation in context.BonusCardOperations
                             join bonusCard in context.BonusCards on operation.BonusCardId equals bonusCard.Id
                             join user in context.Users on operation.UserId equals user.Id
                             join customer in context.Customers on bonusCard.CustomerId equals customer.Id
                             select new BonusCardOperationForFormsDto
                             {
                                 OperationId = operation.Id,
                                 Satici = $"{user.FirstName} {user.LastName}",
                                 Musteri = $"{customer.FirstName} {customer.LastName}",
                                 BonusKartNomresi = bonusCard.BarcodeNumber,
                                 Mebleg = operation.Value,
                                 Tarix = operation.Date,
                                 EmeliyyatVeziyyeti = operation.IsIncreasedBalance 
                                 ? BonusCardOperationDalMessages.BonusMade
                                 : BonusCardOperationDalMessages.BonusCardSale,
                                 Status = operation.Status

                             };
                return result.SingleOrDefault(filter);
            }
        }

        public List<BonusCardOperationForFormsDto> GetAllBonusCardOperationForFormsDtoByIncreasedBalance(Expression<Func<BonusCardOperationForFormsDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from operation in context.BonusCardOperations
                             join bonusCard in context.BonusCards on operation.BonusCardId equals bonusCard.Id
                             join user in context.Users on operation.UserId equals user.Id
                             join customer in context.Customers on bonusCard.CustomerId equals customer.Id
                             where operation.IsIncreasedBalance == true 
                             select new BonusCardOperationForFormsDto
                             {
                                 OperationId = operation.Id,
                                 Satici = $"{user.FirstName} {user.LastName}",
                                 Musteri = $"{customer.FirstName} {customer.LastName}",
                                 BonusKartNomresi = bonusCard.BarcodeNumber,
                                 Mebleg = operation.Value,
                                 Tarix = operation.Date,
                                 EmeliyyatVeziyyeti = operation.IsIncreasedBalance 
                                 ? BonusCardOperationDalMessages.BonusMade
                                 : BonusCardOperationDalMessages.BonusCardSale,
                                 Status = operation.Status

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public List<BonusCardOperationForFormsDto> GetAllBonusCardOperationForFormsDtoByReducedBalance(Expression<Func<BonusCardOperationForFormsDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from operation in context.BonusCardOperations
                             join bonusCard in context.BonusCards on operation.BonusCardId equals bonusCard.Id
                             join user in context.Users on operation.UserId equals user.Id
                             join customer in context.Customers on bonusCard.CustomerId equals customer.Id
                             where operation.IsIncreasedBalance == false   
                             select new BonusCardOperationForFormsDto
                             {
                                 OperationId = operation.Id,
                                 Satici = $"{user.FirstName} {user.LastName}",
                                 Musteri = $"{customer.FirstName} {customer.LastName}",
                                 BonusKartNomresi = bonusCard.BarcodeNumber,
                                 Mebleg = operation.Value,
                                 Tarix = operation.Date,
                                 EmeliyyatVeziyyeti = operation.IsIncreasedBalance
                                 ? BonusCardOperationDalMessages.BonusMade
                                 : BonusCardOperationDalMessages.BonusCardSale,
                                 Status = operation.Status

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

    }
}

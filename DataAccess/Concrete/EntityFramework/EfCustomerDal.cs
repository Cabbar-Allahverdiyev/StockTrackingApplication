using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.CustomerDtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, StockTrackingProjectContext>
                               , ICustomerDal
    {
        public CustomerDto GetCustomerDetail(Expression<Func<CustomerDto, bool>> filter)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from c in context.Customers
                             join cb in context.CustomerBalances on c.Id equals cb.CustomerId
                             select new CustomerDto
                             {
                                 CustomerId = c.Id,
                                 FirstName = c.FirstName,
                                 LastName = c.LastName,
                                 PhoneNumber = c.PhoneNumber,
                                 Address = c.Address,
                                 Debt = cb.Debt,
                                 Balance = cb.Balance,
                                 CustomerCreatedDate = c.CreatedDate
                             };

                return result.SingleOrDefault(filter);

            }
        }

        public List<CustomerDto> GetCustomerDetails(Expression<Func<CustomerDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from c in context.Customers
                             join cb in context.CustomerBalances on c.Id equals cb.CustomerId
                             //join bonusCard in context.BonusCards on c.Id equals bonusCard.CustomerId

                             select new CustomerDto
                             {
                                 CustomerId = c.Id,
                                 FirstName = c.FirstName,
                                 LastName = c.LastName,
                                 PhoneNumber = c.PhoneNumber,
                                 Address = c.Address,
                                 Debt = cb.Debt,
                                 Balance = cb.Balance,
                               // BonusCardBalance=bonusCard.Balance ,
                                 CustomerCreatedDate = c.CreatedDate
                             };
             
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}

using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using Entities.DTOs.CustomerPaymentDtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerPaymentDal : EfEntityRepositoryBase<CustomerPayment, StockTrackingProjectContext>
                               , ICustomerPaymentDal
    {
        public List<CustomerPaymentDto> GetCustomerPaymentDetails(Expression<Func<CustomerPaymentDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from payment in context.CustomerPayments
                             join c in context.Customers on payment.CustomerId equals c.Id
                             select new CustomerPaymentDto
                             {
                                 CustomerPaymentId = payment.Id,
                                 FullName = c.FirstName + " " + c.LastName,
                                 Value = payment.Value,
                                 Date = payment.Date,
                                 PaymentStatus = payment.PaymentStatus
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}

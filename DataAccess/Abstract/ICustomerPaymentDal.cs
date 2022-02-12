using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs.CustomerPaymentDtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICustomerPaymentDal: IEntityRepository<CustomerPayment>
    {
        List<CustomerPaymentDto> GetCustomerPaymentDetails(Expression<Func<CustomerPaymentDto,bool>> filter=null);
    }
}

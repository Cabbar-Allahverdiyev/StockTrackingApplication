using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs.CustomerDtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        List<CustomerDto> GetCustomerDetails(Expression<Func<CustomerDto, bool>> filter = null);
        CustomerDto GetCustomerDetail(Expression<Func<CustomerDto, bool>> filter);

    }
}

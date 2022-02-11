using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerPaymentService
    {
        IDataResult<List<CustomerPayment>> GetAll();
        IResult Add(CustomerPayment customer);
        IResult Update(CustomerPayment customer);
        IResult Delete(CustomerPayment customer);
        IDataResult<CustomerPayment> GetById(int id);
    }
}

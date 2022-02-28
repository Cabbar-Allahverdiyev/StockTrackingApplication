using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.CustomerPaymentDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerPaymentService
    {
        IDataResult<List<CustomerPayment>> GetAll();
        IResult Add(CustomerPayment customerPayment);
        IResult Update(CustomerPayment customerPayment);
        IResult Delete(CustomerPayment customerPayment);
        IDataResult<CustomerPayment> GetById(int id);

        IResult CancelPayment(CustomerPayment customerPayment);

        IDataResult<List<CustomerPaymentDto>> GetCustomerPaymentDetails();
    }
}

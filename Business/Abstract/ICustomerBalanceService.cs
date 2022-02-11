using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerBalanceService
    {
        IDataResult<List<CustomerBalance>> GetAll();
        IResult Add(CustomerBalance  customerBalance);
        IResult Update(CustomerBalance customerBalance);
        IResult Delete(CustomerBalance customerBalance);
        IDataResult<CustomerBalance> GetById(int id);
    }
}

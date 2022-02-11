using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDebtService
    {
        IDataResult<List<Debt>> GetAll();
        IResult Add(Debt debt);
        IResult Update(Debt debt);
        IResult Delete(Debt debt);
        IDataResult<Debt> GetById(int id);

        IDataResult<Debt> GetByCustomerId(int customerId);
    }
}

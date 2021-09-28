using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISaleWinFormService
    {
        IDataResult<List<SaleWinForm>> GetAll();
        IResult Add(SaleWinForm saleWinForm);
        IResult Update(SaleWinForm saleWinForm);
        IResult Delete(SaleWinForm saleWinForm);
    }
}

using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SaleWinFormManager : ISaleWinFormService
    {
        ISaleWinFormDal _saleWinFormDal;
        public SaleWinFormManager(ISaleWinFormDal saleWinFormDal)
        {
            _saleWinFormDal = saleWinFormDal;
        }
        public IResult Add(SaleWinForm saleWinForm)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(SaleWinForm saleWinForm)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SaleWinForm>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(SaleWinForm saleWinForm)
        {
            throw new NotImplementedException();
        }
    }
}

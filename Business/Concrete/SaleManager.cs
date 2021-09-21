using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SaleManager : ISaleService
    {
        ISaleDal _saleDal;
        public SaleManager(ISaleDal saleDal)
        {
            _saleDal = saleDal;
        }
        public IResult Add(Sale sale)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Sale sale)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Sale sale)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Sale>> GetAll()
        {
            throw new NotImplementedException();
        }

       
    }
}

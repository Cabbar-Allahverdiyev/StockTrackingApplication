using Business.Abstract;
using Business.Constants.Messages;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BarcodeNumberManager : IBarcodNumberService
    {
        IBarcodeNumberDal _barcodeNumberDal;
        public BarcodeNumberManager(IBarcodeNumberDal barcodeNumberDal)
        {
            _barcodeNumberDal = barcodeNumberDal;
        }
        //CRUD
       // [ValidationAspect(typeof(BArcodeNumberValidator))]
        [CacheRemoveAspect("IBarcodeNumberService.Get")]
        public IResult Add(BarcodeNumber barcodeNumber)
        {
            _barcodeNumberDal.Add(barcodeNumber);
            return new SuccessResult(BarcodeNumberMessages.BarcodeNumberAdded);
        }

        public IResult Delete(BarcodeNumber barcodeNumber)
        {
            throw new NotImplementedException();
        }

        public IResult Update(BarcodeNumber barcodeNumber)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BarcodeNumber>> GetAll()
        {
            throw new NotImplementedException();
        }

       
    }
}

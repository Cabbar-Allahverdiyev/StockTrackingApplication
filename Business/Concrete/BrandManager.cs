﻿using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        //CRUD
        [ValidationAspect(typeof(BrandValidator))]
        [CacheRemoveAspect("IBarcodeNumberService.Get")]
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(BrandMessages.BrandAdded);
        }

        [CacheRemoveAspect("IBarcodeNumberService.Get")]
        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(BrandMessages.BrandDeleted);
        }

        [ValidationAspect(typeof(BrandValidator))]
        [CacheRemoveAspect("IBarcodeNumberService.Get")]
        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(BrandMessages.BrandUpdated);
        }

        [CacheAspect]
        public IDataResult<List<Brand>> GetAll()
        {
            List<Brand> get = _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(get,BrandMessages.BrandGetAll);
        }
    }
}

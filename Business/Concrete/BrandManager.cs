using Business.Abstract;
using Business.Constants.Messages;
using Business.Utilites.BusinessRuleMethods;
using Business.ValidationRules.FluentValidation.BrandValidators;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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
        [ValidationAspect(typeof(CreateBrandValidator))]
        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Add(Brand brand)
        {
            IResult rule= BusinessRules.Run(
                IsBrandNameExists(brand.BrandName)
              //  BusinessRuleForIEnttityRepository<Brand>.IsNameExists(_brandDal,b=>b.BrandName==brand.BrandName)
                );
            if (rule!=null)
            {
                return new ErrorResult(rule.Message);
            }
           // IResult result = GetAllByName(brand.BrandName);
            //if (result.Success)
            //{
                _brandDal.Add(brand);
                return new SuccessResult(BrandMessages.BrandAdded);
            //}
           // return new ErrorResult(BrandMessages.BrandNotAdded);
        }

        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(BrandMessages.BrandDeleted);
        }

        [ValidationAspect(typeof(UpdateBrandValidator))]
        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Update(Brand brand)
        {
            IResult rule = BusinessRules.Run(IsBrandNameExistsForUpdate(brand)  );
            if (rule != null)
            {
                return new ErrorResult(rule.Message);
            }
            _brandDal.Update(brand);
            return new SuccessResult(BrandMessages.BrandUpdated);
        }

        [CacheAspect]
        public IDataResult<List<Brand>> GetAll()
        {
            List<Brand> get = _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(get,BrandMessages.BrandGetAll);
        }
        
        [CacheAspect]
        public IDataResult<List<Brand>> GetAllByName(string brandName)
        {
            List<Brand> get = _brandDal.GetAll(b=>b.BrandName==brandName);
            if (get.Count==0)
            {
                return new ErrorDataResult<List<Brand>>(BrandMessages.BrandNotFound);
            }
            return new SuccessDataResult<List<Brand>>(get,BrandMessages.BrandGetAll);
        }

        public IDataResult<Brand> GetByName(string brandName)
        {
            Brand get = _brandDal.Get(b => b.BrandName == brandName);
            if (get == null)
            {
                return new ErrorDataResult<Brand>(BrandMessages.BrandNotFound);
            }
            return new SuccessDataResult<Brand>(get, BrandMessages.BrandFound);
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            Brand get = _brandDal.Get(b => b.Id == brandId);
            if (get == null)
            {
                return new ErrorDataResult<Brand>(BrandMessages.BrandNotFound);
            }
            return new SuccessDataResult<Brand>(get, BrandMessages.BrandFound);
        }

        //Elave 

        private IResult IsBrandNameExists(string brandName)
        {
            Brand brand = _brandDal.Get(b => b.BrandName.ToLower() == brandName.ToLower());
            if (brand != null)
            {
                return new ErrorResult(BrandMessages.AlreadyExistsName);
            }
            return new SuccessResult();
        }

        private IResult IsBrandNameExistsForUpdate(Brand brand)
        {
            Brand getBrand = _brandDal.Get(b => b.BrandName.ToLower() == brand.BrandName.ToLower());
            if (getBrand != null && getBrand.Id != brand.Id)
            {
                return new ErrorResult(BrandMessages.AlreadyExistsName);
            }
            return new SuccessResult();
        }
    }
}

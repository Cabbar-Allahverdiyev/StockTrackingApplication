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
using System.Globalization;
using System.Linq;
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
            IResult rule = BusinessRules.Run(
                IsBrandNameExists(brand.BrandName)
                , BrandNameToTitleCase(brand));
            if (rule != null)
            {
                return new ErrorResult(rule.Message);
            }
            _brandDal.Add(brand);
            return new SuccessResult(BrandMessages.BrandAdded);

        }

        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Delete(Brand brand)
        {
            IResult result = BusinessRules.Run(IsBrandIdNull(brand.Id));
            if (result != null)
            {
                return new ErrorResult(result.Message);
            }
            _brandDal.Delete(brand);
            return new SuccessResult(BrandMessages.BrandDeleted);
        }



        [ValidationAspect(typeof(UpdateBrandValidator))]
        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Update(Brand brand)
        {
            IResult rule = BusinessRules.Run(IsBrandNameExistsForUpdate(brand),
                BrandNameToTitleCase(brand));
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
            List<Brand> get = _brandDal.GetAll().OrderBy(b=>b.BrandName).ToList();
            return new SuccessDataResult<List<Brand>>(get, BrandMessages.BrandGetAll);
        }

        [CacheAspect]
        public IDataResult<List<Brand>> GetAllByName(string brandName)
        {
            List<Brand> get = _brandDal.GetAll(b => b.BrandName == brandName)
                .OrderBy(b => b.BrandName).ToList();
            if (get.Count == 0)
            {
                return new ErrorDataResult<List<Brand>>(BrandMessages.BrandNotFound);
            }
            return new SuccessDataResult<List<Brand>>(get, BrandMessages.BrandGetAll);
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


        private IResult IsBrandIdNull(int id)
        {
            if (id == 0)
            {
                return new ErrorResult(BrandMessages.BrandIdIsEmpty);
            }
            return new SuccessResult();
        }

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

        private IResult BrandNameToTitleCase(Brand brand)
        {
            brand.BrandName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(brand.BrandName);
            return new SuccessResult();
        }
    }
}

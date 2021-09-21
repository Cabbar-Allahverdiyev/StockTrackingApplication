using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
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

        [ValidationAspect(typeof(SaleValidator))]
        [CacheRemoveAspect("ISaleService.Get")]
        public IResult Add(Sale sale)
        {
            IResult result = BusinessRules.Run();

            if (result != null)
            {
                return new ErrorDataResult<Sale>(result.Message);
            }

            _saleDal.Add(sale);
            return new SuccessResult(SaleMessages.Added);

        }

        [CacheRemoveAspect("ISaleService.Get")]
        public IResult Delete(Sale sale)
        {
            _saleDal.Delete(sale);
            return new SuccessResult(SaleMessages.Deleted);
        }

        [ValidationAspect(typeof(SaleValidator))]
        [CacheRemoveAspect("ISaleService.Get")]
        public IResult Update(Sale sale)
        {
            _saleDal.Update(sale);
            return new SuccessResult(SaleMessages.Updated);
        }

        [CacheAspect]
        public IDataResult<List<Sale>> GetAll()
        {
            List<Sale> get= _saleDal.GetAll();
            if (get == null)
            {
                return new ErrorDataResult<List<Sale>>(SaleMessages.NotFound);
            }
            return new SuccessDataResult<List<Sale>>(get,SaleMessages.GetAll);
        }

       
    }
}

using Business.Abstract;
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
    public class DebtManager : IDebtService
    {
        IDebtDal _debtDal;
        public DebtManager(IDebtDal debtDal)
        {
            _debtDal = debtDal;
        }
        //CRUD
        [ValidationAspect(typeof(DebtValidator))]
        [CacheRemoveAspect("IDebtService.Get")]
        public IResult Add(Debt debt )
        {
            IResult result = GetByCustomerId(debt.Id);
            if (result.Success)
            {
                _debtDal.Add(debt);
                return new SuccessResult(DebtMessages.Added);
            }
            return new ErrorResult(DebtMessages.NotAdded);
        }

        [CacheRemoveAspect("IDebtService.Get")]
        public IResult Delete( Debt debt)
        {
            _debtDal.Delete(debt);
            return new SuccessResult(DebtMessages.Deleted);
        }

        [ValidationAspect(typeof(DebtValidator))]
        [CacheRemoveAspect("IDebtService.Get")]
        public IResult Update(Debt debt )
        {
            _debtDal.Update(debt);
            return new SuccessResult(DebtMessages.Updated);
        }

        [CacheAspect]
        public IDataResult<List<Debt>> GetAll()
        {
            List<Debt> get = _debtDal.GetAll();
            return new SuccessDataResult<List<Debt>>(get,DebtMessages .GetAll);
        }

        [CacheAspect]
        public IDataResult<Debt> GetById(int id)
        {
            Debt get = _debtDal.Get(b => b.Id == id);
            if (get == null)
            {
                return new ErrorDataResult<Debt>(DebtMessages.NotFound);
            }
            return new SuccessDataResult<Debt>(get, DebtMessages. Found);
        }


        //Elave-------------------------------->
        public IDataResult<Debt> GetByCustomerId(int customerId)
        {
            Debt get = _debtDal.Get(b => b.CustomerId == customerId);
            if (get == null)
            {
                return new ErrorDataResult<Debt>(DebtMessages.NotFound);
            }
            return new SuccessDataResult<Debt>(get, DebtMessages.Found);
        }
    }
}

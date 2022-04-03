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
        ICustomerBalanceService _customerBalanceService;

        public DebtManager(IDebtDal debtDal, ICustomerBalanceService customerBalanceService)
        {
            _debtDal = debtDal;
            _customerBalanceService = customerBalanceService;
        }

        //CRUD
        [ValidationAspect(typeof(DebtValidator))]
        [CacheRemoveAspect("IDebtService.Get")]
        public IResult Add(Debt debt)
        {
            //IResult result = GetByCustomerId(debt.CustomerId);
            IDataResult<CustomerBalance> result = _customerBalanceService.GetByCustomerId(debt.CustomerId);
            if (result.Success)
            {
                result.Data.Debt += (debt.SoldPrice * debt.Quantity);
                if (result.Data.Balance >= result.Data.Debt)
                {
                    result.Data.Balance -= result.Data.Debt;
                    result.Data.Debt = 0;
                    //bura nezer yetir gor dogru isleyirmi
                }
                else
                {
                    result.Data.Debt -= result.Data.Balance;
                    result.Data.Balance = 0;
                }
                // result.Data.DateOfLastLoan = DateTime.Now;
                IResult customerBalanceUpdated = _customerBalanceService.Update(result.Data);
                if (!customerBalanceUpdated.Success)
                {
                    return new ErrorResult($" {DebtMessages.NotAdded} çünki {customerBalanceUpdated.Message} ");
                }

                debt.Date = DateTime.Now;
                debt.Id =0;
                _debtDal.Add(debt);
                return new SuccessResult($"{DebtMessages.Added} və {result.Message}");
            }

            CustomerBalance customerBalance = new CustomerBalance();
            customerBalance.CustomerId = debt.CustomerId;
            customerBalance.Debt = (debt.Quantity * debt.SoldPrice);
            customerBalance.Balance = 0;
            IResult customerBalanceAdded = _customerBalanceService.Add(customerBalance);
            if (!customerBalanceAdded.Success)
            {
                return new ErrorResult($"{DebtMessages.NotAdded} çünki {customerBalanceAdded.Message}");
            }

            debt.Date = DateTime.Now;
            _debtDal.Add(debt);
            return new SuccessResult($"{DebtMessages.Added} və {customerBalanceAdded.Message}");
        }

        [CacheRemoveAspect("IDebtService.Get")]
        public IResult Delete(Debt debt)
        {
            _debtDal.Delete(debt);
            return new SuccessResult(DebtMessages.Deleted);
        }

        [ValidationAspect(typeof(DebtValidator))]
        [CacheRemoveAspect("IDebtService.Get")]
        public IResult Update(Debt debt)
        {
            _debtDal.Update(debt);
            return new SuccessResult(DebtMessages.Updated);
        }

        [CacheAspect]
        public IDataResult<List<Debt>> GetAll()
        {
            List<Debt> get = _debtDal.GetAll();
            return new SuccessDataResult<List<Debt>>(get, DebtMessages.GetAll);
        }

        [CacheAspect]
        public IDataResult<Debt> GetById(int id)
        {
            Debt get = _debtDal.Get(b => b.Id == id);
            if (get == null)
            {
                return new ErrorDataResult<Debt>(DebtMessages.NotFound);
            }
            return new SuccessDataResult<Debt>(get, DebtMessages.Found);
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

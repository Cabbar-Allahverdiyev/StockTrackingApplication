using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules;
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
    public class CustomerBalanceManager : ICustomerBalanceService
    {

        ICustomerBalanceDal _customerBalanceDal;
        public CustomerBalanceManager(ICustomerBalanceDal customerBalanceDal)
        {
            _customerBalanceDal = customerBalanceDal;
        }

        //CRUD
        [ValidationAspect(typeof(CustomerPaymentValidator))]
        [CacheRemoveAspect("ICustomerBalanceService.Get")]
        public IResult Add(CustomerBalance customerBalance)
        {
            customerBalance.DateOfLastLoan = DateTime.Now;
            _customerBalanceDal.Add(customerBalance);
            return new SuccessResult(CustomerBalanceMessages.Added);
        }

        [CacheRemoveAspect("ICustomerBalanceService.Get")]
        public IResult Delete(CustomerBalance customerBalance)
        {
            _customerBalanceDal.Delete(customerBalance);
            return new SuccessResult(CustomerBalanceMessages.Deleted);
        }

        [ValidationAspect(typeof(CustomerPaymentValidator))]
        [CacheRemoveAspect("ICustomerBalanceService.Get")]
        public IResult Update(CustomerBalance customerBalance)
        {
            customerBalance.DateOfLastLoan = DateTime.Now;
            _customerBalanceDal.Update(customerBalance);
            return new SuccessResult(CustomerBalanceMessages.Updated);
        }

        [CacheAspect]
        public IDataResult<List<CustomerBalance>> GetAll()
        {
            List<CustomerBalance> get = _customerBalanceDal.GetAll();
            return new SuccessDataResult<List<CustomerBalance>>(get, CustomerBalanceMessages.GetAll);
        }

        [CacheAspect]
        public IDataResult<CustomerBalance> GetById(int id)
        {
            CustomerBalance get = _customerBalanceDal.Get(b => b.Id == id);
            if (get == null)
            {
                return new ErrorDataResult<CustomerBalance>(CustomerBalanceMessages.NotFound);
            }
            return new SuccessDataResult<CustomerBalance>(get, CustomerBalanceMessages.Found);
        }

        public IDataResult<CustomerBalance> GetByCustomerId(int customerId)
        {
            CustomerBalance get = _customerBalanceDal.Get(b => b.CustomerId ==customerId);
            if (get == null)
            {
                return new ErrorDataResult<CustomerBalance>(CustomerBalanceMessages.NotFound);
            }
            return new SuccessDataResult<CustomerBalance>(get, CustomerBalanceMessages.GetAll);
        }
    }
}

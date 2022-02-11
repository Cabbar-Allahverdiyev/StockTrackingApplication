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
    public class CustomerPaymentManager : ICustomerPaymentService
    {

        ICustomerPaymentDal _customerPaymentDal;
        public CustomerPaymentManager(ICustomerPaymentDal customerPaymentDal)
        {
            _customerPaymentDal = customerPaymentDal;
        }
        //CRUD
        [ValidationAspect(typeof(CustomerPaymentValidator))]
        [CacheRemoveAspect("ICustomerPaymentService.Get")]
        public IResult Add(CustomerPayment customerPayment)
        {
            _customerPaymentDal.Add(customerPayment);
            return new SuccessResult(CustomerPaymentMessages.Added);
        }

        [CacheRemoveAspect("ICustomerPaymentService.Get")]
        public IResult Delete(CustomerPayment customerPayment)
        {
            _customerPaymentDal.Delete(customerPayment);
            return new SuccessResult(CustomerPaymentMessages.Deleted);
        }

        [ValidationAspect(typeof(CustomerPaymentValidator))]
        [CacheRemoveAspect("ICustomerPaymentService.Get")]
        public IResult Update(CustomerPayment customerPayment)
        {
            _customerPaymentDal.Update(customerPayment);
            return new SuccessResult(CustomerPaymentMessages.Updated);
        }

        [CacheAspect]
        public IDataResult<List<CustomerPayment>> GetAll()
        {
            List<CustomerPayment> get = _customerPaymentDal.GetAll();
            return new SuccessDataResult<List<CustomerPayment>>(get, CustomerPaymentMessages.GetAll);
        }

        [CacheAspect]
        public IDataResult<CustomerPayment> GetById(int id)
        {
            CustomerPayment get = _customerPaymentDal.Get(b => b.Id == id);
            if (get == null)
            {
                return new ErrorDataResult<CustomerPayment>(CustomerPaymentMessages.NotFound);
            }
            return new SuccessDataResult<CustomerPayment>(get, CustomerPaymentMessages.GetAll);
        }
    }
}

﻿using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.CustomerPaymentDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerPaymentManager : ICustomerPaymentService
    {

        ICustomerPaymentDal _customerPaymentDal;
        ICustomerBalanceService _balanceService;

        public CustomerPaymentManager(ICustomerPaymentDal customerPaymentDal, ICustomerBalanceService customerBalanceService)
        {
            _customerPaymentDal = customerPaymentDal;
            _balanceService = customerBalanceService;
        }
        //CRUD
        [ValidationAspect(typeof(CustomerPaymentValidator))]
        [CacheRemoveAspect("ICustomerPaymentService.Get")]
        public IResult Add(CustomerPayment customerPayment)
        {
            IDataResult<CustomerBalance> getBalance = _balanceService.GetByCustomerId(customerPayment.CustomerId);
            if (!getBalance.Success)
            {
                CustomerBalance customerBalance = new CustomerBalance();
                customerBalance.CustomerId = customerPayment.CustomerId;
                customerBalance.Debt = 0;
                customerBalance.Balance = customerPayment.Value;
                IResult balanceAdded = _balanceService.Add(customerBalance);
                if (!balanceAdded.Success)
                {
                    return new ErrorResult($"{CustomerPaymentMessages.NotAdded} çünki {balanceAdded.Message}");
                }
                customerPayment.Date = DateTime.Now;
                _customerPaymentDal.Add(customerPayment);
                return new SuccessResult($"{CustomerPaymentMessages.Added} və {balanceAdded.Message}");
            }

           
            getBalance.Data.Balance += customerPayment.Value;
            if (getBalance.Data.Debt>=getBalance.Data.Balance)
            {
                getBalance.Data.Debt -= getBalance.Data.Balance;
                getBalance.Data.Balance = 0;
            }
            else
            {
                getBalance.Data.Balance -= getBalance.Data.Debt;
                getBalance.Data.Debt = 0;
            }

            IResult balanceUpdated = _balanceService.Update(getBalance.Data);
            if (!balanceUpdated.Success)
            {
                return new ErrorResult($"{CustomerPaymentMessages.NotAdded} çünki {balanceUpdated.Message}");
            }

            customerPayment.Date = DateTime.Now;
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


        //Dtos---------------------------->
        public IDataResult<List<CustomerPaymentDto>> GetCustomerPaymentDetails()
        {
            List<CustomerPaymentDto> get = _customerPaymentDal.GetCustomerPaymentDetails();
            return new SuccessDataResult<List<CustomerPaymentDto>>(get, CustomerPaymentMessages.GetAll);
        }
    }
}

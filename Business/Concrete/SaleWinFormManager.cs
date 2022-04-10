using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.SaleWinFormDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Utilities.Business;

namespace Business.Concrete
{
    public class SaleWinFormManager : ISaleWinFormService
    {
        ISaleWinFormDal _saleWinFormDal;
        IProductService _productService;
        public SaleWinFormManager(ISaleWinFormDal saleWinFormDal, IProductService productService)
        {
            _productService = productService;
            _saleWinFormDal = saleWinFormDal;
        }

        [ValidationAspect(typeof(SaleWinFormValidator))]
        [CacheRemoveAspect("ISaleWinFormService.Get")]
        public IResult Add(SaleWinForm saleWinForm)
        {
            saleWinForm.SellDate = DateTime.Now;
            saleWinForm.SaleStatus = true;
            _saleWinFormDal.Add(saleWinForm);
            return new SuccessResult(SaleMessages.Added);
        }

        [ValidationAspect(typeof(SaleWinFormValidator))]
        [CacheRemoveAspect("ISaleWinFormService.Get")]
        public IResult Update(SaleWinForm saleWinForm)
        {
            //saleWinForm.SellDate = DateTime.Now;
            _saleWinFormDal.Update(saleWinForm);
            return new SuccessResult(SaleMessages.Updated);
        }

        [CacheRemoveAspect("ISaleWinFormService.Get")]
        [ValidationAspect(typeof(SaleWinFormValidator))]
        public IResult CancelSale(SaleWinForm sale)
        {
            IDataResult<SaleWinForm> getSale = GetById(sale.Id);
            IResult result = BusinessRules.Run(IsTheSaleStatusTrue(getSale.Data.SaleStatus)
                                               ,IsSuccess(getSale));

            if (result != null)
            {
                return new ErrorResult(result.Message);
            }
            sale = getSale.Data;
            sale.SaleStatus = false;
            IResult updatedSale = Update(sale);

            IDataResult<Product> getProduct = _productService.GetById(getSale.Data.ProductId);
            if (!getProduct.Success)
            {
                return new ErrorResult(getProduct.Message);
            }
            getProduct.Data.UnitsInStock += sale.Quantity;
            IResult productUpdated = _productService.Update(getProduct.Data);
            if (!productUpdated.Success)
            {
                return new ErrorResult(getProduct.Message);
            }
            return new SuccessResult(SaleMessages.SaleCancel + BaseMessages.And + ProductMessages.UnitsInStockIncreased(sale.Quantity));

        }

        [CacheRemoveAspect("ISaleWinFormService.Get")]
        public IResult Delete(SaleWinForm saleWinForm)
        {
            _saleWinFormDal.Delete(saleWinForm);
            return new SuccessResult(SaleMessages.Deleted);
        }

        [CacheAspect]
        public IDataResult<List<SaleWinForm>> GetAll()
        {
            List<SaleWinForm> get = _saleWinFormDal.GetAll();
            //if (get == null)
            //{
            //    return new ErrorDataResult<List<SaleWinForm>>(SaleMessages.NotFound);
            //}
            return new SuccessDataResult<List<SaleWinForm>>(get, SaleMessages.Found);
        }

        public IDataResult<SaleWinForm> GetById(int id)
        {
            SaleWinForm get = _saleWinFormDal.Get(s => s.Id == id);
            if (get == null)
            {
                return new ErrorDataResult<SaleWinForm>(SaleMessages.NotFound);
            }
            return new SuccessDataResult<SaleWinForm>(get, SaleMessages.Found);
        }


        //DTOs----------------------->
        [CacheAspect]
        public IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDtoDetails()
        {
            List<SaleWinFormDto> get = _saleWinFormDal.GetAllWinFormDtoDetails();
            //if (get == null)
            //{
            //    return new ErrorDataResult<List<SaleWinFormDto>>(SaleMessages.NotFound);
            //}
            return new SuccessDataResult<List<SaleWinFormDto>>(get, SaleMessages.Found);
        }

        [CacheAspect]
        public IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDetailsSalesForDay(int day)
        {
            List<SaleWinFormDto> get = _saleWinFormDal.GetAllWinFormDtoDetails(s => s.Tarix.Day == day);
            //if (get == null)
            //{
            //    return new ErrorDataResult<List<SaleWinFormDto>>(SaleMessages.NotFound);
            //}
            return new SuccessDataResult<List<SaleWinFormDto>>(get, SaleMessages.Found);
        }

        [CacheAspect]
        public IDataResult<List<SaleWinFormDto>> GetAllSalewinFormDetailsSalesForMonth(int month)
        {

            List<SaleWinFormDto> get = _saleWinFormDal.GetAllWinFormDtoDetails(s => s.Tarix.Month == month);
            //if (get == null)
            //{
            //    return new ErrorDataResult<List<SaleWinFormDto>>(SaleMessages.NotFound);
            //}
            return new SuccessDataResult<List<SaleWinFormDto>>(get, SaleMessages.Found);
        }

        [CacheAspect]
        public IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDetailsSalesForYear(int year)
        {
            List<SaleWinFormDto> get = _saleWinFormDal.GetAllWinFormDtoDetails(s => s.Tarix.Year == year);
            //if (get == null)
            //{
            //    return new ErrorDataResult<List<SaleWinFormDto>>(SaleMessages.NotFound);
            //}
            return new SuccessDataResult<List<SaleWinFormDto>>(get, SaleMessages.Found);
        }

        [CacheAspect]
        public IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDetailsSalesForDayAndMonthAndYear(int day, int month, int year)
        {
            //List<SaleWinFormDto> get = _saleWinFormDal.GetAllWinFormDtoDetailsByDayAndMonthAndYear(day, month, year);
            List<SaleWinFormDto> get = _saleWinFormDal.GetAllWinFormDtoDetails(s =>s.Tarix.ToString().Contains(day.ToString())).Where(s => s.Tarix.ToString().Contains(month.ToString())).Where(s => s.Tarix.ToString().Contains(year.ToString())).ToList();
            //if (get == null)
            //{
            //    return new ErrorDataResult<List<SaleWinFormDto>>(SaleMessages.NotFound);
            //}
            return new SuccessDataResult<List<SaleWinFormDto>>(get, SaleMessages.Found);
        }

        [CacheAspect]
        public IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDetailsSalesForMonthAndYear(int month, int year)
        {
            //List<SaleWinFormDto> get = _saleWinFormDal.GetAllWinFormDtoDetailsByMonthAndYear(month, year);
            List<SaleWinFormDto> get = _saleWinFormDal.GetAllWinFormDtoDetails().Where(s => s.Tarix.ToString().Contains(month.ToString())).Where(s => s.Tarix.ToString().Contains(year.ToString())).ToList();
            //if (get == null)
            //{
            //    return new ErrorDataResult<List<SaleWinFormDto>>(SaleMessages.NotFound);
            //}
            return new SuccessDataResult<List<SaleWinFormDto>>(get, SaleMessages.Found);
        }


        //Business rules ---------------------->
        public IResult IsTheSaleStatusTrue(bool saleStatus)
        {
            if (saleStatus == false)
            {
                return new ErrorResult(SaleMessages.SaleCanBeCanceledOnce);
            }
            return new SuccessResult();
        }

        public IResult IsSuccess(IDataResult<SaleWinForm> getSale)
        {
            if (!getSale.Success)
            {
                return new ErrorResult(getSale.Message);
            }
            return new SuccessResult();
        }


    }
}

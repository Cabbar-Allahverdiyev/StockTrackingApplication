using Business.Abstract;
using Business.Constants.Messages;
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
using Business.ValidationRules.FluentValidation.SaleValidators;

namespace Business.Concrete
{
    public class SaleManager : ISaleService
    {
        ISaleDal _saleDal;
        IProductService _productService;
        public SaleManager(ISaleDal saleWinFormDal, IProductService productService)
        {
            _productService = productService;
            _saleDal = saleWinFormDal;
        }

        [ValidationAspect(typeof(CreateSaleValidator))]
        [CacheRemoveAspect("ISaleService.Get")]
        public IResult Add(Sale sale)
        {
            sale.SellDate = DateTime.Now;
            sale.SaleStatus = true;
            _saleDal.Add(sale);
            return new SuccessResult(SaleMessages.Added);
        }

        [ValidationAspect(typeof(UpdateSaleValidator))]
        [CacheRemoveAspect("ISaleService.Get")]
        public IResult Update(Sale sale)
        {
            //sale.SellDate = DateTime.Now;
            IResult rule = BusinessRules.Run(IsSaleExsists(sale.Id));
            if (rule != null)
            {
                return new ErrorResult(rule.Message);
            }
            _saleDal.Update(sale);
            return new SuccessResult(SaleMessages.Updated);
        }



        [CacheRemoveAspect("ISaleService.Get")]
        [ValidationAspect(typeof(UpdateSaleValidator))]
        public IResult CancelSale(Sale sale)
        {
            IDataResult<Sale> getSale = GetById(sale.Id);
            IResult result = BusinessRules.Run(IsTheSaleStatusTrue(getSale.Data.SaleStatus)
                                               , IsSuccess(getSale));

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

        [CacheRemoveAspect("ISaleService.Get")]
        public IResult Delete(Sale sale)
        {
            IResult rule = BusinessRules.Run(IsSaleExsists(sale.Id));
            if (rule != null)
            {
                return new ErrorResult(rule.Message);
            }
            _saleDal.Delete(sale);
            return new SuccessResult(SaleMessages.Deleted);
        }

        [CacheAspect]
        public IDataResult<List<Sale>> GetAll()
        {
            List<Sale> get = _saleDal.GetAll();
            //if (get == null)
            //{
            //    return new ErrorDataResult<List<SaleWinForm>>(SaleMessages.NotFound);
            //}
            return new SuccessDataResult<List<Sale>>(get, SaleMessages.GetAll);
        }

        public IDataResult<Sale> GetById(int id)
        {
            Sale get = _saleDal.Get(s => s.Id == id);
            if (get == null)
            {
                return new ErrorDataResult<Sale>(SaleMessages.NotFound);
            }
            return new SuccessDataResult<Sale>(get, SaleMessages.Found);
        }


        //DTOs----------------------->
        [CacheAspect]
        public IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDtoDetails()
        {
            List<SaleWinFormDto> get = _saleDal.GetAllWinFormDtoDetails();
            //if (get == null)
            //{
            //    return new ErrorDataResult<List<SaleWinFormDto>>(SaleMessages.NotFound);
            //}
            return new SuccessDataResult<List<SaleWinFormDto>>(get, SaleMessages.Found);
        }



        [CacheAspect]
        public IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDetailsSalesForDay(int day)
        {
            List<SaleWinFormDto> get = _saleDal.GetAllWinFormDtoDetails(s => s.Tarix.Day == day);
            //if (get == null)
            //{
            //    return new ErrorDataResult<List<SaleWinFormDto>>(SaleMessages.NotFound);
            //}
            return new SuccessDataResult<List<SaleWinFormDto>>(get, SaleMessages.Found);
        }

        [CacheAspect]
        public IDataResult<List<SaleWinFormDto>> GetAllSalewinFormDetailsSalesForMonth(int month)
        {

            List<SaleWinFormDto> get = _saleDal.GetAllWinFormDtoDetails(s => s.Tarix.Month == month);
            //if (get == null)
            //{
            //    return new ErrorDataResult<List<SaleWinFormDto>>(SaleMessages.NotFound);
            //}
            return new SuccessDataResult<List<SaleWinFormDto>>(get, SaleMessages.Found);
        }

        [CacheAspect]
        public IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDetailsSalesForYear(int year)
        {
            List<SaleWinFormDto> get = _saleDal.GetAllWinFormDtoDetails(s => s.Tarix.Year == year);
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
            List<SaleWinFormDto> get = _saleDal.GetAllWinFormDtoDetails(s => s.Tarix.Day.ToString().Equals(day.ToString())).Where(s => s.Tarix.Month.ToString().Equals(month.ToString())).Where(s => s.Tarix.Year.ToString().Equals(year.ToString())).ToList();
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
            List<SaleWinFormDto> get = _saleDal.GetAllWinFormDtoDetails().Where(s => s.Tarix.Month.ToString().Equals(month.ToString())).Where(s => s.Tarix.Year.ToString().Equals(year.ToString())).ToList();
            //if (get == null)
            //{
            //    return new ErrorDataResult<List<SaleWinFormDto>>(SaleMessages.NotFound);
            //}
            return new SuccessDataResult<List<SaleWinFormDto>>(get, SaleMessages.Found);
        }

        public IDataResult<List<SaleWinFormUserDto>> GetAllSaleWinFormUserDtoDetails()
        {
            List<SaleWinFormUserDto> get = _saleDal.GetAllWinFormUserDtoDetails();
            return new SuccessDataResult<List<SaleWinFormUserDto>>(get, SaleMessages.Found);
        }
        public IDataResult<List<SaleWinFormUserDto>> GetAllSaleWinFormDetailsUserSalesForDay(int day)
        {
            List<SaleWinFormUserDto> get = _saleDal.GetAllWinFormUserDtoDetails(s => s.Tarix.Day == day);
            return new SuccessDataResult<List<SaleWinFormUserDto>>(get, SaleMessages.Found);
        }

        public IDataResult<List<SaleWinFormUserDto>> GetAllSaleWinFormDetailsUserSalesForMonth(int month)
        {
            List<SaleWinFormUserDto> get = _saleDal.GetAllWinFormUserDtoDetails(s => s.Tarix.Month == month);
            return new SuccessDataResult<List<SaleWinFormUserDto>>(get, SaleMessages.Found);
        }

        public IDataResult<List<SaleWinFormUserDto>> GetAllSaleWinFormDetailsUserSalesForYear(int year)
        {
            List<SaleWinFormUserDto> get = _saleDal.GetAllWinFormUserDtoDetails(s => s.Tarix.Year == year);
            return new SuccessDataResult<List<SaleWinFormUserDto>>(get, SaleMessages.Found);
        }

        public IDataResult<List<SaleWinFormUserDto>> GetAllSaleWinFormDetailsUserSalesForDayAndMonthAndYear(int day, int month, int year)
        {
            List<SaleWinFormUserDto> get = _saleDal.GetAllWinFormUserDtoDetails(s => s.Tarix.Day.ToString().Equals(day.ToString())).Where(s => s.Tarix.Month.ToString().Equals(month.ToString())).Where(s => s.Tarix.Year.ToString().Equals(year.ToString())).ToList();
            return new SuccessDataResult<List<SaleWinFormUserDto>>(get, SaleMessages.Found);
        }

        public IDataResult<List<SaleWinFormUserDto>> GetAllSaleWinFormDetailsUserSalesForMonthAndYear(int month, int year)
        {
            List<SaleWinFormUserDto> get = _saleDal.GetAllWinFormUserDtoDetails().Where(s => s.Tarix.Month.ToString().Equals(month.ToString())).Where(s => s.Tarix.Year.ToString().Equals(year.ToString())).ToList();
            return new SuccessDataResult<List<SaleWinFormUserDto>>(get, SaleMessages.Found);
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

        public IResult IsSuccess(IDataResult<Sale> getSale)
        {
            if (!getSale.Success)
            {
                return new ErrorResult(getSale.Message);
            }
            return new SuccessResult();
        }

        private IResult IsSaleExsists(int id)
        {
            IResult result = this.GetById(id);
            if (result.Success)
            {
                return new SuccessResult();
            }
            return new ErrorResult(result.Message);
        }


    }
}

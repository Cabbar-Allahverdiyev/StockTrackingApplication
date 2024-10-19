using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.SaleWinFormDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISaleService
    {
        IDataResult<List<Sale>> GetAll();
        IResult Add(Sale saleWinForm);
        IResult Update(Sale saleWinForm);
        IResult Delete(Sale saleWinForm);

        IResult CancelSale(Sale saleWinForm);

        IDataResult<Sale> GetById(int id);

        //SaleWinFormDto
        IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDtoDetails();       
        IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDetailsSalesForDay(int day);
        IDataResult<List<SaleWinFormDto>> GetAllSalewinFormDetailsSalesForMonth(int month);
        IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDetailsSalesForYear(int year);
        IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDetailsSalesForDayAndMonthAndYear(int day, int month, int year);
        IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDetailsSalesForMonthAndYear(int month, int year);

        IDataResult<List<SaleWinFormUserDto>> GetAllSaleWinFormUserDtoDetails();
        IDataResult<List<SaleWinFormUserDto>> GetAllSaleWinFormDetailsUserSalesForDay(int day);
        IDataResult<List<SaleWinFormUserDto>> GetAllSaleWinFormDetailsUserSalesForMonth(int month);
        IDataResult<List<SaleWinFormUserDto>> GetAllSaleWinFormDetailsUserSalesForYear(int year);
        IDataResult<List<SaleWinFormUserDto>> GetAllSaleWinFormDetailsUserSalesForDayAndMonthAndYear(int day, int month, int year);
        IDataResult<List<SaleWinFormUserDto>> GetAllSaleWinFormDetailsUserSalesForMonthAndYear(int month, int year);
    }
}

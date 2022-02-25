﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.SaleWinFormDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISaleWinFormService
    {
        IDataResult<List<SaleWinForm>> GetAll();
        IResult Add(SaleWinForm saleWinForm);
        IResult Update(SaleWinForm saleWinForm);
        IResult Delete(SaleWinForm saleWinForm);

        IDataResult<SaleWinForm> GetById(int id);

        //SaleWinFormDto
        IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDtoDetails();
        IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDetailsSalesForDay(int day);
        IDataResult<List<SaleWinFormDto>> GetAllSalewinFormDetailsSalesForMonth(int month);
        IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDetailsSalesForYear(int year);
        IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDetailsSalesForDayAndMonthAndYear(int day, int month, int year);
        IDataResult<List<SaleWinFormDto>> GetAllSaleWinFormDetailsSalesForMonthAndYear(int month, int year);

    }
}

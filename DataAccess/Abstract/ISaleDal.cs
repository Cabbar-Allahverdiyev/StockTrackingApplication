using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs.SaleWinFormDtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISaleDal : IEntityRepository<Sale>
    {
        List<SaleWinFormDto> GetAllWinFormDtoDetails(Expression<Func<SaleWinFormDto, bool>> filter = null);
        //List<SaleWinFormDto> GetAllWinFormDtoDetailsByTopSelling(Expression<Func<SaleWinFormDto, bool>> filter = null);
        //List<SaleWinFormDto> GetAllWinFormDtoDetailsByDecreasingProducts(Expression<Func<SaleWinFormDto, bool>> filter = null);
        //List<SaleWinFormDto> GetAllWinFormDtoDetailsByProductsThatNeverSell(Expression<Func<SaleWinFormDto, bool>> filter = null);
        //List<SaleWinFormDto> GetAllWinFormDtoDetailsByFinishedProducts(Expression<Func<SaleWinFormDto, bool>> filter = null);

        //List<SaleWinFormDto> GetAllWinFormDtoDetailsByDayAndMonthAndYear(int day, int month, int year);
        //List<SaleWinFormDto> GetAllWinFormDtoDetailsByMonthAndYear(int month, int year);

    }
}

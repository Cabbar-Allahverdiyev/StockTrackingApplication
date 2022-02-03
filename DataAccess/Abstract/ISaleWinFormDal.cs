using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISaleWinFormDal : IEntityRepository<SaleWinForm>
    {
        List<SaleWinFormDto> GetAllWinFormDtoDetails(Expression<Func<SaleWinFormDto, bool>> filter = null);
        List<SaleWinFormDto> GetAllWinFormDtoDetailsByDayAndMonthAndYear(int day, int month, int year);
    }
}

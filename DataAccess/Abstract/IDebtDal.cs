using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs.BonusCardDtos;
using Entities.DTOs.DebtDtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IDebtDal: IEntityRepository<Debt>
    {
        List<DebtDto> GetAllDebtDetail(Expression<Func<DebtDto, bool>> filter = null);
    }
}

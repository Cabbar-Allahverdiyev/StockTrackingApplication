using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs.BonusCardOperationDto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBonusCardOperationDal:IEntityRepository<BonusCardOperation>
    {
        List<BonusCardOperationForFormsDto> GetAllBonusCardOperationForFormsDto(Expression<Func<BonusCardOperationForFormsDto,bool>> filter=null);
        BonusCardOperationForFormsDto GetBonusCardOperationForFormsDto(Expression<Func<BonusCardOperationForFormsDto,bool>> filter);
        List<BonusCardOperationForFormsDto> GetAllBonusCardOperationForFormsDtoByIncreasedBalance(Expression<Func<BonusCardOperationForFormsDto,bool>> filter=null);
        List<BonusCardOperationForFormsDto> GetAllBonusCardOperationForFormsDtoByReducedBalance(Expression<Func<BonusCardOperationForFormsDto,bool>> filter=null);
    }
}

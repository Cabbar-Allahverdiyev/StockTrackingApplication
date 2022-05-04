using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs.BonusCardDtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBonusCardDal : IEntityRepository<BonusCard>
    {
        List<BonusCardForFormsDto> GetBonusCardDetails(Expression<Func<BonusCardForFormsDto, bool>> filter = null);
    }
}

using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs.UserOperationClaimDtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserOperationClaimForFormsDal : IEntityRepository<UserOperationClaimForForms>
    {
        List<UserOperationClaimDto> GetUserOperationClaimDetails(Expression<Func<UserOperationClaimDto, bool>> filter = null);
    }
}

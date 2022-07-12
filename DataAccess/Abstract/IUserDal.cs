using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs.UserDtos;
using Entities.Concrete.ForForms;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<UserDto> GetUserDetails(Expression<Func<UserDto, bool>> filter = null);
        UserDto GetUserDetail(Expression<Func<UserDto, bool>> filter);
        List<OperationClaim> GetClaims(User user);
        List<OperationClaimForForms> GetClaimsForForms(User user);
    }
}

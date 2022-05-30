using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.ForForms;
using Entities.DTOs.UserOperationClaimDtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using Entities.Concrete.ForForms;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserOperationClaimForFormsDal : EfEntityRepositoryBase<UserOperationClaimForForms, StockTrackingProjectContext>
                                                 , IUserOperationClaimForFormsDal
    {
        public List<UserOperationClaimDto> GetUserOperationClaimDetails(Expression<Func<UserOperationClaimDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from userClaim in context.UserOperationClaimsForForms
                             join user in context.Users on userClaim.UserId equals user.Id
                             join claim in context.OperationClaimsForForms on userClaim.OperationClaimId equals claim.Id
                             
                             select new UserOperationClaimDto
                             {
                                Id=userClaim.Id,
                                FirstName=user.FirstName,
                                LastName=user.LastName,
                                ClaimName=claim.Name

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}

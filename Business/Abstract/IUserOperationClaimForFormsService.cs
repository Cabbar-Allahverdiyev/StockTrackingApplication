using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserOperationClaimForFormsService
    {
        IDataResult<List<UserOperationClaimForForms>> GetAll();
        IResult Add(UserOperationClaimForForms operationClaim);
        IResult Update(UserOperationClaimForForms operationClaim);
        IResult Delete(UserOperationClaimForForms operationClaim);
        IDataResult<UserOperationClaimForForms> GetById(int id);

        IDataResult<UserOperationClaimForForms> GetByUserId(int userId);
    }
}

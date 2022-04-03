using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface IOperationClaimForFormsService
    {
        IDataResult<List<OperationClaimForForms>> GetAll();
        IResult Add(OperationClaimForForms operationClaim);
        IResult Update(OperationClaimForForms operationClaim);
        IResult Delete(OperationClaimForForms operationClaim);
        IDataResult<OperationClaimForForms> GetById(int id);

        
    }
}

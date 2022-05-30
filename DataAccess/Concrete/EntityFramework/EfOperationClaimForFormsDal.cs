using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.ForForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOperationClaimForFormsDal :EfEntityRepositoryBase<OperationClaimForForms, StockTrackingProjectContext>,
                                        IOperationClaimForFormsDal
    {
    }
}

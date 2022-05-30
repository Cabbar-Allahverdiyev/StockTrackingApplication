using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.ForForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFormSettingDal:EfEntityRepositoryBase<FormSetting,StockTrackingProjectContext>,IFormSettingDal
    {
    }
}

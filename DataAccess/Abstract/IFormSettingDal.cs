using Core.DataAccess;
using Entities.Concrete;
using Entities.Concrete.ForForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IFormSettingDal :IEntityRepository<FormSetting>
    {
    }
}

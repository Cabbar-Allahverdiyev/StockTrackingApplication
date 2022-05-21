using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFormSettingService
    {
        IDataResult<List<FormSetting>> GetAll();
        IResult Add(FormSetting formSetting);
        IResult Update(FormSetting formSetting);
        IResult Delete(FormSetting formSetting);
        IDataResult<FormSetting> GetById(int id);
    }
}

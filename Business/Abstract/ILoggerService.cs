using Core.Utilities.Results;
using Entities.Concrete.ForForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ILoggerService
    {
        IDataResult<List<Log>> GetAll();
        IResult Add(Log log);
        IResult Update(Log log);
        IResult Delete(Log log);
        IDataResult<Log> GetById(int id);
    }
}

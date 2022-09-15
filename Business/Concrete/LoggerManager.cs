using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete.ForForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class LoggerManager : ILoggerService
    {
        private readonly ILogDal _logDal;

        public LoggerManager(ILogDal logDal)
        {
            _logDal = logDal;
        }


        public IResult Add(Log log)
        {
            _logDal.Add(log);
            return new SuccessResult();
        }

        public IResult Delete(Log log)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Log>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Log> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Log log)
        {
            throw new NotImplementedException();
        }
    }
}

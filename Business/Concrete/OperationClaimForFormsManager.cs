using Business.Abstract;
using Business.Constants.Messages;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete.ForForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class OperationClaimForFormsManager : IOperationClaimForFormsService
    {
        IOperationClaimForFormsDal _operationClaimForFormsDal;

        public OperationClaimForFormsManager(IOperationClaimForFormsDal operationClaimForFormsDal)
        {
            _operationClaimForFormsDal = operationClaimForFormsDal;
        }

        [CacheRemoveAspect("IOperationClaimForFormsService.Get")]
        public IResult Add(OperationClaimForForms operationClaim)
        {
            IResult result = GetAllByName(operationClaim.Name);
            if (result.Success)
            {
                _operationClaimForFormsDal.Add(operationClaim);
                return new SuccessResult(OperationClaimForFormsMessages.Added);
            }
            return new ErrorResult(OperationClaimForFormsMessages.NotAdded);
        }

        [CacheRemoveAspect("IOperationClaimForFormsService.Get")]
        public IResult Delete(OperationClaimForForms operationClaim)
        {
            _operationClaimForFormsDal.Delete(operationClaim);
            return new SuccessResult(OperationClaimForFormsMessages.Deleted);
        }

        [CacheRemoveAspect("IOperationClaimForFormsService.Get")]
        public IResult Update(OperationClaimForForms operationClaim)
        {
            _operationClaimForFormsDal.Update(operationClaim);
            return new SuccessResult(OperationClaimForFormsMessages.Updated);
        }

        [CacheAspect]
        public IDataResult<List<OperationClaimForForms>> GetAll()
        {
            List<OperationClaimForForms> get = _operationClaimForFormsDal.GetAll();
            return new SuccessDataResult<List<OperationClaimForForms>>(get, OperationClaimForFormsMessages.GetAll);
        }

        [CacheAspect]
        public IDataResult<OperationClaimForForms> GetById(int id)
        {
            OperationClaimForForms get = _operationClaimForFormsDal.Get(c => c.Id == id);
            if (get == null)
            {
                return new ErrorDataResult<OperationClaimForForms>(OperationClaimForFormsMessages.NotFound);
            }
            return new SuccessDataResult<OperationClaimForForms>(get, OperationClaimForFormsMessages.Found);
        }

        public IDataResult<OperationClaimForForms> GetByName(string claimName)
        {
            OperationClaimForForms get = _operationClaimForFormsDal.Get(c => 
            c.Name.ToLower() == claimName.ToLower(new CultureInfo("en-Us", false)));
            if (get == null)
            {
                return new ErrorDataResult<OperationClaimForForms>(OperationClaimForFormsMessages.NotFound);
            }
            return new SuccessDataResult<OperationClaimForForms>(get, OperationClaimForFormsMessages.Found);

        }

        [CacheAspect]
        public IDataResult<List<OperationClaimForForms>> GetAllByName(string claimName)
        {
            List<OperationClaimForForms> get = _operationClaimForFormsDal.GetAll(b => b.Name == claimName);
            if (get == null)
            {
                return new ErrorDataResult<List<OperationClaimForForms>>(OperationClaimForFormsMessages.NotFound);
            }
            return new SuccessDataResult<List<OperationClaimForForms>>(get, OperationClaimForFormsMessages.GetAll);
        }

        [CacheAspect]
        public IDataResult<List<OperationClaimForForms>> GetAllButTheBoss()
        {
            List<OperationClaimForForms> get = _operationClaimForFormsDal.GetAll().SkipLast(1).ToList();
            
            if (get == null)
            {
                return new ErrorDataResult<List<OperationClaimForForms>>(OperationClaimForFormsMessages.NotFound);
            }
            return new SuccessDataResult<List<OperationClaimForForms>>(get, OperationClaimForFormsMessages.GetAll);
        }

       
    }
}

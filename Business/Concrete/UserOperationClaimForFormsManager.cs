using Business.Abstract;
using Business.Constants.Messages;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.ForForms;
using Entities.DTOs.UserOperationClaimDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserOperationClaimForFormsManager : IUserOperationClaimForFormsService
    {
        IUserOperationClaimForFormsDal _userOperationClaimForFormsDal;

        public UserOperationClaimForFormsManager(IUserOperationClaimForFormsDal userOperationClaimForFormsDal)
        {
            _userOperationClaimForFormsDal = userOperationClaimForFormsDal;
        }

        [CacheRemoveAspect("IUserOperationClaimForFormsService.Get")]
        public IResult Add(UserOperationClaimForForms operationClaim)
        {
            IResult result = BusinessRules.Run(NotChangeTheBoss(operationClaim));
            if (result != null)
            {
                return new ErrorDataResult<Product>(result.Message);
            }
            _userOperationClaimForFormsDal.Add(operationClaim);
            return new SuccessResult(UserOperationClaimForFormsMessages.Added);
        }

        [CacheRemoveAspect("IUserOperationClaimForFormsService.Get")]
        public IResult Delete(UserOperationClaimForForms operationClaim)
        {
            _userOperationClaimForFormsDal.Delete(operationClaim);
            return new SuccessResult(UserOperationClaimForFormsMessages.Deleted);
        }

        [CacheRemoveAspect("IUserOperationClaimForFormsService.Get")]
        public IResult Update(UserOperationClaimForForms operationClaim)
        {
            _userOperationClaimForFormsDal.Update(operationClaim);
            return new SuccessResult(UserOperationClaimForFormsMessages.Updated);
        }

        [CacheAspect]
        public IDataResult<List<UserOperationClaimForForms>> GetAll()
        {
            List<UserOperationClaimForForms> get = _userOperationClaimForFormsDal.GetAll();
            return new SuccessDataResult<List<UserOperationClaimForForms>>(get, UserOperationClaimForFormsMessages.GetAll);
        }

        [CacheAspect]
        public IDataResult<UserOperationClaimForForms> GetById(int id)
        {
            UserOperationClaimForForms get = _userOperationClaimForFormsDal.Get(c => c.Id == id);
            if (get == null)
            {
                return new ErrorDataResult<UserOperationClaimForForms>(UserOperationClaimForFormsMessages.NotFound);
            }
            return new SuccessDataResult<UserOperationClaimForForms>(get, UserOperationClaimForFormsMessages.Found);
        }


        public IDataResult<UserOperationClaimForForms> GetByUserId(int userId)
        {

            UserOperationClaimForForms get = _userOperationClaimForFormsDal.Get(c => c.Id == userId);
            if (get == null)
            {
                return new ErrorDataResult<UserOperationClaimForForms>(UserOperationClaimForFormsMessages.NotFound);
            }
            return new SuccessDataResult<UserOperationClaimForForms>(get, UserOperationClaimForFormsMessages.Found);
        }

        public IDataResult<List<UserOperationClaimForForms>> GetAllOperationClaimByUserId(int userId)
        {
            List<UserOperationClaimForForms> get = _userOperationClaimForFormsDal.GetAll(u=>u.UserId==userId);
            if (get.Count==0)
            {
                return new ErrorDataResult<List<UserOperationClaimForForms>>( UserOperationClaimForFormsMessages.NotFound);
            }
            return new SuccessDataResult<List<UserOperationClaimForForms>>(get, UserOperationClaimForFormsMessages.Found);
        }

        //Dtos
        public IDataResult<List<UserOperationClaimDto>> GetAllUserOperationClaimDtoDetails()
        {

            List<UserOperationClaimDto> get = _userOperationClaimForFormsDal.GetUserOperationClaimDetails();
            return new SuccessDataResult<List<UserOperationClaimDto>>(get, UserOperationClaimForFormsMessages.GetAll);
        }

        //elave
        private IResult NotChangeTheBoss(UserOperationClaimForForms operationClaim)
        {
            if (operationClaim.UserId == 3002)
            {
                return new ErrorResult(UserOperationClaimForFormsMessages.NotAdded);
            }
            if (operationClaim.OperationClaimId == 4)
            {
                return new ErrorResult(UserOperationClaimForFormsMessages.NotAdded);
            }
            return new SuccessResult();
        }

       
    }
}

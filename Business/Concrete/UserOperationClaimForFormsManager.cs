using Business.Abstract;
using Business.Constants.Messages;
using Core.Aspects.Autofac.Caching;
using Core.Entities.Concrete;
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
        IUserService _userService;
        IUserOperationClaimForFormsDal _userOperationClaimForFormsDal;
        IOperationClaimForFormsService _operationClaimService;

        public UserOperationClaimForFormsManager(IUserOperationClaimForFormsDal userOperationClaimForFormsDal,
            IUserService userService,
            IOperationClaimForFormsService operationClaimService)
        {
            _userOperationClaimForFormsDal = userOperationClaimForFormsDal;
            _userService = userService;
            _operationClaimService = operationClaimService;
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
        public IResult Delete(int id)
        {

            UserOperationClaimForForms claim = null;
            IResult rule = BusinessRules.Run(UserClaimIsExist(id,out claim),
                                             IsNotUserBoss(claim));
            if (rule != null)
            {
                return new ErrorResult(rule.Message);
            }
            _userOperationClaimForFormsDal.Delete(claim);
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
            //if (operationClaim.UserId !=
            //    _userService.GetUserDetailByUserName("Cabbar","Allahverdiyev").Data.UserId)
            //{
            //    return new ErrorResult(UserOperationClaimForFormsMessages.NotAdded);
            //}
            if (operationClaim.OperationClaimId == _operationClaimService.GetByName("Boss").Data.Id
                && operationClaim.UserId !=
                _userService.GetUserDetailByUserName("Cabbar", "Allahverdiyev").Data.UserId)
            {
                return new ErrorResult(UserOperationClaimForFormsMessages.NotAdded);
            }
            return new SuccessResult();
        }

       private IResult IsNotUserBoss(UserOperationClaimForForms operationClaim)
        {
            if (operationClaim.OperationClaimId==_operationClaimService
                .GetByName("Boss").Data.Id)                
            {
                return new ErrorResult(UserOperationClaimForFormsMessages.UserIsBoss);
            }
            return new SuccessResult();

        }
        private IResult UserClaimIsExist(int userClaimId,out UserOperationClaimForForms userOperationClaim)
        {
            IDataResult<UserOperationClaimForForms> userClaim = GetById(userClaimId);
            if (userClaim.Success)
            {
                userOperationClaim = userClaim.Data;
                return new SuccessResult();
            }
            userOperationClaim = null;
            return new ErrorResult(UserOperationClaimForFormsMessages.NotFound);
        }
    }
}

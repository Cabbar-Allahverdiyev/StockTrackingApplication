using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.BonusCardOperationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Business.Concrete
{
    public class BonusCardOperationManager : IBonusCardOperationService
    {
        IBonusCardOperationDal _bonusCardOperationDal;
        IUserService _userService;

        public BonusCardOperationManager(IBonusCardOperationDal bonusCardOperationDal,IUserService userService)
        {
            _bonusCardOperationDal = bonusCardOperationDal;
            _userService = userService;
        }

        [ValidationAspect(typeof(BonusCardOperationValidator))]
        [CacheRemoveAspect("IBonusCardOperationService.Get")]
        public IResult Add(BonusCardOperation cardOperation)
        {
            cardOperation.Date = DateTime.Now;
            _bonusCardOperationDal.Add(cardOperation);
            return new SuccessResult(BonusCardOperationMessages.Added);
        }

        [CacheRemoveAspect("IBonusCardOperationService.Get")]
        public IResult Delete(BonusCardOperation cardOperation)
        {
            _bonusCardOperationDal.Delete(cardOperation);
            return new SuccessResult(BonusCardOperationMessages.Deleted);
        }

        [ValidationAspect(typeof(BonusCardOperationValidator))]
        [CacheRemoveAspect("IBonusCardOperationService.Get")]
        public IResult Update(BonusCardOperation cardOperation)
        {
            _bonusCardOperationDal.Update(cardOperation);
            return new SuccessResult(BonusCardOperationMessages.Updated);
        }

        [CacheAspect]
        public IDataResult<List<BonusCardOperation>> GetAll()
        {
            List<BonusCardOperation> result = _bonusCardOperationDal.GetAll();
            return new SuccessDataResult<List<BonusCardOperation>>(result, BonusCardMessages.GetAll);
        }

        [CacheAspect]
        public IDataResult<BonusCardOperation> GetById(int id)
        {
            BonusCardOperation result = _bonusCardOperationDal.Get(o => o.Id == id);
            if (result == null)
            {
                return new ErrorDataResult<BonusCardOperation>(BonusCardMessages.NotFound);
            }
            return new SuccessDataResult<BonusCardOperation>(result, BonusCardMessages.Found);
        }


        [CacheAspect]
        public IDataResult<List<BonusCardOperationForFormsDto>> GetAllBonusCardOperationForFormsDto()
        {
            List<BonusCardOperationForFormsDto> result = _bonusCardOperationDal.GetAllBonusCardOperationForFormsDto();
            return new SuccessDataResult<List<BonusCardOperationForFormsDto>>(result, BonusCardMessages.GetAll);
        }

        [CacheAspect]
        public IDataResult<List<BonusCardOperationForFormsDto>> GetAllBonusCardOperationForFormsDtoByIncreasedBalance()
        {
            List<BonusCardOperationForFormsDto> result = _bonusCardOperationDal
                                                        .GetAllBonusCardOperationForFormsDtoByIncreasedBalance();
            return new SuccessDataResult<List<BonusCardOperationForFormsDto>>(result, BonusCardMessages.GetAll);
        }

        [CacheAspect]
        public IDataResult<List<BonusCardOperationForFormsDto>> GetAllBonusCardOperationForFormsDtoByReducedBalance()
        {
            List<BonusCardOperationForFormsDto> result = _bonusCardOperationDal
                                                        .GetAllBonusCardOperationForFormsDtoByReducedBalance();
            return new SuccessDataResult<List<BonusCardOperationForFormsDto>>(result, BonusCardMessages.GetAll);
        }

        [CacheAspect]
        public IDataResult<BonusCardOperationForFormsDto> GetBonusCardOperationForFormsDtoById(int id)
        {
            BonusCardOperationForFormsDto result = _bonusCardOperationDal
                                                        .GetBonusCardOperationForFormsDto(o => o.OperationId == id);
            if (result == null)
            {
                return new ErrorDataResult<BonusCardOperationForFormsDto>(result, BonusCardMessages.NotFound);
            }
            return new SuccessDataResult<BonusCardOperationForFormsDto>(result, BonusCardMessages.Found);
        }

        public IResult IncreasedBalance(BonusCard bonusCard, int userId, decimal value)
        {
            var rules=BusinessRules.Run(IsUserIdExists(userId),GreaterThanZero(value));
            if (rules!=null)
            {
                return new ErrorResult(rules.Message);
            }

            BonusCardOperation bonusCardOperation = new BonusCardOperation();
            bonusCardOperation.BonusCardId = bonusCard.Id;
            bonusCardOperation.UserId = userId;
            bonusCardOperation.Value = value;
            bonusCardOperation.IsIncreasedBalance = true;
            bonusCardOperation.Status = true;

            IResult operationAdded = this.Add(bonusCardOperation);
            if (!operationAdded.Success)
            {
                return new ErrorResult(operationAdded.Message);
            }
            return new SuccessResult(operationAdded.Message);
        }


        public IResult ReducedBalance(BonusCard bonusCard, int userId, decimal value)
        {
            var rules = BusinessRules.Run(IsUserIdExists(userId), GreaterThanZero(value));
            if (rules != null)
            {
                return new ErrorResult(rules.Message);
            }
            BonusCardOperation bonusCardOperation = new BonusCardOperation();
            bonusCardOperation.BonusCardId = bonusCard.Id;
            bonusCardOperation.UserId = userId;
            bonusCardOperation.Value = value;
            bonusCardOperation.IsIncreasedBalance = false;
            bonusCardOperation.Status = true;

            IResult operationAdded = this.Add(bonusCardOperation);
            if (!operationAdded.Success)
            {
                return new ErrorResult(operationAdded.Message);
            }
            return new SuccessResult(operationAdded.Message);
        }

        public IDataResult<List<BonusCardOperationForFormsDto>> GetAllSaleWinFormDetailsSalesForMonthAndYear(int month, int year)
        {
            List<BonusCardOperationForFormsDto> get = _bonusCardOperationDal
                 .GetAllBonusCardOperationForFormsDto()
                 .Where(s => s.Tarix.Month.ToString().Contains(month.ToString()))
                 .Where(s => s.Tarix.Year.ToString().Contains(year.ToString())).ToList();
            ;
            return new SuccessDataResult<List<BonusCardOperationForFormsDto>>(get, SaleMessages.Found);
        }

        public IDataResult<List<BonusCardOperationForFormsDto>> GetAllSaleWinFormDetailsSalesForYear(int year)
        {
            List<BonusCardOperationForFormsDto> get = _bonusCardOperationDal
               .GetAllBonusCardOperationForFormsDto(b=>b.Tarix.Year==year);
            return new SuccessDataResult<List<BonusCardOperationForFormsDto>>(get, SaleMessages.Found);
        }

        public IDataResult<List<BonusCardOperationForFormsDto>> GetAllSaleWinFormDetailsSalesForDayAndMonthAndYear(int day, int month, int year)
        {
            List<BonusCardOperationForFormsDto> get = _bonusCardOperationDal
                .GetAllBonusCardOperationForFormsDto(s => s.Tarix.Day.ToString().Contains(day.ToString()))
                    .Where(s => s.Tarix.Month.ToString().Contains(month.ToString()))
                    .Where(s => s.Tarix.Year.ToString().Contains(year.ToString())).ToList();
            return new SuccessDataResult<List<BonusCardOperationForFormsDto>>(get, SaleMessages.Found);
        }
        //busines rules
        private IResult IsUserIdExists(int userId)
        {
            if (_userService.GetById(userId).Success)
            {
                return new SuccessResult();
            }
            return new ErrorResult(UserMessages.UserNotAvailable);
        }

        private IResult GreaterThanZero(decimal value)
        {
            if (value<=0)
            {
                return new ErrorResult(BonusCardMessages.MustNotBeEqualToOrLessThanZero);
            }
            return new SuccessResult();
        }
    }
}

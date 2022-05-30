using Business.Abstract;
using Business.Constants.Messages;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.BonusCardOperationDto;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class BonusCardOperationManager : IBonusCardOperationService
    {
        IBonusCardOperationDal _bonusCardOperationDal;

        public BonusCardOperationManager(IBonusCardOperationDal bonusCardOperationDal)
        {
            _bonusCardOperationDal = bonusCardOperationDal;
        }

        [ValidationAspect(typeof(BonusCardOperationValidator))]
        [CacheRemoveAspect("IBonusCardOperationService.Get")]
        public IResult Add(BonusCardOperation cardOperation)
        {
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
            return new SuccessDataResult<List<BonusCardOperation>>(result,BonusCardMessages.GetAll);
        }

        [CacheAspect]
        public IDataResult<BonusCardOperation> GetById(int id)
        {
            BonusCardOperation result = _bonusCardOperationDal.Get(o=> o.Id ==id);
            if (result==null)
            {
                return new ErrorDataResult<BonusCardOperation>( BonusCardMessages.NotFound);
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
                                                        .GetBonusCardOperationForFormsDto(o=>o.OperationId==id);
            if (result== null)
            {
                return new ErrorDataResult<BonusCardOperationForFormsDto>(result, BonusCardMessages.NotFound);
            }
            return new SuccessDataResult<BonusCardOperationForFormsDto>(result, BonusCardMessages.Found);
        }

        public IResult IncreasedBalance(BonusCard bonusCard, int userId, decimal value)
        {
            BonusCardOperation bonusCardOperation=new BonusCardOperation();
            bonusCardOperation.BonusCardId = bonusCard.Id;
            bonusCardOperation.UserId = userId;
            bonusCardOperation.Value = value ;
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
            BonusCardOperation bonusCardOperation = new BonusCardOperation();
            bonusCardOperation.BonusCardId = bonusCard.Id;
            bonusCardOperation.UserId = userId;
            bonusCardOperation.Value = value ;
            bonusCardOperation.IsIncreasedBalance = false;
            bonusCardOperation.Status = true;

            IResult operationAdded = this.Add(bonusCardOperation);
            if (!operationAdded.Success)
            {
                return new ErrorResult(operationAdded.Message);
            }
            return new SuccessResult(operationAdded.Message);
        }
    }
}

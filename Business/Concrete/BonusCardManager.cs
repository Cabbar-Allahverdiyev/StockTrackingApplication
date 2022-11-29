using Business.Abstract;
using Business.Constants.Dictionaries;
using Business.Constants.Enums;
using Business.Constants.Messages;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.ForForms;
using Entities.DTOs.BonusCardDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BonusCardManager : IBonusCardService
    {

        IBonusCardDal _bonusCardDal;

        ICustomerService _customerService;
        IBonusCardOperationService _bonusCardOperationService;
        IFormSettingService _formSettingService;
        public BonusCardManager(IBonusCardDal bonusCardDal,
                                ICustomerService customerService,
                                IBonusCardOperationService bonusCardOperationService,
                                IFormSettingService formSettingService)
        {
            _bonusCardDal = bonusCardDal;
            _customerService = customerService;
            _bonusCardOperationService = bonusCardOperationService;
            _formSettingService = formSettingService;
        }
        //CRUD
        [ValidationAspect(typeof(BonusCardValidator))]
        [CacheRemoveAspect("IBonusCardService.Get")]
        public IResult Add(BonusCard bonusCard)
        {

            var rules = BusinessRules.Run(DoesTheCustomerHaveABonusCard(bonusCard.CustomerId),
                                          IsThereAnotherBonusCardInThisBarcode(bonusCard.BarcodeNumber),
                                          IsBarcodeNumberLenthVerified(bonusCard.BarcodeNumber)
                                        );
            if (rules != null)
            {
                return new ErrorResult(rules.Message);
            }

            bonusCard.Balance = 0;
            bonusCard.InterestAdvantage = bonusCard.InterestAdvantage == default ? 0 : bonusCard.InterestAdvantage;
            _bonusCardDal.Add(bonusCard);
            return new SuccessResult(BonusCardMessages.Added);
        }

        [CacheRemoveAspect("IBonusCardService.Get")]
        public IResult Delete(BonusCard bonusCard)
        {
            var rules = BusinessRules.Run(GetById(bonusCard.Id));
            if (rules != null)
            {
                return new ErrorResult(rules.Message);
            }
            IDataResult<BonusCard> result =GetById(bonusCard.Id);
            
            _bonusCardDal.Delete(result.Data);
            Customer customer = _customerService.GetById(result.Data.CustomerId).Data;
            return new SuccessResult(BonusCardMessages.Deleted(customer.FirstName + " " + customer.LastName));
        }

        [ValidationAspect(typeof(BonusCardValidator))]
        [CacheRemoveAspect("IBonusCardService.Get")]
        public IResult Update(BonusCard bonusCard)
        {
            var rules = BusinessRules.Run(DoesTheCustomerHaveABonusCardForUpdate(bonusCard),
                                          IsThereAnotherBonusCardInThisBarcodeForUpdate(bonusCard),
                                          IsBarcodeNumberLenthVerified(bonusCard.BarcodeNumber)
                                        );
            if (rules != null)
            {
                return new ErrorResult(rules.Message);
            }
            _bonusCardDal.Update(bonusCard);
            return new SuccessResult(BonusCardMessages.Updated);
        }


        [CacheAspect]
        public IDataResult<List<BonusCard>> GetAll()
        {
            List<BonusCard> get = _bonusCardDal.GetAll();
            return new SuccessDataResult<List<BonusCard>>(get, BonusCardMessages.GetAll);
        }

        [CacheAspect]
        public IDataResult<BonusCard> GetById(int id)
        {
            BonusCard get = _bonusCardDal.Get(b => b.Id == id);
            if (get == null)
            {
                return new ErrorDataResult<BonusCard>(BonusCardMessages.NotFound);
            }
            return new SuccessDataResult<BonusCard>(get, BonusCardMessages.Found);
        }

        // --------------->

        public IDataResult<BonusCard> GetByCustomerId(int customerId)
        {

            BonusCard get = _bonusCardDal.Get(b => b.CustomerId == customerId);
            if (get == null)
            {
                return new ErrorDataResult<BonusCard>(BonusCardMessages.NotFound);
            }
            return new SuccessDataResult<BonusCard>(get, BonusCardMessages.Found);
        }

        [CacheAspect]
        public IDataResult<BonusCard> GetByBarcodeNumber(string barcodeNumber)
        {
            BonusCard get = _bonusCardDal.Get(b => b.BarcodeNumber == barcodeNumber);
            if (get == null)
            {
                return new ErrorDataResult<BonusCard>(BonusCardMessages.NotFound);
            }
            return new SuccessDataResult<BonusCard>(get, BonusCardMessages.Found);
        }

        [CacheRemoveAspect("IBonusCardService.Get")]
        public IDataResult<decimal> IncreaseBalance(int cardId, int userId, decimal value, decimal interestedAdvantage)
        {
            IResult rules = BusinessRules.Run(BonusCardIdExist(cardId)
                                            , IsValueGreaterThanZero(value)
                                            , IsCustomerExistsInterestedAdvantage(cardId, ref interestedAdvantage)
                                            , CalCulateValue(ref value, interestedAdvantage));
            if (rules != null)
            {
                return new ErrorDataResult<decimal>(rules.Message);
            }
            IDataResult<BonusCard> getBonusCard = GetById(cardId);

            BonusCard bonusCard = getBonusCard.Data;
            bonusCard.Balance += value;
            Customer customer = _customerService.GetById(bonusCard.CustomerId).Data;
            IResult result = Update(bonusCard);
            if (!result.Success)
            {
                return new ErrorDataResult<decimal>(BonusCardMessages.NotIncreaseBalance(customer.FirstName));
            }
            IResult bonusCardOperationAdded = _bonusCardOperationService.IncreasedBalance(bonusCard, userId, value);
            if (!bonusCardOperationAdded.Success)
            {
                return new ErrorDataResult<decimal>(bonusCardOperationAdded.Message);
            }
            return new SuccessDataResult<decimal>(value,BonusCardMessages.IncreaseBalance(customer.FirstName));
        }


        [CacheRemoveAspect("IBonusCardService.Get")]
        public IResult ReduceBalance(int cardId, int userId, decimal value)
        {
            IResult rules = BusinessRules.Run(BonusCardIdExist(cardId)
                                            , IsValueGreaterThanZero(value)
                                            , IsBalanceGreaterThanOrEqualsValue(cardId, value));
            if (rules != null)
            {
                return new ErrorResult(rules.Message);
            }
            IDataResult<BonusCard> getBonusCard = GetById(cardId);
            if (!getBonusCard.Success)
            {
                return new ErrorResult(BonusCardMessages.ThisCustomerDoesNotHaveABonusCard);
            }
            BonusCard bonusCard = getBonusCard.Data;
            bonusCard.Balance -= value;
            Customer customer = _customerService.GetById(bonusCard.CustomerId).Data;
            IResult result = Update(bonusCard);
            if (!result.Success)
            {
                return new ErrorResult(BonusCardMessages.NotReduceBalance(customer.FirstName));
            }
            IResult bonusCardOperationAdded = _bonusCardOperationService.ReducedBalance(bonusCard, userId, value);
            if (!bonusCardOperationAdded.Success)
            {
                return new ErrorResult(bonusCardOperationAdded.Message);
            }
            return new SuccessResult(BonusCardMessages.ReduceBalance(customer.FirstName));
        }




        //Dtos
        public IDataResult<List<BonusCardForFormsDto>> GetAllBonusCardForFormsDetail()
        {
            List<BonusCardForFormsDto> get = _bonusCardDal.GetBonusCardDetails();
            if (get == null)
            {
                return new ErrorDataResult<List<BonusCardForFormsDto>>(BonusCardMessages.NotFound);
            }
            return new SuccessDataResult<List<BonusCardForFormsDto>>(get, BonusCardMessages.Found);
        }

        public IDataResult<BonusCardForFormsDto> GetBonusCardForFormsDetailById(int cardId)
        {
            BonusCardForFormsDto get = _bonusCardDal.GetBonusCardForFormsDto(b => b.BonusCardId == cardId);
            if (get == null)
            {
                return new ErrorDataResult<BonusCardForFormsDto>(BonusCardMessages.NotFound);
            }
            return new SuccessDataResult<BonusCardForFormsDto>(get, BonusCardMessages.Found);
        }

        public IDataResult<BonusCardForFormsDto> GetBonusCardForFormsDetailByBarcodeNumber(string barcodeNumber)
        {
            BonusCardForFormsDto get = _bonusCardDal.GetBonusCardForFormsDto(b => b.BarkodNomresi == barcodeNumber);
            if (get == null)
            {
                return new ErrorDataResult<BonusCardForFormsDto>(BonusCardMessages.NotFound);
            }
            return new SuccessDataResult<BonusCardForFormsDto>(get, BonusCardMessages.Found);
        }

        //Businnes Rules
        private IResult IsValueGreaterThanZero(decimal value)
        {
            if (value <= 0)
            {
                return new ErrorResult(BonusCardMessages.MustNotBeEqualToOrLessThanZero);
            }
            return new SuccessResult();
        }

        private IResult IsBalanceGreaterThanOrEqualsValue(int cardId, decimal value)
        {
            BonusCard getBonusCard = GetById(cardId).Data;
            if (getBonusCard.Balance >= value)
            {
                return new SuccessResult();
            }
            return new ErrorResult(BonusCardMessages.BalanceGreaterThanOrEqualsValue);
        }

        private IResult BonusCardIdExist(int cardId)
        {
            IDataResult<BonusCard> getBonusCard = GetById(cardId);
            if (!getBonusCard.Success)
            {
                return new ErrorResult(BonusCardMessages.ThisCustomerDoesNotHaveABonusCard);
            }
            return new SuccessResult();
        }

        private IResult IsCustomerExistsInterestedAdvantage(int cardId, ref decimal interestedAdvantage)
        {
            IDataResult<BonusCard> getBonusCard = GetById(cardId);
            if (getBonusCard.Data.InterestAdvantage <= 0)
            {
                return new SuccessResult();
            }
            interestedAdvantage = getBonusCard.Data.InterestAdvantage;
            return new SuccessResult();
        }

        private IResult CalCulateValue(ref decimal value, decimal interestedAdvantage)
        {
            value = value * interestedAdvantage / 100;
            return new SuccessResult();
        }

        private IResult DoesTheCustomerHaveABonusCard(int customerId)
        {
            IResult result = GetByCustomerId(customerId);
            if (result.Success)
            {
                return new ErrorResult(BonusCardMessages.ThisCustomerAlreadyExistsABonusCard);
            }
            return new SuccessResult();
        }

        private IResult IsThereAnotherBonusCardInThisBarcode(string barcodeNumber)
        {
            IResult result = GetByBarcodeNumber(barcodeNumber);
            if (result.Success)
            {
                return new ErrorResult(BonusCardMessages.ThisCustomerAlreadyExistsABonusCard);
            }
            return new SuccessResult();
        }


        private IResult IsThereAnotherBonusCardInThisBarcodeForUpdate(BonusCard bonusCard)
        {
            BonusCard  data = _bonusCardDal.Get(b => b.BarcodeNumber == bonusCard.BarcodeNumber & b.Id != bonusCard.Id);
            if (data != null) return new ErrorResult(BonusCardMessages.ThisBarcodeAlreadyExistsABonusCard);
            return new SuccessResult();
        }

        private IResult DoesTheCustomerHaveABonusCardForUpdate(BonusCard bonusCard)
        {
            BonusCard data = _bonusCardDal.Get(b => b.CustomerId == bonusCard.CustomerId & b.Id != bonusCard.Id);
            if (data != null) return new ErrorResult(BonusCardMessages.ThisCustomerAlreadyExistsABonusCard);
            return new SuccessResult();
        }

        private IResult IsBarcodeNumberLenthVerified(string barcodeNumber)
        {
            IDataResult<FormSetting> result = _formSettingService.GetByName(SettingsDictionary.Settings[SettingEnums.SettingParameter.BonusCardBarcodeLenth]);
            if (result.Success)
            {
                if (int.Parse(result.Data.Value) == barcodeNumber.Length)
                {
                    return new SuccessResult();
                }
                return new ErrorResult(BonusCardMessages
                    .BarcodeNumberEqualSettingValue(int.Parse(result.Data.Value)));
            }
            return new ErrorResult(result.Message);

        }

    }
}

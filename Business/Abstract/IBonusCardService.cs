using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.BonusCardDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBonusCardService
    {
        IDataResult<List<BonusCard>> GetAll();
        IResult Add(BonusCard bonusCard);
        IResult Update(BonusCard bonusCard);
        IResult Delete(BonusCard bonusCard);
        IDataResult<BonusCard> GetById(int id);

        IDataResult<BonusCard> GetByCustomerId(int customerId);
        IDataResult<BonusCard> GetByBarcodeNumber(string barcodeNumber);

        IResult IncreaseBalance(int cardId,int userId,decimal value,decimal interestedAdvantage);
        IResult ReduceBalance(int cardId,int userId,decimal value);
        IDataResult<List<BonusCardForFormsDto>> GetAllBonusCardForFormsDetail();
        IDataResult<BonusCardForFormsDto> GetBonusCardForFormsDetailById(int cardId);
        IDataResult<BonusCardForFormsDto> GetBonusCardForFormsDetailByBarcodeNumber(string barcodeNumber);
    }
}

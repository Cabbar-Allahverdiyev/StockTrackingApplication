using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.BonusCardOperationDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBonusCardOperationService
    {
        IDataResult<List<BonusCardOperation>> GetAll();
        IResult Add(BonusCardOperation cardOperation);
        IResult Update(BonusCardOperation cardOperation);
        IResult Delete(BonusCardOperation cardOperation);
        IDataResult<BonusCardOperation> GetById(int id);

        IDataResult<List<BonusCardOperationForFormsDto>> GetAllBonusCardOperationForFormsDto();
        IDataResult<BonusCardOperationForFormsDto> GetBonusCardOperationForFormsDtoById(int id);
        IDataResult<List<BonusCardOperationForFormsDto>> GetAllBonusCardOperationForFormsDtoByIncreasedBalance();
        IDataResult<List<BonusCardOperationForFormsDto>> GetAllBonusCardOperationForFormsDtoByReducedBalance();

        IResult IncreasedBalance(BonusCard bonusCard, int userId, decimal value);
        IResult ReducedBalance(BonusCard bonusCard, int userId, decimal value);
        IDataResult<List<BonusCardOperationForFormsDto>> GetAllSaleWinFormDetailsSalesForMonthAndYear(int month, int year);
        IDataResult<List<BonusCardOperationForFormsDto>> GetAllSaleWinFormDetailsSalesForYear( int selectedYearItem);
        IDataResult<List<BonusCardOperationForFormsDto>> GetAllSaleWinFormDetailsSalesForDayAndMonthAndYear(int selectedDayItem, int selectedMonthItem, int selectedYearItem);
    }
}

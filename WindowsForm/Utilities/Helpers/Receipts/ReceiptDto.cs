using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsForm.Utilities.Helpers.Receipts
{
    public class ReceiptDto
    {
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string BonusCardBarcode { get; set; }
        public decimal? EarnedBonus { get; set; }
        public decimal? RemainingBonus { get; set; }

        public ReceiptDto()
        {

        }
        public ReceiptDto(IUserService userService,
                          IBonusCardService bonusCardService,
                          int userId,
                          int bonusCardId,
                          decimal? earnedBonus)
        {
            IDataResult<User> getUser = userService.GetById(userId);
            if (getUser.Success)
            {
                UserFirstName = getUser.Data.FirstName;
                UserLastName = getUser.Data.LastName;
            }
            else
            {
                UserFirstName = "";
                UserLastName = "";
            }
            IDataResult<BonusCard> getBonusCard = bonusCardService.GetById(bonusCardId);
            if (getBonusCard.Success)
            {
                BonusCardBarcode = getBonusCard.Data.BarcodeNumber;
                RemainingBonus = getBonusCard.Data.Balance;
                EarnedBonus = earnedBonus == null ? 0 : earnedBonus;
            }
            else
            {
                BonusCardBarcode = "";
                RemainingBonus = 0;
                EarnedBonus = 0;
            }
        }

    }
}

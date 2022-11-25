using System;
using System.Collections.Generic;
using System.Text;
using static Business.Constants.Enums.SettingEnums;

namespace Business.Constants.Dictionaries
{
    public static class SettingsDictionary
    {
        public static readonly IDictionary<SettingParameter, string>
     Settings = new Dictionary<SettingParameter, string>
     {
            { SettingParameter.WhichDays, "comboBoxWhichDays" },
            { SettingParameter.GeneralInterestRate, "textBoxIGeneralInterestRate" },
            { SettingParameter.WeeklyInterestRate, "textBoxWeeklyInterestRate" },
            { SettingParameter.SignsDecimalPoint, "textBoxSignsDecimalPoint" },
            { SettingParameter.BonusCardBarcodeLenth, "textBoxBonusCardBarcodeLenth" },
            { SettingParameter.BonusType, "textBoxBonusType" },
            { SettingParameter.ShopName, "textBoxShopName" },
            { SettingParameter.ShopAddress, "textBoxShopAddress" },
            { SettingParameter.ShopNumber, "textBoxShopNumber" },
            { SettingParameter.Voen, "textBoxVoen" },
            { SettingParameter.VaultModel, "textBoxVaultModel" },
            { SettingParameter.VaultSerialNumber, "textBoxVaultSerialNumber" },
            { SettingParameter.ReceiptNumber, "ReceiptNumber" },
            { SettingParameter.ReceiptGivenOnTheDay, "ReceiptGivenOnTheDay" },

     };
    }
}

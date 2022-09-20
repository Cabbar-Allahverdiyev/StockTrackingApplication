using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using Entities.DTOs.BonusCardDtos;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.MyControls;

namespace WindowsForm.BonusCardSystem.CommonMethods
{
    public class BonusCardCommonMethod
    {
        IBonusCardService _bonusCardService;
        IFormSettingService _formSettingService;
        private MyControl _myControl;
        private readonly string BonusCardBarcodeLenth;

        public BonusCardCommonMethod(IBonusCardService bonusCardService,
                                     MyControl myControl,
                                     IFormSettingService formSettingService)
        {
            _bonusCardService = bonusCardService;
            _myControl = myControl;
            _formSettingService = formSettingService;
            BonusCardBarcodeLenth = "textBoxBonusCardBarcodeLenth";
        }

        public void BonusCardSelectByTextBox(TextBox textBoxBonusCardSelect,
                                             TextBox textBoxBonusCardCustomerName,
                                             ref int bonusCardId,
                                             KeyPressEventArgs e,
                                             out BonusCardForFormsDto getBonusCardData
                                             )
        {

            getBonusCardData = new BonusCardForFormsDto();
            try
            {
                _myControl.MakeTextBoxNumberBox(e);
                int length = int.Parse(_formSettingService.GetByName(BonusCardBarcodeLenth).Data.Value);
                string barcodeNumber = textBoxBonusCardSelect.Text;
                if (barcodeNumber.Length >= length)
                {
                    IDataResult<BonusCardForFormsDto> getBonusCard = _bonusCardService.GetBonusCardForFormsDetailByBarcodeNumber(barcodeNumber);
                    if (!getBonusCard.Success)
                    {
                        FormsMessage.WarningMessage(getBonusCard.Message);
                        getBonusCardData = getBonusCard.Data;
                        return;
                    }
                    bonusCardId = getBonusCard.Data.BonusCardId;
                    textBoxBonusCardCustomerName.Text = getBonusCard.Data.Ad + " " + getBonusCard.Data.Soyad;
                    FormsMessage.SuccessMessage(getBonusCard.Message);

                }

            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage("BonusCardCommonMethod", MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }
    }
}

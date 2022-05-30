using Business.Abstract;
using Core.Utilities.Results;
using Entities.DTOs.BonusCardDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using USB_Barcode_Scanner;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.MyControls;
using Entities.Concrete;
using Business.Constants.Messages;
using System.Reflection;
using WindowsForm.Utilities.Search.Concrete.BonusCardSearch;
using WindowsForm.Utilities.Search.Concrete.BonusCardOperationSearch;

namespace WindowsForm.BonusCardSystem.Forms
{
    public partial class HomeForm : Form
    {
        private int BonusCardId { get; set; }
        private int UserId { get; set; }

        IBonusCardService _bonusCardService;
        IBonusCardOperationService _bonusCardOperationService;

        public HomeForm(IBonusCardService bonusCardService
                        , IBonusCardOperationService bonusCardOperationService)
        {
            _bonusCardService = bonusCardService;
            _bonusCardOperationService = bonusCardOperationService;
            InitializeComponent();
            ChecBoxBonusCardChanged();
            BonusCardRefresh();
            BarcodeScanner barcodeScanner = new BarcodeScanner(textBoxBonusCardSelect);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
            BonusCardId = 0;
            UserId = BonusCardSystemLoginForm.UserId;
        }

        //Key press----------------------------->
        private void textBoxBonusCardSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxBonusCardSelect.Text.Length == 13)
            {
                IDataResult<BonusCardForFormsDto> getBonusCard = _bonusCardService.GetBonusCardForFormsDetailByBarcodeNumber(textBoxBonusCardSelect.Text);
                if (!getBonusCard.Success)
                {
                    FormsMessage.WarningMessage(getBonusCard.Message);
                    return;
                }
                BonusCardId = getBonusCard.Data.BonusCardId;
                textBoxCustomer.Text = getBonusCard.Data.Ad + " " + getBonusCard.Data.Soyad;
                textBoxGuzest.Text = getBonusCard.Data.MusteriGuzesti.ToString();
            }
        }

        private void textBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyControl.MakeTextBoxDecimalBox(sender, e);
        }


        //Click ---------------------------->
        private void buttonBonusCardSelect_Click(object sender, EventArgs e)
        {
            WindowsForm.Forms.BonusCardSelectForm bonusCardSelectForm = new WindowsForm.Forms.BonusCardSelectForm(_bonusCardService);
            bonusCardSelectForm.ShowDialog();
            if (WindowsForm.Forms.BonusCardSelectForm.BonusCardId == 0)
            {
                FormsMessage.WarningMessage(FormsTextMessages.IdBlank);
                return;
            }
            IDataResult<BonusCardForFormsDto> getBonusCard = _bonusCardService.GetBonusCardForFormsDetailById(WindowsForm.Forms.BonusCardSelectForm.BonusCardId);
            if (!getBonusCard.Success)
            {
                FormsMessage.WarningMessage(getBonusCard.Message);
                return;
            }
            BonusCardId = WindowsForm.Forms.BonusCardSelectForm.BonusCardId;
            textBoxCustomer.Text = getBonusCard.Data.Ad + " " + getBonusCard.Data.Soyad;
            textBoxGuzest.Text = getBonusCard.Data.MusteriGuzesti.ToString();

        }

        private void buttonElaveEt_Click(object sender, EventArgs e)
        {
            try
            {
                if (BonusCardId == 0)
                {
                    FormsMessage.WarningMessage(FormsTextMessages.IdBlank);
                    return;
                }
                if (textBoxValue.Text == "")
                {
                    FormsMessage.WarningMessage(BonusCardMessages.IncreasedBalanceIsBlank);
                }
                IDataResult<BonusCard> getBonusCard = _bonusCardService.GetById(BonusCardId);
                if (!getBonusCard.Success)
                {
                    FormsMessage.WarningMessage(getBonusCard.Message);
                    return;
                }

                IResult result = _bonusCardService.IncreaseBalance(BonusCardId, UserId,decimal.Parse(textBoxValue.Text));
                if (!result.Success)
                {
                    FormsMessage.WarningMessage(result.Message);
                    return;
                }
                FormsMessage.SuccessMessage(result.Message);
                BonusCardRefresh();
                ClearGroupBoxMusteri();
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
            }

        }

        private void buttonTemizleBonusCard_Click(object sender, EventArgs e)
        {
            ClearGroupBoxMusteri();
        }


        //Check Changed ------------------------------>
        private void checkBoxBonusCard_CheckedChanged(object sender, EventArgs e)
        {
            ChecBoxBonusCardChanged();
        }

        private void ChecBoxBonusCardChanged()
        {
            //burani refactor et umumilkde 3 sehifede isleyir
            if (checkBoxBonusCard.Checked == false)
            {
                checkBoxBonusCard.Text = "Avtomatik";
                buttonBonusCardSelect.Visible = false;
                textBoxBonusCardSelect.Visible = true;
            }
            else
            {
                checkBoxBonusCard.Text = "Manual";
                buttonBonusCardSelect.Visible = true;
                textBoxBonusCardSelect.Visible = false;
            }
        }

        //elave ----------------------?
        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            textBoxBonusCardSelect.Text = e.Barcode;
        }

        private void BonusCardRefresh()
        {
            //dataGridViewList.DataSource = _bonusCardService.GetAllBonusCardForFormsDetail().Data;
            dataGridViewList.DataSource = _bonusCardOperationService.GetAllBonusCardOperationForFormsDto().Data;
        }

        private void ClearGroupBoxMusteri()
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBoxMusteri);
        }

        private void dataGridViewList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    //BonusCardId = dataGridViewList.CurrentRow.Cells["BonusCardId"].Value.ToString() == ""
            //    //    ? 0
            //    //    : int.Parse(dataGridViewList.CurrentRow.Cells["BonusCardId"].Value.ToString());

            //    //IDataResult<BonusCardForFormsDto> getBonusCard = _bonusCardService
            //    //    .GetBonusCardForFormsDetailById(BonusCardId);
            //    //if (!getBonusCard.Success)
            //    //{
            //    //    FormsMessage.WarningMessage(getBonusCard.Message);
            //    //    return;
            //    //}
            //    //textBoxCustomer.Text = getBonusCard.Data.Ad + " " + getBonusCard.Data.Soyad;
            //    //textBoxGuzest.Text = getBonusCard.Data.MusteriGuzesti.ToString();
            //}
            //catch (Exception ex)
            //{
            //    FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
            //}
        }

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            BonusCardOperationForFormsDtoSearch bonusCardOperationSearch = new BonusCardOperationForFormsDtoSearch();
            bonusCardOperationSearch.GetDataWriteGridView(_bonusCardOperationService.GetAllBonusCardOperationForFormsDto().Data
                , textBoxAxtar.Text, dataGridViewList);
        }
    }
}

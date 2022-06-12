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
using WindowsForm.Utilities.Search.Concrete.BonusCardOperationSearch;
using Entities.DTOs.BonusCardOperationDto;
using DataAccess.Constants.Messages;
using WindowsForm.Utilities.Helpers.Calculators;

namespace WindowsForm.BonusCardSystem.Forms
{
    public partial class HomeForm : Form
    {
        private int BonusCardId { get; set; }
        private int UserId { get; set; }

        IBonusCardService _bonusCardService;
        IBonusCardOperationService _bonusCardOperationService;
        IFormSettingService _formSettingService;

        BonusCardOperationForFormsDtoSearch _bonusCardOperationSearch;
        List<BonusCardOperationForFormsDto> _data;

        public HomeForm(IBonusCardService bonusCardService
                        , IBonusCardOperationService bonusCardOperationService
                        , IFormSettingService formSettingService)
        {
            _bonusCardService = bonusCardService;
            _bonusCardOperationService = bonusCardOperationService;
            _formSettingService = formSettingService;
            _bonusCardOperationSearch = new BonusCardOperationForFormsDtoSearch();
            _data = _bonusCardOperationService.GetAllBonusCardOperationForFormsDto().Data;
            InitializeComponent();
            ChecBoxBonusCardChanged(checkBoxBonusCard, textBoxBonusCardSelect, buttonBonusCardSelect);
            ChecBoxBonusCardChanged
              (checkBoxGroupBoxPayment, textBoxGroupBoxPaymentBonusCardSelect, buttonGroupBoxPaymentBonusCardSelect);
            BonusCardRefresh();
            BarcodeScanner barcodeScanner = new BarcodeScanner(textBoxBonusCardSelect);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
            BonusCardId = 0;
            UserId = BonusCardSystemLoginForm.UserId;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            ComboBoxController.WriteDaysInComboBox(comboBoxDays);
            ComboBoxController.WriteMonthsInComboBox(comboBoxMonths);
            ComboBoxController.WriteYearsInComboBox(comboBoxYears);
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

        private void textBoxGroupBoxPaymentBonusCardSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxGroupBoxPaymentBonusCardSelect.Text.Length == 13)
            {
                IDataResult<BonusCardForFormsDto> getBonusCard = _bonusCardService
                    .GetBonusCardForFormsDetailByBarcodeNumber(textBoxGroupBoxPaymentBonusCardSelect.Text);
                if (!getBonusCard.Success)
                {
                    FormsMessage.WarningMessage(getBonusCard.Message);
                    return;
                }
                BonusCardId = getBonusCard.Data.BonusCardId;
                textBoxGroupBoxPaymentCustomer.Text = getBonusCard.Data.Ad + " " + getBonusCard.Data.Soyad;

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
                    return;
                }
                IDataResult<BonusCard> getBonusCard = _bonusCardService.GetById(BonusCardId);
                if (!getBonusCard.Success)
                {
                    FormsMessage.WarningMessage(getBonusCard.Message);
                    return;
                }

                decimal value = textBoxValue.Text == "" ? 0 : decimal.Parse(textBoxValue.Text);

                decimal interestedAdvantage = AdvantageCalculator.WhatIsAdvantageToday(_formSettingService);

                IResult result = _bonusCardService.IncreaseBalance(BonusCardId, UserId, value, interestedAdvantage);
                if (!result.Success)
                {
                    FormsMessage.WarningMessage(result.Message);
                    return;
                }
                FormsMessage.SuccessMessage(result.Message);
                BonusCardRefresh();
                ClearGroupBox(groupBoxBonus);
                BonusCardId = 0;
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
            }

        }

        private void buttonGroupBoxPaymentOdenisEt_Click(object sender, EventArgs e)
        {
            if (BonusCardId == 0)
            {
                FormsMessage.WarningMessage(FormsTextMessages.IdBlank);
                return;
            }
            if (textBoxGroupBoxPaymentValue.Text == "")
            {
                FormsMessage.WarningMessage(BonusCardMessages.IncreasedBalanceIsBlank);
                return;
            }
            IDataResult<BonusCard> getBonusCard = _bonusCardService.GetById(BonusCardId);
            if (!getBonusCard.Success)
            {
                FormsMessage.WarningMessage(getBonusCard.Message);
                return;
            }
            decimal value = textBoxGroupBoxPaymentValue.Text == "" ? 0 : decimal.Parse(textBoxGroupBoxPaymentValue.Text);
            IResult result = _bonusCardService.ReduceBalance(BonusCardId, UserId, value);
            if (!result.Success)
            {
                FormsMessage.WarningMessage(result.Message);
                return;
            }
            FormsMessage.SuccessMessage(result.Message);
            BonusCardRefresh();
            ClearGroupBox(groupBoxPayment);
            BonusCardId = 0;
        }


        private void buttonGroupBoxTemizlePayment_Click(object sender, EventArgs e)
        {
            ClearGroupBox(groupBoxPayment);
        }

        private void buttonTemizleBonusCard_Click(object sender, EventArgs e)
        {
            ClearGroupBox(groupBoxBonus);
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            _data = _bonusCardOperationService.GetAllBonusCardOperationForFormsDto().Data;
            dataGridViewList.DataSource = _data;
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            ComboBoxController.ClearAllComboBoxByGroupBox(groupBoxBonusCardSearch);
        }

        private void buttonGroupBoxPaymentBonusCardSelect_Click(object sender, EventArgs e)
        {
            BonusCardId = 0;
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
            textBoxGroupBoxPaymentCustomer.Text = getBonusCard.Data.Ad + " " + getBonusCard.Data.Soyad;

        }

        private void buttonAxtar_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedDayItem = comboBoxDays.SelectedItem != null ? int.Parse(comboBoxDays.SelectedItem.ToString())
             : DateTime.Now.Day;

                int selectedMonthItem = comboBoxMonths.SelectedItem != null ? int.Parse(comboBoxMonths.SelectedItem.ToString())
                   : DateTime.Now.Month;

                int selectedYearItem = comboBoxYears.SelectedItem != null ? int.Parse(comboBoxYears.SelectedItem.ToString())
                   : DateTime.Now.Year;
                decimal totalBonus = 0;
                decimal totalBonusSales = 0;
                decimal totalBonusMade = 0;
                // decimal incomeTotal = 0;
                int staticUserId = BonusCardSystemLoginForm.UserId;


                labelTotalBonus.Text = CalculateTotalBonus(_bonusCardService.GetAll().Data).ToString();

                if (comboBoxDays.SelectedItem == null && comboBoxMonths.SelectedItem != null && comboBoxYears.SelectedItem == null)
                {
                    List<BonusCardOperationForFormsDto> dataMonth = _bonusCardOperationService
                        .GetAllSaleWinFormDetailsSalesForMonthAndYear(selectedMonthItem, selectedYearItem).Data;
                    foreach (var item in dataMonth)
                    {
                        if (item.Status == true)
                        {
                            if (item.EmeliyyatVeziyyeti == BonusCardOperationDalMessages.BonusMade)
                            {
                                totalBonusMade += item.Mebleg;
                            }
                            else
                            {
                                totalBonusSales += item.Mebleg;
                            }

                        }
                    }
                    labelTotalBonusMade.Text = totalBonusMade.ToString();
                    labelTotalBonusCardSales.Text = totalBonusSales.ToString();
                    dataGridViewList.DataSource = dataMonth;
                    return;
                }

                if (comboBoxDays.SelectedItem == null && comboBoxMonths.SelectedItem == null && comboBoxYears.SelectedItem != null)
                {
                    List<BonusCardOperationForFormsDto> dataYear = _bonusCardOperationService
                        .GetAllSaleWinFormDetailsSalesForYear(selectedYearItem).Data;
                    foreach (var item in dataYear)
                    {
                        if (item.EmeliyyatVeziyyeti == BonusCardOperationDalMessages.BonusMade)
                        {
                            totalBonusMade += item.Mebleg;
                        }
                        else
                        {
                            totalBonusSales += item.Mebleg;
                        }
                    }

                    labelTotalBonusMade.Text = totalBonusMade.ToString();
                    labelTotalBonusCardSales.Text = totalBonusSales.ToString();
                    dataGridViewList.DataSource = dataYear;
                    return;
                }

                if (comboBoxDays.SelectedItem == null && comboBoxMonths.SelectedItem != null && comboBoxYears.SelectedItem != null)
                {
                    List<BonusCardOperationForFormsDto> dataMonth = _bonusCardOperationService
                        .GetAllSaleWinFormDetailsSalesForMonthAndYear(selectedMonthItem, selectedYearItem).Data;
                    foreach (var item in dataMonth)
                    {
                        if (item.Status == true)
                        {
                            if (item.EmeliyyatVeziyyeti == BonusCardOperationDalMessages.BonusMade)
                            {
                                totalBonusMade += item.Mebleg;
                            }
                            else
                            {
                                totalBonusSales += item.Mebleg;
                            }
                        }
                    }
                    labelTotalBonusMade.Text = totalBonusMade.ToString();
                    labelTotalBonusCardSales.Text = totalBonusSales.ToString();

                    //burani refactor et 
                    //labelTotalBonus.Text = CalculateTotalBonus(_bonusCardService.GetAll().Data).ToString();
                    //labelTotalBonusCardSales.Text = CalculateTotalBonusCardDto(_bonusCardOperationService.GetAllBonusCardOperationForFormsDtoByReducedBalance().Data).ToString();

                    dataGridViewList.DataSource = dataMonth;
                    return;
                }

                List<BonusCardOperationForFormsDto> data = _bonusCardOperationService
                        .GetAllSaleWinFormDetailsSalesForDayAndMonthAndYear(selectedDayItem, selectedMonthItem, selectedYearItem).Data;
                foreach (var item in data)
                {
                    if (item.Status == true)
                    {
                        if (item.EmeliyyatVeziyyeti == BonusCardOperationDalMessages.BonusMade)
                        {
                            totalBonusMade += item.Mebleg;
                        }
                        else
                        {
                            totalBonusSales += item.Mebleg;
                        }
                    }
                }
                labelTotalBonusMade.Text = totalBonusMade.ToString();
                labelTotalBonusCardSales.Text = totalBonusSales.ToString();

                //labelIncome.Text = incomeTotal.ToString();

                dataGridViewList.DataSource = data;
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }

        //Check Changed ------------------------------>
        private void checkBoxBonusCard_CheckedChanged(object sender, EventArgs e)
        {
            ChecBoxBonusCardChanged(checkBoxBonusCard, textBoxBonusCardSelect, buttonBonusCardSelect);
        }
        private void checkBoxGroupBoxPayment_CheckedChanged(object sender, EventArgs e)
        {
            ChecBoxBonusCardChanged
                (checkBoxGroupBoxPayment, textBoxGroupBoxPaymentBonusCardSelect, buttonGroupBoxPaymentBonusCardSelect);
        }

        private void ChecBoxBonusCardChanged(CheckBox checkBox, TextBox textBox, Button button)
        {
            //burani refactor et umumilkde 3 sehifede isleyir
            if (checkBox.Checked == false)
            {
                checkBox.Text = "Avtomatik";
                button.Visible = false;
                textBox.Visible = true;
            }
            else
            {
                checkBox.Text = "Manual";
                button.Visible = true;
                textBox.Visible = false;
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
            _data = _bonusCardOperationService.GetAllBonusCardOperationForFormsDto().Data;
            dataGridViewList.DataSource = _data;
        }

        private void ClearGroupBox(GroupBox groupBox)
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBox);
        }

        private void dataGridViewList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {

            _bonusCardOperationSearch.GetDataWriteGridView(_data, textBoxAxtar.Text, dataGridViewList);

        }



        private decimal CalculateTotalBonus(List<BonusCard> data)
        {
            decimal total = 0;
            foreach (var item in data)
            {
                total += item.Balance;
            }
            return total;
        }

        private decimal CalculateTotalBonusCardDto(List<BonusCardOperationForFormsDto> data)
        {
            decimal total = 0;
            foreach (var item in data)
            {
                total += item.Mebleg;
            }
            return total;
        }
    }
}

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
using Entities.DTOs.BonusCardOperationDto;

namespace WindowsForm.BonusCardSystem.Forms
{
    public partial class HomeForm : Form
    {
        private int BonusCardId { get; set; }
        private int UserId { get; set; }

        IBonusCardService _bonusCardService;
        IBonusCardOperationService _bonusCardOperationService;

        BonusCardOperationForFormsDtoSearch _bonusCardOperationSearch;
        List<BonusCardOperationForFormsDto> _data;

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
            _bonusCardOperationSearch = new BonusCardOperationForFormsDtoSearch();
            _data= _bonusCardOperationService.GetAllBonusCardOperationForFormsDto().Data;
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
            _data= _bonusCardOperationService.GetAllBonusCardOperationForFormsDto().Data;
            dataGridViewList.DataSource = _data;
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

            _bonusCardOperationSearch.GetDataWriteGridView(_data,textBoxAxtar.Text,dataGridViewList);
            
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            ComboBoxController.ClearAllComboBoxByGroupBox(groupBoxBonusCardSearch);
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
               // decimal incomeTotal = 0;
                int staticUserId = BonusCardSystemLoginForm.UserId;

                if (comboBoxDays.SelectedItem == null && comboBoxMonths.SelectedItem != null && comboBoxYears.SelectedItem == null)
                {
                    List<BonusCardOperationForFormsDto> dataMonth = _bonusCardOperationService
                        .GetAllSaleWinFormDetailsSalesForMonthAndYear(selectedMonthItem, selectedYearItem).Data;
                        //_saleWinFormService
                        //.GetAllSaleWinFormDetailsSalesForMonthAndYear(selectedMonthItem, selectedYearItem).Data;

                    foreach (var item in dataMonth)
                    {
                        if (item.Status == true)
                        {


                            totalBonus += item.Mebleg;

                            //Product getProduct = _productService.GetById(item.ProductId).Data;
                            //for (int i = 1; i < item.Miqdar + 1; i++)
                            //{
                            //    incomeTotal += (item.SatilanQiymet - getProduct.PurchasePrice);
                            //}
                        }

                    }

                    labelTotal.Text = totalBonus.ToString();
                    //labelIncome.Text = incomeTotal.ToString();
                    dataGridViewList.DataSource = dataMonth;
                    return;
                }

                if (comboBoxDays.SelectedItem == null && comboBoxMonths.SelectedItem == null && comboBoxYears.SelectedItem != null)
                {
                    List<BonusCardOperationForFormsDto> dataYear = _bonusCardOperationService
                        .GetAllSaleWinFormDetailsSalesForYear( selectedYearItem).Data;
                    //_saleWinFormService
                    //.GetAllSaleWinFormDetailsSalesForYear(selectedYearItem).Data;

                    foreach (var item in dataYear)
                    {
                        if (item.Status == true)
                        {
                            totalBonus += item.Mebleg;

                            //Product getProduct = _productService.GetById(item.ProductId).Data;
                            //for (int i = 1; i < item.Miqdar + 1; i++)
                            //{
                            //    incomeTotal += (item.SatilanQiymet - getProduct.PurchasePrice);
                            //}
                        }
                    }

                    labelTotal.Text = totalBonus.ToString();
                    //labelIncome.Text = incomeTotal.ToString();
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
                            totalBonus += item.Mebleg;
                            //Product getProduct = _productService.GetById(item.ProductId).Data;
                            //for (int i = 1; i < item.Miqdar + 1; i++)
                            //{
                            //    incomeTotal += (item.SatilanQiymet - getProduct.PurchasePrice);
                            //}
                        }
                    }
                    labelTotal.Text = totalBonus.ToString();
                    //if (staticUserId == 3002 || staticUserId == 2004)
                    //{
                    //    labelIncome.Text = incomeTotal.ToString();
                    //}
                    dataGridViewList.DataSource = dataMonth;
                    return;
                }

                List<BonusCardOperationForFormsDto> data = _bonusCardOperationService
                        .GetAllSaleWinFormDetailsSalesForDayAndMonthAndYear(selectedDayItem, selectedMonthItem, selectedYearItem).Data;
                foreach (var item in data)
                {
                    if (item.Status == true)
                    {
                        totalBonus += item.Mebleg;
                        //Product getProduct = _productService.GetById(item.ProductId).Data;
                        //for (int i = 1; i < item.Miqdar + 1; i++)
                        //{
                        //    incomeTotal += (item.SatilanQiymet - getProduct.PurchasePrice);
                        //}
                    }
                }
                labelTotal.Text = totalBonus.ToString();

                //labelIncome.Text = incomeTotal.ToString();

                dataGridViewList.DataSource = data;
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }
    }
}

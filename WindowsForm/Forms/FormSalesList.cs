using Business.Concrete;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs.SaleWinFormDtos;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.ValidatorControllers;
using WindowsForm.Utilities.Search.Concrete.SaleSearch;

namespace WindowsForm.Forms
{
    public partial class FormSalesList : Form
    {
        SaleWinFormManager _saleWinFormManager = new SaleWinFormManager(new EfSaleWinFormDal());
        ProductManager _productManager = new ProductManager(new EfProductDal());
        SaleValidationTool saleValidationTool = new SaleValidationTool();

        public FormSalesList()
        {
            InitializeComponent();
        }

        private void FormSalesList_Load(object sender, EventArgs e)
        {
            ComboBoxController.WriteDaysInComboBox(comboBoxDays);
            ComboBoxController.WriteMonthsInComboBox(comboBoxMonths);
            ComboBoxController.WriteYearsInComboBox(comboBoxYears);
            comboBoxAxtar.Items.Add("MehsulAdi");
            comboBoxAxtar.Items.Add("Istifadeci");
            SaleListRefesh();
            checkBoxSatisLegvEdilsin.Checked = false;
        }

        //Click------------------------------------------->
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
                decimal saleTotal = 0;
                decimal incomeTotal = 0;
                int staticUseraId = LoginForm.UserId;

                if (comboBoxDays.SelectedItem == null && comboBoxMonths.SelectedItem != null && comboBoxYears.SelectedItem == null)
                {
                    List<SaleWinFormDto> dataMonth = _saleWinFormManager
                        .GetAllSaleWinFormDetailsSalesForMonthAndYear(selectedMonthItem, selectedYearItem).Data;

                    foreach (SaleWinFormDto item in dataMonth)
                    {
                        if (item.SatisinVeziyyeti == true)
                        {


                            saleTotal += item.Cem;

                            Product getProduct = _productManager.GetById(item.ProductId).Data;
                            for (int i = 1; i < item.Miqdar + 1; i++)
                            {
                                incomeTotal += (item.SatilanQiymet - getProduct.PurchasePrice);
                            }
                        }

                    }

                    labelTotal.Text = saleTotal.ToString();
                    if (staticUseraId == 3002 || staticUseraId == 2004)
                    {

                        labelIncome.Text = incomeTotal.ToString();
                    }

                    dataGridViewSaleList.DataSource = dataMonth;
                    return;
                }

                if (comboBoxDays.SelectedItem == null && comboBoxMonths.SelectedItem == null && comboBoxYears.SelectedItem != null)
                {
                    List<SaleWinFormDto> dataYear = _saleWinFormManager
                        .GetAllSaleWinFormDetailsSalesForYear(selectedYearItem).Data;

                    foreach (SaleWinFormDto item in dataYear)
                    {
                        if (item.SatisinVeziyyeti == true)
                        {
                            saleTotal += item.Cem;

                            Product getProduct = _productManager.GetById(item.ProductId).Data;
                            for (int i = 1; i < item.Miqdar + 1; i++)
                            {
                                incomeTotal += (item.SatilanQiymet - getProduct.PurchasePrice);
                            }
                        }
                    }

                    labelTotal.Text = saleTotal.ToString();
                    if (staticUseraId == 3002 || staticUseraId == 2004)
                    {
                        labelIncome.Text = incomeTotal.ToString();
                    }
                    dataGridViewSaleList.DataSource = dataYear;
                    return;
                }


                if (comboBoxDays.SelectedItem == null && comboBoxMonths.SelectedItem != null && comboBoxYears.SelectedItem != null)
                {
                    List<SaleWinFormDto> dataMonth = _saleWinFormManager
                        .GetAllSaleWinFormDetailsSalesForMonthAndYear(selectedMonthItem, selectedYearItem).Data;
                    foreach (SaleWinFormDto item in dataMonth)
                    {
                        if (item.SatisinVeziyyeti == true)
                        {
                            saleTotal += item.Cem;
                            Product getProduct = _productManager.GetById(item.ProductId).Data;
                            for (int i = 1; i < item.Miqdar + 1; i++)
                            {
                                incomeTotal += (item.SatilanQiymet - getProduct.PurchasePrice);
                            }
                        }
                    }
                    labelTotal.Text = saleTotal.ToString();
                    if (staticUseraId == 3002 || staticUseraId == 2004)
                    {
                        labelIncome.Text = incomeTotal.ToString();
                    }
                    dataGridViewSaleList.DataSource = dataMonth;
                    return;
                }

                List<SaleWinFormDto> data = _saleWinFormManager
                        .GetAllSaleWinFormDetailsSalesForDayAndMonthAndYear(selectedDayItem, selectedMonthItem, selectedYearItem).Data;
                foreach (SaleWinFormDto item in data)
                {
                    if (item.SatisinVeziyyeti == true)
                    {
                        saleTotal += item.Cem;
                        Product getProduct = _productManager.GetById(item.ProductId).Data;
                        for (int i = 1; i < item.Miqdar + 1; i++)
                        {
                            incomeTotal += (item.SatilanQiymet - getProduct.PurchasePrice);
                        }
                    }
                }
                labelTotal.Text = saleTotal.ToString();
                if (staticUseraId == 3002 || staticUseraId == 2004)
                {
                    labelIncome.Text = incomeTotal.ToString();
                }
                dataGridViewSaleList.DataSource = data;
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage($"{AuthMessages.ErrorMessage} | {ex.Message}");
            }
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            SaleListRefesh();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            ComboBoxController.ClearAllComboBoxByGroupBox(groupBox1);
        }

        //Elave Metodlar------------------------>

        private void SaleListRefesh()
        {
            dataGridViewSaleList.DataSource = _saleWinFormManager.GetAllSaleWinFormDtoDetails().Data;
        }

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            SaleWinFormDetailDtoSearch detailSearch = new SaleWinFormDetailDtoSearch();
            detailSearch.SearchBySelectedValueOfComboBoxAndWriteToDataGridView(textBoxAxtar, dataGridViewSaleList, comboBoxAxtar);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonTetbiqEt_Click(object sender, EventArgs e)
        {
            try
            {
                SaleWinForm sale = new SaleWinForm();
                if (textBoxSaleId.Text == "")
                {
                    FormsMessage.WarningMessage(FormsTextMessages.PasswordOrEmailIsBlank);
                    return;
                }
                sale.Id = int.Parse(textBoxSaleId.Text);
                IDataResult<SaleWinForm> getSale = _saleWinFormManager.GetById(sale.Id);
                if (!getSale.Success)
                {
                    FormsMessage.ErrorMessage(getSale.Message);
                    return;
                }
                sale = getSale.Data;
                sale.SaleStatus = false;

                if (!saleValidationTool.IsValid(sale))
                {
                    return;
                }
                IResult updatedSale;
                if (checkBoxSatisLegvEdilsin.Checked == true)
                {
                    updatedSale = _saleWinFormManager.Update(sale);

                    if (!updatedSale.Success)
                    {
                        FormsMessage.WarningMessage(updatedSale.Message);
                        return;
                    }

                    IDataResult<Product> getProduct = _productManager.GetById(sale.ProductId);
                    if (!getProduct.Success)
                    {
                        FormsMessage.ErrorMessage(getProduct.Message);
                        return;
                    }
                    getProduct.Data.UnitsInStock += sale.Quantity;
                    IResult productUpdated = _productManager.Update(getProduct.Data);
                    if (!productUpdated.Success)
                    {
                        FormsMessage.ErrorMessage(productUpdated.Message);
                        return;
                    }

                    FormsMessage.SuccessMessage(ProductMessages.UnitsInStockIncreased(sale.Quantity));
                    FormsMessage.SuccessMessage(updatedSale.Message);
                    FormsMessage.SuccessMessage(SaleMessages.SaleCancel);
                    checkBoxSatisLegvEdilsin.Checked = false;
                }

                SaleListRefesh();
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage($"{AuthMessages.ErrorMessage} | {ex.Message}");
            }


        }

        private void dataGridViewSaleList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxSaleId.Text = dataGridViewSaleList.CurrentRow.Cells["SaleId"].Value.ToString();
            textBoxMehsul.Text = dataGridViewSaleList.CurrentRow.Cells["MehsulAdi"].Value.ToString();
            textBoxMiqdar.Text = dataGridViewSaleList.CurrentRow.Cells["Miqdar"].Value.ToString();
            textBoxUmumiDeyer.Text = dataGridViewSaleList.CurrentRow.Cells["Cem"].Value.ToString();
            textBoxSatIici.Text = dataGridViewSaleList.CurrentRow.Cells["Istifadeci"].Value.ToString();
            textBoxTarix.Text = dataGridViewSaleList.CurrentRow.Cells["Tarix"].Value.ToString();
            checkBoxSatisLegvEdilsin.Checked = false;
        }
    }
}

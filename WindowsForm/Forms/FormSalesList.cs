using Business.Concrete;
using Business.Constants.Messages;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs.SaleWinFormDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Utilities.Search.Concrete.SaleSearch;

namespace WindowsForm.Forms
{
    public partial class FormSalesList : Form
    {
        SaleWinFormManager _saleWinFormManager = new SaleWinFormManager(new EfSaleWinFormDal());
        ProductManager _productManager = new ProductManager(new EfProductDal());

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
                decimal IncomeTotal = 0;
                int staticUseraId = LoginForm.UserId;

                if (comboBoxDays.SelectedItem == null && comboBoxMonths.SelectedItem != null && comboBoxYears.SelectedItem == null)
                {
                    List<SaleWinFormDto> dataMonth = _saleWinFormManager
                        .GetAllSaleWinFormDetailsSalesForMonthAndYear(selectedMonthItem, selectedYearItem).Data;

                    foreach (SaleWinFormDto item in dataMonth)
                    {
                        saleTotal += item.Cem;

                        Product getProduct=_productManager.GetByProductId(item.ProductId).Data;
                        for (int i = 1; i < item.Miqdar+1; i++)
                        {
                            IncomeTotal += (item.SatilanQiymet - getProduct.PurchasePrice);
                        }
                       
                    }
                   
                    labelTotal.Text = saleTotal.ToString();
                    if (staticUseraId == 3002 || staticUseraId == 2004)
                    {
                        labelIncome.Text = IncomeTotal.ToString();
                    }
                        
                    dataGridViewSaleList.DataSource = dataMonth;
                    return;
                }

                if (comboBoxDays.SelectedItem == null && comboBoxMonths.SelectedItem == null && comboBoxYears.SelectedItem != null)
                {
                    List<SaleWinFormDto> dataYear = _saleWinFormManager
                        .GetAllSaleWinFormDetailsSalesForYear( selectedYearItem).Data;

                    foreach (SaleWinFormDto item in dataYear)
                    {
                        saleTotal += item.Cem;

                        Product getProduct = _productManager.GetByProductId(item.ProductId).Data;
                        for (int i = 1; i < item.Miqdar + 1; i++)
                        {
                            IncomeTotal += (item.SatilanQiymet - getProduct.PurchasePrice);
                        }

                    }

                    labelTotal.Text = saleTotal.ToString();
                    if (staticUseraId == 3002 || staticUseraId == 2004)
                    {
                        labelIncome.Text = IncomeTotal.ToString();
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
                        saleTotal += item.Cem;
                        Product getProduct = _productManager.GetByProductId(item.ProductId).Data;
                        for (int i = 1; i < item.Miqdar+1; i++)
                        {
                            IncomeTotal += (item.SatilanQiymet - getProduct.PurchasePrice);
                        }
                    }
                    labelTotal.Text = saleTotal.ToString();
                    if (staticUseraId == 3002 || staticUseraId == 2004)
                    {
                        labelIncome.Text = IncomeTotal.ToString();
                    }
                    dataGridViewSaleList.DataSource = dataMonth;
                    return;
                }

                List<SaleWinFormDto> data = _saleWinFormManager
                        .GetAllSaleWinFormDetailsSalesForDayAndMonthAndYear(selectedDayItem, selectedMonthItem, selectedYearItem).Data;
                foreach (SaleWinFormDto item in data)
                {
                    saleTotal += item.Cem;
                    Product getProduct = _productManager.GetByProductId(item.ProductId).Data;
                    for (int i = 1; i < item.Miqdar+1; i++)
                    {
                        IncomeTotal += (item.SatilanQiymet - getProduct.PurchasePrice);
                    }
                }
                labelTotal.Text = saleTotal.ToString();
                if (staticUseraId == 3002 || staticUseraId == 2004)
                {
                    labelIncome.Text = IncomeTotal.ToString();
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
            detailSearch.SearchBySelectedValueOfComboBoxAndWriteToDataGridView(textBoxAxtar,dataGridViewSaleList,comboBoxAxtar);
        }
    }
}

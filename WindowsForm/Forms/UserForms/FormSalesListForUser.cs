using Business.Concrete;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs.SaleWinFormDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.FormsAuthorization.User;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.ValidatorControllers;
using WindowsForm.MyControls;
using WindowsForm.Utilities.Search.Concrete.SaleSearch;

namespace WindowsForm.Forms.UserForms
{
    public partial class FormSalesListForUser : Form
    {
        // public static bool QrCodeIsSuccess = false;

        SaleWinFormManager _saleWinFormManager = new SaleWinFormManager(new EfSaleWinFormDal(), new ProductManager(new EfProductDal()));
        ProductManager _productManager = new ProductManager(new EfProductDal());
        SaleValidationTool saleValidationTool = new SaleValidationTool();
        MyControl myControl = new MyControl();

        public FormSalesListForUser()
        {
            InitializeComponent();
        }

        private void FormSalesList_Load(object sender, EventArgs e)
        {
            ComboBoxController.WriteDaysInComboBox(comboBoxDays);
            ComboBoxController.WriteMonthsInComboBox(comboBoxMonths);
            ComboBoxController.WriteYearsInComboBox(comboBoxYears);
            //comboBoxAxtar.Items.Add("MehsulAdi");
            //comboBoxAxtar.Items.Add("Istifadeci");
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
                // decimal incomeTotal = 0;
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
                        }

                    }

                    labelTotal.Text = saleTotal.ToString();

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
                        }
                    }

                    labelTotal.Text = saleTotal.ToString();

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

                        }
                    }
                    labelTotal.Text = saleTotal.ToString();
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
                    }
                }
                labelTotal.Text = saleTotal.ToString();
                dataGridViewSaleList.DataSource = data;
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }

        private void buttonTetbiqEt_Click(object sender, EventArgs e)
        {
            UserAuthorization.QrCodeIsSuccess = false;
            if (checkBoxSatisLegvEdilsin.Checked == false)
            {
                FormsMessage.InformationMessage(BaseMessages.NoChange);
                return;
            }
            AdminValidationForm validationForm = new AdminValidationForm();
            validationForm.ShowDialog();


            if (UserAuthorization.QrCodeIsSuccess == false)
            {
                FormsMessage.WarningMessage(AuthMessages.AuthorizationDenied);
                return;
            }
            try
            {
                SaleWinForm sale = new SaleWinForm();
                if (textBoxSaleId.Text == "")
                {
                    FormsMessage.WarningMessage(FormsTextMessages.SaleIdBlank);
                    return;
                }
                sale.Id = int.Parse(textBoxSaleId.Text);

                IResult canceledSale;
                if (checkBoxSatisLegvEdilsin.Checked == true)
                {
                    canceledSale = _saleWinFormManager.CancelSale(sale);
                    if (!canceledSale.Success)
                    {
                        FormsMessage.WarningMessage(canceledSale.Message);
                        return;
                    }

                    FormsMessage.SuccessMessage(canceledSale.Message);
                    TextBoxController.ClearAllTextBoxesByGroupBox(groupBoxCancelSale);
                    checkBoxSatisLegvEdilsin.Checked = false;

                }

                SaleListRefesh();
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
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

        //Cell double click ------------------->

        private void dataGridViewSaleList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSaleList.CurrentRow == null)
            {
                FormsMessage.WarningMessage(BaseMessages.SelectedValueIsNull);
                return;
            }
            textBoxSaleId.Text = dataGridViewSaleList.CurrentRow.Cells["SaleId"].Value.ToString();
            textBoxMehsul.Text = dataGridViewSaleList.CurrentRow.Cells["MehsulAdi"].Value.ToString();
            textBoxMiqdar.Text = dataGridViewSaleList.CurrentRow.Cells["Miqdar"].Value.ToString();
            textBoxUmumiDeyer.Text = dataGridViewSaleList.CurrentRow.Cells["Cem"].Value.ToString();
            textBoxSatIici.Text = dataGridViewSaleList.CurrentRow.Cells["Istifadeci"].Value.ToString();
            textBoxTarix.Text = dataGridViewSaleList.CurrentRow.Cells["Tarix"].Value.ToString();
            checkBoxSatisLegvEdilsin.Checked = false;
        }

        //Elave Metodlar------------------------>

        private void SaleListRefesh()
        {
            dataGridViewSaleList.DataSource = _saleWinFormManager.GetAllSaleWinFormDtoDetails().Data;
            myControl.MakeDataGridViewCurrentColumnCurrentColor(dataGridViewSaleList, "AlisQiymeti", Color.Yellow);
            myControl.MakeDataGridViewCurrentColumnCurrentColor(dataGridViewSaleList, "SatilanQiymet", Color.Green);
            myControl.MakeDataGridViewCurrentColumnCurrentColor(dataGridViewSaleList, "Cem", Color.Red);
        }

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            SaleWinFormDetailDtoSearch detailSearch = new SaleWinFormDetailDtoSearch();
            List<SaleWinFormDto> data = _saleWinFormManager.GetAllSaleWinFormDtoDetails().Data;
            detailSearch.GetDataWriteGridView(data, textBoxAxtar.Text, dataGridViewSaleList);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

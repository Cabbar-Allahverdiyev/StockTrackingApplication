using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Controllers.Concrete;

namespace WindowsForm.Forms
{
    public partial class FormSalesList : Form
    {
        SaleWinFormManager _saleWinFormManager = new SaleWinFormManager(new EfSaleWinFormDal());
        public FormSalesList()
        {
            InitializeComponent();
        }

        private void FormSalesList_Load(object sender, EventArgs e)
        {
            ComboBoxController.WriteDaysInComboBox(comboBoxDays);
            ComboBoxController.WriteMonthsInComboBox(comboBoxMonths);
            ComboBoxController.WriteYearsInComboBox(comboBoxYears);
            SaleListRefesh();
        }
       
        //Click------------------------------------------->
        private void buttonAxtar_Click(object sender, EventArgs e)
        {
            int selectedDayItem = comboBoxDays.SelectedItem != null ? int.Parse(comboBoxDays.SelectedItem.ToString())
               : DateTime.Now.Day;

            int selectedMonthItem = comboBoxMonths.SelectedItem != null ? int.Parse(comboBoxMonths.SelectedItem.ToString())
               : DateTime.Now.Month;

            int selectedYearItem = comboBoxYears.SelectedItem != null ? int.Parse(comboBoxYears.SelectedItem.ToString())
               : DateTime.Now.Year;
            decimal saleTotal = 0;

            if (comboBoxDays.SelectedItem == null && comboBoxMonths.SelectedItem != null && comboBoxYears.SelectedItem == null)
            {
                List<SaleWinFormDto> dataMonth = _saleWinFormManager
                    .GetAllSaleWinFormDetailsSalesForMonthAndYear(selectedMonthItem, selectedYearItem).Data;
                
                foreach (SaleWinFormDto item in dataMonth)
                {
                    saleTotal += item.Cem;
                }
                labelTotal.Text = saleTotal.ToString();
                dataGridViewSaleList.DataSource = dataMonth;
                return;
            }

            if (comboBoxDays.SelectedItem == null && comboBoxMonths.SelectedItem != null && comboBoxYears.SelectedItem != null)
            {
                List<SaleWinFormDto> dataMonth = _saleWinFormManager
                    .GetAllSaleWinFormDetailsSalesForMonthAndYear(selectedMonthItem, selectedYearItem).Data;
                foreach (SaleWinFormDto item in dataMonth)
                {
                    saleTotal += item.Cem;
                }
                labelTotal.Text = saleTotal.ToString();
                dataGridViewSaleList.DataSource = dataMonth;
                return;
            }

            List<SaleWinFormDto> data = _saleWinFormManager
                    .GetAllSaleWinFormDetailsSalesForDayAndMonthAndYear(selectedDayItem, selectedMonthItem, selectedYearItem).Data;
            foreach (SaleWinFormDto item in data)
            {
                saleTotal += item.Cem;
            }
            labelTotal.Text = saleTotal.ToString();
            dataGridViewSaleList.DataSource = data;
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
    }
}

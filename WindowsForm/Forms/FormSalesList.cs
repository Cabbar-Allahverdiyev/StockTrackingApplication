using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
        private void SaleListRefesh()
        {
            dataGridViewSaleList.DataSource = _saleWinFormManager.GetAllSaleWinFormDtoDetails().Data;
        }

        //sil burdan sonrani----------------------->
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewSaleList.DataSource = _saleWinFormManager.GetAllSaleWinFormDetailsSalesForDay(int.Parse(comboBoxDays.SelectedItem.ToString())).Data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewSaleList.DataSource = _saleWinFormManager.GetAllSalewinFormDetailsSalesForMonth(int.Parse(comboBoxMonths.SelectedItem.ToString())).Data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridViewSaleList.DataSource = _saleWinFormManager.GetAllSaleWinFormDetailsSalesForYear(int.Parse(comboBoxYears.SelectedItem.ToString())).Data;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}

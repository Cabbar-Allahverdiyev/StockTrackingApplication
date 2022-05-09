using Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Utilities.Search.Concrete.CustomerSearch;

namespace WindowsForm.Forms
{
    public partial class CustomerSelectForm : Form
    {
        ICustomerService _customerService;

        public static int CustomerId { get; set; }
        public CustomerSelectForm(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
            CustomerId = 0;
        }

        //Load
        private void CustomerSelectForm_Load(object sender, EventArgs e)
        {
            CustomerListRefresh();
        }
        //Text Changed
        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            CustomerSearch customerSearch = new CustomerSearch();
            customerSearch.GetDataWriteGridView(_customerService.GetAll().Data
                , textBoxAxtar.Text, dataGridViewList);
        }

        //Click
        private void buttonSec_Click(object sender, EventArgs e)
        {
          //  CustomerId = int.Parse(textBoxCustomerId.Text);
          CustomerId=  textBoxCustomerId.Text == "" ? 0 :  int.Parse(textBoxCustomerId.Text);
            this.Hide();
        }

        //Cell Double Click
        private void dataGridViewList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCustomerId.Text = dataGridViewList.CurrentRow.Cells["Id"].Value.ToString();
            textBoxAd.Text = dataGridViewList.CurrentRow.Cells["FirstName"].Value.ToString();
            textBoxSoyad.Text = dataGridViewList.CurrentRow.Cells["LastName"].Value.ToString();
        }

        //Elave
        private void CustomerListRefresh()
        {
            dataGridViewList.DataSource = _customerService.GetAll().Data;
        }
    }
}

using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.Concrete.ValidatorControllers;
using WindowsForm.Utilities.Search.Concrete.CustomerSearch;

namespace WindowsForm.Forms
{
    public partial class CustomerForm : Form
    {
        ICustomerService _customerService;

        public CustomerForm(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
            CustomerRefresh();
        }

        private void buttonEalveEt_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                customer.FirstName = textBoxAd.Text;
                customer.LastName = textBoxSoyad.Text;
                customer.PhoneNumber = textBoxTelefonNomresi.Text;
                customer.Email = textBoxEmail.Text;
                customer.Address = textBoxAdres.Text;

                if (!FormValidationTool.IsValid(new CustomerValidator(), customer))
                {
                    return;
                }

                IResult result = _customerService.Add(customer);
                if (!result.Success)
                {
                    FormsMessage.ErrorMessage(result.Message);
                    return;
                }
                FormsMessage.SuccessMessage(result.Message);
                TextBoxController.ClearAllTextBoxesByGroupBox(groupBox1);
                CustomerRefresh();
            }
            catch (Exception ex)
            {

                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void CustomerRefresh()
        {
            dataGridViewList.DataSource = _customerService.GetCustomerDetails().Data;
        }

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            CustomerDtoSearch customerDtoSearch = new CustomerDtoSearch();
            customerDtoSearch.GetDataWriteGridView(_customerService.GetCustomerDetails().Data, textBoxAxtar.Text, dataGridViewList);
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBox1);
        }
    }
}

using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.CustomerDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;

namespace WindowsForm.Forms
{
    public partial class CustomerDetailForm : Form
    {
        private CustomerDto _customerDto;
        private readonly IDebtService _debtService;
        private readonly ICustomerService _customerService;
        public CustomerDetailForm(IDebtService debtService, ICustomerService customerService)
        {
            _debtService = debtService;
            _customerService = customerService;
            int id = CustomerForm.SelectedCustomerId == null ? 0 : CustomerForm.SelectedCustomerId;
            IDataResult<CustomerDto> result = _customerService.GetCustomerDetailByCustomerId(id) ;
            if (!result.Success)
            {
                FormsMessage.ErrorMessage(result.Message);
                return;
            }
            _customerDto = result.Data;
            InitializeComponent();
            WriteToTextBox();
        }

        private void CustomerDetailForm_Load(object sender, EventArgs e)
        {
            CustomerRefresh();
        }

        private void CustomerRefresh()
        {
            dataGridViewList.DataSource = _debtService.GetAllByCustomerId(_customerDto.CustomerId).Data;
        }
        private void WriteToTextBox()
        {
            textBoxAd.Text = _customerDto.FirstName.ToString();
            textBoxSoyad.Text = _customerDto.LastName;

            textBoxTelefonNomresi.Text = _customerDto.PhoneNumber;
            textBoxAdres.Text = _customerDto.Address;
            textBoxBorc.Text = _customerDto.Debt.ToString();
            textBoxBalans.Text = _customerDto.Balance.ToString();
            textBoxbonusKartBalans.Text = _customerDto.BonusCardBalance.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}


using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete.ValidatorControllers;

namespace WindowsForm.Forms
{
    public partial class CustomerForm : Form
    {
        CustomerManager _customerManager = new CustomerManager(new EfCustomerDal(),new CustomerBalanceManager(new EfCustomerBalanceDal()));
        CustomerValidationTool validationTool = new CustomerValidationTool();
        public CustomerForm()
        {
            InitializeComponent();
            CustomerRefresh();
        }

        private void buttonEalveEt_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = textBoxAd.Text;
            customer.LastName = textBoxSoyad.Text;
            customer.PhoneNumber = textBoxTelefonNomresi.Text;
            customer.Email = textBoxEmail.Text;
            customer.Address = textBoxAdres.Text;

            if (!validationTool.IsValid(customer))
            {
                return;
            }

            IResult result = _customerManager.Add(customer);
            if (!result.Success)
            {
                FormsMessage.ErrorMessage(result.Message);
                return;
            }
            FormsMessage.SuccessMessage(result.Message);
            CustomerRefresh();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void CustomerRefresh()
        {
            dataGridViewList.DataSource = _customerManager.GetCustomerDetails().Data;
        }
    }
}

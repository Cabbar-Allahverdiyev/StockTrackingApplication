using Business.Concrete;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
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
using WindowsForm.Core.Controllers.Concrete.ValidatorControllers;
using WindowsForm.MyControls;

namespace WindowsForm.Forms
{
    public partial class CustomerPaymentForm : Form
    {
        CustomerPaymentManager _paymentManager = new CustomerPaymentManager(new EfCustomerPaymentDal(), new CustomerBalanceManager(new EfCustomerBalanceDal()));
        CustomerManager _customerManager = new CustomerManager(new EfCustomerDal(),new CustomerBalanceManager(new EfCustomerBalanceDal()));
        CustomerPaymentValidationTool validationTool = new CustomerPaymentValidationTool();

        public CustomerPaymentForm()
        {
            InitializeComponent();
            CustomerPaymentRefresh();
            CustomerGetComboBox();
        }

        //Click-------------->
        private void buttoElaveEt_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerPayment customerPayment = new CustomerPayment();
                customerPayment.CustomerId = Convert.ToInt32(comboBoxMusteri.SelectedValue);
                customerPayment.Value = decimal.Parse(textBoxMebleg.Text);

                if (!validationTool.IsValid(customerPayment))
                {
                    return;
                }

                IResult result = _paymentManager.Add(customerPayment);
                if (!result.Success)
                {
                    FormsMessage.ErrorMessage(result.Message);
                    return;
                }
                FormsMessage.SuccessMessage(result.Message);
                CustomerPaymentRefresh();
            }
            catch (Exception ex)
            {

                FormsMessage.ErrorMessage($"{AuthMessages.ErrorMessage} | { ex.Message}");
                return;
            }
           
        }


        //Key Press----------------------------------->
        private void textBoxMebleg_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyControl.MakeTextBoxDecimalBox(sender, e);
        }


        //Elave metodlar------------------>
        private void CustomerPaymentRefresh()
        {
            dataGridViewPaymentList.DataSource = _paymentManager.GetCustomerPaymentDetails().Data;
        }

        private void CustomerGetComboBox()
        {
            List<CustomerDto> get = _customerManager.GetCustomerDetails().Data;
            comboBoxMusteri.DataSource = get;
            comboBoxMusteri.DisplayMember = "FullName";
            comboBoxMusteri.ValueMember = "CustomerId";

        }

       
    }
}

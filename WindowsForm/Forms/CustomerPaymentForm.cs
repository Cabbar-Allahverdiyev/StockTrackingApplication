using Business.Concrete;
using Business.Constants.Messages;
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
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.Concrete.ValidatorControllers;
using WindowsForm.MyControls;
using WindowsForm.Core.Constants.SelectionItem;
using WindowsForm.Forms.UserForms;
using WindowsForm.Core.Constants.FormsAuthorization.User;
using WindowsForm.Utilities.Search.Concrete.CustomerPaymentSearch;
using System.Reflection;
using Entities.DTOs.CustomerPaymentDtos;

namespace WindowsForm.Forms
{
    public partial class CustomerPaymentForm : Form
    {
        CustomerPaymentManager _paymentManager = new CustomerPaymentManager(new EfCustomerPaymentDal(), new CustomerBalanceManager(new EfCustomerBalanceDal()));
        CustomerManager _customerManager = new CustomerManager(new EfCustomerDal(), new CustomerBalanceManager(new EfCustomerBalanceDal()));
        CustomerPaymentValidationTool validationTool = new CustomerPaymentValidationTool();

        public CustomerPaymentForm()
        {
            InitializeComponent();
            CustomerPaymentListRefresh();
            //CustomerGetComboBox();
            checkBoxOdenisLegvEdilsin.Checked = false;
        }

        //Click-------------->
        private void buttoElaveEt_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                CustomerPayment customerPayment = new CustomerPayment();
                customerPayment.CustomerId = Convert.ToInt32(textBoxCustomerIdInPaymentAdd.Text);
                customerPayment.Value = decimal.Parse(textBoxMeblegInPaymentAdd.Text);

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
                TextBoxController.ClearAllTextBoxesByGroupBox(groupBoxPaymentAdd);
                CustomerPaymentListRefresh();
            }
            catch (Exception ex)
            {

                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }

        }

        private void buttonTetbiqEt_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerPayment customerPayment = new CustomerPayment();
                if (textBoxCustomerPaymentIdInCancelPayment.Text == "")
                {
                    FormsMessage.WarningMessage(FormsTextMessages.CustomerPaymentIdBlank);
                    return;
                }
                customerPayment.Id = int.Parse(textBoxCustomerPaymentIdInCancelPayment.Text);

                IDataResult<CustomerPayment> getPayment = _paymentManager.GetById(customerPayment.Id);
                if (!getPayment.Success)
                {
                    FormsMessage.WarningMessage(getPayment.Message);
                    return;
                }

                if (checkBoxOdenisLegvEdilsin.Checked == true)
                {
                    if (LoginForm.UserId != 3002 && LoginForm.UserId != 2004)
                    {
                        UserAuthorization.QrCodeIsSuccess = false;
                        AdminValidationForm validationForm = new AdminValidationForm();
                        validationForm.ShowDialog();

                        // if (QrCodeIsSuccess == false)
                        if (UserAuthorization.QrCodeIsSuccess == false)
                        {
                            FormsMessage.WarningMessage(AuthMessages.AuthorizationDenied);
                            return;
                        }
                    }


                    getPayment.Data.PaymentStatus = false;
                    IResult result = _paymentManager.CancelPayment(getPayment.Data);
                    if (!result.Success)
                    {
                        FormsMessage.WarningMessage(result.Message);
                        return;
                    }
                    FormsMessage.SuccessMessage(result.Message);
                    TextBoxController.ClearAllTextBoxesByGroupBox(groupBoxCancelPayment);
                    checkBoxOdenisLegvEdilsin.Checked = false;
                    CustomerPaymentListRefresh();

                    //getPayment.Data.CancelDate = DateTime.Now;
                    //bax
                }
                else
                {
                    FormsMessage.InformationMessage(BaseMessages.NoChange);
                }
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
            
        }

        private void buttonSec_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedCustomerForSalesForm.Id = 0;
                CustomerListForm customerListForm = new CustomerListForm();
                customerListForm.ShowDialog();
                textBoxCustomerIdInPaymentAdd.Text = SelectedCustomerForSalesForm.Id.ToString();
                IDataResult<Customer> result = _customerManager.GetById(SelectedCustomerForSalesForm.Id);
                if (!result.Success)
                {
                    FormsMessage.ErrorMessage(result.Message);
                    return;
                }
                textBoxMusteriInPaymentAdd.Text = result.Data.FirstName + " " + result.Data.LastName;
                textBoxTelefonInPaymentAdd.Text = result.Data.PhoneNumber;
            }
            catch (Exception ex)
            {

                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
            
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBoxPaymentAdd);
        }

        //Cell Double Click-------------------------->
        private void dataGridViewPaymentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPaymentList.CurrentRow == null)
            {
                FormsMessage.WarningMessage(BaseMessages.SelectedValueIsNull);
                return;
            }
            textBoxCustomerPaymentIdInCancelPayment.Text = dataGridViewPaymentList.CurrentRow.Cells["CustomerPaymentId"].Value.ToString();
            textBoxMusteriInCancelPayment.Text = dataGridViewPaymentList.CurrentRow.Cells["FullName"].Value.ToString();
            //textBoxSaticiInCancelPayment.Text = dataGridViewPaymentList.CurrentRow.Cells["UserName"].Value.ToString();
            textBoxMeblegInCancelPayment.Text = dataGridViewPaymentList.CurrentRow.Cells["Value"].Value.ToString();
            textBoxTarixInCancelPayment.Text = dataGridViewPaymentList.CurrentRow.Cells["Date"].Value.ToString();
            checkBoxOdenisLegvEdilsin.Checked = false;
        }

        //Text chamged ------------------------------->

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {

            List<CustomerPaymentDto> data = _paymentManager.GetCustomerPaymentDetails().Data;
            CustomerPaymentDtoSearch detailSearch = new  CustomerPaymentDtoSearch();
            detailSearch.GetDataWriteGridView(data, textBoxAxtar.Text, dataGridViewPaymentList);
        }

        //Key Press----------------------------------->
        private void textBoxMebleg_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyControl.MakeTextBoxDecimalBox(sender, e);
        }


        //Elave metodlar------------------>
        private void CustomerPaymentListRefresh()
        {
            dataGridViewPaymentList.DataSource = _paymentManager.GetCustomerPaymentDetails().Data;
        }

        //private void CustomerGetComboBox()
        //{
        //    List<CustomerDto> get = _customerManager.GetCustomerDetails().Data;
        //    comboBoxMusteriInPaymentAdd.DataSource = get;
        //    comboBoxMusteriInPaymentAdd.DisplayMember = "FirstName";
        //    comboBoxMusteriInPaymentAdd.ValueMember = "CustomerId";

        //}

        private void groupBoxPayment_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxCancelPayment_Enter(object sender, EventArgs e)
        {

        }

        private void CustomerPaymentForm_Load(object sender, EventArgs e)
        {

        }
    }
}

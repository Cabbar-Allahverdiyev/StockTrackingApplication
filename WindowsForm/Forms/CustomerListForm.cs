using Business.Concrete;
using Business.Constants.Messages;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Constants.SelectionItem;

namespace WindowsForm.Forms
{
    public partial class CustomerListForm : Form
    {
        CustomerManager _customerManager = new CustomerManager(new EfCustomerDal(), new CustomerBalanceManager(new EfCustomerBalanceDal()));

        

        public CustomerListForm()
        {
            InitializeComponent();
            CustomerRefresh();
        }

        //Click ----------------------------------->
        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            CustomerRefresh();
        }

        private void buttonSec_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedCustomerForSalesForm.Id = int.Parse(textBoxCustomerId.Text);
                this.Hide();
            }
           
            catch (ArgumentNullException ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex) +
                      " ( Hansısa dəyər boşdur zəhmət olmasa bütün dəyərləri yenidən yoxlayın ) ");
                return;
            }
            catch (Exception ex)
            {

                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex)+" dəyər seçib yenidən yoxlayın");
                return;
            }
            
        }

        //Cell Double Click------------------------->
        private void dataGridViewCustomerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCustomerList.CurrentRow == null)
            {
                FormsMessage.WarningMessage(BaseMessages.SelectedValueIsNull);
                return;
            }
            textBoxCustomerId.Text = dataGridViewCustomerList.CurrentRow.Cells["CustomerId"].Value.ToString();
            textBoxAd.Text=dataGridViewCustomerList.CurrentRow.Cells["FirstName"].Value.ToString();
            textBoxSoyad.Text=dataGridViewCustomerList.CurrentRow.Cells["LastName"].Value.ToString();
            textBoxTelefon.Text = dataGridViewCustomerList.CurrentRow.Cells["PhoneNumber"].Value.ToString();
        }


        //Text Changed-------------------->
        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {

        }

        
      

        //Elave metodlar ------------------------------->
        private void CustomerRefresh()
        {
            dataGridViewCustomerList.DataSource = _customerManager.GetCustomerDetails().Data;
        }

      
    }
}

using Business.Concrete;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.ValidatorControllers;
using WindowsForm.MyControls;
using WindowsForm.Utilities.Search.Concrete.SupplierSearch;

namespace WindowsForm.Forms
{
    public partial class SupplierForm : Form
    {
        SupplierManager _suplierManager = new SupplierManager(new EfSupplierDal());
        SupplierValidationTool validationTool = new SupplierValidationTool();
        SupplierSearch search = new SupplierSearch();
        public SupplierForm()
        {
            InitializeComponent();
            MyControl myControl = new MyControl();
            myControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
            myControl.WritePlaceholdersForTextBoxAddress(textBoxAdres);
            myControl.WritePlaceholdersForTextBoxEmail(textBoxEmail);
            myControl.WritePlaceholdersForTextBoxPhoneNumberAndMaxLengthTen(textBoxTelefon);

        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            SupplierRefresh();
        }



        //Click ------------------------->

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBox1);
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            SupplierRefresh();
        }

        private void buttonElaveEt_Click(object sender, EventArgs e)
        {

            Supplier supplier = new Supplier();
            supplier.CompanyName = textBoxSirketAdi.Text;
            supplier.ContactName = textBoxAd.Text;
            supplier.City = textBoxSeher.Text;
            supplier.Address = textBoxAdres.Text;
            supplier.Email = textBoxEmail.Text;
            supplier.Phone = textBoxTelefon.Text;
            supplier.WhenWillCome = textBoxNeZamanGelir.Text;

            if (!validationTool.IsValid(supplier))
            {
                return;
            }

            var supplierAdd = _suplierManager.Add(supplier);
            if (!supplierAdd.Success)
            {
                FormsMessage.WarningMessage(supplierAdd.Message);
                return;
            }
            FormsMessage.SuccessMessage(supplierAdd.Message);
            SupplierRefresh();

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        //Text Changed ------------------------->

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search.GetDataWriteGridView(textBoxAxtar.Text, dataGridViewSupplierListed);
        }

        private void SupplierRefresh()
        {
            dataGridViewSupplierListed.DataSource = _suplierManager.GetAll().Data;
        }
    }
}

using Business.Abstract;
using Business.Concrete;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using DataAccess.Concrete.EntityFramework;
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
using WindowsForm.MyControls;
using WindowsForm.Utilities.Search.Concrete.SupplierSearch;

namespace WindowsForm.Forms
{
    public partial class SupplierForm : Form
    {
        ISupplierService _suplierService;
        SupplierSearch search = new SupplierSearch();
        public SupplierForm(ISupplierService suplierService)
        {
            _suplierService = suplierService;
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
            try
            {

                Supplier supplier = new Supplier();
                supplier.CompanyName = textBoxSirketAdi.Text;
                supplier.ContactName = textBoxAd.Text;
                supplier.City = textBoxSeher.Text;
                supplier.Address = textBoxAdres.Text;
                supplier.Email = textBoxEmail.Text;
                supplier.Phone = textBoxTelefon.Text;
                supplier.WhenWillCome = textBoxNeZamanGelir.Text;

                if (!FormValidationTool.IsValid(new SupplierValidator(), supplier))
                {
                    return;
                }

                var supplierAdd = _suplierService.Add(supplier);
                if (!supplierAdd.Success)
                {
                    FormsMessage.WarningMessage(supplierAdd.Message);
                    return;
                }
                FormsMessage.SuccessMessage(supplierAdd.Message);
                SupplierRefresh();
                TextBoxController.ClearAllTextBoxesByGroupBox(groupBox1);

                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        control.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }

        //Text Changed ------------------------->

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Supplier> data = _suplierService.GetAll().Data;
            search.GetDataWriteGridView(data, textBoxAxtar.Text, dataGridViewSupplierListed);
        }

        private void SupplierRefresh()
        {
            dataGridViewSupplierListed.DataSource = _suplierService.GetAll().Data;
        }
    }
}

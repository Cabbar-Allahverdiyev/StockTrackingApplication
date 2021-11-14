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
using WindowsForm.Core.Controllers.ValidatorControllers;
using WindowsForm.Utilities.Search.Concrete.SupplierSearch;

namespace WindowsForm.Forms
{
    public partial class SupplierForm : Form
    {
        SupplierManager _suplierManager = new SupplierManager(new EfSupplierDal());
        SupplierValidationTool validationTool = new SupplierValidationTool();
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {

            var supplierGetAll = _suplierManager.GetAll();

            dataGridViewSupplierListed.DataSource = supplierGetAll.Data;
        }

        private void ButtonSupplierFormElaveEt_Click(object sender, EventArgs e)
        {


            Supplier supplier = new Supplier();
            supplier.CompanyName = TextBoxSupplierFormSirketAdi.Text;
            supplier.ContactName = TextBoxSupplierFormAd.Text;
            supplier.City = TextBoxSupplierFormSeher.Text;
            supplier.Address = TextBoxSupplierFormAdres.Text;
            supplier.Email = TextBoxSupplierFormEmail.Text;
            supplier.Phone = TextBoxSupplierFormTelefon.Text;
            supplier.WhenWillCome = TextBoxSupplierFormNeZamanGelir.Text;

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
            dataGridViewSupplierListed.DataSource = _suplierManager.GetAll().Data;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Supplier> data = _suplierManager.GetAll().Data;
            List<Supplier> oldData = _suplierManager.GetAll().Data;
            SupplierSearch supplierSearch = new SupplierSearch();
            supplierSearch.Search(data, oldData, textBoxAxtar.Text, dataGridViewSupplierListed);


        }
    }
}

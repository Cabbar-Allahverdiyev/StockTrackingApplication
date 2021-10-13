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

namespace WindowsForm.Forms
{
    public partial class SupplierForm : Form
    {
        SupplierManager _suplierManager = new SupplierManager(new EfSupplierDal());
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            
            var supplierGetAll = _suplierManager.GetAll();

            DataGridViewSupplierForm.DataSource = supplierGetAll.Data;
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

            SupplierValidator validationRules = new SupplierValidator();
            ValidationResult results = validationRules.Validate(supplier);
            if (!results.IsValid)
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    FormsMessage.ErrorMessage(failure.ErrorMessage);
                    return;
                }
                
            }

           var supplierAdd= _suplierManager.Add(supplier);
            if (!supplierAdd.Success)
            {
                FormsMessage.ErrorMessage(supplierAdd.Message);
                return;
            }
            FormsMessage.InformationMessage(supplierAdd.Message);
            DataGridViewSupplierForm.DataSource = _suplierManager.GetAll().Data;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }


        }

        
    }
}

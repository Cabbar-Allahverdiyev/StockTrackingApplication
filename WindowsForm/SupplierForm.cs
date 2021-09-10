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

namespace WindowsForm
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
                    MessageBox.Show(failure.ErrorMessage, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                return;
            }

           var supplierAdd= _suplierManager.Add(supplier);
            if (!supplierAdd.Success)
            {
                MessageBox.Show(supplierAdd.Message, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(supplierAdd.Message, AuthMessages.InformationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

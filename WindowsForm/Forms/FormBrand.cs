using Business.Concrete;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results;
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
    public partial class FormBrand : Form
    {
        public FormBrand()
        {
            InitializeComponent();
        }

        BrandManager _brandManager = new BrandManager(new EfBrandDal());
       

        private void FormBrand_Load(object sender, EventArgs e)
        {
            var get = _brandManager.GetAll();
            dataGridViewBrandsListed.DataSource = get.Data;
        }

        private void ButtonFormBrandElaveEt_Click(object sender, EventArgs e)
        {
            try
            {
                Brand brand = new Brand();
                brand.BrandName = TextBoxFormBrandMarkaAdi.Text;

                BrandValidator validationRules = new BrandValidator();
                ValidationResult results = validationRules.Validate(brand);

                if (results.IsValid == false)
                {
                    foreach (ValidationFailure failure in results.Errors)
                    {
                        FormsMessage.ErrorMessage(failure.ErrorMessage);
                    }
                    return;
                }

                IResult brandAdd = _brandManager.Add(brand);
                if (brandAdd.Success)
                {
                    FormsMessage.InformationMessage(brandAdd.Message);
                    dataGridViewBrandsListed.DataSource = _brandManager.GetAll().Data;
                }
                else
                {
                    FormsMessage.ErrorMessage(BrandMessages.BrandNotAdded);
                    return;
                }

                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        control.Text = "";
                    }
                }

            }
            catch (Exception)
            {
                FormsMessage.ErrorMessage(AuthMessages.ErrorMessage);
                return;
            }
           


        }
    }
}

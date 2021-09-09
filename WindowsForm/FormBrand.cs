﻿using Business.Concrete;
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
            DataGridViewFormBrand.DataSource = get.Data;
        }

        private void ButtonFormBrandElaveEt_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            brand.BrandName = TextBoxFormBrandMarkaAdi.Text;

            BrandValidator validationRules = new BrandValidator();
            ValidationResult results = validationRules.Validate(brand);

            if (results.IsValid == false)
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage);
                }
                return;
            }

            var brandAdd=_brandManager.Add(brand);
            if (brandAdd.Success)
            {
                MessageBox.Show(BrandMessages.BrandAdded, AuthMessages.InformationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridViewFormBrand.DataSource = _brandManager.GetAll().Data;
            }
            else
            {
                MessageBox.Show(BrandMessages.BrandNotAdded, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
    }
}

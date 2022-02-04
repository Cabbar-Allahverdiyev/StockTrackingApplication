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
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.Concrete.ValidatorControllers;
using WindowsForm.MyControls;
using WindowsForm.Utilities.Search.Concrete.BrandSearch;

namespace WindowsForm.Forms
{
    public partial class FormBrand : Form
    {
        public FormBrand()
        {
            InitializeComponent();
            MyControl myControl = new MyControl();
            myControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
        }

        BrandManager _brandManager = new BrandManager(new EfBrandDal());
        BrandValidationTool validationTool = new BrandValidationTool();
        BrandSearch brandSearch = new BrandSearch();

        private void FormBrand_Load(object sender, EventArgs e)
        {
            BrandRefresh();
        }

        private void ButtonFormBrandElaveEt_Click(object sender, EventArgs e)
        {
            try
            {
                Brand brand = new Brand();
                brand.BrandName = TextBoxFormBrandMarkaAdi.Text;

                if (!validationTool.IsValid(brand))
                {
                    return;
                }


                IResult brandAdd = _brandManager.Add(brand);
                if (brandAdd.Success)
                {
                    FormsMessage.SuccessMessage(brandAdd.Message);
                    BrandRefresh();
                }
                else
                {
                    FormsMessage.WarningMessage(BrandMessages.BrandNotAdded);
                    return;
                }

                foreach (Control control in this.Controls)
                {
                    TextBoxController.ClearAllTextBoxes(control);
                }

            }
            catch (Exception)
            {
                FormsMessage.ErrorMessage(AuthMessages.ErrorMessage);
                return;
            }



        }

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            brandSearch.GetDataWriteGridView(textBoxAxtar.Text, dataGridViewBrandsListed);
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            BrandRefresh();
        }

        private void BrandRefresh()
        {
            dataGridViewBrandsListed.DataSource = _brandManager.GetAll().Data;
        }
    }
}

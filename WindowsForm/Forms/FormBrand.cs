using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results;
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
using WindowsForm.Utilities.Search.Concrete.BrandSearch;

namespace WindowsForm.Forms
{
    public partial class FormBrand : Form
    {
        IBrandService _brandService;
        public FormBrand(IBrandService brandService)
        {
            _brandService = brandService;
            InitializeComponent();
            MyControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
        }

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

                if (!FormValidationTool.IsValid(new BrandValidator(), brand))
                {
                    return;
                }

                IResult brandAdd = _brandService.Add(brand);
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
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            List<Brand> data = _brandService.GetAll().Data;
            brandSearch.GetDataWriteGridView(data, textBoxAxtar.Text, dataGridViewBrandsListed);
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            BrandRefresh();
        }

        private void BrandRefresh()
        {
            dataGridViewBrandsListed.DataSource = _brandService.GetAll().Data;
        }
    }
}

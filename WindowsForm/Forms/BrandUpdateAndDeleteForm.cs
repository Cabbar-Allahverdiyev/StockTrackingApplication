using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation.BrandValidators;
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
using WindowsForm.Utilities.Search.Concrete.BrandSearch;

namespace WindowsForm.Forms
{
    public partial class BrandUpdateAndDeleteForm : Form
    {
        // BrandManager _brandService = new BrandManager(new EfBrandDal());
        IBrandService _brandService;
        BrandSearch brandSearch = new BrandSearch();

        public BrandUpdateAndDeleteForm(IBrandService brandService)
        {
            _brandService = brandService;
            InitializeComponent();
            BrandRefresh();

        }
        //Click-------------------------->
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        private void buttonSupplierYenile_Click(object sender, EventArgs e)
        {
            try
            {
                Brand brand = new Brand();
                brand.Id = int.Parse(textBoxId.Text);
                brand.BrandName = textBoxBrand.Text;

                if (!FormValidationTool.IsValid(new UpdateBrandValidator(), brand))
                {
                    return;
                }

                var brandUdated = _brandService.Update(brand);
                if (!brandUdated.Success)
                {
                    FormsMessage.WarningMessage(brandUdated.Message);
                    return;
                }
                FormsMessage.SuccessMessage(brandUdated.Message);
                BrandRefresh();
                TextBoxClear();

            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }



        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                Brand brand = new Brand();
                brand.Id = int.Parse(textBoxId.Text);
                var brandDeleted = _brandService.Delete(brand);
                if (!brandDeleted.Success)
                {
                    FormsMessage.WarningMessage(brandDeleted.Message);
                    return;
                }
                FormsMessage.SuccessMessage(brandDeleted.Message);
                BrandRefresh();
                TextBoxClear();

            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            BrandRefresh();
        }

        //Cell Double Click----------------------------------------->
        private void dataGridViewBrandList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewBrandList.CurrentRow == null)
            {
                FormsMessage.WarningMessage(BaseMessages.SelectedValueIsNull);
                return;
            }
            textBoxId.Text = dataGridViewBrandList.CurrentRow.Cells["Id"].Value.ToString();
            textBoxBrand.Text = dataGridViewBrandList.CurrentRow.Cells["BrandName"].Value.ToString();
        }

        //Tetx Changed------------------------------>
        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            List<Brand> data = _brandService.GetAll().Data;
            brandSearch.GetDataWriteGridView(data, textBoxAxtar.Text, dataGridViewBrandList);
        }


        //Elave metodlar---------------------------->
        private void BrandRefresh()
        {
            dataGridViewBrandList.DataSource = _brandService.GetAll().Data;
        }

        private void TextBoxClear()
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBox1);
        }

        private void dataGridViewBrandList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}

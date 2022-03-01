using Business.Concrete;
using Business.Constants.Messages;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
using WindowsForm.Utilities.Search.Concrete.BrandSearch;

namespace WindowsForm.Forms
{
    public partial class BrandUpdateAndDeleteForm : Form
    {
        BrandManager _brandManager = new BrandManager(new EfBrandDal());
        BrandValidationTool validationTool = new BrandValidationTool();
        BrandSearch brandSearch = new BrandSearch();

        public BrandUpdateAndDeleteForm()
        {
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

                if (!validationTool.IsValid(brand))
                {
                    return;
                }

                var brandUdated = _brandManager.Update(brand);
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
                FormsMessage.ErrorMessage($"{BaseMessages.ErrorMessage} | {ex.Message}");
                return;
            }
        }

        

        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                Brand brand = new Brand();
                brand.Id = int.Parse(textBoxId.Text);
                var brandDeleted = _brandManager.Delete(brand);
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
                FormsMessage.ErrorMessage($"{BaseMessages.ErrorMessage} | {ex.Message}");
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
            textBoxId.Text = dataGridViewBrandList.CurrentRow.Cells["Id"].Value.ToString();
            textBoxBrand.Text = dataGridViewBrandList.CurrentRow.Cells["BrandName"].Value.ToString();
        }

        //Tetx Changed------------------------------>
        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            brandSearch.GetDataWriteGridView(textBoxAxtar.Text, dataGridViewBrandList);
        }


        //Elave metodlar---------------------------->
        private void BrandRefresh()
        {
           dataGridViewBrandList.DataSource= _brandManager.GetAll().Data;
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

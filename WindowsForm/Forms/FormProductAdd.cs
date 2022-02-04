using Business.Concrete;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.ValidatorControllers;
using WindowsForm.MyControls;
using WindowsForm.Utilities.Search.Concrete.ProductSearch;

namespace WindowsForm.Forms
{
    public partial class FormProductAdd : Form
    {
        public FormProductAdd()
        {
            InitializeComponent();
            MyControl myControl = new MyControl();
            myControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
            myControl.WritePlaceholdersForTextBoxBarcodeNo(textBoxBarkodNo);
            myControl.WritePlaceholdersForTextBoxQuantityPerUnit(textBoxKemiyyet);

        }
        ProductManager _productManager = new ProductManager(new EfProductDal());
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        BrandManager _brandManager = new BrandManager(new EfBrandDal());
        SupplierManager _supplierManager = new SupplierManager(new EfSupplierDal());
        ProductValidationTool validationTool = new ProductValidationTool();

        ProductViewDetailSearch detailSearch = new ProductViewDetailSearch();

        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            ProductRefresh();            
            CategoryGetComboBoxYeni();
            BrandGetComboBoxYeni();
            SupplierGetComboBox();
            TextBoxController.ClearAllTextBoxesAndCmboBoxesByGroupBox(GroupBoxFormProductAddYeniMehsul);
            //GroupBoxYeniMehsulControlClear();
        }

        //Click---------------------------------------->

        private void ButtonFormProductAddYeniMehsulElaveEt_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.BarcodeNumber = textBoxBarkodNo.Text;
                product.BrandId = Convert.ToInt32(comboBoxMarka.SelectedValue);
                product.CategoryId = Convert.ToInt32(comboBoxKategoriya.SelectedValue);
                product.SupplierId = Convert.ToInt32(comboBoxTedarikci.SelectedValue);

                product.ProductName = textBoxMehsulAdi.Text;

                product.UnitsInStock = Convert.ToInt32(textBoxMiqdar.Text);
                product.PurchasePrice = Convert.ToDecimal(textBoxAlisQiymet.Text);
                product.UnitPrice = Convert.ToDecimal(textBoxSatisQiymet.Text);

                product.QuantityPerUnit = textBoxKemiyyet.Text;
                product.Description = textBoxAciqlama.Text;

                if (!validationTool.IsValid(product))
                { return; }

                IResult productAdd = _productManager.Add(product);
                if (!productAdd.Success)
                {
                    FormsMessage.WarningMessage(productAdd.Message);
                    return;
                }

                TextBoxController.ClearAllTextBoxesAndCmboBoxesByGroupBox(GroupBoxFormProductAddYeniMehsul);
                //GroupBoxYeniMehsulControlClear();
                ProductRefresh();
                FormsMessage.SuccessMessage(productAdd.Message);
            }
            catch (Exception)
            {
                FormsMessage.ErrorMessage(AuthMessages.ErrorMessage);
                return;
            }

        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            TextBoxController.ClearAllTextBoxesAndCmboBoxesByGroupBox(GroupBoxFormProductAddYeniMehsul);
        }

        //Cell Double Click----------------------------------------->
        private void DataGridViewProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            IDataResult<ProductViewDetailDto> productViewDetailByProductId = _productManager.GetProductViewProductIdDetail(
                     Convert.ToInt32(dataGridViewProductList.CurrentRow.Cells["ProductId"].Value.ToString())
                );

        }

        //Text Changed --------------------------------->
        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            detailSearch.GetDataWriteGridView(textBoxAxtar.Text, dataGridViewProductList);
        }

        //Key Press---------------------------------------->
        private void textBoxMiqdar_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyControl.MakeTextBoxNumberBox(e);
        }

        private void textBoxAlisQiymet_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyControl.MakeTextBoxDecimalBox(sender, e);
        }

        private void textBoxSatisQiymet_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyControl.MakeTextBoxDecimalBox(sender, e);
        }



        //Elave Metodlar---------------------->

        private void CategoryGetComboBoxYeni()
        {
            var categoryGetAll = _categoryManager.GetAll();
            comboBoxKategoriya.DataSource = categoryGetAll.Data;
            comboBoxKategoriya.DisplayMember = "CategoryName";
            comboBoxKategoriya.ValueMember = "Id";
        }



        private void BrandGetComboBoxYeni()
        {
            var brandGetAll = _brandManager.GetAll();

            comboBoxMarka.DataSource = brandGetAll.Data;
            comboBoxMarka.DisplayMember = "BrandName";
            comboBoxMarka.ValueMember = "Id";
        }

        private void SupplierGetComboBox()
        {
            var supplierGetAll = _supplierManager.GetAll();
            comboBoxTedarikci.DataSource = supplierGetAll.Data;
            comboBoxTedarikci.DisplayMember = "CompanyName";
            comboBoxTedarikci.ValueMember = "Id";
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            ProductRefresh();
        }

        private void ProductRefresh()
        {
            dataGridViewProductList.DataSource = _productManager.GetAllProductViewDasboardDetails().Data;
        }
    }
}

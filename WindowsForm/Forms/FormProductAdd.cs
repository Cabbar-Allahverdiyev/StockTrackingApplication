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
using WindowsForm.Core.Controllers.ValidatorControllers;
using WindowsForm.Utilities.Search.Concrete.ProductSearch;

namespace WindowsForm.Forms
{
    public partial class FormProductAdd : Form
    {
        public FormProductAdd()
        {
            InitializeComponent();
        }
        ProductManager _productManager = new ProductManager(new EfProductDal());
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        BrandManager _brandManager = new BrandManager(new EfBrandDal());
        SupplierManager _supplierManager = new SupplierManager(new EfSupplierDal());
        ProductValidationTool validationTool = new ProductValidationTool();



        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            dataGridViewProductList.DataSource = _productManager.GetProductCompactDetails().Data;
            CategoryGetComboBoxYeni();
            BrandGetComboBoxYeni();
            SupplierGetComboBox();
            GroupBoxYeniMehsulControlClear();
        }

        private void ButtonFormProductAddYeniMehsulElaveEt_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.BarcodeNumber = Convert.ToInt32(TextBoxFormProductAddBarkodNo.Text);
                product.BrandId = Convert.ToInt32(ComboBoxFormProductAddMarka.SelectedValue);
                product.CategoryId = Convert.ToInt32(ComboBoxFormProductAddKategoriya.SelectedValue);
                product.SupplierId = Convert.ToInt32(ComboBoxFormProductAddTedarikci.SelectedValue);

                product.ProductName = TextBoxFormProductAddMehsulAdi.Text;
                product.UnitsInStock = Convert.ToInt32(TextBoxFormProductAddMiqdar.Text);
                product.PurchasePrice = Convert.ToDecimal(TextBoxFormProductAddAlisQiymet.Text);
                product.UnitPrice = Convert.ToDecimal(TextBoxFormProductAddSatisQiymet.Text);
                product.QuantityPerUnit = TextBoxFormProductAddKemiyyet.Text;
                product.Description = TextBoxFormProductAddAciqlama.Text;

                if (!validationTool.IsValid(product))
                {
                    return;
                }

                IResult productAdd = _productManager.Add(product);
                if (!productAdd.Success)
                {
                    FormsMessage.WarningMessage(productAdd.Message);
                    return;
                }

                GroupBoxYeniMehsulControlClear();
                dataGridViewProductList.DataSource = _productManager.GetProductCompactDetails().Data;
                FormsMessage.SuccessMessage(productAdd.Message);


            }
            catch (Exception)
            {

                FormsMessage.ErrorMessage(AuthMessages.ErrorMessage);
                return;
            }

        }

        private void DataGridViewProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            IDataResult<ProductViewDetailDto> productViewDetailByProductId = _productManager.GetProductViewProductIdDetail(
                     Convert.ToInt32(dataGridViewProductList.CurrentRow.Cells["ProductId"].Value.ToString())
                );

        }

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            List<ProductViewDetailDto> data = _productManager.GetProductViewDetails().Data;
            List<ProductViewDetailDto> oldData = _productManager.GetProductViewDetails().Data;
            ProductViewDetailSearch search = new ProductViewDetailSearch();
            search.Search(data, oldData, textBoxAxtar.Text, dataGridViewProductList);
        }



        //Elave Metodlar---------------------->

        private void GroupBoxYeniMehsulControlClear()
        {
            foreach (Control control in GroupBoxFormProductAddYeniMehsul.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                if (control is ComboBox)
                {
                    control.Text = "";
                }

            }
        }

        private void CategoryGetComboBoxYeni()
        {
            var categoryGetAll = _categoryManager.GetAll();

            ComboBoxFormProductAddKategoriya.DataSource = categoryGetAll.Data;
            ComboBoxFormProductAddKategoriya.DisplayMember = "CategoryName";
            ComboBoxFormProductAddKategoriya.ValueMember = "Id";
        }



        private void BrandGetComboBoxYeni()
        {
            var brandGetAll = _brandManager.GetAll();

            ComboBoxFormProductAddMarka.DataSource = brandGetAll.Data;
            ComboBoxFormProductAddMarka.DisplayMember = "BrandName";
            ComboBoxFormProductAddMarka.ValueMember = "Id";
        }

        private void SupplierGetComboBox()
        {
            var supplierGetAll = _supplierManager.GetAll();
            ComboBoxFormProductAddTedarikci.DataSource = supplierGetAll.Data;
            ComboBoxFormProductAddTedarikci.DisplayMember = "CompanyName";
            ComboBoxFormProductAddTedarikci.ValueMember = "Id";
        }

       



    }
}

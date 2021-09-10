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


        private void FormProductAdd_Load(object sender, EventArgs e)
        {

            DataGridViewProductList.DataSource = _productManager.GetProductCompactDetails().Data;

            CategoryGetComboBoxYeni();
            CategoryGetComboBoxVarOlan();

            BrandGetComboBoxVarOlan();
            BrandGetComboBoxYeni();

            SupplierGetComboBox();
            GroupBoxVarOlanMehsulControlClear();
            GroupBoxYeniMehsulControlClear();

        }

        private void ButtonFormProductAddYeniMehsulElaveEt_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.BarcodeNumber = TextBoxFormProductAddBarkodNo.Text;
            product.BrandId = Convert.ToInt32(ComboBoxFormProductAddMarka.SelectedValue);
            product.CategoryId = Convert.ToInt32(ComboBoxFormProductAddKategoriya.SelectedValue);
            product.SupplierId = Convert.ToInt32(ComboBoxFormProductAddTedarikci.SelectedValue);

            product.ProductName = TextBoxFormProductAddMehsulAdi.Text;
            product.UnitsInStock = Convert.ToInt16(TextBoxFormProductAddMiqdar.Text);
            product.PurchasePrice = Convert.ToDecimal(TextBoxFormProductAddAlisQiymet.Text);
            product.UnitPrice = Convert.ToDecimal(TextBoxFormProductAddSatisQiymet.Text);
            product.QuantityPerUnit = TextBoxFormProductAddKemiyyet.Text;
            product.Description = TextBoxFormProductAddAciqlama.Text;


            ProductValidator validationRules = new ProductValidator();
            ValidationResult results = validationRules.Validate(product);
            if (!results.IsValid)
            {
                foreach (ValidationFailure validationFailure in results.Errors)
                {
                    MessageBox.Show(validationFailure.ErrorMessage, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            var productAdd = _productManager.Add(product);
            if (!productAdd.Success)
            {
                MessageBox.Show(productAdd.Message, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(productAdd.Message, AuthMessages.InformationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);


            GroupBoxYeniMehsulControlClear();

        }

        private void DataGridViewProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var productGetId = _productManager.GetByProductId(
            //        Convert.ToInt32(DataGridViewProductList.CurrentRow.Cells["ProductId"].Value.ToString())
            //    );
            var productViewDetailByProductId = _productManager.GetProductViewProductIdDetail(
                     Convert.ToInt32(DataGridViewProductList.CurrentRow.Cells["ProductId"].Value.ToString())
                );
            textBoxVarOlanBarkodNo.Text = DataGridViewProductList.CurrentRow.Cells["BarcodeNomresi"].Value.ToString();
            textBoxVarOlanMehsulAdi.Text = DataGridViewProductList.CurrentRow.Cells["MehsulAdi"].Value.ToString();
            comboBoxVarOlanKateqoriya.Text = productViewDetailByProductId.Data.Kateqoriya;
            comboBoxVarOlanMarka.Text = productViewDetailByProductId.Data.Marka;
            LabelMiqdarVB.Text = productViewDetailByProductId.Data.StokdakiVahid.ToString();

        }


         

        private void CategoryGetComboBoxVarOlan()
        {

            var categoryGetAll = _categoryManager.GetAll();

            comboBoxVarOlanKateqoriya.DataSource = categoryGetAll.Data;
            comboBoxVarOlanKateqoriya.DisplayMember = "CategoryName";
            comboBoxVarOlanKateqoriya.ValueMember = "Id";


        }

        private void CategoryGetComboBoxYeni()
        {
            var categoryGetAll = _categoryManager.GetAll();

            ComboBoxFormProductAddKategoriya.DataSource = categoryGetAll.Data;
            ComboBoxFormProductAddKategoriya.DisplayMember = "CategoryName";
            ComboBoxFormProductAddKategoriya.ValueMember = "Id";
        }

        private void BrandGetComboBoxVarOlan()
        {
            var brandGetAll = _brandManager.GetAll();

            comboBoxVarOlanMarka.DataSource = brandGetAll.Data;
            comboBoxVarOlanMarka.DisplayMember = "BrandName";
            comboBoxVarOlanMarka.ValueMember = "Id";

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

        private void GroupBoxVarOlanMehsulControlClear()
        {
            foreach (Control control in GroupBoxFormProductAddVarOlanMehsul.Controls)
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

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAxtar.Text.Length == 0)
            {
                DataGridViewProductList.DataSource = _productManager.GetProductCompactDetails().Data;
                return;
            }

            string productName = textBoxAxtar.Text.ToString();
            var productGetDetailsByName = _productManager.GetByPrdouctNameCompactDetails(productName);
            if (productGetDetailsByName.Success)
            {
                DataGridViewProductList.DataSource = productGetDetailsByName.Data;
            }
            else
            {
                MessageBox.Show(ProductMessages.ProductNotFound, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

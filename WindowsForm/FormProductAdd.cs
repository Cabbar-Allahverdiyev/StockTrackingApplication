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

            CategoryGetComboBox();
            BrandGetComboBox();
            SupplierGetComboBox();
        }

        private void ButtonFormProductAddYeniMehsulElaveEt_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.BarcoodeNumber = TextBoxFormProductAddBarkodNo.Text;
            product.BrandId = Convert.ToInt32(ComboBoxFormProductAddMarka.SelectedValue);
            product.CategoryId = Convert.ToInt32(ComboBoxFormProductAddKategoriya.SelectedValue);
            product.SupplierId = Convert.ToInt32(ComboBoxFormProductAddTedarikci.SelectedValue);

            //product.ProductName = TextBoxFormProductAddMehsulAdi.Text;
            //product.UnitsInStock = Convert.ToInt32(TextBoxFormProductAddMiqdar.Text);
            //product.PurchasePrice = Convert.ToDecimal(TextBoxFormProductAddAlisQiymet.Text);
            //product.UnitPrice = Convert.ToDecimal(TextBoxFormProductAddSatisQiymet.Text);
            //product.QuantityPerUnit = TextBoxFormProductAddKemiyyet.Text;
            //product.Description = TextBoxFormProductAddAciqlama.Text;


            //ProductValidator validationRules = new ProductValidator();
            //ValidationResult results = validationRules.Validate(product);
            //if (!results.IsValid)
            //{
            //    foreach (ValidationFailure validationFailure in results.Errors)
            //    {
            //        MessageBox.Show(validationFailure.ErrorMessage, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //var productAdd = _productManager.Add(product);
            //if (!productAdd.Success)
            //{
            //    MessageBox.Show(productAdd.Message, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //MessageBox.Show(productAdd.Message, AuthMessages.InformationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show($"{product.SupplierId}{product.CategoryId}{product.BrandId}");
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                if (control is ComboBox)
                {
                    control.Text ="";
                }
                
            }

        }




        private void CategoryGetComboBox()
        {
            var categoryGetAll = _categoryManager.GetAll();

            ComboBoxFormProductAddKategoriya.DataSource = categoryGetAll.Data;
            ComboBoxFormProductAddKategoriya.DisplayMember = "CategoryName";
            ComboBoxFormProductAddKategoriya.ValueMember = "Id";

            
        }

        private void BrandGetComboBox()
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

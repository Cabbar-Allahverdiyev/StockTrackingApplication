using Business.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.ValidationRules.FluentValidation;
using FluentValidation.Results;
using Business.Constants.Messages;

namespace WindowsForm
{
    public partial class FormProductList : Form
    {
        public FormProductList()
        {
            InitializeComponent();
        }
        ProductManager _productManager = new ProductManager(new EfProductDal());
        FormProductAdd formProductAdd = new FormProductAdd();
        Product product = new Product();


        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        BrandManager _brandManager = new BrandManager(new EfBrandDal());
        SupplierManager _supplierManager = new SupplierManager(new EfSupplierDal());

        private void FormProductList_Load(object sender, EventArgs e)
        {
            IDataResult<List<ProductViewDashboardDetailDto>> getProductDashboard = _productManager.GetProductViewDasgboardDetails();
            dataGridViewFormPrdouctList.DataSource = getProductDashboard.Data;

            BrandGetComboBoxVarOlan();
            CategoryGetComboBoxVarOlan();
            SupplierGetComboBox();
            GroupBoxVarOlanMehsulControlClear();
        }

        private void dataGridViewFormPrdouctList_DoubleClick(object sender, EventArgs e)
        {
            var productViewDetailByProductId = _productManager.GetProductViewProductIdDetail(
                    Convert.ToInt32(dataGridViewFormPrdouctList.CurrentRow.Cells["ProductId"].Value.ToString())
               );

            product.Id = productViewDetailByProductId.Data.ProductId;
            product.UnitsInStock = productViewDetailByProductId.Data.StokdakiVahid;
            product.QuantityPerUnit = productViewDetailByProductId.Data.Kemiyyet;

            textBoxVarOlanBarkodNo.Text = dataGridViewFormPrdouctList.CurrentRow.Cells["BarcodeNomresi"].Value.ToString();
            textBoxVarOlanMehsulAdi.Text = dataGridViewFormPrdouctList.CurrentRow.Cells["MehsulAdi"].Value.ToString();
            textBoxVarOlanAlisQiymet.Text = productViewDetailByProductId.Data.AlisQiymeti.ToString();
            textBoxVarOlanSatisQiymet.Text = productViewDetailByProductId.Data.Qiymet.ToString();
            comboBoxVarOlanKateqoriya.Text = productViewDetailByProductId.Data.Kateqoriya;
            comboBoxVarOlanMarka.Text = productViewDetailByProductId.Data.Marka;
            comboBoxVarOlanTedarikci.Text = productViewDetailByProductId.Data.TedarikciSirket;
            textBoxVarOlanMehsulAdi.Text = productViewDetailByProductId.Data.MehsulAdi;
            TextBoxVarOlanAciqlama.Text = productViewDetailByProductId.Data.Aciqlama;
            LabelMiqdarVB.Text = productViewDetailByProductId.Data.StokdakiVahid.ToString();




        }

        private void ButtonVarOlanYenile_Click(object sender, EventArgs e)
        {
            int newUnitInStock = 0;
            if (textBoxVarOlanStokaElaveEdilecekMiqdar.Text != "")
            {
                newUnitInStock = Convert.ToInt32(textBoxVarOlanStokaElaveEdilecekMiqdar.Text);
            }
            else
            {
                newUnitInStock = 0;
            }

            product.BarcodeNumber = Convert.ToInt32(textBoxVarOlanBarkodNo.Text);
            product.CategoryId = Convert.ToInt32(comboBoxVarOlanKateqoriya.SelectedValue);
            product.BrandId = Convert.ToInt32(comboBoxVarOlanMarka.SelectedValue);
            product.SupplierId = Convert.ToInt32(comboBoxVarOlanTedarikci.SelectedValue);
            product.ProductName = textBoxVarOlanMehsulAdi.Text;
            product.UnitsInStock = product.UnitsInStock + newUnitInStock;
            product.PurchasePrice = Convert.ToDecimal(textBoxVarOlanAlisQiymet.Text);
            product.UnitPrice = Convert.ToDecimal(textBoxVarOlanSatisQiymet.Text);
            product.Description = TextBoxVarOlanAciqlama.Text;

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

            IResult productUpdated = _productManager.Update(product);

            if (!productUpdated.Success)
            {
                MessageBox.Show(productUpdated.Message, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(productUpdated.Message, AuthMessages.InformationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);

            GroupBoxVarOlanMehsulControlClear();
            dataGridViewFormPrdouctList.DataSource = _productManager.GetProductViewDasgboardDetails().Data;



        }


        //elave metodlar------------------->
        //CategoryGetComboBoxVarOlan(),CategoryGetComboBoxVarOlan(),SupplierGetComboBox(),GroupBoxVarOlanMehsulControlClear()
        //Genericlestir mutleq
        private void CategoryGetComboBoxVarOlan()
        {

            var categoryGetAll = _categoryManager.GetAll();

            comboBoxVarOlanKateqoriya.DataSource = categoryGetAll.Data;
            comboBoxVarOlanKateqoriya.DisplayMember = "CategoryName";
            comboBoxVarOlanKateqoriya.ValueMember = "Id";


        }



        private void BrandGetComboBoxVarOlan()
        {
            var brandGetAll = _brandManager.GetAll();

            comboBoxVarOlanMarka.DataSource = brandGetAll.Data;
            comboBoxVarOlanMarka.DisplayMember = "BrandName";
            comboBoxVarOlanMarka.ValueMember = "Id";

        }



        private void SupplierGetComboBox()
        {
            var supplierGetAll = _supplierManager.GetAll();
            comboBoxVarOlanTedarikci.DataSource = supplierGetAll.Data;
            comboBoxVarOlanTedarikci.DisplayMember = "CompanyName";
            comboBoxVarOlanTedarikci.ValueMember = "Id";
        }

        private void GroupBoxVarOlanMehsulControlClear()
        {
            foreach (Control control in GroupBoxVarOlanMehsul.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                if (control is ComboBox)
                {
                    control.Text = "";
                }

                LabelMiqdarVB.Text = "";


            }
        }
    }
}

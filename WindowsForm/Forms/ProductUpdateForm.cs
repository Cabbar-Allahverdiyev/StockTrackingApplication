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
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.ValidatorControllers;

namespace WindowsForm.Forms
{
    public partial class ProductUpdateForm : Form
    {
        public ProductUpdateForm()
        {
            InitializeComponent();
        }
        ProductManager _productManager = new ProductManager(new EfProductDal());
        Product product = new Product();
        ProductValidationTool validationTool = new ProductValidationTool();

        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        BrandManager _brandManager = new BrandManager(new EfBrandDal());
        SupplierManager _supplierManager = new SupplierManager(new EfSupplierDal());

        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            IDataResult<List<ProductViewDashboardDetailDto>> getProductDashboard = _productManager.GetAllProductViewDasgboardDetails();
            dataGridViewFormPrdouctList.DataSource = getProductDashboard.Data;

            BrandGetComboBoxVarOlan();
            CategoryGetComboBoxVarOlan();
            SupplierGetComboBox();
            GroupBoxVarOlanMehsulControlClear();
        }


        private void ButtonVarOlanYenile_Click(object sender, EventArgs e)
        {

            try
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
                product.UnitsInStock += newUnitInStock;
                if (textBoxVarOlanAlisQiymet.Text != "")
                {
                    product.PurchasePrice = Convert.ToDecimal(textBoxVarOlanAlisQiymet.Text);
                }
                if (textBoxVarOlanSatisQiymet.Text != "")
                {
                    product.UnitPrice = Convert.ToDecimal(textBoxVarOlanSatisQiymet.Text);
                }
                product.Description = TextBoxVarOlanAciqlama.Text;

                if (!validationTool.IsValid(product))
                {
                    return;
                }


                IResult productUpdated = _productManager.Update(product);

                if (!productUpdated.Success)
                {
                    FormsMessage.WarningMessage(productUpdated.Message);
                    return;
                }
                FormsMessage.SuccessMessage(productUpdated.Message);
                GroupBoxVarOlanMehsulControlClear();
                dataGridViewFormPrdouctList.DataSource = _productManager.GetAllProductViewDasgboardDetails().Data;
            }
            catch (Exception)
            {
                FormsMessage.ErrorMessage($"{ButtonMessages.UpdateError} {AuthMessages.ErrorMessage} ");
                return;
            }
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

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAxtar.Text == "")
            {
                LabelMiqdarVB.Text = "";
                GroupBoxVarOlanMehsulControlClear();
                dataGridViewFormPrdouctList.DataSource = _productManager.GetAllProductViewDasgboardDetails().Data;
                return;
            }

            int barcodeNumber = Convert.ToInt32(textBoxAxtar.Text);
            IDataResult<List<ProductViewDashboardDetailDto>> productGetDetailsByName = _productManager.GetProductViewDasgboardDetailByBarcodeNumber(barcodeNumber);
            if (productGetDetailsByName.Success)
            {
                dataGridViewFormPrdouctList.DataSource = productGetDetailsByName.Data;
            }
            else
            {
                FormsMessage.ErrorMessage(productGetDetailsByName.Message);
            }
        }


    }
}


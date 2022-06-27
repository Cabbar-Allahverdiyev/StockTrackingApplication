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
using WindowsForm.Core.Controllers.Concrete.ValidatorControllers;
using WindowsForm.Utilities.Search.Concrete.ProductSearch;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.MyControls;
using System.Reflection;
using Entities.DTOs.ProductDtos;
using Business.Abstract;
using Business.ValidationRules.FluentValidation.ProductValidators;

namespace WindowsForm.Forms
{
    public partial class ProductUpdateForm : Form
    {
        Product product = new Product();
        //ProductValidationTool validationTool = new ProductValidationTool();
        ProductViewDashboardDetailsSearch detailsSearch = new ProductViewDashboardDetailsSearch();
        IProductService _productService;
        IBrandService _brandService;
        ICategoryService _categoryService;
        ISupplierService _supplierService;
        IFormSettingService _formSettingService;
        private MyControl _myControl;

        List<ProductViewDashboardDetailDto> _dataProductViewDashboardDetail;


        public ProductUpdateForm(IProductService productManager, IBrandService brandManager, ICategoryService categoryManager, ISupplierService supplierManager, IFormSettingService formSettingService)
        {
            _productService = productManager;
            _brandService = brandManager;
            _categoryService = categoryManager;
            _supplierService = supplierManager;
            _formSettingService = formSettingService;
            _dataProductViewDashboardDetail = _productService.GetAllProductViewDasboardDetail().Data;
            _myControl = new MyControl(_formSettingService);
            InitializeComponent();
            MyControl.WritePlaceholdersForTextBoxSearchByProductName(textBoxAxtar);
            MyControl.WritePlaceholdersForTextBoxBarcodeNo(textBoxBarkodNo);
        }

        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            ProductRefresh();
            WriteBrandsInComboBox();
            WriteCategoryInComboBox();
            WriteSuppliersInComboBox();
            GroupBoxVarOlanMehsulControlClear();
        }

        //Click---------------->
        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            ProductRefresh();
        }



        private void ButtonVarOlanYenile_Click(object sender, EventArgs e)
        {

            try
            {
                int newUnitInStock = 0;
                if (textBoxStokaElaveEdilecekMiqdar.Text != "")
                {
                    newUnitInStock = Convert.ToInt32(textBoxStokaElaveEdilecekMiqdar.Text);
                }
                else
                {
                    newUnitInStock = 0;
                }

                product.BarcodeNumber = textBoxBarkodNo.Text;
                product.CategoryId = Convert.ToInt32(comboBoxKateqoriya.SelectedValue);
                product.BrandId = Convert.ToInt32(comboBoxMarka.SelectedValue);
                product.SupplierId = Convert.ToInt32(comboBoxTedarikci.SelectedValue);
                product.ProductName = textBoxMehsulAdi.Text;
                product.LastModifiedDate = DateTime.Now;
                product.UnitsInStock += newUnitInStock;
                if (textBoxAlisQiymet.Text != "")
                {
                    product.PurchasePrice = Convert.ToDecimal(textBoxAlisQiymet.Text);
                }
                if (textBoxSatisQiymet.Text != "")
                {
                    product.UnitPrice = Convert.ToDecimal(textBoxSatisQiymet.Text);
                }
                product.Description = TextBoxAciqlama.Text;

                if (!FormValidationTool.IsValid(new UpdateProductValidator(),product))
                {
                    return;
                }


                IResult productUpdated = _productService.Update(product);

                if (!productUpdated.Success)
                {
                    FormsMessage.WarningMessage(productUpdated.Message);
                    return;
                }
                FormsMessage.SuccessMessage(productUpdated.Message);
                GroupBoxVarOlanMehsulControlClear();
                ProductRefresh();
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            GroupBoxVarOlanMehsulControlClear();
        }
        //Double Click---------------->

        private void dataGridViewFormPrdouctList_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewPrdouctList.CurrentRow == null)
            {
                FormsMessage.WarningMessage(BaseMessages.SelectedValueIsNull);
                return;
            }
            var productViewDetailByProductId = _productService.GetProductViewDetailByProductId(
                    Convert.ToInt32(dataGridViewPrdouctList.CurrentRow.Cells["ProductId"].Value.ToString())
               );

            textBoxStokaElaveEdilecekMiqdar.Text = "";
            product.Id = productViewDetailByProductId.Data.ProductId;
            product.UnitsInStock = productViewDetailByProductId.Data.StokdakiVahid;
            product.QuantityPerUnit = productViewDetailByProductId.Data.Kemiyyet;

            textBoxBarkodNo.Text = dataGridViewPrdouctList.CurrentRow.Cells["BarcodeNomresi"].Value.ToString();
            textBoxMehsulAdi.Text = dataGridViewPrdouctList.CurrentRow.Cells["MehsulAdi"].Value.ToString();
            textBoxAlisQiymet.Text = productViewDetailByProductId.Data.AlisQiymeti.ToString();
            textBoxSatisQiymet.Text = productViewDetailByProductId.Data.Qiymet.ToString();
            comboBoxKateqoriya.Text = productViewDetailByProductId.Data.Kateqoriya;
            comboBoxMarka.Text = productViewDetailByProductId.Data.Marka;
            comboBoxTedarikci.Text = productViewDetailByProductId.Data.TedarikciSirket;
            textBoxMehsulAdi.Text = productViewDetailByProductId.Data.MehsulAdi;
            TextBoxAciqlama.Text = productViewDetailByProductId.Data.Aciqlama;
            LabelMiqdarVB.Text = productViewDetailByProductId.Data.StokdakiVahid.ToString();
        }

        //Text Changed---------------->

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            detailsSearch.GetDataWriteGridView(_dataProductViewDashboardDetail, textBoxAxtar.Text, dataGridViewPrdouctList);
            //detailsSearch.SearchBySelectedValueOfComboBoxAndWriteToDataGridView(data,textBoxAxtar
            //    , dataGridViewPrdouctList, comboBoxProperty);
        }




        //Key Press------------------->
        private void textBoxStokaElaveEdilecekMiqdar_KeyPress(object sender, KeyPressEventArgs e)
        {
            _myControl.MakeTextBoxNumberBox(e);
        }

        private void textBoxAlisQiymet_KeyPress(object sender, KeyPressEventArgs e)
        {
            _myControl.MakeTextBoxDecimalBox(sender, e);
        }

        private void textBoxSatisQiymet_KeyPress(object sender, KeyPressEventArgs e)
        {
            _myControl.MakeTextBoxDecimalBox(sender, e);
        }




        //elave metodlar------------------->
        //CategoryGetComboBoxVarOlan(),CategoryGetComboBoxVarOlan(),SupplierGetComboBox(),GroupBoxVarOlanMehsulControlClear()
        //Genericlestir mutleq
        private void WriteCategoryInComboBox()
        {
            var categoryGetAll = _categoryService.GetAll();
            comboBoxKateqoriya.DataSource = categoryGetAll.Data;
            comboBoxKateqoriya.DisplayMember = "CategoryName";
            comboBoxKateqoriya.ValueMember = "Id";
        }

        private void WriteBrandsInComboBox()
        {
            var brandGetAll = _brandService.GetAll();
            comboBoxMarka.DataSource = brandGetAll.Data;
            comboBoxMarka.DisplayMember = "BrandName";
            comboBoxMarka.ValueMember = "Id";
        }



        private void WriteSuppliersInComboBox()
        {
            var supplierGetAll = _supplierService.GetAll();
            comboBoxTedarikci.DataSource = supplierGetAll.Data;
            comboBoxTedarikci.DisplayMember = "CompanyName";
            comboBoxTedarikci.ValueMember = "Id";
        }


        private void GroupBoxVarOlanMehsulControlClear()
        {
            TextBoxController.ClearAllTextBoxesAndCmboBoxesByGroupBox(GroupBoxVarOlanMehsul);
            LabelMiqdarVB.Text = "";
        }

        private void ProductRefresh()
        {
            _dataProductViewDashboardDetail = _productService.GetAllProductViewDasboardDetail().Data;
            dataGridViewPrdouctList.DataSource=_dataProductViewDashboardDetail;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


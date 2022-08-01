using Business.Abstract;
using Business.Concrete;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Business.ValidationRules.FluentValidation.ProductValidators;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs.ProductDtos;
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
using WindowsForm.Utilities.BarcodeScanner.BarcodeGenerate;
using WindowsForm.Utilities.Search.Concrete.ProductSearch;

namespace WindowsForm.Forms
{
    public partial class FormProductAdd : Form
    {
        IProductService _productService;
        IBrandService _brandService;
        ICategoryService _categoryService;
        ISupplierService _supplierService;
        IFormSettingService _formSettingService;
        private readonly IBarcodeGenerator _barcodeGenerator;

        private MyControl _myControl;


        public FormProductAdd(IProductService productService
                            , IBrandService brandService
                            , ICategoryService categoryService
                            , ISupplierService supplierService
                            , IFormSettingService formSettingService
                            , IBarcodeGenerator barcodeGenerator)
        {
            _productService = productService;
            _brandService = brandService;
            _categoryService = categoryService;
            _supplierService = supplierService;
            _formSettingService = formSettingService;
            _barcodeGenerator = barcodeGenerator;
            _myControl = new MyControl(_formSettingService);
            InitializeComponent();

            usbBarcodeScannerForm= new USBBarcodeScannerForm(_barcodeGenerator,_formSettingService);
             detailSearch= new ProductViewDashboardDetailsSearch();

            MyControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
            MyControl.WritePlaceholdersForTextBoxBarcodeNo(textBoxBarkodNo);
            MyControl.WritePlaceholdersForTextBoxQuantityPerUnit(textBoxKemiyyet);
        }

        private readonly USBBarcodeScannerForm usbBarcodeScannerForm;
        private readonly ProductViewDashboardDetailsSearch detailSearch;

        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            ProductRefresh();
            CategoryGetComboBoxYeni();
            BrandGetComboBoxYeni();
            SupplierGetComboBox();
            TextBoxController.ClearAllTextBoxesAndCmboBoxesByGroupBox(GroupBoxFormProductAddYeniMehsul);
            checkBoxIsClearTextBox.Checked = true;

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


                if (!FormValidationTool.IsValid(new CreateProductValidator(), product))
                { return; }

                IResult productAdd = _productService.Add(product);
                if (!productAdd.Success)
                {
                    FormsMessage.WarningMessage(productAdd.Message);
                    return;
                }
                if (checkBoxIsClearTextBox.Checked)
                {
                    TextBoxController.ClearAllTextBoxesAndCmboBoxesByGroupBox(GroupBoxFormProductAddYeniMehsul);

                }

                //GroupBoxYeniMehsulControlClear();
                ProductRefresh();
                FormsMessage.SuccessMessage(productAdd.Message);
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }

        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            TextBoxController.ClearAllTextBoxesAndCmboBoxesByGroupBox(GroupBoxFormProductAddYeniMehsul);
        }

        private void buttonBarcodeGenerate_Click(object sender, EventArgs e)
        {
            USBBarcodeScannerForm.BarcodeNumber = null;
            usbBarcodeScannerForm.ShowDialog();
            if (USBBarcodeScannerForm.BarcodeNumber == null)
            {
                FormsMessage.WarningMessage(BarcodeNumberMessages.BarcodeNumberNotSelected);
                return;
            }
            textBoxBarkodNo.Text = USBBarcodeScannerForm.BarcodeNumber;
            FormsMessage.SuccessMessage(BarcodeNumberMessages.BarcodeNumberSelected);
        }

        //Cell Double Click----------------------------------------->
        private void DataGridViewProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        //Text Changed --------------------------------->
        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            List<ProductViewDashboardDetailDto> data = _productService.GetAllProductViewDasboardDetail().Data;
            detailSearch.GetDataWriteGridView(data, textBoxAxtar.Text, dataGridViewProductList);
        }

        //Key Press---------------------------------------->
        private void textBoxMiqdar_KeyPress(object sender, KeyPressEventArgs e)
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



        //Elave Metodlar---------------------->

        private void CategoryGetComboBoxYeni()
        {
            var categoryGetAll = _categoryService.GetAll();
            comboBoxKategoriya.DataSource = categoryGetAll.Data;
            comboBoxKategoriya.DisplayMember = "CategoryName";
            comboBoxKategoriya.ValueMember = "Id";
        }



        private void BrandGetComboBoxYeni()
        {
            var brandGetAll = _brandService.GetAll();

            comboBoxMarka.DataSource = brandGetAll.Data;
            comboBoxMarka.DisplayMember = "BrandName";
            comboBoxMarka.ValueMember = "Id";
        }

        private void SupplierGetComboBox()
        {
            var supplierGetAll = _supplierService.GetAll();
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
            dataGridViewProductList.DataSource = _productService.GetAllProductViewDasboardDetail().Data;
        }

        private void checkBoxIsClearTextBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsClearTextBox.Checked)
            {

            }
        }
    }
}

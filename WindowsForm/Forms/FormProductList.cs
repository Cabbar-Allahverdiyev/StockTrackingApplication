using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Constants.Messages;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Utilities.Search.Concrete.ProductSearch;
using WindowsForm.MyControls;
using WindowsForm.Core.Controllers.Concrete;
using Entities.DTOs.ProductDtos;
using Business.Abstract;
using WindowsForm.Utilities.Helpers.OfficeHelpers;

namespace WindowsForm.Forms
{
    public partial class FormProductList : Form
    {
        IProductService _productService;
        IBrandService _brandService;
        ICategoryService _categoryService;
        ISupplierService _supplierService;
       private readonly ExcelHelper _excelHelper;

        ProductViewDashboardDetailsSearch detailsSearch = new ProductViewDashboardDetailsSearch();
        Product product = new Product();

        public FormProductList(IProductService productService
            , IBrandService brandService
            , ICategoryService categoryService
            , ISupplierService supplierService)
        {
            _productService = productService;
            _brandService = brandService;
            _categoryService = categoryService;
            _supplierService = supplierService;
            _excelHelper = new ExcelHelper(_productService);
            InitializeComponent();
            MyControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
        }


        private void FormProductList_Load(object sender, EventArgs e)
        {
            ProductRefresh();
            BrandGetComboBoxVarOlan();
            CategoryGetComboBoxVarOlan();
            SupplierGetComboBox();
            GroupBoxVarOlanMehsulControlClear();
        }

        private void buttonToExcel_Click(object sender, EventArgs e)
        {
            _excelHelper.CreateExcel();
        }

        private void dataGridViewFormPrdouctList_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewFormPrdouctList.CurrentRow == null)
            {
                FormsMessage.WarningMessage(BaseMessages.SelectedValueIsNull);
                return;
            }
            var productViewDetailByProductId = _productService.GetProductViewDetailByProductId(
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
            var categoryGetAll = _categoryService.GetAll();
            comboBoxVarOlanKateqoriya.DataSource = categoryGetAll.Data;
            comboBoxVarOlanKateqoriya.DisplayMember = "CategoryName";
            comboBoxVarOlanKateqoriya.ValueMember = "Id";
        }



        private void BrandGetComboBoxVarOlan()
        {
            var brandGetAll = _brandService.GetAll();
            comboBoxVarOlanMarka.DataSource = brandGetAll.Data;
            comboBoxVarOlanMarka.DisplayMember = "BrandName";
            comboBoxVarOlanMarka.ValueMember = "Id";
        }



        private void SupplierGetComboBox()
        {
            var supplierGetAll = _supplierService.GetAll();
            comboBoxVarOlanTedarikci.DataSource = supplierGetAll.Data;
            comboBoxVarOlanTedarikci.DisplayMember = "CompanyName";
            comboBoxVarOlanTedarikci.ValueMember = "Id";
        }


        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            List<ProductViewDashboardDetailDto> data = _productService.GetAllProductViewDasboardDetail().Data;
            detailsSearch.GetDataWriteGridView(data, textBoxAxtar.Text, dataGridViewFormPrdouctList);
            //detailsSearch.SearchBySelectedValueOfComboBoxAndWriteToDataGridView(data,textBoxAxtar
            //    , dataGridViewFormPrdouctList, comboBoxProperty);
            //detailsSearch.GetDataWriteGridView(textBoxAxtar.Text, dataGridViewFormPrdouctList);
        }


        private void GroupBoxVarOlanMehsulControlClear()
        {
            TextBoxController.ClearAllTextBoxesAndCmboBoxesByGroupBox(GroupBoxVarOlanMehsul);
            //foreach (Control control in GroupBoxVarOlanMehsul.Controls)
            //{

            //    if (control is TextBox)
            //    {
            //        control.Text = "";
            //    }
            //    if (control is ComboBox)
            //    {
            //        control.Text = "";
            //    }
            LabelMiqdarVB.Text = "";
            //}
        }


        private DataGridViewCell GetCellWhereTextExistsInGridView(string searchText, DataGridView dataGridView, int columnIndex)
        {
            DataGridViewCell cellWhereTextIsMet = null;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnIndex].Value != null && searchText == row.Cells[columnIndex].Value.ToString())
                {
                    cellWhereTextIsMet = row.Cells[columnIndex];
                    break;
                }
            }
            return cellWhereTextIsMet;
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            ProductRefresh();
        }

        private void ProductRefresh()
        {
            dataGridViewFormPrdouctList.DataSource = _productService.GetAllProductViewDasboardDetail().Data;
        }

        
    }
}

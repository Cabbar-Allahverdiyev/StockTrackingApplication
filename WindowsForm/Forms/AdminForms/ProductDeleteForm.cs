using Business.Concrete;
using Entities.Concrete;
using Entities.DTOs.ProductDtos;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
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
using System.Reflection;
using Business.Abstract;

namespace WindowsForm.Forms
{
    public partial class ProductDeleteForm : Form
    {
        Product product = new Product();

        //ProductManager _productService = new ProductManager(new EfProductDal());
        //CategoryManager _categoryService = new CategoryManager(new EfCategoryDal());
        //BrandManager _brandService = new BrandManager(new EfBrandDal());
        //SupplierManager _supplierService = new SupplierManager(new EfSupplierDal());

        IProductService _productService;
        IBrandService _brandService;
        ICategoryService _categoryService;
        ISupplierService _supplierService;

        ProductViewDashboardDetailsSearch detailsSearch = new ProductViewDashboardDetailsSearch();
        MyControl myControl = new MyControl();

        public ProductDeleteForm(IProductService productService
                                , IBrandService brandService
                                , ICategoryService categoryService
                                , ISupplierService supplierService)
        {
            _productService = productService;
            _brandService = brandService;
            _categoryService = categoryService;
            _supplierService = supplierService;
            InitializeComponent();
            myControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
        }

        private void ProductDeleteForm_Load(object sender, EventArgs e)
        {
            ProductRefresh();
            //  myControl.WriteProductPropertiesInComboBox(comboBoxProperty);
            BrandGetComboBoxVarOlan();
            CategoryGetComboBoxVarOlan();
            SupplierGetComboBox();
            GroupBoxVarOlanMehsulControlClear();
        }

        //Click---------------------------->
        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                //Product result = _productManager.GetByProductBarcodeNumber(textBoxVarOlanBarkodNo.Text).Data;
                product.Id = int.Parse(dataGridViewProductList.CurrentRow.Cells["ProductId"].Value.ToString());
                IResult productDeleted = _productService.Delete(product);
                if (!productDeleted.Success)
                {
                    FormsMessage.ErrorMessage(productDeleted.Message);
                    return;
                }
                FormsMessage.SuccessMessage(productDeleted.Message);
                ProductRefresh();
                GroupBoxVarOlanMehsulControlClear();
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

        //Double Click ------------------------------------>
        private void dataGridViewFormPrdouctList_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewProductList.CurrentRow == null)
            {
                FormsMessage.WarningMessage(BaseMessages.SelectedValueIsNull);
                return;
            }
            var productViewDetailByProductId = _productService.GetProductViewDetailByProductId(
                             Convert.ToInt32(dataGridViewProductList.CurrentRow.Cells["ProductId"].Value.ToString())
                        );

            product.Id = productViewDetailByProductId.Data.ProductId;
            product.UnitsInStock = productViewDetailByProductId.Data.StokdakiVahid;
            product.QuantityPerUnit = productViewDetailByProductId.Data.Kemiyyet;

            textBoxVarOlanBarkodNo.Text = dataGridViewProductList.CurrentRow.Cells["BarcodeNomresi"].Value.ToString();
            textBoxVarOlanMehsulAdi.Text = dataGridViewProductList.CurrentRow.Cells["MehsulAdi"].Value.ToString();
            textBoxVarOlanAlisQiymet.Text = productViewDetailByProductId.Data.AlisQiymeti.ToString();
            textBoxVarOlanSatisQiymet.Text = productViewDetailByProductId.Data.Qiymet.ToString();
            comboBoxVarOlanKateqoriya.Text = productViewDetailByProductId.Data.Kateqoriya;
            comboBoxVarOlanMarka.Text = productViewDetailByProductId.Data.Marka;
            comboBoxVarOlanTedarikci.Text = productViewDetailByProductId.Data.TedarikciSirket;
            textBoxVarOlanMehsulAdi.Text = productViewDetailByProductId.Data.MehsulAdi;
            TextBoxVarOlanAciqlama.Text = productViewDetailByProductId.Data.Aciqlama;
            LabelMiqdarVB.Text = productViewDetailByProductId.Data.StokdakiVahid.ToString();

        }

        //Text changed -------------------------------->
        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            List<ProductViewDashboardDetailDto> data = _productService.GetAllProductViewDasboardDetails().Data;
            detailsSearch.GetDataWriteGridView(data, textBoxAxtar.Text, dataGridViewProductList);
            //detailsSearch.SearchBySelectedValueOfComboBoxAndWriteToDataGridView(data,textBoxAxtar, dataGridViewProductList, comboBoxProperty);
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


        private void GroupBoxVarOlanMehsulControlClear()
        {
            TextBoxController.ClearAllTextBoxesAndCmboBoxesByGroupBox(GroupBoxVarOlanMehsul);
            LabelMiqdarVB.Text = "";
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            ProductRefresh();
        }

        private void ProductRefresh()
        {
            IDataResult<List<ProductViewDashboardDetailDto>> getProductDashboard = _productService.GetAllProductViewDasboardDetails();
            dataGridViewProductList.DataSource = getProductDashboard.Data;
        }
    }
}

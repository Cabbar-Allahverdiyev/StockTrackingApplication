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
using Business.Constants.Messages;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Utilities.Search.Concrete.ProductSearch;
using WindowsForm.MyControls;
using WindowsForm.Core.Controllers.Concrete;

namespace WindowsForm.Forms
{
    public partial class ProductDeleteForm : Form
    {
        ProductManager _productManager = new ProductManager(new EfProductDal());
        Product product = new Product();

        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        BrandManager _brandManager = new BrandManager(new EfBrandDal());
        SupplierManager _supplierManager = new SupplierManager(new EfSupplierDal());

        ProductViewDashboardDetailsSearch detailsSearch = new ProductViewDashboardDetailsSearch();
        MyControl myControl = new MyControl();

        public ProductDeleteForm()
        {
            InitializeComponent();

            myControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
        }

        private void ProductDeleteForm_Load(object sender, EventArgs e)
        {
            ProductRefresh();
            myControl.WriteProductPropertiesInComboBox(comboBoxProperty);
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
                Product result = _productManager.GetByProductBarcodeNumber(textBoxVarOlanBarkodNo.Text).Data;
                product.Id = result.Id;
                IResult productDeleted = _productManager.Delete(product);
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
                FormsMessage.ErrorMessage($"{AuthMessages.ErrorMessage} | {ex.Message}");
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
            var productViewDetailByProductId = _productManager.GetProductViewProductIdDetail(
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
            detailsSearch.SearchBySelectedValueOfComboBoxAndWriteToDataGridView(textBoxAxtar, dataGridViewProductList, comboBoxProperty);
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
            TextBoxController.ClearAllTextBoxesAndCmboBoxesByGroupBox(GroupBoxVarOlanMehsul);
            LabelMiqdarVB.Text = "";
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            ProductRefresh();
        }

        private void ProductRefresh()
        {
            IDataResult<List<ProductViewDashboardDetailDto>> getProductDashboard = _productManager.GetAllProductViewDasboardDetails();
            dataGridViewProductList.DataSource = getProductDashboard.Data;
        }
    }
}

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

namespace WindowsForm.Forms
{
    public partial class FormProductList : Form
    {
        public FormProductList()
        {
            InitializeComponent();
        }
        ProductManager _productManager = new ProductManager(new EfProductDal());
        Product product = new Product();


        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        BrandManager _brandManager = new BrandManager(new EfBrandDal());
        SupplierManager _supplierManager = new SupplierManager(new EfSupplierDal());

        private void FormProductList_Load(object sender, EventArgs e)
        {
            IDataResult<List<ProductViewDashboardDetailDto>> getProductDashboard = _productManager.GetAllProductViewDasgboardDetails();
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





        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            //if (textBoxAxtar.Text == "")
            //{
            //    LabelMiqdarVB.Text = "";
            //    GroupBoxVarOlanMehsulControlClear();
            //    dataGridViewFormPrdouctList.DataSource = _productManager.GetAllProductViewDasgboardDetails().Data;
            //    return;
            //}

            //int barcodeNumber = Convert.ToInt32(textBoxAxtar.Text);
            //IDataResult<List<ProductViewDashboardDetailDto>> productGetDetailsByName = _productManager.GetProductViewDasgboardDetailByBarcodeNumber(barcodeNumber);
            //if (productGetDetailsByName.Success)
            //{
            //    dataGridViewFormPrdouctList.DataSource = productGetDetailsByName.Data;
            //}
            //else
            //{
            //    FormsMessage.ErrorMessage(ProductMessages.ProductNotFound);
            //}
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

        private void buttonAxtar_Click(object sender, EventArgs e)
        {
            //ChangeTheColorOfTheSoughtValue(2);


            Filter(textBoxAxtar.Text);
        }

        private void Filter(string searchText)
        {

            List<ProductViewDashboardDetailDto> newProductList = new List<ProductViewDashboardDetailDto>();
            List<ProductViewDashboardDetailDto> oldProductList = _productManager.GetAllProductViewDasgboardDetails().Data;
            List<ProductViewDashboardDetailDto> productList = _productManager.GetAllProductViewDasgboardDetails().Data;
            searchText = searchText.ToLower();
            for (int i = 0; i < productList.Count; i++)
            {
                productList[i].MehsulAdi = productList[i].MehsulAdi.ToLower();
            }

            foreach (var product in productList)
            {
                if (product.MehsulAdi.Contains(searchText))
                {
                    newProductList.Add(product);
                }
            }

            if (textBoxAxtar.Text != "")
            {
                if (newProductList.Count == 0)
                {
                    FormsMessage.ErrorMessage(ProductMessages.ProductNotFound);
                    return;
                }
                dataGridViewFormPrdouctList.DataSource = newProductList;
                return;
            }

            dataGridViewFormPrdouctList.DataSource = oldProductList;
        }


        private void ChangeTheColorOfTheSoughtValue(int columnIndex)
        {
            string searchValue = textBoxAxtar.Text;
            DataGridViewCell cell = GetCellWhereTextExistsInGridView(textBoxAxtar.Text, dataGridViewFormPrdouctList, columnIndex);
            if (cell != null)
            {
                cell.Style = new DataGridViewCellStyle { ForeColor = Color.Red };
            }
            else
            {
                FormsMessage.ErrorMessage(ProductMessages.ProductNotFound);
            }
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


    }
}

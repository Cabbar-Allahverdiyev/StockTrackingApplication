using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using Entities.Concrete;
using Business.Abstract;

namespace WindowsForm.Forms
{
    public partial class StatisticForProductForm : Form
    {
        //ProductManager _productManager = new ProductManager(new EfProductDal());
        //EfSaleWinFormDal formDal = new EfSaleWinFormDal();

        IProductService _productService;

        public StatisticForProductForm(IProductService productService)
        {
            _productService = productService;
            InitializeComponent();
            ProductListRefresh();
        }

        private void StatisticForProductForm_Load(object sender, EventArgs e)
        {

        }

        //Click---------------------------->

        private void buttonEnCoxSatilan_Click(object sender, EventArgs e)
        {
           // IDataResult<List<ProductViewDashboardDetailDto>> result = _productManager.GetAllProductViewDashboardDetailByTopSelling();
            //List<Product> result = formDal.GetAllWinFormDtoDetailsByTopSellinQuery();
           
            //dataGridViewProductList.DataSource = result;
           
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            ProductListRefresh();
        }

        private void buttonAzalan_Click(object sender, EventArgs e)
        {
            //IDataResult<List<ProductViewDashboardDetailDto>> result = _productManager.GetAllProductViewDashboardDetailByDecreasingProducts();
            //if (!result.Success)
            //{
            //    FormsMessage.ErrorMessage(result.Message);
            //    return;
            //}
            //dataGridViewProductList.DataSource = result.Data;
            //FormsMessage.SuccessMessage(result.Message);
        }

        private void buttonSatilmayan_Click(object sender, EventArgs e)
        {
            //IDataResult<List<ProductViewDashboardDetailDto>> result = _productManager.GetAllProductViewDashboardDetailByProductsThatNeverSell();
            //if (!result.Success)
            //{
            //    FormsMessage.ErrorMessage(result.Message);
            //    return;
            //}
            //dataGridViewProductList.DataSource = result.Data;
            //FormsMessage.SuccessMessage(result.Message);
        }

        private void buttonBitenler_Click(object sender, EventArgs e)
        {
            //IDataResult<List<ProductViewDashboardDetailDto>> result = _productManager.GetAllProductViewDashboardDetailByFinishedProducts();
            //if (!result.Success)
            //{
            //    FormsMessage.ErrorMessage(result.Message);
            //    return;
            //}
            //dataGridViewProductList.DataSource = result.Data;
            //FormsMessage.SuccessMessage(result.Message);
        }

        private void ProductListRefresh()
        {
            dataGridViewProductList.DataSource =  _productService.GetAllProductViewDasboardDetails().Data;
        }

     
    }
}

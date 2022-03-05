using Business.Concrete;
using Business.Constants.Messages;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.ProductSearch
{
    public class ProductViewDashboardDetailsSearch : IWinFormsSearch
    {
        ProductManager _productManager = new ProductManager(new EfProductDal());
       

        public void GetDataWriteGridView(string seachText,DataGridView dataGridView)
        {
            
            List<ProductViewDashboardDetailDto> data = _productManager.GetAllProductViewDasboardDetails().Data;
            List<ProductViewDashboardDetailDto> oldData = data;
            SearchByProductName(data, oldData, seachText, dataGridView);
        }
        public void GetDataWriteGridView(string seachText,DataGridView dataGridView,string property)
        {
            List<ProductViewDashboardDetailDto> data = _productManager.GetAllProductViewDasboardDetails().Data;
            List<ProductViewDashboardDetailDto> oldData = _productManager.GetAllProductViewDasboardDetails().Data;
            if (property=="BarcodeNumber")
            {
                SearchByBarcodeNumber(data, oldData, seachText, dataGridView);
                return;
            }
            SearchByProductName(data, oldData, seachText, dataGridView);



        }

        public void SearchByProductName(List<ProductViewDashboardDetailDto> data, List<ProductViewDashboardDetailDto> oldData, string searchText, DataGridView dataGridView)
        {

            List<ProductViewDashboardDetailDto> newProductList = new List<ProductViewDashboardDetailDto>();
            List<ProductViewDashboardDetailDto> oldProductList = oldData;
            List<ProductViewDashboardDetailDto> productList = data;
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

            if (searchText != "")
            {
                if (newProductList.Count == 0)
                {
                   // FormsMessage.ErrorMessage(ProductMessages.ProductNotFound);
                    return;
                }
                dataGridView.DataSource = newProductList;
                return;
            }

            dataGridView.DataSource = oldProductList;
        }

        public void SearchByBarcodeNumber(List<ProductViewDashboardDetailDto> data, List<ProductViewDashboardDetailDto> oldData, string searchText, DataGridView dataGridView)
        {

            List<ProductViewDashboardDetailDto> newProductList = new List<ProductViewDashboardDetailDto>();
            List<ProductViewDashboardDetailDto> oldProductList = oldData;
            List<ProductViewDashboardDetailDto> productList = data;
            searchText = searchText.ToLower();
            for (int i = 0; i < productList.Count; i++)
            {
                productList[i].BarcodeNomresi = productList[i].BarcodeNomresi.ToLower();
            }

            foreach (var product in productList)
            {
                if (product.BarcodeNomresi.Contains(searchText))
                {
                    newProductList.Add(product);
                }
            }

            if (searchText != "")
            {
                if (newProductList.Count == 0)
                {
                    FormsMessage.ErrorMessage(ProductMessages.ProductNotFound);
                    return;
                }
                dataGridView.DataSource = newProductList;
                return;
            }

            dataGridView.DataSource = oldProductList;
        }

        public void SearchBySelectedValueOfComboBoxAndWriteToDataGridView(TextBox textBox, DataGridView dataGridView, ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                if (comboBox.SelectedItem.ToString() == "Barkod")
                {
                    GetDataWriteGridView(textBox.Text, dataGridView, "BarcodeNumber");
                    return;
                }
            }
            GetDataWriteGridView(textBox.Text, dataGridView);
        }
    }
}

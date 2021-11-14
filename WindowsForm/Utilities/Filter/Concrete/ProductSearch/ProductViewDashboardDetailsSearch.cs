using Business.Constants.Messages;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Utilities.Filter.Abstract;

namespace WindowsForm.Utilities.Filter.Concrete.ProductSearch
{
    public class ProductViewDashboardDetailsSearch : IWinFormsSearch
    {
        public void Search(List<ProductViewDashboardDetailDto> data, List<ProductViewDashboardDetailDto> oldData, string searchText, DataGridView dataGridView)
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
                    FormsMessage.ErrorMessage(ProductMessages.ProductNotFound);
                    return;
                }
                dataGridView.DataSource = newProductList;
                return;
            }

            dataGridView.DataSource = oldProductList;
        }
    }
}

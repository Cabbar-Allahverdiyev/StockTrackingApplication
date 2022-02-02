using Business.Concrete;
using Business.Constants.Messages;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.ProductSearch
{
    public class ProductViewDetailSearch : IWinFormsSearch
    {
        ProductManager _productManager = new ProductManager(new EfProductDal());

        public void GetDataWriteGridView(string seachText, DataGridView dataGridView)
        {
            //heleki hec bir yerde istifade edilmeyib proyekt bitdikden sonra istifade olunmazsa sil bu classi
            List<ProductViewDetailDto> data = _productManager.GetProductViewDetails().Data;
            List<ProductViewDetailDto> oldData = _productManager.GetProductViewDetails().Data;
            Search(data, oldData, seachText, dataGridView);
        }

        public void Search(List<ProductViewDetailDto> data, List<ProductViewDetailDto> oldData, string searchText, DataGridView dataGridView)
        {
            List<ProductViewDetailDto> newList = new List<ProductViewDetailDto>();
            List<ProductViewDetailDto> oldList = oldData;
            List<ProductViewDetailDto> list = data;
            searchText = searchText.ToLower();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].MehsulAdi = list[i].MehsulAdi.ToLower();
            }

            foreach (var item in list)
            {
                if (item.MehsulAdi.Contains(searchText))
                {
                    newList.Add(item);
                }
            }

            if (searchText != "")
            {
                if (newList.Count == 0)
                {
                    FormsMessage.ErrorMessage(ProductMessages.ProductNotFound);
                    return;
                }
                dataGridView.DataSource = newList;
                return;
            }

            dataGridView.DataSource = oldList;
        }

        public void SearchBySelectedValueOfComboBoxAndWriteToDataGridView(TextBox textBox, DataGridView dataGridView, ComboBox comboBox)
        {
            throw new NotImplementedException();
        }
    }
}

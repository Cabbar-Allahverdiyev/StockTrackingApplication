using Business.Constants.Messages;
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
    }
}

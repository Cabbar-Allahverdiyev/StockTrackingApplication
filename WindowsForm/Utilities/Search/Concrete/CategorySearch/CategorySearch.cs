using Business.Constants.Messages;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.CategorySearch
{
    public class CategorySearch : IWinFormsSearch
    {
        
        public void Search(List<Category> data, List<Category> oldData, string searchText, DataGridView dataGridView)
        {

            List<Category> newList = new List<Category>();
            List<Category> oldList = oldData;
            List<Category> list = data;
            searchText = searchText.ToLower();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].CategoryName = list[i].CategoryName.ToLower();
            }

            foreach (var item in list)
            {
                if (item.CategoryName.Contains(searchText))
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

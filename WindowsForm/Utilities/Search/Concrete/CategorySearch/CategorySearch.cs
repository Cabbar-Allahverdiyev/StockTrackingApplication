using Business.Concrete;
using Business.Constants.Messages;
using DataAccess.Concrete.EntityFramework;
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
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        public void GetDataWriteGridView(string seachText, DataGridView dataGridView)
        {
            List<Category> data = _categoryManager.GetAll().Data;
            List<Category> oldData = _categoryManager.GetAll().Data;
            Search(data, oldData, seachText, dataGridView);
        }

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
                    FormsMessage.ErrorMessage(CategoryMessages.CategoryNotFound);
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

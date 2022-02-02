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

namespace WindowsForm.Utilities.Search.Concrete.BrandSearch
{
    public class BrandSearch : IWinFormsSearch
    {
        BrandManager _brandManager = new BrandManager(new EfBrandDal());

        public void GetDataWriteGridView(string seachText, DataGridView dataGridView)
        {
           
            List<Brand> data = _brandManager.GetAll().Data;
            List<Brand> oldData = _brandManager.GetAll().Data;
            Search(data, oldData, seachText, dataGridView);
        }

        public void Search(List<Brand> data, List<Brand> oldData, string searchText, DataGridView dataGridView)
        {

            List<Brand> newList = new List<Brand>();
            List<Brand> oldList = oldData;
            List<Brand> list = data;
            searchText = searchText.ToLower();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].BrandName = list[i].BrandName.ToLower();
            }

            foreach (var product in list)
            {
                if (product.BrandName.Contains(searchText))
                {
                    newList.Add(product);
                }
            }

            if (searchText != "")
            {
                if (newList.Count == 0)
                {
                    FormsMessage.ErrorMessage(BrandMessages.BrandNotFound);
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

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

namespace WindowsForm.Utilities.Search.Concrete.SupplierSearch
{
    public class SupplierSearch : IWinFormsSearch
    {
        SupplierManager _supplierManager = new SupplierManager(new EfSupplierDal());

        public void GetDataWriteGridView(string seachText, DataGridView dataGridView)
        {
            List<Supplier> data = _supplierManager.GetAll().Data;
            List<Supplier> oldData = _supplierManager.GetAll().Data;
            Search(data, oldData, seachText, dataGridView);
        }

        public void Search(List<Supplier> data, List<Supplier> oldData, string searchText, DataGridView dataGridView)
        {
            List<Supplier> newList = new List<Supplier>();
            List<Supplier> oldList = oldData;
            List<Supplier> list = data;
            searchText = searchText.ToLower();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].CompanyName = list[i].CompanyName.ToLower();
            }

            foreach (var product in list)
            {
                if (product.CompanyName.Contains(searchText))
                {
                    newList.Add(product);
                }
            }

            if (searchText != "")
            {
                if (newList.Count == 0)
                {
                    FormsMessage.ErrorMessage(SupplierMessages.SupplierNotFound);
                    return;
                }
                dataGridView.DataSource = newList;
                return;
            }

            dataGridView.DataSource = oldList;
        }
    }
}

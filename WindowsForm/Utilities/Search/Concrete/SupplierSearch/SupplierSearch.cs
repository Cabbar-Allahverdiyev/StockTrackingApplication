using Business.Concrete;
using Business.Constants.Messages;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.SupplierSearch
{
    public class SupplierSearch : IWinFormsSearch<Supplier>
    {
        public void GetDataWriteGridView(List<Supplier> data, string seachText, DataGridView dataGridView)
        {
            dataGridView.DataSource = Search(data, seachText);
        }

        public List<Supplier> Search(List<Supplier> data, string searchText)
        {
            return data.Where(s => $"{s.Id} {s.CompanyName} {s.ContactName} {s.WhenWillCome} {s.Address} {s.City} {s.Email} {s.Phone} {s.IsSupplierActive}"
            .ToLower().Contains(searchText.ToLower())).ToList();
        }

    }
}

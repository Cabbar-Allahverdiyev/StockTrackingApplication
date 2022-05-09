using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.CustomerSearch
{
    public class CustomerSearch : IWinFormsSearch<Customer>
    {
        public void GetDataWriteGridView(List<Customer> data, string seachText, DataGridView dataGridView)
        {
            dataGridView.DataSource = Search(data,seachText);
        }

        public List<Customer> Search(List<Customer> data, string searchText)
        {
            return data.Where(c => $"{c.Id} {c.FirstName} {c.LastName} {c.PhoneNumber} {c.Address} {c.Email} {c.CreatedDate}"
           .ToLower().Contains(searchText.ToLower())).ToList();
        }
    }
}

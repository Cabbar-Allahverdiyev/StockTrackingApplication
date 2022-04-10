using Entities.DTOs.CustomerDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.CustomerSearch
{
    public class CustomerDtoSearch : IWinFormsSearch<CustomerDto>
    {
        public void GetDataWriteGridView(List<CustomerDto> data, string seachText, DataGridView dataGridView)
        {
            dataGridView.DataSource = Search(data, seachText);
        }

        public List<CustomerDto> Search(List<CustomerDto> data, string searchText)
        {
            return data.Where(c=>$"{c.CustomerId} {c.FirstName} {c.LastName} {c.PhoneNumber} {c.Address} {c.Debt} {c.Balance} {c.CustomerCreatedDate}"
            .ToLower().Contains(searchText.ToLower())).ToList();
        }
    }
}

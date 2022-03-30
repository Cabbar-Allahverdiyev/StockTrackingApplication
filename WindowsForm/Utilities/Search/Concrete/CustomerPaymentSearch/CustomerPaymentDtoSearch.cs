using Business.Abstract;
using Business.Constants.Messages;
using Entities.Concrete;
using Entities.DTOs.CustomerPaymentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.CustomerPaymentSearch
{
    public class CustomerPaymentDtoSearch : IWinFormsSearch<CustomerPaymentDto>
    {

        public List<CustomerPaymentDto> Search(List<CustomerPaymentDto> data, string searchText)
        {
            return data.Where(c => $"{c.FullName} {c.Value} {c.PaymentStatus} {c.Date}".ToLower().Contains(searchText.ToLower())).ToList();

        }

        public void GetDataWriteGridView(List<CustomerPaymentDto> data, string seachText, DataGridView dataGridView)
        {
            dataGridView.DataSource = Search(data, seachText);
        }


    }
}

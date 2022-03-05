using Business.Abstract;
using Business.Constants.Messages;
using Entities.Concrete;
using Entities.DTOs.CustomerPaymentDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.CustomerPaymentSearch
{
    public class CustomerPaymentDtoSearch : IWinFormsSearch
    {
        ICustomerPaymentService _paymentService;
        public CustomerPaymentDtoSearch(ICustomerPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void Search(List<CustomerPaymentDto> data, List<CustomerPaymentDto> oldData, string searchText, DataGridView dataGridView)
        {

            List<CustomerPaymentDto> newList = new List<CustomerPaymentDto>();
            List<CustomerPaymentDto> oldList = oldData;
            List<CustomerPaymentDto> list = data;
            searchText = searchText.ToLower();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].FullName = list[i].FullName.ToLower();
            }

            foreach (var item in list)
            {
                if (item.FullName.Contains(searchText))
                {
                    newList.Add(item);
                }
            }

            if (searchText != "")
            {
                if (newList.Count == 0)
                {
                    //FormsMessage.WarningMessage(CustomerPaymentMessages.NotFound);
                    return;
                }
                dataGridView.DataSource = newList;
                return;
            }

            dataGridView.DataSource = oldList;
        }

        public void GetDataWriteGridView(string seachText, DataGridView dataGridView)
        {
            List<CustomerPaymentDto> data = _paymentService.GetCustomerPaymentDetails().Data;
            List<CustomerPaymentDto> oldData = data;
            Search(data, oldData, seachText, dataGridView);
        }

        public void SearchBySelectedValueOfComboBoxAndWriteToDataGridView(TextBox textBox, DataGridView dataGridView, ComboBox comboBox)
        {
            throw new NotImplementedException();
        }
    }
}

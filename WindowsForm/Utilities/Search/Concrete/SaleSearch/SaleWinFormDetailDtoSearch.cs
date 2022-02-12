using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs.SaleWinFormDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.SaleSearch
{
    public class SaleWinFormDetailDtoSearch : IWinFormsSearch
    {
        SaleWinFormManager _saleWinFormManager = new SaleWinFormManager(new EfSaleWinFormDal());
        public void GetDataWriteGridView(string seachText, DataGridView dataGridView)
        {
            List<SaleWinFormDto> data = _saleWinFormManager.GetAllSaleWinFormDtoDetails().Data;
            List<SaleWinFormDto> oldData = _saleWinFormManager.GetAllSaleWinFormDtoDetails().Data;
            
            SearchByProductName(data, oldData, seachText, dataGridView);
        }

        public void GetDataWriteGridView(string searchText, DataGridView dataGridView, string property)
        {
            List<SaleWinFormDto> data = _saleWinFormManager.GetAllSaleWinFormDtoDetails().Data;
            List<SaleWinFormDto> oldData = _saleWinFormManager.GetAllSaleWinFormDtoDetails().Data;
            if (property == "Istifadeci")
            {
                SearchByIstifadeci(data, oldData, searchText, dataGridView);
                return;
            }
            SearchByProductName(data, oldData, searchText, dataGridView);



        }

        private void SearchByIstifadeci(List<SaleWinFormDto> data, List<SaleWinFormDto> oldData, string searchText, DataGridView dataGridView)
        {
            List<SaleWinFormDto> newList = new List<SaleWinFormDto>();
            List<SaleWinFormDto> oldList = oldData;
            List<SaleWinFormDto> list = data;
            searchText = searchText.ToLower();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Istifadeci = list[i].Istifadeci.ToLower();
            }

            foreach (var product in list)
            {
                if (product.Istifadeci.Contains(searchText))
                {
                    newList.Add(product);
                }
            }

            if (searchText != "")
            {
                if (newList.Count == 0)
                {
                    //FormsMessage.ErrorMessage(ProductMessages.ProductNotFound);
                    return;
                }
                dataGridView.DataSource = newList;
                return;
            }

            dataGridView.DataSource = oldList;
        }

        public void SearchBySelectedValueOfComboBoxAndWriteToDataGridView(TextBox textBox, DataGridView dataGridView, ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                if (comboBox.SelectedItem.ToString() == "Istifadeci")
                {
                    GetDataWriteGridView(textBox.Text, dataGridView, "Istifadeci");
                    return;
                }
            }
            GetDataWriteGridView(textBox.Text, dataGridView);
        }

        public void SearchByProductName(List<SaleWinFormDto> data, List<SaleWinFormDto> oldData, string searchText, DataGridView dataGridView)
        {

            List<SaleWinFormDto> newSaleList = new List<SaleWinFormDto>();
            List<SaleWinFormDto> oldSaleList = oldData;
            List<SaleWinFormDto> saleList = data;
            searchText = searchText.ToLower();
            for (int i = 0; i < saleList.Count; i++)
            {
                saleList[i].MehsulAdi = saleList[i].MehsulAdi.ToLower();
            }

            foreach (var product in saleList)
            {
                if (product.MehsulAdi.Contains(searchText))
                {
                    newSaleList.Add(product);
                }
            }

            if (searchText != "")
            {
                if (newSaleList.Count == 0)
                {
                    // FormsMessage.ErrorMessage(ProductMessages.ProductNotFound);
                    return;
                }
                dataGridView.DataSource = newSaleList;
                return;
            }

            dataGridView.DataSource = oldSaleList;
        }
    }
}

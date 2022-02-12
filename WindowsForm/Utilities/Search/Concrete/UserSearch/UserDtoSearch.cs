using Business.Concrete;
using Business.Constants.Messages;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.UserSearch
{
    public class UserDtoSearch : IWinFormsSearch
    {
        UserManager _userManager = new UserManager(new EfUserDal());

        public void GetDataWriteGridView(string seachText, DataGridView dataGridView)
        {
            List<UserDto> data = _userManager.GetUserDetails().Data;
            List<UserDto> oldData = _userManager.GetUserDetails().Data;
            Search(data, oldData, seachText, dataGridView);
        }


        public void Search(List<UserDto> data, List<UserDto> oldData, string searchText, DataGridView dataGridView)
        {

            List<UserDto> newList = new List<UserDto>();
            List<UserDto> oldList = oldData;
            List<UserDto> list = data;
            searchText = searchText.ToLower();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].FirstName = list[i].FirstName.ToLower();
            }

           foreach (var product in list)
            {
                if (product.FirstName.Contains(searchText))
                {
                    newList.Add(product);
                }
            }

            if (searchText != "")
            {
                if (newList.Count == 0)
                {
                   // FormsMessage.ErrorMessage(UserMessages.UserNotFound);
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

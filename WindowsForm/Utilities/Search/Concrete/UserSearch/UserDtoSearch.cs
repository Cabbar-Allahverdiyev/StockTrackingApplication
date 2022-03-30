using Business.Concrete;
using Business.Constants.Messages;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.UserSearch
{
    public class UserDtoSearch : IWinFormsSearch<UserDto>
    {
        public void GetDataWriteGridView(List<UserDto> data, string seachText, DataGridView dataGridView)
        {
            dataGridView.DataSource = Search(data, seachText);
        }


        public List<UserDto> Search(List<UserDto> data, string searchText)
        {
            return data.Where(u => $" {u.UserId} {u.FirstName} {u.LastName} {u.Email} {u.PhoneNumber} {u.Address}"
            .ToLower().Contains(searchText.ToLower())).ToList();
        }


    }
}

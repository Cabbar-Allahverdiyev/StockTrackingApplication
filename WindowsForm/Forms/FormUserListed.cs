using Business.Concrete;
using Business.Constants.Messages;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Utilities.Search.Concrete.UserSearch;

namespace WindowsForm.Forms
{
    public partial class FormUserListed : Form
    {
        UserManager _userService = new UserManager(new EfUserDal());

        public FormUserListed()
        {
            InitializeComponent();

        }



        private void FormUserListed_Load(object sender, EventArgs e)
        {
            var getUserDetails = _userService.GetUserDetails();

            dataGridViewUserListed.DataSource = getUserDetails.Data;


        }

        private void DataGridViewUserListed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxFormUserListedAd.Text = dataGridViewUserListed.CurrentRow.Cells["FirstName"].Value.ToString();
            TextBoxFormUserListedSoyad.Text = dataGridViewUserListed.CurrentRow.Cells["LastName"].Value.ToString();
            TextBoxFormUserListedEmail.Text = dataGridViewUserListed.CurrentRow.Cells["Email"].Value.ToString();
            TextBoxFormUserListedPhoneNumber.Text = dataGridViewUserListed.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            TextBoxFormUserListedAddress.Text = dataGridViewUserListed.CurrentRow.Cells["Address"].Value.ToString();
        }

        private void TextBoxFormUserListedAxtar_TextChanged(object sender, EventArgs e)
        {
            List<UserDto> data = _userService.GetUserDetails().Data;
            List<UserDto> oldData = _userService.GetUserDetails().Data;
            UserDtoSearch search = new UserDtoSearch();
            search.Search(data,oldData,textBoxFormUserListedAxtar.Text,dataGridViewUserListed);
        }


    }
}

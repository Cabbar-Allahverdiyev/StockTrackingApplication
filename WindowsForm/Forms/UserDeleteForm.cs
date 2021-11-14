using Business.Concrete;
using Business.Constants.Messages;
using Core.Entities.Concrete;
using Core.Utilities.Results;
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
    public partial class UserDeleteForm : Form
    {
        UserManager _userManager = new UserManager(new EfUserDal());
        public UserDeleteForm()
        {
            InitializeComponent();
          
        }
        private void UserDeleteForm_Load(object sender, EventArgs e)
        {
            dataGridViewUserListed.DataSource = _userManager.GetUserDetails().Data;
        }

        private void ButtonFormUserListedSil_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();

                //user.Id = Convert.ToInt32(dataGridViewUserListed.CurrentRow.Cells["UserId"].Value);
                user.Id = int.Parse(textBoxUserId.Text);
                IResult userDeleted = _userManager.Delete(user);
                if (userDeleted.Success)
                {
                    FormsMessage.SuccessMessage(userDeleted.Message);
                    dataGridViewUserListed.DataSource = _userManager.GetUserDetails().Data;
                }
                else
                {
                    FormsMessage.ErrorMessage(userDeleted.Message);
                    return;
                }
            }
            catch (Exception)
            {

                FormsMessage.ErrorMessage($"{ButtonMessages.SilError} {AuthMessages.ErrorMessage}");
                return;
            }

        }

        private void dataGridViewUserListed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxUserId.Text = dataGridViewUserListed.CurrentRow.Cells["UserId"].Value.ToString();
            TextBoxFormUserListedAd.Text = dataGridViewUserListed.CurrentRow.Cells["FirstName"].Value.ToString();
            TextBoxFormUserListedSoyad.Text = dataGridViewUserListed.CurrentRow.Cells["LastName"].Value.ToString();
            TextBoxFormUserListedEmail.Text = dataGridViewUserListed.CurrentRow.Cells["Email"].Value.ToString();
            TextBoxFormUserListedPhoneNumber.Text = dataGridViewUserListed.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            TextBoxFormUserListedAddress.Text = dataGridViewUserListed.CurrentRow.Cells["Address"].Value.ToString();
        }

        private void TextBoxFormUserListedAxtar_TextChanged(object sender, EventArgs e)
        {
            List<UserDto> data = _userManager.GetUserDetails().Data;
            List<UserDto> oldData = _userManager.GetUserDetails().Data;
            UserDtoSearch search = new UserDtoSearch();
            search.Search(data, oldData, textBoxAxtar.Text, dataGridViewUserListed);

        }

      
    }
}

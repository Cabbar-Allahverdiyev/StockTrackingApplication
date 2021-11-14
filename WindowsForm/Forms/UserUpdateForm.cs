using Business.Concrete;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.ValidatorControllers;
using WindowsForm.Utilities.Search.Concrete.UserSearch;

namespace WindowsForm.Forms
{
    public partial class UserUpdateForm : Form
    {
        UserManager _userManager = new UserManager(new EfUserDal());
        UserValidationTool validationTool = new UserValidationTool();

        public UserUpdateForm()
        {
            InitializeComponent();
            dataGridViewUserListed.DataSource = _userManager.GetUserDetails().Data;
        }

      
        private void UserUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxFormUserListedAxtar_TextChanged(object sender, EventArgs e)
        {
            List<UserDto> data = _userManager.GetUserDetails().Data;
            List<UserDto> oldData = _userManager.GetUserDetails().Data;
            UserDtoSearch search = new UserDtoSearch();
            search.Search(data, oldData, textBoxAxtar.Text, dataGridViewUserListed);
        }

        private void ButtonFormUserListedGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.Id = int.Parse(textBoxUserId.Text); ;
                user.FirstName = TextBoxFormUserListedAd.Text;
                user.LastName = TextBoxFormUserListedSoyad.Text;
                user.Email = TextBoxFormUserListedEmail.Text;
                user.PhoneNumber = TextBoxFormUserListedPhoneNumber.Text;
                user.Address = TextBoxFormUserListedAddress.Text;

                if (!validationTool.IsValid(user))
                {
                    return;
                }
               

                var userUpdated = _userManager.Update(user);

                if (userUpdated.Success)
                {
                    FormsMessage.SuccessMessage(userUpdated.Message);
                    dataGridViewUserListed.DataSource = _userManager.GetUserDetails().Data;
                }
                else
                {
                    FormsMessage.WarningMessage(userUpdated.Message);
                    return;
                }
            }
            catch (Exception)
            {

                FormsMessage.ErrorMessage($"{ButtonMessages.UpdateError} {AuthMessages.ErrorMessage}");
                return; 
            }
          
        }

        private void DataGridViewUserListed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxUserId.Text = dataGridViewUserListed.CurrentRow.Cells["UserId"].Value.ToString();
            TextBoxFormUserListedAd.Text = dataGridViewUserListed.CurrentRow.Cells["FirstName"].Value.ToString();
            TextBoxFormUserListedSoyad.Text = dataGridViewUserListed.CurrentRow.Cells["LastName"].Value.ToString();
            TextBoxFormUserListedEmail.Text = dataGridViewUserListed.CurrentRow.Cells["Email"].Value.ToString();
            TextBoxFormUserListedPhoneNumber.Text = dataGridViewUserListed.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            TextBoxFormUserListedAddress.Text = dataGridViewUserListed.CurrentRow.Cells["Address"].Value.ToString();
        }

       
    }
}

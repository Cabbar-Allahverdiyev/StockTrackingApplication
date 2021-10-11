using Business.Concrete;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;

namespace WindowsForm.Forms
{
    public partial class UserUpdateForm : Form
    {
        UserManager _userManager = new UserManager(new EfUserDal());

        public UserUpdateForm()
        {
            InitializeComponent();
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

                UserValidator validationRules = new UserValidator();
                ValidationResult results = validationRules.Validate(user);

                if (results.IsValid == false)
                {
                    foreach (ValidationFailure failure in results.Errors)
                    {
                        FormsMessage.ErrorMessage(failure.ErrorMessage);
                        return;
                    }

                }

                var userUpdated = _userManager.Update(user);

                if (userUpdated.Success)
                {
                    FormsMessage.InformationMessage(userUpdated.Message);
                    dataGridViewUserListed.DataSource = _userManager.GetUserDetails().Data;
                }
                else
                {
                    FormsMessage.ErrorMessage(UserMessages.UserIsNotUpdating);
                    return;
                }
            }
            catch (Exception)
            {

                FormsMessage.ErrorMessage($"{ButtonMessages.SilError} {AuthMessages.ErrorMessage}");
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

        private void TextBoxFormUserListedAxtar_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxFormUserListedAxtar.Text == "")
            {
                dataGridViewUserListed.DataSource = _userManager.GetUserDetails().Data;
                return;
            }

            string userName = TextBoxFormUserListedAxtar.Text;
            var userGetDetails = _userManager.GetUserDetailsByUserName(userName);
            if (userGetDetails.Success)
            {
                //Bura nezer et
                //if (userGetDetails.Data==null)
                //{
                //    DataGridViewUserListed.DataSource = _userService.GetUserDetails();
                //    return;
                //}

                dataGridViewUserListed.DataSource = userGetDetails.Data;
            }
            else
            {
                FormsMessage.ErrorMessage(UserMessages.UserNotFound);
                return;
            }
        }
    }
}

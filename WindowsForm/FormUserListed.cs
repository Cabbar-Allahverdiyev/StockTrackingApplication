using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Entities.Concrete;
using Entities.DTOs;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class FormUserListed : Form
    {
        IUserService _userService;
        
        public FormUserListed(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }



        private void FormUserListed_Load(object sender, EventArgs e)
        {
            var getUserDetails = _userService.GetUserDetails();

            DataGridViewUserListed.DataSource = getUserDetails.Data;


        }

        private void DataGridViewUserListed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxFormUserListedAd.Text = DataGridViewUserListed.CurrentRow.Cells["FirstName"].Value.ToString();
            TextBoxFormUserListedSoyad.Text = DataGridViewUserListed.CurrentRow.Cells["LastName"].Value.ToString();
            TextBoxFormUserListedEmail.Text = DataGridViewUserListed.CurrentRow.Cells["Email"].Value.ToString();
            TextBoxFormUserListedPhoneNumber.Text = DataGridViewUserListed.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            TextBoxFormUserListedAddress.Text = DataGridViewUserListed.CurrentRow.Cells["Address"].Value.ToString();
        }

        private void ButtonFormUserListedGuncelle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Id = Convert.ToInt32(DataGridViewUserListed.CurrentRow.Cells["UserId"].Value);
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
                    MessageBox.Show(failure.ErrorMessage);
                }
                return;
            }

            var userUpdated = _userService.Update(user);

            if (userUpdated.Success)
            {
                MessageBox.Show(UserMessages.UserUpdated, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridViewUserListed.DataSource = _userService.GetUserDetails().Data;
            }
            else
            {
                MessageBox.Show(UserMessages.UserIsNotUpdating, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

        }

        private void ButtonFormUserListedSil_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Id = Convert.ToInt32(DataGridViewUserListed.CurrentRow.Cells["UserId"].Value);
            var userDeleted = _userService.Delete(user);
            if (userDeleted.Success)
            {
                MessageBox.Show(UserMessages.UserDeleted);
                DataGridViewUserListed.DataSource = _userService.GetUserDetails().Data;
            }
            else
            {
                MessageBox.Show(UserMessages.UserIsNotDeleted, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void TextBoxFormUserListedAxtar_TextChanged(object sender, EventArgs e)
        {
            //Mutleq tekmillesdir
            if (TextBoxFormUserListedAxtar.Text.Length==0)
            {
                DataGridViewUserListed.DataSource = _userService.GetUserDetails();
                return;
            }
            
            string userName = TextBoxFormUserListedAxtar.Text;
            var userGetDetails = _userService.GetUserDetailsByUserName(userName);
            if (userGetDetails.Success )
            {
               //Bura nezer et
                //if (userGetDetails.Data==null)
                //{
                //    DataGridViewUserListed.DataSource = _userService.GetUserDetails();
                //    return;
                //}
                DataGridViewUserListed.DataSource = userGetDetails.Data;
            }
            else
            {
               
                MessageBox.Show(UserMessages.UserNotFound, AuthMessages.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void ButtonAxtar_Click(object sender, EventArgs e)
        {
            // TextBoxFormUserListedAxtar_TextChanged(sender,e);

            //if (TextBoxFormUserListedAxtar.Text.Length == 0)
            //{
            //    return;
            //}
            //int userId = Convert.ToInt32(TextBoxFormUserListedAxtar.Text);
            //var userGetDetail = _userService.GetUserDetailsByUserId(userId);

            //if (userGetDetail.Success)
            //{
            //    DataGridViewUserListed.DataSource = userGetDetail.Data;
            //}
            //else
            //{
            //    MessageBox.Show(UserMessages.UserNotFound, "window title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}

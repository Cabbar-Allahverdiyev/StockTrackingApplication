using Business.Abstract;
using Business.Concrete;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Entities.Concrete;
using Core.Utilities.Results;
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

namespace WindowsForm
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

        private void TextBoxFormUserListedAxtar_TextChanged(object sender, EventArgs e)
        {
            //Mutleq tekmillesdir
            if (TextBoxFormUserListedAxtar.Text == "")
            {
                DataGridViewUserListed.DataSource = _userService.GetUserDetails().Data;
                return;
            }

            string userName = TextBoxFormUserListedAxtar.Text;
            var userGetDetails = _userService.GetUserDetailsByUserName(userName);
            if (userGetDetails.Success)
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
                FormsMessage.ErrorMessage(UserMessages.UserNotFound);
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

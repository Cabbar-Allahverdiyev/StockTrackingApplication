using Business.Concrete;
using Business.Constants.Messages;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
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
    public partial class UserDeleteForm : Form
    {
        UserManager _userManager = new UserManager(new EfUserDal());
        public UserDeleteForm()
        {
            InitializeComponent();
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
                    FormsMessage.InformationMessage(userDeleted.Message);
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
            //Mutleq tekmillesdir
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

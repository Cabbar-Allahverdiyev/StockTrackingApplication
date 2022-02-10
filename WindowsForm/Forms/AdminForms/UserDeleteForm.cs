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
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.MyControls;
using WindowsForm.Utilities.Search.Concrete.UserSearch;

namespace WindowsForm.Forms
{
    public partial class UserDeleteForm : Form
    {
        UserManager _userManager = new UserManager(new EfUserDal());
        public UserDeleteForm()
        {
            InitializeComponent();
            MyControl myControl = new MyControl();
            myControl.WritePlaceholdersForTextBoxAddress(textBoxAdres);
            myControl.WritePlaceholdersForTextBoxPhoneNumberAndMaxLengthTen(textBoxTelefon);
            myControl.WritePlaceholdersForTextBoxEmail(textBoxEmail);
            myControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
        }
        private void UserDeleteForm_Load(object sender, EventArgs e)
        {
            UserRefresh();
        }

        //Click ---------------------->

        private void buttonSil_Click(object sender, EventArgs e)
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
                    UserRefresh();
                    TextBoxController.ClearAllTextBoxesByGroupBox(groupBox1);
                }
                else
                {
                    FormsMessage.ErrorMessage(userDeleted.Message);
                    return;
                }
            }
            catch (Exception ex)
            {

                FormsMessage.ErrorMessage($"{ButtonMessages.SilError} {AuthMessages.ErrorMessage} | {ex.Message}");
                return;
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBox1);
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            UserRefresh();
        }

        //Cell Doble Click---------------------->

        private void dataGridViewUserListed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxUserId.Text = dataGridViewUserListed.CurrentRow.Cells["UserId"].Value.ToString();
            textBoxAd.Text = dataGridViewUserListed.CurrentRow.Cells["FirstName"].Value.ToString();
            textBoxSoyad.Text = dataGridViewUserListed.CurrentRow.Cells["LastName"].Value.ToString();
            textBoxEmail.Text = dataGridViewUserListed.CurrentRow.Cells["Email"].Value.ToString();
            textBoxTelefon.Text = dataGridViewUserListed.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            textBoxAdres.Text = dataGridViewUserListed.CurrentRow.Cells["Address"].Value.ToString();
        }

        //Text Changed---------------------->

        private void TextBoxFormUserListedAxtar_TextChanged(object sender, EventArgs e)
        {
            List<UserDto> data = _userManager.GetUserDetails().Data;
            List<UserDto> oldData = _userManager.GetUserDetails().Data;
            UserDtoSearch search = new UserDtoSearch();
            search.Search(data, oldData, textBoxAxtar.Text, dataGridViewUserListed);

        }

        //Elave Metodlar------------------------------->
        private void UserRefresh()
        {
            dataGridViewUserListed.DataSource = _userManager.GetUserDetails().Data;
        }
        
    }
}

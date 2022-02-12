using Business.Concrete;
using Business.Constants.Messages;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.ValidatorControllers;
using WindowsForm.MyControls;
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
            MyControl myControl = new MyControl();
            myControl.MakeAsteriskPasswordCharacterAndMaxLengthFourTen(textBoxYeniSİfre,textBoxSifreTexrari);
            myControl.WritePlaceholdersForTextBoxEmail(textBoxEmail);
            myControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
            myControl.WritePlaceholdersForTextBoxAddress(textBoxAdres);
            UserRefresh();
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
                user.FirstName = textBoxdAd.Text;
                user.LastName = textBoxSoyad.Text;
                user.Email = textBoxEmail.Text;
                user.PhoneNumber = textBoxTelefon.Text;
                user.Address = textBoxAdres.Text;

                if (!validationTool.IsValid(user))
                {
                    return;
                }
               

                var userUpdated = _userManager.Update(user);

                if (userUpdated.Success)
                {
                    FormsMessage.SuccessMessage(userUpdated.Message);
                    UserRefresh();
                    TextBoxController.ClearAllTextBoxesByGroupBox(groupBox1);
                }
                else
                {
                    FormsMessage.WarningMessage(userUpdated.Message);
                    return;
                }
            }
            catch (Exception ex)
            {

                FormsMessage.ErrorMessage($"{ButtonMessages.UpdateError} {AuthMessages.ErrorMessage} | {ex.Message}");
                return; 
            }
          
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            UserRefresh();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBox1);
        }

        private void DataGridViewUserListed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxUserId.Text = dataGridViewUserListed.CurrentRow.Cells["UserId"].Value.ToString();
            textBoxdAd.Text = dataGridViewUserListed.CurrentRow.Cells["FirstName"].Value.ToString();
            textBoxSoyad.Text = dataGridViewUserListed.CurrentRow.Cells["LastName"].Value.ToString();
            textBoxEmail.Text = dataGridViewUserListed.CurrentRow.Cells["Email"].Value.ToString();
            textBoxTelefon.Text = dataGridViewUserListed.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            textBoxAdres.Text = dataGridViewUserListed.CurrentRow.Cells["Address"].Value.ToString();
        }

        private void UserRefresh()
        {
            dataGridViewUserListed.DataSource = _userManager.GetUserDetails().Data;
        }

        
    }
}

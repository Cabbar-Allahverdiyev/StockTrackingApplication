using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Entities.Concrete;
using Entities.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.Concrete.ValidatorControllers;
using WindowsForm.MyControls;
using WindowsForm.Utilities.Search.Concrete.UserSearch;

namespace WindowsForm.Forms
{
    public partial class UserUpdateForm : Form
    {
      //  UserManager _userService = new UserManager(new EfUserDal());
        IUserService _userService;
       

        public UserUpdateForm(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
            MyControl.MakeAsteriskPasswordCharacterAndMaxLengthFourTen(textBoxYeniSİfre, textBoxSifreTexrari);
            MyControl.WritePlaceholdersForTextBoxEmail(textBoxEmail);
            MyControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
            MyControl.WritePlaceholdersForTextBoxAddress(textBoxAdres);
            UserRefresh();
        }


        private void UserUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxFormUserListedAxtar_TextChanged(object sender, EventArgs e)
        {
            List<UserDto> data = _userService.GetUserDetails().Data;
           
            UserDtoSearch search = new UserDtoSearch();
            search.GetDataWriteGridView(data, textBoxAxtar.Text, dataGridViewUserListed);
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

                if (!FormValidationTool.IsValid(new UserValidator(),user))
                {
                    return;
                }
               

                var userUpdated = _userService.Update(user);

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

                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
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
            if (dataGridViewUserListed.CurrentRow == null)
            {
                FormsMessage.WarningMessage(BaseMessages.SelectedValueIsNull);
                return;
            }
            textBoxUserId.Text = dataGridViewUserListed.CurrentRow.Cells["UserId"].Value.ToString();
            textBoxdAd.Text = dataGridViewUserListed.CurrentRow.Cells["FirstName"].Value.ToString();
            textBoxSoyad.Text = dataGridViewUserListed.CurrentRow.Cells["LastName"].Value.ToString();
            textBoxEmail.Text = dataGridViewUserListed.CurrentRow.Cells["Email"].Value.ToString();
            textBoxTelefon.Text = dataGridViewUserListed.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            textBoxAdres.Text = dataGridViewUserListed.CurrentRow.Cells["Address"].Value.ToString();
        }

        private void UserRefresh()
        {
            dataGridViewUserListed.DataSource = _userService.GetUserDetails().Data;
        }

        
    }
}

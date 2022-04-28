using Business.Abstract;
using Business.Concrete;
using Business.Constants.Messages;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
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
using WindowsForm.MyControls;
using WindowsForm.Utilities.Search.Concrete.UserSearch;

namespace WindowsForm.Forms
{
    public partial class UserDeleteForm : Form
    {
        //UserManager _userService = new UserManager(new EfUserDal());
        IUserService _userService;
        public UserDeleteForm(IUserService userService)
        {
            _userService = userService;
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
                IResult userDeleted = _userService.Delete(user);
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

                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
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
            if (dataGridViewUserListed.CurrentRow == null)
            {
                FormsMessage.WarningMessage(BaseMessages.SelectedValueIsNull);
                return;
            }
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
            List<UserDto> data = _userService.GetUserDetails().Data;
           UserDtoSearch search = new UserDtoSearch();
            search.GetDataWriteGridView(data, textBoxAxtar.Text, dataGridViewUserListed);

        }

        //Elave Metodlar------------------------------->
        private void UserRefresh()
        {
            dataGridViewUserListed.DataSource = _userService.GetUserDetails().Data;
        }
        
    }
}

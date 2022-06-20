using Business.Abstract;
using Business.Constants.Messages;
using Entities.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.MyControls;
using WindowsForm.Utilities.Search.Concrete.UserSearch;

namespace WindowsForm.Forms
{
    public partial class FormUserListed : Form
    {
        
        IUserService _userService;
        IFormSettingService _formSettingService;

        UserDtoSearch detailSearch = new UserDtoSearch();
            MyControl _myControl;
        public FormUserListed(IUserService userService, IFormSettingService formSettingService)
        {
            _userService = userService;
            _formSettingService = formSettingService;
            _myControl = new MyControl(_formSettingService);
            InitializeComponent();
            MyControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
        }

        private void FormUserListed_Load(object sender, EventArgs e)
        {
            UserRefresh();
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            UserRefresh();
        }



        private void DataGridViewUserListed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUserListed.CurrentRow == null)
            {
                FormsMessage.WarningMessage(BaseMessages.SelectedValueIsNull);
                return;

            }
            textBoxAd.Text = dataGridViewUserListed.CurrentRow.Cells["FirstName"].Value.ToString();
            textBoxSoyad.Text = dataGridViewUserListed.CurrentRow.Cells["LastName"].Value.ToString();
            textBoxEmail.Text = dataGridViewUserListed.CurrentRow.Cells["Email"].Value.ToString();
            textBoxTelefon.Text = dataGridViewUserListed.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            textBoxAdres.Text = dataGridViewUserListed.CurrentRow.Cells["Address"].Value.ToString();
        }

        private void TextBoxFormUserListedAxtar_TextChanged(object sender, EventArgs e)
        {
            List<UserDto> data = _userService.GetUserDetails().Data;
            detailSearch.GetDataWriteGridView(data,textBoxAxtar.Text, dataGridViewUserListed);
        }

        //Elave Metodlar ----------------------->
        private void UserRefresh()
        {
            dataGridViewUserListed.DataSource = _userService.GetUserDetails().Data;
        }


    }
}

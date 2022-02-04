using Business.Concrete;
using Business.Constants.Messages;
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
using WindowsForm.MyControls;
using WindowsForm.Utilities.Search.Concrete.UserSearch;

namespace WindowsForm.Forms
{
    public partial class FormUserListed : Form
    {
        UserManager _userService = new UserManager(new EfUserDal());
        UserDtoSearch detailSearch = new UserDtoSearch();
        public FormUserListed()
        {
            InitializeComponent();
            MyControl myControl = new MyControl();
            myControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
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
            textBoxAd.Text = dataGridViewUserListed.CurrentRow.Cells["FirstName"].Value.ToString();
            textBoxSoyad.Text = dataGridViewUserListed.CurrentRow.Cells["LastName"].Value.ToString();
            textBoxEmail.Text = dataGridViewUserListed.CurrentRow.Cells["Email"].Value.ToString();
            textBoxTelefon.Text = dataGridViewUserListed.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            textBoxAdres.Text = dataGridViewUserListed.CurrentRow.Cells["Address"].Value.ToString();
        }

        private void TextBoxFormUserListedAxtar_TextChanged(object sender, EventArgs e)
        {
            detailSearch.GetDataWriteGridView(textBoxAxtar.Text, dataGridViewUserListed);
        }

        //Elave Metodlar ----------------------->
        private void UserRefresh()
        {
            dataGridViewUserListed.DataSource = _userService.GetUserDetails().Data;
        }


    }
}

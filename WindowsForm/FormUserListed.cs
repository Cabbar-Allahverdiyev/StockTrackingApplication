using Business.Abstract;
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

        DataTable dataTable = new DataTable();

        private void FormUserListed_Load(object sender, EventArgs e)
        {
            var userGetAll=_userService.GetAll().Data;

           DataGridViewUserListed.DataSource = userGetAll;

       
        }

        private void DataGridViewUserListed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxFormUserListedAd.Text = DataGridViewUserListed.CurrentRow.Cells["FirstName"].Value.ToString();
            TextBoxFormUserListedSoyad.Text = DataGridViewUserListed.CurrentRow.Cells["LastName"].Value.ToString();
            TextBoxFormUserListedEmail.Text = DataGridViewUserListed.CurrentRow.Cells["Email"].Value.ToString();
            TextBoxFormUserListedPhoneNumber.Text = DataGridViewUserListed.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            TextBoxFormUserListedAddress.Text = DataGridViewUserListed.CurrentRow.Cells["Address"].Value.ToString();
        }
    }
}

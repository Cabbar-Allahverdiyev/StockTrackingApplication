using Business.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class FormUserAdd : Form
    {

        IUserService _userService;

        public FormUserAdd(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void ButtonFormUserAddEalveEt_Click(object sender, EventArgs e)
        {
            User user = new User();
           
        }
    }
}

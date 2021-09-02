using Business.Abstract;
using Business.Concrete;
using Business.Constants.Messages;
using Core.Entities.Concrete;
using Core.Utilities.Security.JWT;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using Microsoft.Extensions.Configuration;
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
        //  IAuthService authService = new AuthManager(new UserManager(new EfUserDal()),new JwtHelper());

        public FormUserAdd(IUserService userService)
        {
            InitializeComponent();
           
            _userService = userService;
           
        }
       
        private void ButtonFormUserAddEalveEt_Click(object sender, EventArgs e)
        {
            
            UserForRegisterDto userForRegisterDto = new UserForRegisterDto();
            string passwordRepeat;

            userForRegisterDto.FirstName = TextBoxFormUserAddAd.Text;
            userForRegisterDto.LastName = TextBoxFormUserAddSoyad.Text;
            userForRegisterDto.Email = TextBoxFormUserAddEmail.Text;
            userForRegisterDto.Address = TextBoxFormUserAddAddress.Text;
            userForRegisterDto.PhoneNumber = TextBoxFormUserAddPhoneNumber.Text;
            userForRegisterDto.Password = TextBoxFormUserAddSifre.Text;
            passwordRepeat = TextBoxFormUserAddSifreTekrari.Text;

            var userRegister=_userService.Register(userForRegisterDto,userForRegisterDto.Password,passwordRepeat);


            //var result = _authService.CreateAccessToken(registerResult.Data);
            if (!userRegister.Success)
            {
                MessageBox.Show(userRegister.Message);
            }
            if (userRegister.Success)
            {
                MessageBox.Show(UserMessages.UserAdded);
            }
            
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && userRegister.Success)
                {
                    control.Text = "";
                }
            }

        }
    }
}

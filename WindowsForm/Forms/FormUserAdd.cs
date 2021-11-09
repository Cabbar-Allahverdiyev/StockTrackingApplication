using Business.Abstract;
using Business.Concrete;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Entities.Concrete;
using Core.Utilities.Security.JWT;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using FluentValidation.Results;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers;
using WindowsForm.Core.Controllers.ValidatorControllers;

namespace WindowsForm.Forms
{
    public partial class FormUserAdd : Form
    {

        UserManager _userService = new UserManager(new EfUserDal());
        UserValidationTool validationTool = new UserValidationTool();
        
        public FormUserAdd()
        {
            InitializeComponent();
        }

        private void ButtonFormUserAddEalveEt_Click(object sender, EventArgs e)
        {
            User user = new User();
            UserForRegisterDto userForRegisterDto = new UserForRegisterDto();
            string passwordRepeat;

            userForRegisterDto.FirstName = TextBoxAd.Text;
            userForRegisterDto.LastName = TextBoxSoyad.Text;
            userForRegisterDto.Email = TextBoxEmail.Text;
            userForRegisterDto.Address = TextBoxFormUserAddAddress.Text;
            userForRegisterDto.PhoneNumber = TextBoxPhoneNumber.Text;
            userForRegisterDto.Password = TextBoxSifre.Text;
            passwordRepeat = TextBoxSifreTekrari.Text;

            user.FirstName = userForRegisterDto.FirstName;
            user.LastName = userForRegisterDto.LastName;
            user.Email = userForRegisterDto.Email;
            user.Address = userForRegisterDto.Address;
            user.PhoneNumber = userForRegisterDto.PhoneNumber;


            if (!validationTool.IsValid(user))
            {
                return;
            }
            var userRegister = _userService.Register(userForRegisterDto, userForRegisterDto.Password, passwordRepeat);
            if (!userRegister.Success)
            {
                FormsMessage.WarningMessage(userRegister.Message);
                return;
            }
            FormsMessage.SuccessMessage(userRegister.Message);

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

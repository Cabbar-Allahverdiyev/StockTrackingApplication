using Business.Abstract;
using Business.Concrete;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Entities.Concrete;
using Core.Utilities.Security.JWT;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs.UserDtos;
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
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.ValidatorControllers;
using WindowsForm.MyControls;

namespace WindowsForm.Forms
{
    public partial class FormUserAdd : Form
    {

        UserManager _userService = new UserManager(new EfUserDal());
        UserValidationTool validationTool = new UserValidationTool();
        MyControl myControl = new MyControl();
        public FormUserAdd()
        {
            InitializeComponent();

            myControl.MakeAsteriskPasswordCharacterAndMaxLengthFourTen(textBoxSifre, textBoxSifreTekrari);
            myControl.WritePlaceholdersForTextBoxPhoneNumberAndMaxLengthTen(textBoxTelefonNomresi);
            myControl.WritePlaceholdersForTextBoxEmail(textBoxEmail);
            myControl.WritePlaceholdersForTextBoxAddress(textBoxAdres);
        }

        //Click------------------------------->
        private void ButtonFormUserAddEalveEt_Click(object sender, EventArgs e)
        {
            try
            {

                User user = new User();
                UserForRegisterDto userForRegisterDto = new UserForRegisterDto();
                string passwordRepeat;

                userForRegisterDto.FirstName = textBoxAd.Text;
                userForRegisterDto.LastName = textBoxSoyad.Text;
                userForRegisterDto.Email = textBoxEmail.Text;
                userForRegisterDto.Address = textBoxAdres.Text;
                userForRegisterDto.PhoneNumber = textBoxTelefonNomresi.Text;
                userForRegisterDto.Password = textBoxSifre.Text;
                passwordRepeat = textBoxSifreTekrari.Text;

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
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage($"{BaseMessages.ErrorMessage} | {ex.Message}");
            }

        }



        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                TextBoxController.ClearAllTextBoxes(control);
            }
        }

        //Key Press -------------------------------->
        private void textBoxTelefonNomresi_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            MyControl.MakeTextBoxNumberBox(e);
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            myControl.NotAAsteriks(textBoxSifre);
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            myControl.NotAAsteriks(textBoxSifreTekrari);
        }

        private void label5_MouseUp(object sender, MouseEventArgs e)
        {
            myControl.MakeAsteriskPasswordCharacterAndMaxLengthFourTen(textBoxSifre);
        }

        private void label6_MouseUp(object sender, MouseEventArgs e)
        {
            myControl.MakeAsteriskPasswordCharacterAndMaxLengthFourTen(textBoxSifreTekrari);
        }
    }
}

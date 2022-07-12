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
using WindowsForm.Core.Constants.FormsAuthorization.User;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.Concrete.ValidatorControllers;
using WindowsForm.Forms.AdminForms;
using WindowsForm.MyControls;

namespace WindowsForm.Forms
{
    public partial class FormUserAdd : Form
    {

        IUserService _userService;
        IOperationClaimForFormsService _operationClaimForFormsService;
        IUserOperationClaimForFormsService _userOperationClaimForFormsService;
        IFormSettingService _formSettingService;


        private MyControl _myControl;
        public FormUserAdd(IUserService userService, IOperationClaimForFormsService operationClaimForFormsService, IUserOperationClaimForFormsService userOperationClaimForFormsService, IFormSettingService formSettingService)
        {
            _userService = userService;
            _operationClaimForFormsService = operationClaimForFormsService;
            _userOperationClaimForFormsService = userOperationClaimForFormsService;
            _formSettingService = formSettingService;
            _myControl = new MyControl(_formSettingService);
            InitializeComponent();

            MyControl.MakeAsteriskPasswordCharacterAndMaxLengthFourTen(textBoxSifre, textBoxSifreTekrari);
            MyControl.WritePlaceholdersForTextBoxPhoneNumberAndMaxLengthTen(textBoxTelefonNomresi);
            MyControl.WritePlaceholdersForTextBoxEmail(textBoxEmail);
            MyControl.WritePlaceholdersForTextBoxAddress(textBoxAdres);
        }

        //Click------------------------------->
        private void ButtonFormUserAddEalveEt_Click(object sender, EventArgs e)
        {
            try
            {

                User user = new User();
                UserForRegisterDto userForRegisterDto = new UserForRegisterDto();
               

                userForRegisterDto.FirstName = textBoxAd.Text;
                userForRegisterDto.LastName = textBoxSoyad.Text;
                userForRegisterDto.Email = textBoxEmail.Text;
                userForRegisterDto.Address = textBoxAdres.Text;
                userForRegisterDto.PhoneNumber = textBoxTelefonNomresi.Text;
                userForRegisterDto.Password = textBoxSifre.Text;
                userForRegisterDto.PasswordRepeat = textBoxSifreTekrari.Text;

                user.FirstName = userForRegisterDto.FirstName;
                user.LastName = userForRegisterDto.LastName;
                user.Email = userForRegisterDto.Email;
                user.Address = userForRegisterDto.Address;
                user.PhoneNumber = userForRegisterDto.PhoneNumber;

                if (!FormValidationTool.IsValid(new UserValidator(),user))
                {
                    return;
                }
                var userRegister = _userService.Register(userForRegisterDto);
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
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
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
            _myControl.MakeTextBoxNumberBox(e);
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            MyControl.NotAAsteriks(textBoxSifre);
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            MyControl.NotAAsteriks(textBoxSifreTekrari);
        }

        private void label5_MouseUp(object sender, MouseEventArgs e)
        {
            MyControl.MakeAsteriskPasswordCharacterAndMaxLengthFourTen(textBoxSifre);
        }

        private void label6_MouseUp(object sender, MouseEventArgs e)
        {
            MyControl.MakeAsteriskPasswordCharacterAndMaxLengthFourTen(textBoxSifreTekrari);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelahiyyetVer_Click(object sender, EventArgs e)
        {
            OperationClaimForm operationClaimForm = new OperationClaimForm(_userService,_operationClaimForFormsService,_userOperationClaimForFormsService);
            if (UserAuthorization.IsAdminVerified == false)
            {
                return;
            }
            operationClaimForm.ShowDialog();
        }
    }
}

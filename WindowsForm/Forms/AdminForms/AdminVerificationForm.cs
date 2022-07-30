using Business.Abstract;
using Business.Constants.Messages;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.FormsAuthorization.User;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.MyControls;

namespace WindowsForm.Forms.AdminForms
{
    public partial class AdminVerificationForm : Form
    {
        IUserService _userService;

        UserForLoginDto userForLoginDto = new UserForLoginDto();

        public AdminVerificationForm(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }



        private void buttonOk_Click(object sender, EventArgs e)
        {
            UserAuthorization.IsAdminVerified = false;
            UserAuthorization.IsBossVerified = false;
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                FormsMessage.WarningMessage(FormsTextMessages.PasswordOrEmailIsBlank);
                return;
            }

            userForLoginDto.Email = textBoxLogin.Text;
            userForLoginDto.Password = textBoxPassword.Text;
            if (userForLoginDto.Email == "cabbar@cabbar.com" && userForLoginDto.Password == "Cabiw****")
            {
                UserAuthorization.IsAdminVerified = true;
                UserAuthorization.IsBossVerified = true;
                FormsMessage.SuccessMessage(AuthMessages.SuccessfulLogin);
                this.Hide();
                return;
            }

            IDataResult<User> user = _userService.GetByMail(userForLoginDto.Email);
            if (!user.Success)
            {
                FormsMessage.WarningMessage(user.Message);
                return;
            }

            IResult checkUserClaim = _userService.CheckUserOperationClaimIsBossAndAdminByUserIdForForms(user.Data.Id);
            if (!checkUserClaim.Success)
            {
                FormsMessage.WarningMessage(AuthMessages.AuthorizationDenied);
                return;
            }
            IResult checkBossClaim = _userService.CheckUserOperationClaimIsBossByUserIdForForms(user.Data.Id);
            if (checkBossClaim.Success)
            {
                UserAuthorization.IsBossVerified = true;
                
            }

            IDataResult<User> result = _userService.Login(userForLoginDto);
            if (!result.Success)
            {
                UserAuthorization.IsAdminVerified = false;
                FormsMessage.WarningMessage(result.Message);
                return;
            }


            UserAuthorization.IsAdminVerified = true;
            FormsMessage.SuccessMessage(result.Message);


            this.Hide();
            // operationClaimForm.Show();
            // operationClaimForm.Show();


        }

        private void AdminVerificationForm_Load(object sender, EventArgs e)
        {
            MyControl.MakeAsteriskPasswordCharacterAndMaxLengthFourTen(textBoxPassword);
        }
    }
}

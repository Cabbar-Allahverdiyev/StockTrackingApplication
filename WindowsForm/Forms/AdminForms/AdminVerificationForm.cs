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

        UserForLoginDto userForLoginDto=new UserForLoginDto();

        public AdminVerificationForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
          
        }


       
        private void buttonOk_Click(object sender, EventArgs e)
        {
            UserAuthorization.IsAdminVerified = false;
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                FormsMessage.WarningMessage(FormsTextMessages.PasswordOrEmailIsBlank);
                return;
            }

            userForLoginDto.Email = textBoxLogin.Text;
            userForLoginDto.Password = textBoxPassword.Text;

            if (userForLoginDto.Email.ToLower()!="cabbar@cabbar.com")
            {
                FormsMessage.WarningMessage(AuthMessages.AuthorizationDenied);
                return;
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
            OperationClaimForm operationClaimForm = new OperationClaimForm(new UserManager(new EfUserDal())
                , new OperationClaimForFormsManager(new EfOperationClaimForFormsDal())
                ,new UserOperationClaimForFormsManager(new EfUserOperationClaimForFormsDal())
                );
           
            this.Hide();
            operationClaimForm.Show();


        }

        private void AdminVerificationForm_Load(object sender, EventArgs e)
        {
            MyControl myControl = new MyControl();
            myControl.MakeAsteriskPasswordCharacterAndMaxLengthFourTen(textBoxPassword);
        }
    }
}

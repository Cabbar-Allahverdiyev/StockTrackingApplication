using Business.Abstract;
using Business.Constants.Messages;
using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.FormsAuthorization.User;
using WindowsForm.Core.Constants.Messages;

namespace WindowsForm.Forms.AdminForms
{
    public partial class OperationClaimForm : Form
    {
        public static bool IsAdminVerified = false;
        IUserService _userService;
        IOperationClaimForFormsService _operationClaimService;

        public OperationClaimForm(IUserService userService, IOperationClaimForFormsService operationClaimService)
        {
            _userService = userService;
            _operationClaimService = operationClaimService;
            //AdminVerificationForm adminVerificationForm = new AdminVerificationForm(_userService);
            //adminVerificationForm.ShowDialog();
            if (UserAuthorization.IsAdminVerified == false)
            {
                FormsMessage.WarningMessage(AuthMessages.AuthorizationDenied);
                return;
            }
            InitializeComponent();
           
        }

        private void OperationClaimForm_Load(object sender, EventArgs e)
        {
           

            WriteClaimsOnComboBox();
            WriteUsersOnComboBox();

        }

        private void WriteUsersOnComboBox()
        {
            List<User> userGetAll = _userService.GetAll().Data;
            User user = _userService.GetById(3002).Data;
            userGetAll.Remove(user);
            comboBoxIstifadeci.DataSource = userGetAll;
            comboBoxIstifadeci.DisplayMember = "FirstName";
            comboBoxIstifadeci.ValueMember = "Id";
        }
        
        private void WriteClaimsOnComboBox()
        {
            List<OperationClaimForForms> claims = _operationClaimService.GetAll().Data;
            comboBoxSelahiyyet.DataSource = claims;
            comboBoxSelahiyyet.DisplayMember = "Name";
            comboBoxSelahiyyet.ValueMember = "Id";
        }
    }
}

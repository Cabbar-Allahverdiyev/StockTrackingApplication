using Business.Abstract;
using Business.Constants.Messages;
using Core.Entities.Concrete;
using Core.Utilities.Results;
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
using WindowsForm.Core.Controllers.Concrete;

namespace WindowsForm.Forms.AdminForms
{
    public partial class OperationClaimForm : Form
    {
        public static bool IsAdminVerified = false;
        IUserService _userService;
        IOperationClaimForFormsService _operationClaimService;
        IUserOperationClaimForFormsService _useroperationClaimService;

        public OperationClaimForm(IUserService userService
                                , IOperationClaimForFormsService operationClaimService
                                , IUserOperationClaimForFormsService useroperationClaimService)
        {
            _userService = userService;
            _operationClaimService = operationClaimService;
            _useroperationClaimService = useroperationClaimService;
            //AdminVerificationForm adminVerificationForm = new AdminVerificationForm(_userService);
            //adminVerificationForm.ShowDialog();
            //if (UserAuthorization.IsAdminVerified == false)
            //{
            //    FormsMessage.WarningMessage(AuthMessages.AuthorizationDenied);
            //    return;
            //}
            InitializeComponent();
            
        }

        private void OperationClaimForm_Load(object sender, EventArgs e)
        {


            WriteClaimsOnComboBox();
            WriteUsersOnComboBox();
            RefreshUserClaims();
            ComboBoxController.ClearAllComboBoxByGroupBox(groupBoxOperationClaim);

        }

        private void WriteUsersOnComboBox()
        {
            List<User> userGetAll = _userService.GetAll().Data;
            comboBoxIstifadeci.DataSource = userGetAll;//bossu admini gizlet
            comboBoxIstifadeci.DisplayMember = "FirstName";
            comboBoxIstifadeci.ValueMember = "Id";
        }

        private void WriteClaimsOnComboBox()
        {
            List<OperationClaimForForms> claims = _operationClaimService.GetAllButTheBoss().Data;

            comboBoxSelahiyyet.DataSource = claims;
            comboBoxSelahiyyet.DisplayMember = "Name";
            comboBoxSelahiyyet.ValueMember = "Id";
        }

        private void RefreshUserClaims()
        {
            dataGridViewUserClaims.DataSource = _useroperationClaimService.GetAllUserOperationClaimDtoDetails().Data;
            
        }

        private void buttonElaveEt_Click(object sender, EventArgs e)
        {
            if (comboBoxIstifadeci.Text==""||comboBoxSelahiyyet.Text=="")
            {
                FormsMessage.WarningMessage(FormsTextMessages.SectionsIsBlank);
                return;
            }
            UserOperationClaimForForms userOperationClaim = new UserOperationClaimForForms();
            userOperationClaim.UserId = Convert.ToInt32(comboBoxIstifadeci.SelectedValue);
            userOperationClaim.OperationClaimId = Convert.ToInt32(comboBoxSelahiyyet.SelectedValue);
            //validation yaz
            IResult  userClaimAdded= _useroperationClaimService.Add(userOperationClaim);
            if (!userClaimAdded.Success)
            {
                FormsMessage.WarningMessage(userClaimAdded.Message);
                return;
            }
            FormsMessage.SuccessMessage(userClaimAdded.Message);
            RefreshUserClaims();
            ComboBoxController.ClearAllComboBoxByGroupBox(groupBoxOperationClaim);
        }
    }
}

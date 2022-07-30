using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.ForForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;

namespace WindowsForm.Forms.AdminForms
{
    public partial class MacAddressForm : Form
    {
        MacAddressManager macAddressManager = new MacAddressManager(new EfMacAddressDal());
        IUserService _userService;
        IUserOperationClaimForFormsService _userOperationClaimService;
        IFormSettingService _formSettingService;
        IOperationClaimForFormsService _operationClaimService;
        public MacAddressForm(IUserService userService,
            IUserOperationClaimForFormsService userOperationClaimService,
            IFormSettingService formSettingService,
            IOperationClaimForFormsService operationClaimService)
        {
            _userService = userService;
            _userOperationClaimService = userOperationClaimService;
            _formSettingService = formSettingService;

            InitializeComponent();
            dataGridViewListed.DataSource = macAddressManager.GetAll().Data;
            _operationClaimService = operationClaimService;
        }

        private void buttonElaveEt_Click(object sender, EventArgs e)
        {
            if (textBoxMacAddress.Text == "")
            {
                return;
            }
            MacAddres macAddress = new MacAddres();
            macAddress.Address = textBoxMacAddress.Text;
            IResult macAdded = macAddressManager.Add(macAddress);
            if (!macAdded.Success)
            {
                FormsMessage.WarningMessage(macAdded.Message);
            }
            FormsMessage.SuccessMessage(macAdded.Message);
            dataGridViewListed.DataSource = macAddressManager.GetAll().Data;
        }


        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
            {
                return;
            }
            MacAddres macAddress = new MacAddres();
            macAddress.Id = int.Parse(textBoxId.Text);
            IResult macDeleted = macAddressManager.Delete(macAddress);
            if (!macDeleted.Success)
            {
                FormsMessage.WarningMessage(macDeleted.Message);
            }
            FormsMessage.SuccessMessage(macDeleted.Message);
            dataGridViewListed.DataSource = macAddressManager.GetAll().Data;
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewListed.DataSource = macAddressManager.GetAll().Data;
        }

        private void dataGridViewListed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewListed.CurrentRow.Cells["Id"].Value.ToString();
        }

        private void MacAddressForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonUserAdd_Click(object sender, EventArgs e)
        {
            FormUserAdd formUserAdd = new FormUserAdd(_userService, _operationClaimService,_userOperationClaimService, _formSettingService);
            formUserAdd.ShowDialog();
            

        }
    }
}

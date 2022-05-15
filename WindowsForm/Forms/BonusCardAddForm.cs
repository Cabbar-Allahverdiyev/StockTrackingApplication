using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using USB_Barcode_Scanner;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.Concrete.ValidatorControllers;
using WindowsForm.MyControls;
using WindowsForm.Utilities.Search.Concrete.BonusCardSearch;

namespace WindowsForm.Forms
{
    public partial class BonusCardAddForm : Form
    {
        IBonusCardService _bonusCardService;
        ICustomerService _customerService;


        public BonusCardAddForm(IBonusCardService bonusCardService, ICustomerService customerService)
        {
            _bonusCardService = bonusCardService;
            _customerService = customerService;
            InitializeComponent();
            BarcodeScanner barcodeScanner = new BarcodeScanner(textBoxBarkod);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }

        //Load
        private void BonusCardAddForm_Load(object sender, EventArgs e)
        {
            BonusCardRefresh();
        }

        //Click
        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            BonusCardRefresh();
        }

        private void buttonSec_Click(object sender, EventArgs e)
        {
            CustomerSelectForm customerSelectForm = new CustomerSelectForm(_customerService);
            CustomerSelectForm.CustomerId = 0;
            customerSelectForm.ShowDialog();

            IDataResult<Customer> getCustomer = _customerService.GetById(CustomerSelectForm.CustomerId);
            if (!getCustomer.Success)
            {
                FormsMessage.WarningMessage(getCustomer.Message);
                return;
            }
            textBoxMusteriId.Text = CustomerSelectForm.CustomerId.ToString();
            textBoxAd.Text = getCustomer.Data.FirstName;
            textBoxSoyad.Text = getCustomer.Data.LastName;
        }

        private void buttonElaveEt_Click(object sender, EventArgs e)
        {
            BonusCard bonusCard = new BonusCard();
            bonusCard.CustomerId = int.Parse(textBoxMusteriId.Text);
            bonusCard.BarcodeNumber = textBoxBarkod.Text;

            BonusCardValidationTool bonusCardValidationTool = new BonusCardValidationTool();
            if (!bonusCardValidationTool.IsValid(bonusCard))
            {
                return;
            }
            IResult result = _bonusCardService.Add(bonusCard);
            if (!result.Success)
            {
                FormsMessage.WarningMessage(result.Message);
                return;
            }
            FormsMessage.SuccessMessage(result.Message);
            BonusCardRefresh();
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBoxMusteri);
        }

        //Text Changed
        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            BonusCardSearch bonusCardSearch = new BonusCardSearch();
            bonusCardSearch.GetDataWriteGridView(_bonusCardService.GetAllBonusCardForFormsDetail().Data
                , textBoxAxtar.Text, dataGridViewList);
        }


        //Key Press
        private void textBoxGuzest_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyControl.MakeTextBoxDecimalBox(sender, e);
        }

        private void textBoxBonusCardBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyControl.MakeTextBoxDecimalBox(sender, e);
        }

        //Elave
        private void BonusCardRefresh()
        {
            dataGridViewList.DataSource = _bonusCardService.GetAllBonusCardForFormsDetail().Data;
        }

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            textBoxBarkod.Text = e.Barcode;
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBoxMusteri);
        }

    }
}

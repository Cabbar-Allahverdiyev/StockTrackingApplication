using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using USB_Barcode_Scanner;
using WindowsForm.Utilities.BarcodeScanner.BarcodeGenerate;
using Core.Utilities.Results;
using WindowsForm.Core.Constants.Messages;
using Business.Constants.Messages;
using System.Reflection;
using System.Drawing.Printing;
using System.Threading.Tasks;
using Business.Abstract;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace WindowsForm.Forms
{
    public partial class AutomaticBarcodeGenerateForm : Form
    {
        private readonly IBarcodeGenerator _barcodeGenerator;
        private readonly IFormSettingService _formSettingService;
        public static string? BarcodeNumber { get; set; }
        private int width;
        private int height;

        public AutomaticBarcodeGenerateForm(IBarcodeGenerator barcodeGenerator, IFormSettingService formSettingService)
        {
            _barcodeGenerator = barcodeGenerator;
            _formSettingService = formSettingService;
            InitializeComponent();
            BarcodeNumber = null;
            BarcodeScanner barcodeScanner = new BarcodeScanner(textBoxBarcodeNumber);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;

        }

         private void AutomaticBarcodeGenerateForm_Load(object sender, EventArgs e)
        {
            width = pictureBox1.Width;
            height = pictureBox1.Height;
            
            trackBarWith.Value = _formSettingService.GetUsbBarCodeScannerFormTrackBarValues().Data.Width;
            trackBarHeight.Value = _formSettingService.GetUsbBarCodeScannerFormTrackBarValues().Data.Height;

            pictureBox1.Width= trackBarWith.Value * 10 + width;
            pictureBox1.Height= trackBarHeight.Value * 10 + height;
        }

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            textBoxBarcodeNumber.Text = e.Barcode;
        }

        private void trackBarWith_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Width = trackBarWith.Value * 10 + width;
            _formSettingService.UpdateUsbBarCodeScannerFormTrackBarValues(trackBarWith.Value,
                                                                          trackBarHeight.Value);
        }

        private void trackBarHeight_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Height = trackBarHeight.Value * 2 + height;
            _formSettingService.UpdateUsbBarCodeScannerFormTrackBarValues(trackBarWith.Value,
                                                                          trackBarHeight.Value);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            IDataResult<List<Image>> barcodes = _barcodeGenerator
                                            .GenerateBarcodeCode128ThanMoreOne(textBoxBarcodeNumber.Text,
                                                                               pictureBox1.Width,
                                                                               pictureBox1.Height,
                                                                               int.Parse(
                                                                                   textBoxCount.Text.ToString()
                                                                                   ));
            if (!barcodes.Success)
            {
                FormsMessage.ErrorMessage(barcodes.Message);
                return;
            }
            IResult result = _barcodeGenerator.ThanMoreOneSave(barcodes.Data);
            if (!result.Success)
            {
                FormsMessage.ErrorMessage(result.Message);
                return;
            }
            FormsMessage.SuccessMessage(result.Message);
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                IDataResult<string> barcodeCreated;
                IDataResult<Image> result = _barcodeGenerator.GenerateBarcodeCode128(textBoxBarcodeNumber.Text,
                                                                                  pictureBox1.Width,
                                                                                pictureBox1.Height);
                if (!result.Success)
                {
                    FormsMessage.WarningMessage(result.Message);
                    //MessageBox.Show(result.Message);
                    return;
                }
                pictureBox1.Image = result.Data;
                barcodeCreated = _barcodeGenerator.InmemoryScanItAndConvertString(pictureBox1.Image);
                if (!barcodeCreated.Success)
                {
                    FormsMessage.WarningMessage(barcodeCreated.Message);

                    return;
                }

                if (barcodeCreated.Data != textBoxBarcodeNumber.Text)
                {
                    textBoxBarcodeNumber.Text = barcodeCreated.Data;
                    buttonGenerate_Click(sender, e);
                }

                //pictureBox1.Width += trackBarWith.Value * 10;
                //pictureBox1.Height += trackBarHeight.Value * 10;
                FormsMessage.SuccessMessage(result.Message);
            }
            catch (Exception ex)
            {

                FormsMessage.ErrorMessage(BarcodeNumberMessages.QRCodeNotGenerated + " : " + BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod()?.Name, ex));
                return;
            }
        }

        private void buttonQrCode_Click(object sender, EventArgs e)
        {

        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            try
            {
                IDataResult<string> result = _barcodeGenerator.InmemoryScanItAndConvertString(pictureBox1.Image);
                if (!result.Success)
                {
                    FormsMessage.WarningMessage(result.Message);
                    // MessageBox.Show(result.Message);
                    return;
                }
                textBoxBarcodeNumber.Text = result.Data;
                FormsMessage.SuccessMessage(result.Message);
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod()?.Name, ex));
                return;
            }
        }

       
    }
}

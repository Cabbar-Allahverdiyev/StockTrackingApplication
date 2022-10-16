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

namespace WindowsForm.Forms
{
    public partial class USBBarcodeScannerForm : Form
    {
        public static string? BarcodeNumber { get; set; }
        private int width;
        private int height;

        private readonly IBarcodeGenerator _barcodeGenerator;
        private readonly IFormSettingService _formSettingService;
        public USBBarcodeScannerForm(IBarcodeGenerator barcodeGenerator, IFormSettingService formSettingService)
        {
            _barcodeGenerator = barcodeGenerator;
            _formSettingService = formSettingService;
            InitializeComponent();
            textBoxInfo.Visible = true;
            BarcodeNumber = null;
            BarcodeScanner barcodeScanner = new BarcodeScanner(textBoxBarcodeNumber);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
           
        }

        private void USBBarcodeScannerForm_Load_1(object sender, EventArgs e)
        {
            textBoxBarcodeNumber.Text = BarcodeNumber;
            width = pictureBox1.Width;
            height = pictureBox1.Height;
            trackBarWith.Value = _formSettingService.GetUsbBarCodeScannerFormTrackBarValues().Data.Width;
            trackBarHeight.Value = _formSettingService.GetUsbBarCodeScannerFormTrackBarValues().Data.Height;
            pictureBox1.Width = width + trackBarWith.Value * 10;
            pictureBox1.Height = height + trackBarHeight.Value * 10;
        }



        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            textBoxBarcodeNumber.Text = e.Barcode;
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

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                //trackBarWith.Value = 0;
                //trackBarHeight.Value = 0;
                //pictureBox1.Width = width;
                //pictureBox1.Height = height;
                IDataResult<string> barcodeCreated;
                IDataResult<Image> result = _barcodeGenerator.GenerateBarcode(textBoxBarcodeNumber.Text,
                                                                                textBoxInfo.Text,
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


                pictureBox1.Width = trackBarWith.Value * 10+width;
                pictureBox1.Height = trackBarHeight.Value * 10+ height;
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
            IDataResult<Image> result = _barcodeGenerator.GenerateQRCode(textBoxBarcodeNumber.Text);
            if (!result.Success)
            {
                FormsMessage.WarningMessage(result.Message);
                //MessageBox.Show(result.Message);
                return;
            }
            pictureBox1.Image = result.Data;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            IResult result = _barcodeGenerator.Save(pictureBox1.Image);
            if (!result.Success)
            {
                FormsMessage.WarningMessage(result.Message);
                //MessageBox.Show(result.Message);
                return;
            }
            FormsMessage.SuccessMessage(result.Message);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            IResult result = _barcodeGenerator.Load(pictureBox1);
            if (!result.Success)
            {
                FormsMessage.WarningMessage(result.Message);
                //MessageBox.Show(result.Message);
                return;
            }
            FormsMessage.SuccessMessage(result.Message);
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            IDataResult<string> result = _barcodeGenerator.RandomBarcodeNumberGenerator();
            if (!result.Success)
            {
                FormsMessage.WarningMessage(result.Message);
                return;
            }
            textBoxBarcodeNumber.Text = result.Data;
            BarcodeNumber = result.Data;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintPicture;
            printDialog.Document = printDoc;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {

                printDoc.Print();
            }
        }

        private void PrintPicture(object sender, PrintPageEventArgs e)
        {

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics?.DrawImage(bmp, 0, 0);
            bmp.Dispose();
        }

        //scroll---------------------->

        private void trackBarWith_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Width = trackBarWith.Value * 10 + width;
            //width = pictureBox1.Width;
            _formSettingService.UpdateUsbBarCodeScannerFormTrackBarValues(trackBarWith.Value,
                                                                          trackBarHeight.Value);
        }

        private void trackBarHeight_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Height = trackBarHeight.Value * 10 + height;
           // height=pictureBox1.Height;  
            _formSettingService.UpdateUsbBarCodeScannerFormTrackBarValues(trackBarWith.Value,
                                                                          trackBarHeight.Value);
        }
    }
}
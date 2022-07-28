using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using USB_Barcode_Scanner;
using WindowsForm.Utilities.BarcodeScanner.BarcodeGenerate;
using Core.Utilities.Results;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using WindowsForm.Core.Constants.Messages;
using Business.Constants.Messages;
using System.Reflection;
using System.Drawing.Printing;

namespace WindowsForm.Forms
{
    public partial class USBBarcodeScannerForm : Form
    {
        public static string BarcodeNumber { get; set; }
        public USBBarcodeScannerForm()
        {
            InitializeComponent();
            textBoxInfo.Visible = false;
            BarcodeNumber = null;
            BarcodeScanner barcodeScanner = new BarcodeScanner(textBoxBarcodeNumber);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }

        private void USBBarcodeScannerForm_Load_1(object sender, EventArgs e)
        {
        }

        BarcodeGenerator barcodeGenerator = new BarcodeGenerator(new ProductManager(new EfProductDal()));

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            textBoxBarcodeNumber.Text = e.Barcode;
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            IDataResult<string> result = barcodeGenerator.InmemoryScanItAndConvertString(pictureBox1);
            if (!result.Success)
            {
                FormsMessage.WarningMessage(result.Message);
                // MessageBox.Show(result.Message);
                return;
            }
            textBoxBarcodeNumber.Text = result.Data;
            FormsMessage.SuccessMessage(result.Message);
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                IDataResult<string> barcodeCreated;
                IDataResult<Image> result = barcodeGenerator.GenerateBarcode(textBoxBarcodeNumber.Text, textBoxInfo.Text, pictureBox1);
                if (!result.Success)
                {
                    FormsMessage.WarningMessage(result.Message);
                    //MessageBox.Show(result.Message);
                    return;
                }
                //pictureBox1.Image = result.Data;
                barcodeCreated = barcodeGenerator.InmemoryScanItAndConvertString(pictureBox1);
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
                FormsMessage.SuccessMessage(result.Message);
            }
            catch (Exception ex)
            {

                FormsMessage.ErrorMessage(BarcodeNumberMessages.QRCodeNotGenerated + " : " + BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }

        private void buttonQrCode_Click(object sender, EventArgs e)
        {
            IDataResult<Image> result = barcodeGenerator.GenerateQRCode(textBoxBarcodeNumber.Text);
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
            IResult result = barcodeGenerator.Save(pictureBox1);
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
            IResult result = barcodeGenerator.Load(pictureBox1);
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
            IDataResult<string> result = barcodeGenerator.RandomBarcodeNumberGenerator();
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
            //var doc = new PrintDocument();
            //doc.PrintPage += (s, printArgs) =>
            //{
            //    // send that graphics object to the rendering code using the size
            //    // of the media defined in the print arguments
            //    RenderBarcodeInfoToGraphics(printArgs.Graphics, textBoxBarcodeNumber.Text,
            //        textBoxInfo.Text, printArgs.PageBounds);
            //};

            //// save yourself some paper and render to a print-preview first
            //using (var printPrvDlg = new PrintPreviewDialog { Document = doc })
            //{
            //    printPrvDlg.ShowDialog();
            //}

            //// finally show the print dialog so the user can select a printer
            //// and a paper size (along with other miscellaneous settings)
            //using (var pd = new PrintDialog { Document = doc })
            //{
            //    if (pd.ShowDialog() == DialogResult.OK) { doc.Print(); }
            //}

            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintPicture;
            printDialog.Document = printDoc;


            //PaperSize paperSize = new PaperSize("abcd", 60, 27);

            //printDialog.PrinterSettings.DefaultPageSettings.PaperSize = paperSize;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {

                printDoc.Print();
            }
        }

        private void PrintPicture(object sender, PrintPageEventArgs e)
        {

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();
        }

        private void USBBarcodeScannerForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
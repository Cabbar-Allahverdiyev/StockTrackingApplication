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

namespace WindowsForm.Forms
{
    public partial class USBBarcodeScannerForm : Form
    {
        public USBBarcodeScannerForm()
        {
            InitializeComponent();
            BarcodeScanner barcodeScanner = new BarcodeScanner(textBox1);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;


        }
        //ProductManager productManager = new ProductManager(new EfProductDal());
        //BarcodeEncoder generator;
        //BarcodeDecoder scanner;
        //SaveFileDialog saveDialog;
        //OpenFileDialog openDialog;
        BarcodeGenerator barcodeGenerator = new BarcodeGenerator(new ProductManager(new EfProductDal()));

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            textBox1.Text = e.Barcode;
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            IDataResult<string> result = barcodeGenerator.InmemoryScanItAndConvertString(pictureBox1);
            if (!result.Success)
            {
                MessageBox.Show(result.Message);
                return;
            }
            textBox1.Text = result.Data;
            //scanner = new BarcodeDecoder();
            //if (pictureBox1.IsMirrored==true)
            //{
            //    MessagingToolkit.Barcode.Result result = scanner.Decode(new Bitmap(pictureBox1.Image));
            //    MessageBox.Show(result.Text);
            //}
            //MessageBox.Show("deyer bos");
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            IDataResult<Image> result = barcodeGenerator.GenerateBarcode(textBox1.Text);
            if (!result.Success)
            {
                MessageBox.Show(result.Message);
                return;
            }
            pictureBox1.Image = result.Data;
            //generator = new BarcodeEncoder();
            //generator.IncludeLabel = true;
            //generator.CustomLabel = textBox1.Text;
            //if (textBox1.Text != "")
            //{
            //    pictureBox1.Image = new Bitmap(generator.Encode(BarcodeFormat.Code39, textBox1.Text));
            //}
        }

        private void buttonQrCode_Click(object sender, EventArgs e)
        {
            IDataResult<Image> result = barcodeGenerator.GenerateQRCode(textBox1.Text);
            if (!result.Success)
            {
                MessageBox.Show(result.Message);
                return;
            }
            pictureBox1.Image = result.Data;


            //generator = new BarcodeEncoder();
            //generator.IncludeLabel = true;
            //generator.CustomLabel = textBox1.Text;
            //if (textBox1.Text != "")
            //{
            //    pictureBox1.Image = new Bitmap(generator.Encode(BarcodeFormat.QRCode, textBox1.Text));
            //}
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            IResult result = barcodeGenerator.Save(pictureBox1);
            if (!result.Success)
            {
                MessageBox.Show(result.Message);

            }



            ////saveDialog = new SaveFileDialog();
            ////saveDialog.Filter = "PNG File|*.png";
            ////if (saveDialog.ShowDialog() == DialogResult.OK)
            ////{
            ////    pictureBox1.Image.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            ////}
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            IResult result = barcodeGenerator.Load(pictureBox1);
            if (!result.Success)
            {
                MessageBox.Show(result.Message);

            }


            ////openDialog = new OpenFileDialog();
            ////openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ////if (openDialog.ShowDialog() == DialogResult.OK)
            ////{
            ////    pictureBox1.Load(openDialog.FileName);
            ////}
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            IDataResult<string> result = barcodeGenerator.RandomBarcodeNumberGenerator();
            if (!result.Success)
            {
                MessageBox.Show(result.Message);
                return;
            }
            textBox1.Text = result.Data;

            //Random random = new Random();
            //String randomText = random.Next(0, 999999).ToString("D13"); //eger sistemde varsa yeniden yarat
            //textBox1.Text = randomText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using MessagingToolkit.Barcode;
using System.Windows.Forms;
using System.Drawing;
using Business.Constants.Messages;
using Core.Utilities.Results;

namespace WindowsForm.Utilities.BarcodeScanner.BarcodeGenerate
{
    public class BarcodeGenerator
    {
        BarcodeEncoder generator;
        BarcodeDecoder scanner;
        SaveFileDialog saveDialog;
        OpenFileDialog openDialog;

        public IDataResult<Image> GenerateBarcode( string text)
        {
            generator = new BarcodeEncoder();
            generator.IncludeLabel = true;
            generator.CustomLabel = text;
            if (text != "")
            {
               Image result = new Bitmap(generator.Encode(BarcodeFormat.Code39, text));
                return new SuccessDataResult<Image>(result, BarcodeNumberMessages.BarcodeNumberGenerated);
            }
            return new ErrorDataResult<Image>(BarcodeNumberMessages.QRCodeNotGenerated);
        }

        public IDataResult<Image> GenerateQRCode( string text)
        {
            generator = new BarcodeEncoder();
            generator.IncludeLabel = true;
            generator.CustomLabel = text;
            if (text != "")
            {
                //pictureBox.Image = 
                    Image result=new Bitmap(generator.Encode(BarcodeFormat.QRCode, text));
                return new SuccessDataResult<Image>(result, BarcodeNumberMessages.QRCodeGenerated);
            }
            return new ErrorDataResult<Image>(BarcodeNumberMessages.QRCodeNotGenerated);
        }


        public IDataResult<string> InmemoryScanItAndConvertString(PictureBox barcodePicture)
        {
            scanner = new BarcodeDecoder();
            if (barcodePicture.IsMirrored == false)
            {
                new ErrorDataResult<string>(BarcodeNumberMessages.ScanFailed);
            }
            MessagingToolkit.Barcode.Result result = scanner.Decode(new Bitmap(barcodePicture.Image));
            return new SuccessDataResult<string>(result.Text, BarcodeNumberMessages.Scanned);
        }

        public IResult Save(PictureBox barcodePicture)
        {
            saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PNG File|*.png";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                
                barcodePicture.Image.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                return new SuccessResult();
            }
            return new ErrorResult(BarcodeNumberMessages.SaveFailed);
        }

        public IResult Load(PictureBox barcodePicture)
        {
            openDialog = new OpenFileDialog();
            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                barcodePicture.Load(openDialog.FileName);
                return new SuccessResult();
            }
            return new ErrorResult(BarcodeNumberMessages.LoadFailed);
        }

        public IDataResult<string> RandomBarcodeNumberGenerator()
        {
            Random random = new Random();
            //string randomText = random.Next(0, 999999).ToString()+ random.Next(0, 999999).ToString(); //eger sistemde varsa yeniden yarat
            string randomText = random.Next(0, 999999).ToString("D13"); //eger sistemde varsa yeniden yarat
            return new SuccessDataResult<string>( randomText,BarcodeNumberMessages.RandomBarcodeNumberGenerated);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using MessagingToolkit.Barcode;
using System.Windows.Forms;
using System.Drawing;
using Business.Constants.Messages;
using Core.Utilities.Results;
using Business.Abstract;
using Entities.Concrete;

namespace WindowsForm.Utilities.BarcodeScanner.BarcodeGenerate
{
    public class BarcodeGenerator
    {
        BarcodeEncoder generator;
        BarcodeDecoder scanner;

        OpenFileDialog openDialog;
        IProductService _productService;

        public BarcodeGenerator(IProductService productService)
        {
            _productService = productService;
        }

        public IDataResult<Image> GenerateBarcode(string text)
        {
            generator = new BarcodeEncoder();
            generator.IncludeLabel = true;
            generator.CustomLabel = text;
            if (text != "")
            {
                Image result = new Bitmap(generator.Encode(BarcodeFormat.QRCode, text));
                return new SuccessDataResult<Image>(result, BarcodeNumberMessages.BarcodeNumberGenerated);
            }
            return new ErrorDataResult<Image>(BarcodeNumberMessages.QRCodeNotGenerated);
        }

        public IDataResult<Image> GenerateQRCode(string text)
        {
            generator = new BarcodeEncoder();
            generator.IncludeLabel = true;
            generator.CustomLabel = text;
            if (text != "")
            {
                //pictureBox.Image = 
                Image result = new Bitmap(generator.Encode(BarcodeFormat.QRCode, text));
                return new SuccessDataResult<Image>(result, BarcodeNumberMessages.QRCodeGenerated);
            }
            return new ErrorDataResult<Image>(BarcodeNumberMessages.QRCodeNotGenerated);
        }


        public IDataResult<string> InmemoryScanItAndConvertString(PictureBox barcodePicture)
        {
            scanner = new BarcodeDecoder();
            if (barcodePicture.Image == null)
            {
                return new ErrorDataResult<string>(BarcodeNumberMessages.ScanFailed);
            }
            MessagingToolkit.Barcode.Result result = scanner.Decode(new Bitmap(barcodePicture.Image));
            return new SuccessDataResult<string>(result.Text, BarcodeNumberMessages.Scanned);
        }

        public IResult Save(PictureBox barcodePicture)
        {
            if (barcodePicture.Image == null)
            {
                return new ErrorResult(BarcodeNumberMessages.SaveFailed); //sekil yoxdu
            }
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PNG|*.png"; //burada 'File' sozu silinib eger lazim olsa Png nin yanina sadece File yaz 
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    barcodePicture.Image.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    return new SuccessResult();
                }
                return new ErrorResult(BarcodeNumberMessages.SaveFailed); 

            }

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
            IDataResult<Product> result;
            do
            {
                Random random = new Random();
                string randomText = "476" + "0776" + random.Next(0, 99999).ToString() + "0"; //eger sistemde varsa yeniden yarat
                                                                                             //string randomText = random.Next(0, 999999).ToString("D13"); //eger sistemde varsa yeniden yarat
                result= _productService.GetByProductBarcodeNumber(randomText);
                if (result.Success)
                {
                    return new ErrorDataResult<string>(ProductMessages.BarcodeNumberAvailable);


                }
                return new SuccessDataResult<string>(randomText, BarcodeNumberMessages.RandomBarcodeNumberGenerated);
            } while (!result.Success);
           
        }
    }
}

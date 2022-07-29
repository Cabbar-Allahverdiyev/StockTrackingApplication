using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Utilities.BarcodeScanner.BarcodeGenerate
{
    public class BarcodeGeneratorBase
    {
        private readonly IProductService _productService;
        private OpenFileDialog openDialog;

        public BarcodeGeneratorBase(IProductService productService)
        {
            _productService = productService;
        }

        public IDataResult<string> RandomBarcodeNumberGenerator()
        {
            IDataResult<Product> result;
            string randomText = "";
            do
            {
                Random random = new Random();
                randomText = CalculateEan13("476", "0201", random.Next(0, 99999).ToString());
                if (randomText.Length < 13)
                {

                }
                result = _productService.GetByBarcodeNumber(randomText);
                if (result.Success)
                {
                    return new ErrorDataResult<string>(ProductMessages.BarcodeNumberAvailable);


                }
                if (randomText.Length < 13)
                {
                    return RandomBarcodeNumberGenerator();
                }
                return new SuccessDataResult<string>(randomText, BarcodeNumberMessages.RandomBarcodeNumberGenerated);
            } while (!result.Success);
        }

        public string CalculateEan13(string country, string manufacturer, string product)
        {
            string temp = $"{country}{manufacturer}{product}";
            int sum = 0;
            int digit = 0;
            for (int i = temp.Length; i >= 1; i--)
            {
                digit = Convert.ToInt32(temp.Substring(i - 1, 1));

                if (i % 2 == 0)
                {
                    sum += digit * 3;
                }
                else
                {
                    sum += digit * 1;
                }
            }
            int checkSum = (10 - (sum % 10)) % 10;
            return $"{temp}{checkSum}";
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
                    barcodePicture.Image.Save(saveDialog.FileName, ImageFormat.Png);
                    return new SuccessResult(BarcodeNumberMessages.Save);
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
                return new SuccessResult(BarcodeNumberMessages.Load);
            }
            return new ErrorResult(BarcodeNumberMessages.LoadFailed);
        }
    }
}

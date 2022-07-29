using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using IronBarCode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Utilities.BarcodeScanner.BarcodeGenerate.IronBarcodeGenerator
{
    public class BarcodeGeneratorIron:BarcodeGeneratorBase,IBarcodeGenerator
    {
        public BarcodeGeneratorIron(IProductService productService):base(productService)
        {

        }

        public IDataResult<Image> GenerateBarcode(string barcodeText, string info, PictureBox pictureBox)
        {
            GeneratedBarcode barcode = BarcodeWriter.CreateBarcode(barcodeText, BarcodeEncoding.EAN13)
                .ResizeTo(pictureBox.Width, pictureBox.Height).SetMargins(10);
            barcode.AddBarcodeValueTextBelowBarcode();
            pictureBox.Image = barcode.ToImage();
            return new SuccessDataResult<Image>(pictureBox.Image);
        }

        public IDataResult<Image> GenerateQRCode(string text)
        {
            throw new NotImplementedException();
        }

        public IDataResult<string> InmemoryScanItAndConvertString(PictureBox barcodePicture)
        {
            var result= BarcodeReader.QuicklyReadOneBarcode(barcodePicture.Image);//= scanner.Decode(new Bitmap(barcodePicture.Image));
            return new SuccessDataResult<string>(result.Value, BarcodeNumberMessages.Scanned);
        }

       
    }
}

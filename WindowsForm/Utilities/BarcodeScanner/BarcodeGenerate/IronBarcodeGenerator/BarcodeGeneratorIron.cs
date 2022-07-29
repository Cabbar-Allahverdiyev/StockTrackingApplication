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
    public class BarcodeGeneratorIron : BarcodeGeneratorBase, IBarcodeGenerator
    {
        public BarcodeGeneratorIron(IProductService productService) : base(productService)
        {

        }

        public IDataResult<Image> GenerateBarcode(string barcodeText, string info, int width, int height)
        {
            if (barcodeText.Length > 13)
            {
                barcodeText = barcodeText.Substring(0, 13);
            }
            if (barcodeText.Length < 13)
            {
                return new ErrorDataResult<Image>(BarcodeNumberMessages.BarcodeNumberLengthLessThan13NotGenerated);
            }
            GeneratedBarcode barcode = BarcodeWriter.CreateBarcode(barcodeText, BarcodeEncoding.EAN13)
           .ResizeTo(width, height).SetMargins(5);
            barcode.AddBarcodeValueTextBelowBarcode();
            barcode.AddAnnotationTextAboveBarcode(info
                , new Font(new FontFamily("Arial"), 10, FontStyle.Regular, GraphicsUnit.Pixel)
                , Color.DarkSlateBlue);
            Image img = barcode.ToBitmap();
            return new SuccessDataResult<Image>(img, BarcodeNumberMessages.BarcodeNumberGenerated);



        }

        public IDataResult<Image> GenerateQRCode(string text)
        {
            GeneratedBarcode barcode = BarcodeWriter.CreateBarcode(text, BarcodeEncoding.QRCode)
          .SetMargins(20);
            barcode.AddBarcodeValueTextBelowBarcode();
            //barcode.AddAnnotationTextAboveBarcode(info
            //    , new Font(new FontFamily("Arial"), 10, FontStyle.Regular, GraphicsUnit.Pixel)
            //    , Color.DarkSlateBlue);
            Image img = barcode.ToBitmap();
            return new SuccessDataResult<Image>(img, BarcodeNumberMessages.QRCodeGenerated);
        }

        public IDataResult<string> InmemoryScanItAndConvertString(Image img)
        {

            var result = BarcodeReader.QuicklyReadOneBarcode(img);
            return new SuccessDataResult<string>(result.Value, BarcodeNumberMessages.Scanned);

        }


    }
}

using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using IronBarCode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Zen.Barcode;

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
            GeneratedBarcode barcode = BarcodeWriter.CreateBarcode(barcodeText, BarcodeEncoding.EAN13, width, height)
           .ResizeTo(width, height)
           .SetMargins(2);
            barcode.AddBarcodeValueTextBelowBarcode();
            //new Font(new FontFamily("MS Sans Serif"), 20, FontStyle.Regular, GraphicsUnit.World)
            //    , Color.DarkSlateBlue);
            barcode.AddAnnotationTextAboveBarcode(info
                , new Font(new FontFamily("Arial"), 12, FontStyle.Regular, GraphicsUnit.Pixel)
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

        private static void RenderBarcodeInfoToGraphics(Graphics g, string code, string info, Rectangle rect)
        {
            const int barcodeHeight = 30;//50;
            const int marginTop = 5;//20;
            const string codeFontFamilyName = "Courier New";
            const int codeFontEmSize = 10;
            const int marginCodeFromCode = 10;
            const string infoFontFamilyName = "Arial";
            const int infoFontEmSize = 12;
            const int marginInfoFromCode = 10;

            g.Clear(Color.White);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            using (var img = BarcodeDrawFactory.Code128WithChecksum.Draw(code, barcodeHeight))
            {
                g.DrawImage(img,
                    new Point(rect.X + (rect.Width / 2 - img.Width / 2), rect.Y + marginTop));
            }
            using (var br = new SolidBrush(Color.Black))
            {
                var yPos = rect.Y + marginTop + barcodeHeight + marginCodeFromCode;
                var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Near
                };
                var codeTextHeight = 0;
                using (var font =
                    new Font(codeFontFamilyName, codeFontEmSize, FontStyle.Regular))
                {
                    codeTextHeight = (int)Math.Round(g.MeasureString(code, font).Height);
                    g.DrawString(code, font, br,
                                new Rectangle(rect.X, yPos, rect.Width, 0), sf);
                }
                using (var font =
                    new Font(infoFontFamilyName, infoFontEmSize, FontStyle.Regular))
                {
                    g.DrawString(info, font, br,
                        new Rectangle(rect.X,
                            yPos + codeTextHeight + marginInfoFromCode, rect.Width, 0), sf);
                }
            }
        }

        public IDataResult<Image> GenerateBarcodeCode128(string text, int width, int height)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Image>> GenerateBarcodeCode128ThanMoreOne(string text, int width, int height, int count)
        {
            throw new NotImplementedException();
        }
    }
}

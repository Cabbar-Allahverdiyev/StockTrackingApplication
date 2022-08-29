using System;
using System.Collections.Generic;
using System.Text;
using MessagingToolkit.Barcode;
using System.Windows.Forms;
using System.Drawing;
using Business.Constants.Messages;
using Core.Utilities.Results;
using Business.Abstract;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using Zen.Barcode;

namespace WindowsForm.Utilities.BarcodeScanner.BarcodeGenerate.MessagingToolkitGenerator
{
    public class MTBarcodeGenerator : BarcodeGeneratorBase, IBarcodeGenerator
    {
        BarcodeEncoder generator;
        BarcodeDecoder scanner;

        public MTBarcodeGenerator(IProductService productService) : base(productService)
        {
        }

        public IDataResult<Image> GenerateBarcode(string barcodeText, string info, int width, int height)
        {
            // pictureBox.Image?.Dispose();

            if (barcodeText.Length > 13)
            {
                barcodeText = barcodeText.Substring(0, 13);
            }
            if (barcodeText.Length < 13)
            {
                return new ErrorDataResult<Image>(BarcodeNumberMessages.BarcodeNumberLengthLessThan13NotGenerated);
            }
            Image img = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            using (var g = Graphics.FromImage(img))
            {
                RenderBarcodeInfoToGraphics(g, barcodeText, info,
                                             new Rectangle(0, 0, width, height));
            }
            return new SuccessDataResult<Image>(img, BarcodeNumberMessages.BarcodeNumberGenerated);
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


        public IDataResult<string> InmemoryScanItAndConvertString(Image img)
        {
            scanner = new BarcodeDecoder();
            if (img == null)
            {
                return new ErrorDataResult<string>(BarcodeNumberMessages.ScanFailed);
            }
            MessagingToolkit.Barcode.Result result = scanner.Decode(new Bitmap(img));
            return new SuccessDataResult<string>(result.Text, BarcodeNumberMessages.Scanned);
        }

        public IDataResult<Image> GenerateBarcodeCode128(string barcodeText, int width, int height)
        {
            generator = new BarcodeEncoder();
            generator.IncludeLabel = true;
            generator.CustomLabel = barcodeText;
            if (barcodeText != "")
            {
                //pictureBox.Image = 
                Image result = new Bitmap(generator.Encode(BarcodeFormat.Code128, barcodeText));
                return new SuccessDataResult<Image>(result, BarcodeNumberMessages.BarcodeNumberGenerated);
            }
            return new ErrorDataResult<Image>(BarcodeNumberMessages.QRCodeNotGenerated);
        }

        public IDataResult<List<Image>> GenerateBarcodeCode128ThanMoreOne(string text, int width, int height, int count)
        {
            throw new NotImplementedException();
        }

        //public IResult Save(PictureBox barcodePicture)
        //{
        //    if (barcodePicture.Image == null)
        //    {
        //        return new ErrorResult(BarcodeNumberMessages.SaveFailed); //sekil yoxdu
        //    }
        //    using (SaveFileDialog saveDialog = new SaveFileDialog())
        //    {
        //        saveDialog.Filter = "PNG|*.png"; //burada 'File' sozu silinib eger lazim olsa Png nin yanina sadece File yaz 
        //        if (saveDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            barcodePicture.Image.Save(saveDialog.FileName, ImageFormat.Png);
        //            return new SuccessResult(BarcodeNumberMessages.Save);
        //        }
        //        return new ErrorResult(BarcodeNumberMessages.SaveFailed);

        //    }

        //}

        //public IResult Load(PictureBox barcodePicture)
        //{
        //    openDialog = new OpenFileDialog();
        //    openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //    if (openDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        barcodePicture.Load(openDialog.FileName);
        //        return new SuccessResult(BarcodeNumberMessages.Load);
        //    }
        //    return new ErrorResult(BarcodeNumberMessages.LoadFailed);
        //}





    }
}

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

        //OpenFileDialog openDialog;


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
            // create a 24 bit image that is the size of your picture box
            Image img = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            // wrap it in a graphics object
            using (var g = Graphics.FromImage(img))
            {
                // send that graphics object to the rendering code
                RenderBarcodeInfoToGraphics(g, barcodeText, info,
                    new Rectangle(0, 0, width, height));
            }

            // set the new image in the picture box
            
            return new SuccessDataResult<Image>(img, BarcodeNumberMessages.BarcodeNumberGenerated);




            //generator = new BarcodeEncoder();
            //generator.IncludeLabel = true;
            //generator.CustomLabel = text;
            //if (text != "")
            //{
            //    Image result = new Bitmap(generator.Encode(BarcodeFormat.EAN13, text));
            //    return new SuccessDataResult<Image>(result, BarcodeNumberMessages.BarcodeNumberGenerated);
            //}
            //return new ErrorDataResult<Image>(BarcodeNumberMessages.QRCodeNotGenerated);
        }

        private static void RenderBarcodeInfoToGraphics(Graphics g, string code, string info, Rectangle rect)
        {
            // Constants to make numbers a little less magical

            const int barcodeHeight = 30;//50;
            const int marginTop = 5;//20;
            const string codeFontFamilyName = "Courier New";
            const int codeFontEmSize = 10;
            const int marginCodeFromCode = 10;
            const string infoFontFamilyName = "Arial";
            const int infoFontEmSize = 12;
            const int marginInfoFromCode = 10;

            // white background
            g.Clear(Color.White);

            // We want to make sure that when it draws, the renderer doesn't compensate
            // for images scaling larger by blurring the image. This will leave your
            // bars crisp and clean no matter how high the DPI is
            g.InterpolationMode = InterpolationMode.NearestNeighbor;

            // generate barcode
            using (var img = BarcodeDrawFactory.Code128WithChecksum.Draw(code, barcodeHeight))
            {
                // daw the barcode image

                g.DrawImage(img,                                //img
                    new Point(rect.X + (rect.Width / 2 - img.Width / 2), rect.Y + marginTop));
            }

            // now draw the code under the bar code
            using (var br = new SolidBrush(Color.Black))
            {
                // calculate starting position of text from the top
                var yPos = rect.Y + marginTop + barcodeHeight + marginCodeFromCode;

                // align text to top center of area
                var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Near
                };

                // draw the code, saving the height of the code text
                var codeTextHeight = 0;
                using (var font =
                    new Font(codeFontFamilyName, codeFontEmSize, FontStyle.Regular))
                {
                    codeTextHeight = (int)Math.Round(g.MeasureString(code, font).Height);

                    g.DrawString(code, font, br,
                        new Rectangle(rect.X, yPos, rect.Width, 0), sf);
                }

                // draw the info below the code
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

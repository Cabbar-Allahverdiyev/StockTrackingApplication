using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using NetBarcode;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsForm.Utilities.BarcodeScanner.BarcodeGenerate.NetBarcodes
{
    public class NetBarcodeGenerator : BarcodeGeneratorBase, IBarcodeGenerator
    {
       
        private readonly IBarcodeGenerator _barcodeTool;
        public NetBarcodeGenerator(IProductService productService) : base(productService)
        {
            
            _barcodeTool = new MessagingToolkitGenerator.MTBarcodeGenerator(productService);
        }
        public IDataResult<System.Drawing.Image> GenerateBarcode(string barcodeText, string info, int width, int height)
        {
            try
            {
                if (barcodeText.Length > 13)
                {
                    barcodeText = barcodeText.Substring(0, 13);
                }
                if (barcodeText.Length < 13)
                {
                    return new ErrorDataResult<System.Drawing.Image>(BarcodeNumberMessages.BarcodeNumberLengthLessThan13NotGenerated);
                }


                SixLabors.Fonts.FontCollection collection = new SixLabors.Fonts.FontCollection();
                SixLabors.Fonts.FontFamily family = collection.Add("Fonts/Helvetica.ttf");
                SixLabors.Fonts.Font font = family.CreateFont(4, SixLabors.Fonts.FontStyle.Italic);
                /////Font font = new System.Drawing.Font(FontFamily.GenericMonospace, 20, FontStyle.Italic)

                //SixLabors.Fonts.FontStyle.Bold);
                var barcode = new Barcode(barcodeText
                    , NetBarcode.Type.EAN13
                    , true
                    , width
                    , height
                    ,font
                    //,LabelPosition.TopRight
                    //,AlignmentPosition.Right
                    );
                
               
                SixLabors.ImageSharp.Image image = barcode.GetImage();
                var stream = new System.IO.MemoryStream();
                image.SaveAsBmp(stream);
                System.Drawing.Image img = System.Drawing.Image.FromStream(stream);
                return new SuccessDataResult<System.Drawing.Image>(img
                    , BarcodeNumberMessages.BarcodeNumberGenerated);
            }
            catch (Exception ex)
            {

                return new SuccessDataResult<System.Drawing.Image>($"{BarcodeNumberMessages.QRCodeNotGenerated} | {ex.Message}");
            }
            
            //pdfSharpCore
        }

        public IDataResult<System.Drawing.Image> GenerateQRCode(string text)
        {
            IDataResult<System.Drawing.Image> getBarcode = _barcodeTool.GenerateQRCode(text);
            if (getBarcode.Success)
            {
                return new SuccessDataResult<System.Drawing.Image>(getBarcode.Data, getBarcode.Message);
            }
            return new ErrorDataResult<System.Drawing.Image>(getBarcode.Message);
           
        }

        public IDataResult<string> InmemoryScanItAndConvertString(System.Drawing.Image img)
        {            
           IDataResult<string> getText= _barcodeTool.InmemoryScanItAndConvertString(img);
            if (getText.Success)
            {
                return new SuccessDataResult<string>(getText.Data,getText.Message);
            }
            return new ErrorDataResult<string>( getText.Message);
        }
    }
}

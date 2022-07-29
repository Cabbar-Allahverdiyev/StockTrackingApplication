using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Utilities.BarcodeScanner.BarcodeGenerate
{
    public interface IBarcodeGenerator:IBarcodeGeneratorBase
    {
        IDataResult<Image> GenerateBarcode(string barcodeText, string info, int width, int height);
        IDataResult<Image> GenerateQRCode(string text);
        IDataResult<string> InmemoryScanItAndConvertString(Image img);
        

    }
}

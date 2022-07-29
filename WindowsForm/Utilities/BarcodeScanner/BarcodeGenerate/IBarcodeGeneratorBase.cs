using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Utilities.BarcodeScanner.BarcodeGenerate
{
    public interface IBarcodeGeneratorBase
    {
        IDataResult<string> RandomBarcodeNumberGenerator();
        string CalculateEan13(string country, string manufacturer, string product);
        IResult Load(PictureBox barcodePicture);
        IResult Save(Image ımage);
    }
}

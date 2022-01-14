using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using USB_Barcode_Scanner;

namespace WindowsForm.Utilities.BarcodeScanner
{
    public class USBBarcodeScannerExtension
    {
        public void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e,TextBox textBox)
        {
            textBox.Text = e.Barcode;
        }
    }
}

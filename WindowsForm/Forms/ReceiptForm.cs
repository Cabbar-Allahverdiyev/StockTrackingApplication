using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Forms
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocReceipt;
            //printPreviewDialog1.ShowDialog();
            //Aclas Printer
            printDocReceipt.DefaultPageSettings.PrinterSettings.PrinterName = "Aclas Printer";
            //printDocReceipt.DefaultPageSettings.Landscape = true;


           printDocReceipt.Print();
        }

        private void printDocReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawString("TapSat System", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            //e.Graphics.DrawString("IphoneShop", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 40));
            //e.Graphics.DrawString("Yevlax şəh. Nizami 57", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 70));
            //e.Graphics.DrawString("Obyektin kodu:17011102351-22001", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 90));
            //e.Graphics.DrawString("VÖEN: 2903885001-22001", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 110));
            //e.Graphics.DrawString("Satış çeki", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 130));
            //e.Graphics.DrawString("----------------------------------------", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 150));
            //e.Graphics.DrawString("Çek nömrəsi № 3226", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 170));
            PrinterSettings printerSettings = new PrinterSettings();
            List<ReceiptText> receiptTexts = new List<ReceiptText>()
            {
                new ReceiptText("TapSat System",fontSize: 20,style: FontStyle.Bold),
                new ReceiptText("",value:"IphoneShop",fontSize: 20,style: FontStyle.Bold),
                new ReceiptText ("",value:"Yevlax şəh. Nizami 57"),
                new ReceiptText("Obyektin kodu:",value:"17011102351-22001"),
                new ReceiptText("VÖEN: 2903885001-22001"),
                new ReceiptText("Satış çeki",x:100),
                new ReceiptText("-------------------------------------------------------------------------------"),
                new ReceiptText("Çek nömrəsi № ",value:"3226")
               // new ReceiptText("Kass aparatının modeli   " value:printerSettings.PrinterName),
              
                
              
             
            };

            int y=0;
            for (int i = 0; i < receiptTexts.Count; i++)
            {
                ReceiptText receiptText = receiptTexts[i];
                if (i == 0) y = 10;
               // else if (i != 0) receiptText.Y = y;

                if (receiptTexts[i].FontSize>8 && i!=0) y += 30;
                if (receiptTexts[i].FontSize<=8 && i!=0 && receiptTexts[i-1].FontSize<=8) y += 20;
                if (receiptTexts[i].FontSize<=8 && i!=0 && receiptTexts[i-1].FontSize>8) y += 40;
                receiptText.Y = y;

                e.Graphics.DrawString(receiptText.Text+" "+receiptText.Value,
                                      new Font(receiptText.FontType,
                                               receiptText.FontSize,
                                               receiptText.Style),
                                      Brushes.Black, 
                                      new Point(receiptText.X,receiptText.Y));

                

               
               
            }

           
            //for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            //{
            //    if (receiptTexts[4].FontSize <= 8 && i != 0 && receiptTexts[4 - 1].FontSize <= 8) y += 20;
            //    if (receiptTexts[4].FontSize <= 8 && i != 0 && receiptTexts[4 - 1].FontSize > 8) y += 40;

            //    e.Graphics.DrawString(PrinterSettings.InstalledPrinters[i],
            //                         new Font(receiptTexts[4].FontType,
            //                                  receiptTexts[4].FontSize,
            //                                  receiptTexts[4].Style),
            //                         Brushes.Black,
            //                         new Point(receiptTexts[4].X, y));
            //}
        }
    }

    public class ReceiptText
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public string FontType { get; set; }
        public float FontSize { get; set; }
        public FontStyle Style { get; set; } 
        public int X { get; set; } 
        public int Y { get; set; }

        public ReceiptText()
        {

        }

        public ReceiptText(string text,string value="", string fontType="Arial", float fontSize=8, FontStyle style= FontStyle.Regular, int x=10, int y=0)
        {
            Text = text;
            Value = value;
            FontType = fontType;
            FontSize = fontSize;
            Style = style;
            X = x;
            Y = y;
        }

        
    }
}

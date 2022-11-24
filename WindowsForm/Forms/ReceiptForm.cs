using AForge.Imaging.Filters;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.CartDtos;
using Microsoft.Win32;
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
        private IProductService _productService;
        private ICartService _cartService;
        public ReceiptForm(IProductService productService, ICartService cartService)
        {
            _productService = productService;
            _cartService = cartService;
            InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocReceipt;
            printPreviewDialog1.ShowDialog();
            //Aclas Printer
            // printDocReceipt.DefaultPageSettings.PrinterSettings.PrinterName = "Aclas Printer";
            //printDocReceipt.DefaultPageSettings.Landscape = true;


            //printDocReceipt.Print();
        }

        public IDataResult<PrintDocument> PrepareAReceipt(System.Drawing.Printing.PrintPageEventArgs e,
                                                          IDataResult<CartListDtoForReceipt> carts,
                                                          User user
                                                          //BonusCarddto kimimbir sey icinde musteri Id barkod verilen bonus qaliq bonus bonusCard
                                                          )
        {
            string shopName = "",
                   address = "",
                   shopeCode = "17011102351-22001",
                   shopNumber = "",
                   voen = "2903885001-22001",
                   receiptNumber = "".ToString(),
                   checkDrawnDuringTheDay = "",
                   cashier = $"{user.FirstName} {user.LastName}",
                   bonusType = "",
                   bonusCardNumber = "",//bonusCard.BarcodeNumber,
                   bonusEarned = "",//bonusCard.BonusEarned,
                   remainingBonus = "",//bonusCard.RemainingBonus,
                   vaultNumber = "",
                   vaultSerialNumber = "";


            List<ReceiptText> receiptTexts = new List<ReceiptText>()
            {
                new ReceiptText("TapSat System",fontSize: 18,style: FontStyle.Bold,x:40),
                new ReceiptText("",value:shopName,fontSize: 18,style: FontStyle.Bold,x:40),
                new ReceiptText ("",value:address),
                new ReceiptText("Obyektin kodu:",value:shopeCode),
                new ReceiptText("VÖEN:" ,value:""),
                new ReceiptText("Satış çeki",x:100,style:FontStyle.Bold),
                new ReceiptText("-----------------------------------------------------------------------"),
                new ReceiptText("Çek nömrəsi № ",value:receiptNumber),
                new ReceiptText("Mağaza:",value:"524",style:FontStyle.Bold),
                new ReceiptText("Kassir:",value:cashier),
            };

            //products
            int y = 180, x = 160;
            receiptTexts.Add(new ReceiptText("Tarix:", value: DateTime.Today.ToString("dd/MM/yyyy"), y: y, x: x));
            y += 20;
            receiptTexts.Add(new ReceiptText("Saat:", value: DateTime.Now.ToString("HH/mm/ss"), y: y, x: x));

            y = 240;
            x = 0;
            receiptTexts.Add(new ReceiptText("Malın adı", style: FontStyle.Underline, x: 10, y: y));
            receiptTexts.Add(new ReceiptText("Miqdar", style: FontStyle.Underline, x: 160, y: y));
            receiptTexts.Add(new ReceiptText("Qiymət", style: FontStyle.Underline, x: 200, y: y));
            receiptTexts.Add(new ReceiptText("Toplam", style: FontStyle.Underline, x: 240, y: y));
            foreach (var cart in carts.Data.Carts)
            {
                y += 20;
                receiptTexts.Add(new ReceiptText(cart.ProductName, x: 10, y: y));
                receiptTexts.Add(new ReceiptText(cart.Quantity.ToString(), x: 160, y: y));
                receiptTexts.Add(new ReceiptText(cart.SoldPrice.ToString(), x: 200, y: y));
                receiptTexts.Add(new ReceiptText(cart.TotalPrice.ToString(), x: 240, y: y));
            }
            x = 240;
            y += 20;
            receiptTexts.Add(new ReceiptText("-----------------------------------------------------------------------"));
            y += 10;
            receiptTexts.Add(new ReceiptText("YEKUN MƏBLƏĞ", style: FontStyle.Bold, fontSize: 16, y: y));

            receiptTexts.Add(new ReceiptText("*" + carts.Data.Total.ToString(), style: FontStyle.Bold, fontSize: 14, x: 200, y: y));
            y += 20;
            receiptTexts.Add(new ReceiptText("-----------------------------------------------------------------------", y: y));

            y += 20;
            receiptTexts.Add(new ReceiptText("Nağd", y: y));
            receiptTexts.Add(new ReceiptText(carts.Data.Total.ToString(), y: y, x: x));
            y += 20;
            receiptTexts.Add(new ReceiptText("Ödəndi", y: y));
            receiptTexts.Add(new ReceiptText(carts.Data.Total.ToString(), y: y, x: x));
            y += 20;
            receiptTexts.Add(new ReceiptText("Pulun qalığı", y: y));
            receiptTexts.Add(new ReceiptText("0.00", y: y, x: x));

            receiptTexts.Add(new ReceiptText("Müştəri kart nömrəsi:", value: bonusCardNumber));
            //barkod yerlesdir
            receiptTexts.Add(new ReceiptText($"Qazanılan bonus ({bonusType}):", value: "*" + bonusEarned));
            receiptTexts.Add(new ReceiptText($"Bonus qalığı ({bonusType}):", value: "*" + remainingBonus));
            receiptTexts.Add(new ReceiptText("Gün ərzində vurulan çek:", value: checkDrawnDuringTheDay));

            receiptTexts.Add(new ReceiptText("Kassa aparatının modeli:", value: vaultNumber));


            receiptTexts.Add(new ReceiptText("Kassa aparatının zavod nömrəsi:", value: vaultSerialNumber));//tap ve duzelt
            //receiptTexts.Add(new ReceiptText("")); qr kod qoy
            receiptTexts.Add(new ReceiptText("Karabakh is Azerbaijan", fontSize: 12, style: FontStyle.Bold, x: 40));
            //receiptTexts.Add(new ReceiptText(""));


            y = 0;
            x = 0;
            for (int i = 0; i < receiptTexts.Count; i++)
            {
                ReceiptText receiptText = receiptTexts[i];

                if (i == 0) y = 10;
                // else if (i != 0) receiptText.Y = y;

                if (receiptTexts[i].FontSize > 8 && i != 0) y += 30;
                if (receiptTexts[i].FontSize <= 8 && i != 0 && receiptTexts[i - 1].FontSize <= 8) y += 20;
                if (receiptTexts[i].FontSize <= 8 && i != 0 && receiptTexts[i - 1].FontSize > 8) y += 40;
                if (receiptTexts[i].Y != 0) y = receiptText.Y;
                if (receiptTexts[i].Y == 0) receiptText.Y = y;

                if (receiptText.X == 10) receiptText.X = x;
                e.Graphics.DrawString(receiptText.Text + " " + receiptText.Value,
                                      new Font(receiptText.FontType,
                                               receiptText.FontSize,
                                               receiptText.Style),
                                      Brushes.Black,
                                      new Point(receiptText.X, receiptText.Y));





            }


            foreach (var item in receiptTexts)
            {
                item.Y = 0;
            }
            return new SuccessDataResult<PrintDocument>(printDocReceipt);
        }

        private void printDocReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var carts = _cartService.GetAllCartListDtoForReceiptByUserId(1004);
            PrepareAReceipt(e, carts);
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

        public ReceiptText(string text, string value = "", string fontType = "Arial", float fontSize = 8, FontStyle style = FontStyle.Regular, int x = 10, int y = 0)
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

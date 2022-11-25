using Business.Abstract;
using Business.Constants.Dictionaries;
using Core.Utilities.Results;
using Entities.Concrete.ForForms;
using Entities.DTOs.CartDtos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Forms;
using static Business.Constants.Enums.SettingEnums;

namespace WindowsForm.Utilities.Helpers.Receipts
{
    public   class ReceiptOperations
    {
        IFormSettingService _formSettingService;
        public ReceiptOperations(IFormSettingService formSettingService)
        {
            _formSettingService = formSettingService;
        }
        public IDataResult<PrintDocument> PrepareAReceipt(System.Drawing.Printing.PrintPageEventArgs e,
                                                          PrintDocument printDocReceipt,
                                                          IDataResult<CartListDtoForReceipt> carts
        //User user
        //BonusCarddto kimimbir sey icinde musteri Id barkod verilen bonus qaliq bonus bonusCard
                                                          )
        {
            List<FormSetting> settings = _formSettingService.GetAll().Data;
            string shopName = settings.SingleOrDefault(s => s.Name == SettingsDictionary.Settings[SettingParameter.ShopName]).Value == null ? "" : settings.SingleOrDefault(s => s.Name == SettingsDictionary.Settings[SettingParameter.ShopName]).Value,
                   address = settings.SingleOrDefault(s => s.Name == SettingsDictionary.Settings[SettingParameter.ShopAddress]).Value == null ? "" : settings.SingleOrDefault(s => s.Name == SettingsDictionary.Settings[SettingParameter.ShopAddress]).Value,
                   shopeCode = settings.SingleOrDefault(s => s.Name == SettingsDictionary.Settings[SettingParameter.ShopNumber]).Value == null ? "" : settings.SingleOrDefault(s => s.Name == SettingsDictionary.Settings[SettingParameter.ShopNumber]).Value,
                   shopNumber = "",
                   voen = settings.SingleOrDefault(s => s.Name == SettingsDictionary.Settings[SettingParameter.Voen]).Value == null ? "" : settings.SingleOrDefault(s => s.Name ==  SettingsDictionary.Settings[SettingParameter.Voen]).Value,
                   cashier = "",//$"{user.FirstName} {user.LastName}",
                   bonusType = settings.SingleOrDefault(s => s.Name == SettingsDictionary.Settings[SettingParameter.BonusType]).Value == null ? "" : settings.SingleOrDefault(s => s.Name == SettingsDictionary.Settings[SettingParameter.BonusType]).Value,
                   bonusCardNumber = "",//bonusCard.BarcodeNumber,
                   bonusEarned = "",//bonusCard.BonusEarned,
                   remainingBonus = "",//bonusCard.RemainingBonus,
                   vaultModel = settings.SingleOrDefault(s => s.Name == SettingsDictionary.Settings[SettingParameter.VaultModel]).Value == null ? "" : settings.SingleOrDefault(s => s.Name == SettingsDictionary.Settings[SettingParameter.VaultModel]).Value,
                   vaultSerialNumber = settings.SingleOrDefault(s => s.Name == SettingsDictionary.Settings[SettingParameter.VaultSerialNumber]).Value == null ? "" : settings.SingleOrDefault(s => s.Name == SettingsDictionary.Settings[SettingParameter.VaultSerialNumber]).Value;

            FormSetting recipeNumberSetting = settings.SingleOrDefault(s => s.Name == SettingsDictionary. Settings[SettingParameter.ReceiptNumber]);
            FormSetting receiptGivenOnTheDaySetting = settings.SingleOrDefault(s => s.Name == SettingsDictionary.Settings[SettingParameter.ReceiptGivenOnTheDay]);

            int receiptNumber = int.Parse(recipeNumberSetting.Value);
            int receiptGivenOnTheDay = int.Parse(receiptGivenOnTheDaySetting.Value);
            receiptGivenOnTheDay++;
            receiptNumber++;

            List<ReceiptText> receiptTexts = new List<ReceiptText>()
            {
                new ReceiptText("TapSat System",fontSize: 18,style: FontStyle.Bold,x:40),
                new ReceiptText("",value:shopName,fontSize: 18,style: FontStyle.Bold,x:40),
                new ReceiptText ("",value:address),
                new ReceiptText("Obyektin kodu:",value:shopeCode),
                new ReceiptText("VÖEN:" ,value:voen),
                new ReceiptText("Satış çeki",x:100,style:FontStyle.Bold),
                new ReceiptText("-----------------------------------------------------------------------"),
                new ReceiptText("Çek nömrəsi № ",value:receiptNumber.ToString()),
                new ReceiptText("Mağaza:",value:shopNumber,style:FontStyle.Bold),
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
            receiptTexts.Add(new ReceiptText("Gün ərzində vurulan çek:", value: receiptGivenOnTheDay.ToString()));

            receiptTexts.Add(new ReceiptText("Kassa aparatının modeli:", value: vaultModel));


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

            //save  receiptNumber  receiptGivenOnTheDay  

            _formSettingService.Update(new FormSetting() { Id = recipeNumberSetting.Id, Name = recipeNumberSetting.Name, Value = receiptNumber.ToString() });
            _formSettingService.Update(new FormSetting() { Id = receiptGivenOnTheDaySetting.Id, Name = receiptGivenOnTheDaySetting.Name, Value = receiptGivenOnTheDay.ToString() });
            return new SuccessDataResult<PrintDocument>(printDocReceipt);
        }

        public IResult PrintReceipt(PrintPreviewDialog printPreviewDialog,
                                    PrintDocument printDocReceipt)
        {
            printPreviewDialog.Document = printDocReceipt;
           // printPreviewDialog.ShowDialog();
            //Aclas Printer
            // printDocReceipt.DefaultPageSettings.PrinterSettings.PrinterName = "Aclas Printer";
            //printDocReceipt.DefaultPageSettings.Landscape = true;


            //printDocReceipt.Print();
        }
    }
}

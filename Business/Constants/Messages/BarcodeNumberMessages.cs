using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants.Messages
{
    public static class BarcodeNumberMessages
    {
        //CRUD
        public static string BarcodeNumberAdded = "Barkod nömrəsi əlavə edildi";
        public static string BarcodeNumberDeleted = "Barkod nömrəsi silindi";
        public static string BarcodeNumberIsNotDeleted = "Barkod nömrəsi silinə bilmədi";
        public static string BarcodeNumberUpdated = "Barkod nömrəsi yeniləndi";
        public static string BarcodeNumberIsNotUpdating = "Barkod nömrəsi  yenilənə bilmədi";
        public static string BarcodeNumberGetAll = "Barkod nömrələri sıralandi";
        public static string BarcodeNumberFound = "Barkod nömrəsi tapıldı";
        public static string BarcodNumberNotFound = "Belə bir Barkod nömrəsi yoxdur";

        public static string BarcodeNumberGenerated = "Verilən dəyərə uyğun barkod yaradıldı";
        public static string QRCodeNotGenerated = "Verilən dəyərə uyğun barkod yaradıla bilmədi!";
        public static string Scanned = "Scan edildi";
        public static string ScanFailed = "Scan edile bilmədi!";
        public static string QRCodeGenerated = "Verilən dəyərə uyğun QR kod yaradıldı";
        public static string SaveFailed = "Yaddaşa yazıla bilmədi";
        public static string LoadFailed = "Fayl açıla bilmədi";
        public static string RandomBarcodeNumberGenerated = "Təsadüfi barkod nömrəsi yaradıldı";
    }
}

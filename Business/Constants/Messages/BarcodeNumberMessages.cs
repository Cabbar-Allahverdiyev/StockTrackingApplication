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
        public static string BarcodeNumberGeneratedThanMoreOne(int count) => $"Verilən dəyərə uyğun {count} ədəd barkod yaradıldı";
        public static string BarcodeNumberLengthLessThan13NotGenerated = "Verilən dəyər '13' dən kiçik olduğu üçün barkod yaradıla bilmədi";
        public static string QRCodeNotGenerated = "Verilən dəyərə uyğun barkod yaradıla bilmədi!";
        public static string Scanned = "Scan edildi";
        public static string ScanFailed = "Scan edile bilmədi!";
        public static string QRCodeGenerated = "Verilən dəyərə uyğun QR kod yaradıldı";
        public static string SaveFailed = "Yaddaşa yazıla bilmədi";
        public static string Save = "Yaddaşa yazıldı";
        public static string SavedBarcodeThanMoreOne(int count) => $"{count} ədəd barkod Yaddaşa yazıldı";
        public static string LoadFailed = "Fayl açıla bilmədi";
        public static string Load = "Fayl açıldı";
        public static string RandomBarcodeNumberGenerated = "Təsadüfi barkod nömrəsi yaradıldı";
        public static string BarcodeNumberNotSelected = "Barkod nömrəsi seçilə bilmədi";
        public static string BarcodeNumberSelected = "Barkod nömrəsi seçildi";
        public static string BarcodeNumberIsNull = "Barkod nömrəsi boşdur !";
        public static string CountQreaterThanZero = "Say 0-dan böyük olmalıdır";
    }
}

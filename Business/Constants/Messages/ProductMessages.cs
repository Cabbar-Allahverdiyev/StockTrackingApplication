using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Constants.Messages
{
    public static class ProductMessages
    {
        //CRUD
        public static string ProductAdded = "Məhsul əlavə edildi";
        public static string ProductDeleted = "Məhsul silindi";
        public static string ProductIsNotDeleted = "Məhsul silinə bilmədi";
        public static string ProductUpdated = "Məhsul yeniləndi";
        public static string ProductIsNotUpdating = "Məhsul  yenilənə bilmədi";
        public static string ProductGetAll = "Məhsul sıralandi";
        public static string ProductFound = "Məhsul tapıldı";
        public static string ProductNotFound = "Belə bir məhsul yoxdur";
        public static string ProductNotSelected="Məhsul seçilmədi, zəhmət olmasa silmək istədiyiniz məhsulu seçin";
        public static string BarcodeNumberAvailable="Sistemdə bu barkodla eyni barkodlu məhsul var, zəhmət olmasa basqa barkod sınayın";
        public static string ProductNameAvailable= "Sistemdə bu ad ilə eyni eyni adlı məhsul var, zəhmət olmasa  o məhsulun üzərinə yazın və ya basqa ad sınayın";
        public static string SureFillInFields= "Xanaları mütləq doldurun";
    }
}

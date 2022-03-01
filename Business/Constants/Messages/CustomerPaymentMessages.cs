using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants.Messages
{
    public static class CustomerPaymentMessages
    {
        public static string Added = "Müştəri ödənişi əlavə edildi";
        public static string NotAdded = "Müştəri ödənişi əlavə edilə bilmədi";
        public static string Deleted = "Müştəri ödənişi silindi";
        public static string IsNotDeleted = "Müştəri ödənişi silinə bilmədi";
        public static string Updated = "Müştəri ödənişi yeniləndi";
        public static string IsNotUpdating = "Müştəri ödənişi yenilənə bilmədi";
        public static string GetAll = "Müştəri ödənişləri sıralandi";
        public static string Found = "Müştəri ödənişi tapıldı";
        public static string NotFound = "Belə bir Müştəri ödənişi yoxdur";
        public static string ValueMustBeGreaterThanZero = "Ödəniş məbləği '0' dan böyük olamlıdır";
        public static string CancelPayment = "Ödəniş ləğv edildi";
        public static string PaymentCanBeCanceledOnce= "Ödəniş daha öncə ləğv edilib";

        public static string CancelPaymentUnexpectableError(string path)
        {
            return $"{path} gözlənilməyən xəta. Buranın şəklini çəkin və proqramistlə əlaqəyə keçin. Əlaqə vasitələri giriş səhifəsində verilib";
        }
    }
}

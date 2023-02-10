using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants.Messages
{
    public static class SupplierMessages
    {
        //CRUD
        public static string SupplierAdded = "Tədarikçi əlavə edildi";
        public static string SupplierNotAdded = "Tədarikçi əlavə edilə bilmədi";
        public static string SupplierDeleted = "Tədarikçi silindi";
        public static string SupplierIsNotDeleted = "Tədarikçi silinə bilmədi";
        public static string SupplierUpdated = "Tədarikçi məlumatları yeniləndi";
        public static string SupplierIsNotUpdating = "Tədarikçi məlumatları  yenilənə bilmədi";
        public static string SupplierGetAll = "Tədarikçilər sıralandi";
        public static string SupplierFound = "Tədarikçi tapıldı";
        public static string SupplierNotFound = "Belə bir tədarikçi yoxdur";

        public static string PhoneNumberNotValid= "Telefon nömrəsi formata uyğun deyil məs: 0554926939"; //niyese islemir

        public static string AlreadyExistsCompanyNameAndContactName(Supplier supplier) =>$"Bu {supplier.CompanyName}-in {supplier.ContactName} adı mövcuddur ! ";
        public static string CompanyNameNotFound(string companyName) => $"{companyName} tapılmadı";
        public static string GetAllByCompanyName(string companyName) => $"Şirkət adı {companyName} uyğun olan bütün tədarükçülər sıralandı";
        public static string ContactNameNotFound(string contactName) => $"{contactName} tapılmadı";
        public static string GetAllByContactName(string contactName) => $"Adı {contactName} uyğun olan bütün tədarükçülər sıralandı";
    }
}

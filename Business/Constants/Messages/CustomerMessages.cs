using Entities.DTOs.CustomerDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants.Messages
{
    public static class CustomerMessages
    {
        public static string Added = "Müştəri əlavə edildi";
        public static string NotAdded = "Müştəri əlavə edilə bilmədi";
        public static string Deleted = "Müştəri silindi";
        public static string IsNotDeleted = "Müştəri silinə bilmədi";
        public static string Updated = "Müştəri yeniləndi";
        public static string IsNotUpdating = "Müştəri  yenilənə bilmədi";
        public static string GetAll = "Müştərilər sıralandi";
        public static string Found = "Müştəri tapıldı";
        public static string NotFound = "Belə bir Müştəri yoxdur";

        // validation--------------------------->
        public static string PhoneNumberNotValid = "Telefon nömrəsi formata uyğun deyil məs: 0554926939";

        //Businnes rules
        public static string FirstNameAndLastNameAvailable = "Bu adda və soyadda istifadəçi mövcuddur, eyni ad və soyadda iki istifadəçi ola bilməz";
        public static string EmailAvailable = "Bu emailda artıq istifadəçi mövcuddur, zəhmət olmasa başqa email sınayın";
        public static string PhoneNumberAvailable = "Bu nömrə artıq sistemdə mövcuddur";

        //Dto
        public static string CustomerDetailFound = "Müştəri məlumatları tapıldı";
        public static string CustomerDetailNotFound = "Müştəri məlumatları tapıla bilmədi !";
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants.Messages
{
    public static class UserMessages
    {
        //base
        //user add
        public static string UserAdded = "Istifadəci əlavə edildi";

        public static string UserDeleted = "Istifadəci silindi";
        public static string UserIsNotDeleted = "İstifadçi silinə bilmədi";
        public static string UserUpdated = "Isifadəci yeniləndi";
        public static string UserIsNotUpdating = "İstifadəçi məlumatları yenilənə bilmədi";
        public static string UserGetAll = "Isifadəcilər siralandi";
        public static string UserFound = "İstifadəçi tapıldı";
        
        public static string UserRegistered = "Qeydiyyatdan kecdi";
        public static string UserNotFound = "Istifadəci tapilmadi";
        public static string PasswordError = "Şifrə yanlışdır";
        public static string SuccessfulLogin = "Uğurlu giriş";
        public static string UserAlreadyExists = "İstifadəçi mövcuddur";
        public static string AccessTokenCreated = "Token yaradıldı";
        public static string GetClaimsIsNull = "Əməliyyatin iddəaları yoxdur";
        public static string UserDetailsListed="İstifadəçilər əlavə məlumatlara görə sıralandl";
        public static string UserDetailsByNameListed = "İstifadəçilərin əlavə məlumatları adlara görə görə sıralandl";
       
        //BusinesRules------------->
        public static string FirstNameAndLastNameAvailable="Bu adda və soyadda istifadəçi mövcuddur, eyni ad və soyadda iki istifadəçi ola bilməz";
        public static string EmailAvailable="Bu emailda artıq istifadəçi mövcuddur, zəhmət olmasa başqa email sınayın";
        public static string PhoneNumberFormatIsNotSuitable="Telefon nömrəsi formata uyğun deyil (məsələn : 0554926939)";
        public static string PhoneNumberAvailable = "Bu nömrə artıq sistemdə mövcuddur";

        public static string UserDoesNotHaveBossPermission = "Bu istifadəçinin 'Boss' səlahiyyəti yoxdur!";
        public static string UserDoesNotHaveAdminPermission = "Bu istifadəçinin 'Admin' səlahiyyəti yoxdur!";
    }
}

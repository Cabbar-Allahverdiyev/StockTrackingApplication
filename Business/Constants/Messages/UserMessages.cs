using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants.Messages
{
    public static class UserMessages
    {
        //base
        public static string UserAdded = "Istifadəci əlavə edildi";
        public static string UserDeleted = "Istifadəci silindi";
        public static string UserUpdated = "Isifadəci yeniləndi";
        public static string UserGetAll = "Isifadəcilər siralandi";

        public static string UserRegistered = "Qeydiyyatdan kecdi";
        public static string UserNotFound = "Istifadəci tapilmadi";
        public static string PasswordError = "Şifr xətası";
        public static string SuccessfulLogin = "Uğurlu giriş";
        public static string UserAlreadyExists = "İstifadəçi mövcuddur";
        public static string AccessTokenCreated = "Token yaradıldı";

        public static string GetClaimsIsNull = "Əməliyyatin iddəaları yoxdur";
    }
}

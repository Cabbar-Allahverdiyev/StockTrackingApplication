using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants.Messages
{
   public static class CategoryMessages
    {
        //CRUD
        public static string CategoryAdded = "Kateqoriya əlavə edildi";
        public static string CategoryNotAdded = "Kateqoriya əlavə edilmədi";

        public static string CategoryDeleted = "Kateqoriya silindi";
        public static string CategoryIsNotDeleted = "Kateqoriya silinə bilmədi";
        public static string CategoryUpdated = "Kateqoriya yeniləndi";
        public static string CategoryIsNotUpdating = "Kateqoriya  yenilənə bilmədi";
        public static string CategoryGetAll = "Kateqoriya sıralandi";
        public static string CategoryFound = "Kateqoriya tapıldı";
        public static string CategoryNotFound = "Belə bir Kateqoriya yoxdur";
        public static string CategoryNameAvailable= "Bu kateqoriya adı artıq istidfadə edillib !";

       // public static string AlreadyExistsName = "";
        public static string CategoryIdIsEmpty = "Kateqoriya ID-si boş və ya 0 ola bilməz!";

    }
}

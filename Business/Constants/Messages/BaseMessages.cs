using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants.Messages
{
    public static class BaseMessages
    {
        public static string And = " və ";
        public static string Or = " və ya ";
        public static string ErrorMessage = "Xəta";
        public static string InformationMessage = "Məlumat";
        public static string SelectValue = "Zəhmət olmasa bir dəyər seçin";
        public static string SelectedValueIsNull = "Seçilmiş dəyər boşdur. Zəhmət olmasa dəyər seçmək istədiyiniz yeri gözdən keçirin";

        public static string NoChange = "Heç bir dəyişiklik yoxdur";
        public static string Because=" çünki ";

        public static string ExceptionMessage(string className,string methodName,Exception exception)
        {
            string e = BaseMessages.ErrorMessage + " | " +className + "." + methodName + " : " + exception.Message;
            return e;
        }
    }
}

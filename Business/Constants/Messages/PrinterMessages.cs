using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants.Messages
{
    public static class PrinterMessages
    {
        public static string PrinterNotFound = "Printer tapılmadı !";
        public static string PrinterNameIsNotFound(string name) => $"Kompyuterinizə qoşulu olan {name} adda printer mövcud deyil!";
    }
}

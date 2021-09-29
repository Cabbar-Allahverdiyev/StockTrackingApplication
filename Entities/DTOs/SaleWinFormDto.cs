using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class SaleWinFormDto : IDto
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public string MehsulAdi { get; set; }
        public int UserId { get; set; }
        public string Istifadeci { get; set; }
        public decimal SatilanQiymet { get; set; }
        public int Miqdar { get; set; }
        public decimal Cem { get; set; }
        public DateTime Tarix { get; set; }
    }
}

using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CartViewDto:IDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string MehsulAdi { get; set; }
        public int UserId { get; set; }
        public string Istifadeci { get; set; }
        public decimal Qiymet { get; set; }
        public int Miqdar { get; set; }
        public decimal Cem { get; set; }
        public DateTime CartDate { get; set; }
    }
}


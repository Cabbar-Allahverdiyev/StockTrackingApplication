using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.CartDtos
{
    public class CartViewDto : IDto
    {
        public string MehsulAdi { get; set; }
        public string Kateqoriya { get; set; }
        public decimal Qiymet { get; set; }
        public int Miqdar { get; set; }
        public decimal Cem { get; set; }
        public string Aciqlama { get; set; }
        public decimal AlisQiymeti { get; set; }
        public DateTime CartDate { get; set; }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}


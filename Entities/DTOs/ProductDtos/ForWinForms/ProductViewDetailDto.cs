using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.ProductDtos
{
    public class ProductViewDetailDto : IDto
    {
        public int ProductId { get; set; }
        public string BarcodeNomresi { get; set; }
        public string Kateqoriya { get; set; }
        public string Marka { get; set; }
        public string MehsulAdi { get; set; }
        public int StokdakiVahid { get; set; }
        public int SifaristekiVahid { get; set; }
        public int YeniSifarisEdedi { get; set; }
        public decimal AlisQiymeti { get; set; }
        public decimal Qiymet { get; set; }
        public string TedarikciSirket { get; set; }
        public string TedarikEdenInsan { get; set; }
        public string TedarikciNeZamanGelir { get; set; }
        public string Kemiyyet { get; set; }
        public string Aciqlama { get; set; }
        public DateTime SonDeyistirilmeTaixi { get; set; }
        public bool Sonlanmis { get; set; }
    }
}

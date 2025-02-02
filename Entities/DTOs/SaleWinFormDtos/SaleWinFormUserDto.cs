﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.SaleWinFormDtos
{
    public class SaleWinFormUserDto : IDto
    {
        public string BarkodNomresi { get; set; }
        public string MehsulAdi { get; set; }
        public string Kateqoriya { get; set; }
        public string Marka { get; set; }
        public string Istifadeci { get; set; }
        public decimal SatilanQiymet { get; set; }
        public int Miqdar { get; set; }
        public decimal Cem { get; set; }
        public DateTime Tarix { get; set; }
        public bool SatisinVeziyyeti { get; set; }

        public int SaleId { get; set; }
        public int ProductId { get; set; }
    }
}

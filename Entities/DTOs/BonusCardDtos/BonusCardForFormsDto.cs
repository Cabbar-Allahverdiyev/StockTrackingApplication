using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.BonusCardDtos
{
    public class BonusCardForFormsDto:IDto
    {
        public int BonusCardId { get; set; }
        public string BarkodNomresi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public decimal Balans { get; set; }
        public decimal MusteriGuzesti { get; set; }
    }
}

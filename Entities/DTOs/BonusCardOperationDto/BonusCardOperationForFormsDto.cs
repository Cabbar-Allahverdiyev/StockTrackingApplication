using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.BonusCardOperationDto
{
    public class BonusCardOperationForFormsDto:IDto
    {
        public int OperationId { get; set; }
        public string Satici { get; set; }
        public string BonusKartNomresi { get; set; }
        public string Musteri { get; set; }
        public decimal Mebleg { get; set; }
       // public bool IsIncreasedBalance { get; set; }
        public bool Status { get; set; }
    }
}

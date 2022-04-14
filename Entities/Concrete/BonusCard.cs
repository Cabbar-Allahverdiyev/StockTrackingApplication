using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class BonusCard :IEntity
    {
        public int Id { get; set; }
      
        public int CustomerId { get; set; }
        public string BarcodeNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestAdvantage { get; set; }
    }
}

using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class BonusCardOperation:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BonusCardId { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public bool IsIncreasedBalance { get; set; }
        public bool Status { get; set; }
    }
}

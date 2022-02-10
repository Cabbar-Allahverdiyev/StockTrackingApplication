using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Debt : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public decimal SoldPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}

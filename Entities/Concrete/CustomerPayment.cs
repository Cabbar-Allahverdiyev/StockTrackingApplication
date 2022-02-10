using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CustomerPayment:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
    }
}

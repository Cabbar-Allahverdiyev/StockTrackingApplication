using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CustomerBalance:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Debt { get; set; }
        public decimal Balance { get; set; }
        public DateTime DateOfLastLoan { get; set; }
    }
}

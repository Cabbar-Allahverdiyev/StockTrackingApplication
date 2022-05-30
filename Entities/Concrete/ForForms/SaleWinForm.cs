using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.ForForms    
{
    public class SaleWinForm:IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public decimal SoldPrice { get; set; }
        public int Quantity { get; set; }
        public bool SaleStatus { get; set; }
        //public decimal TotalPrice { get; set; }
        public DateTime SellDate { get; set; }
    }
}

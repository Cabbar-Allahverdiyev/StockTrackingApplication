using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.DebtDtos
{
    public class DebtDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal SoldPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}

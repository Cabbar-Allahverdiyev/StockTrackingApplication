using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.CustomerDtos
{
    public class CustomerDto:IDto
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public decimal Debt { get; set; }
        public decimal Balance { get; set; }
        public DateTime CustomerCreatedDate { get; set; }
      
    }
}

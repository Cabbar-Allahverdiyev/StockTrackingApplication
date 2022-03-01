using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.CustomerPaymentDtos
{
    public class CustomerPaymentDto
    {
        public int CustomerPaymentId { get; set; }
        public string FullName { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public bool PaymentStatus { get; set; }
    }
}

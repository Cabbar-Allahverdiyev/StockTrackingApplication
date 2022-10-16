using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.ProductDtos.ForAPI
{
    public class ExcelDto : IDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }
        public string BarcodeNumber { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
    }
}

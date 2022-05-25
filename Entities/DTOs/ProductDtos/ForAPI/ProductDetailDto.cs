using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.ProductDtos.ForAPI
{
    public class ProductDetailDto:IDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public string SupplierName { get; set; }
        public string SupplierContactName { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductName { get; set; }
        public string BarcodeNumber { get; set; }
        public string QuantityPerUnit { get; set; }
        public string Description { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool Discontinued { get; set; }
    }
}

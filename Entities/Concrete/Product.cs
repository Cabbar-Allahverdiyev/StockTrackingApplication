using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public  class Product:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int SupplierId { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductName { get; set; }
        public int BarcodeNumber { get; set; }
        public string QuantityPerUnit { get; set; }
        public string Description { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool Discontinued { get; set; }
    }
}

using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductCompactDetailDto:IDto
    { 
        public int ProductId { get; set; }
        public string BarcodeNomresi { get; set; }
        public string Marka { get; set; }
        public string MehsulAdi { get; set; }
       
    }
}

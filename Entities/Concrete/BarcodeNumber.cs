using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class BarcodeNumber:IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string BarcodeNo { get; set; }
    }
}

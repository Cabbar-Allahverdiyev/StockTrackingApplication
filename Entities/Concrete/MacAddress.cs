using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class MacAddress : IEntity
    {
        public int Id { get; set; }
        public string Address { get; set; }
    }
}

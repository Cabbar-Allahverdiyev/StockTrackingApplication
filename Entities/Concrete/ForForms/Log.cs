using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.ForForms
{
    public class Log :IEntity
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}

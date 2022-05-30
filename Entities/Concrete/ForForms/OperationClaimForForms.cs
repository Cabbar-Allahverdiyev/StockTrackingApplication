using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.ForForms
{
   public  class OperationClaimForForms:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

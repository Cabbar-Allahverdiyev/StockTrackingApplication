using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsForm.Core.Controllers.Abstract
{
    public  interface IValidationTool
    {
         bool IsValid(IEntity entity);
    }
}

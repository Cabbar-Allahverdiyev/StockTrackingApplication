using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface IMacAddressService
    {
        IDataResult<List<MacAddress>> GetAll();
        IResult Add(MacAddress macAddress);
        IResult Update(MacAddress macAddress);
        IResult Delete(MacAddress macAddress);
        IDataResult<MacAddress> GetById(int id);
    }
}

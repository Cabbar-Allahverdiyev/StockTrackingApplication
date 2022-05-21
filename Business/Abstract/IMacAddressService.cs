using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface IMacAddressService
    {
        IDataResult<List<MacAddres>> GetAll();
        IResult Add(MacAddres macAddress);
        IResult Update(MacAddres macAddress);
        IResult Delete(MacAddres macAddress);
        IDataResult<MacAddres> GetById(int id);
    }
}

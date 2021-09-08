using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBarcodNumberService
    {
        IDataResult<List<BarcodeNumber>> GetAll();
        IResult Add(BarcodeNumber barcodeNumber);
        IResult Update(BarcodeNumber barcodeNumber);
        IResult Delete(BarcodeNumber barcodeNumber);
    }
}

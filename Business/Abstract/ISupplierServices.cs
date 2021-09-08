using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISupplierServices
    {
        IDataResult<List<Supplier>> GetAll();
        IResult Add(Supplier supplier);
        IResult Update(Supplier supplier );
        IResult Delete(Supplier supplier );
    }
}

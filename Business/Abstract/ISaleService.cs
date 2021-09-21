using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISaleService
    {
        IDataResult<List<Sale>> GetAll();
        IResult Add(Sale sale );
        IResult Update(Sale sale );
        IResult Delete(Sale sale);
    }
}

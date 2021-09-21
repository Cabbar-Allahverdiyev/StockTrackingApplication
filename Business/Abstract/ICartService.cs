using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICartService
    {
        IDataResult<List<Cart>> GetAll();
        IResult Add(Cart cart);
        IResult Update(Cart cart);
        IResult Delete(Cart cart);
    }
}

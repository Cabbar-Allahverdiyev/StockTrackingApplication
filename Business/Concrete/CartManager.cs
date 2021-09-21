using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        ICartDal _cartDal;
        public CartManager(ICartDal  cartDal)
        {
            _cartDal = cartDal;
        }
        public IResult Add(Cart cart)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Cart cart)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Cart cart)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Cart>> GetAll()
        {
            throw new NotImplementedException();
        }

       
    }
}

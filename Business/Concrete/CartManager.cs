using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.CartDtos;
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

        [ValidationAspect(typeof(CartValidator))]
        [CacheRemoveAspect("ICartService.Get")]
        public IResult Add(Cart cart)
        {
            IResult result = BusinessRules.Run();

            if (result != null)
            {
                return new ErrorDataResult<Cart>(result.Message);
            }
            cart.CartDate = DateTime.Now;
            _cartDal.Add(cart);
            return new SuccessResult(CartMessages.Added);
        }

        [CacheRemoveAspect("ICartService.Get")]
        public IResult Delete(Cart cart)
        {
            _cartDal.Delete(cart);
            return new SuccessResult(CartMessages.Deleted);
        }

        [ValidationAspect(typeof(CartValidator))]
        [CacheRemoveAspect("ICartService.Get")]
        public IResult Update(Cart cart)
        {
            cart.CartDate = DateTime.Now;
            _cartDal.Update(cart);
            return new SuccessResult(CartMessages.Updated);
        }

        [CacheAspect]
        public IDataResult<List<Cart>> GetAll()
        {
            List<Cart> get= _cartDal.GetAll();
            if (get==null)
            {
                return new ErrorDataResult<List<Cart>>(CartMessages.NotFound);
            }
            return new SuccessDataResult<List<Cart>>(get,CartMessages.GetAll);
        }

        // Get By----------------------------->

        public IDataResult<Cart> GetByProductId(int productId)
        {
            Cart get = _cartDal.Get(c => c.ProductId == productId);
            if (get == null)
            {
                return new ErrorDataResult<Cart>(CartMessages.NotFound);
            }
            return new SuccessDataResult<Cart>(get, CartMessages.GetAll);
        }

        //Dtos------------------>
        public IDataResult<CartAddDto> GetCartAddDetailByBarcodeNumber(string barcodeNumber)
        {
            CartAddDto get = _cartDal.GetCartAddDetailByBarcodeNumber(barcodeNumber);
            if (get == null)
            {
                return new ErrorDataResult<CartAddDto>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<CartAddDto>(get, ProductMessages.ProductFound);
        } 
        
        public IDataResult<CartAddDto> GetCartAddDetailByProductId(int productId)
        {
            CartAddDto get = _cartDal.GetCartAddDetailByProductId(productId);
            if (get == null)
            {
                return new ErrorDataResult<CartAddDto>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<CartAddDto>(get, ProductMessages.ProductFound);
        }  
        
        public IDataResult<CartDto> GetCartDtoDetailByProductId(int productId)
        {
            CartDto get = _cartDal.GetCartDtoDetailByProductId(productId);
            if (get == null)
            {
                return new ErrorDataResult<CartDto>(CartMessages.NotFound);
            }
            return new SuccessDataResult<CartDto>(get, CartMessages.Found);
        }

        public IDataResult<List<CartViewDto>> GetAllCartViewDetailsByUserId(int userId)
        {
            List<CartViewDto> get = _cartDal.GetAllCartViewDetails(c=>c.UserId==userId);
            if (get is null)
            {
                return new ErrorDataResult<List<CartViewDto>>(CartMessages.NotFound);
            }
            return new SuccessDataResult<List<CartViewDto>>(get, CartMessages.Found);
        }

        // Metodlar-------------------------------------->
        public IResult ByUserIdAllRemove(int userId)
        {
            List<Cart> carts = _cartDal.GetAll(c=>c.UserId==userId);
            foreach (var cart in carts)
            {
                _cartDal.Delete(cart);
            }
            return new SuccessResult();
        }

        public IDataResult<List<Cart>> GetAllByUserId(int userId)
        {
            List<Cart> carts = _cartDal.GetAll(c => c.UserId == userId);
            if (carts is null)
            {
                return new ErrorDataResult<List<Cart>>(CartMessages.NotFound);
            }
            return new SuccessDataResult<List<Cart>>(carts,CartMessages.Found);
        }

        
    }
}

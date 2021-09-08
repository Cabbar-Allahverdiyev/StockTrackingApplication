using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        //CRUD

        [ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Add(Product product)
        {
            product.Discontinued = true;
            _productDal.Add(product);
            return new SuccessResult(ProductMessages.ProductAdded);
        }

        [CacheRemoveAspect("IProductService.Get")]
        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(ProductMessages.ProductDeleted);
        }

        [ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(ProductMessages.ProductUpdated);
        }

        [CacheAspect]
        public IDataResult<List<Product>> GetAll()
        {
            List<Product> get = _productDal.GetAll();
            return new SuccessDataResult<List<Product>>(get, ProductMessages.ProductGetAll);
        }


        //DTOs------------------------------------>
        public IDataResult<List<ProducViewtDto>> GetProductViewDetails()
        {
            List<ProducViewtDto> get = _productDal.GetProductViewDetails();
            return new SuccessDataResult<List<ProducViewtDto>>(get, ProductMessages.ProductGetAll);
        }

        public IDataResult<ProducViewtDto> GetProductViewDetail(int productId)
        {
            ProducViewtDto get = _productDal.GetProductViewDetail(productId);
            return new SuccessDataResult<ProducViewtDto>(get, ProductMessages.ProductFound);
        }
    }
}

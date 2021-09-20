using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
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
            IResult result = BusinessRules.Run(IsBarcodeNumberExists(product.BarcodeNumber)
                                               , IsProductNameExists(product.ProductName)
                                               );

            if (result != null)
            {
                return new ErrorDataResult<Product>(result.Message);
            }
            product.Discontinued = false;
            product.LastModifiedDate = DateTime.Now;
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
            product.LastModifiedDate = DateTime.Now;
            _productDal.Update(product);
            return new SuccessResult(ProductMessages.ProductUpdated);
        }

        [CacheAspect]
        public IDataResult<List<Product>> GetAll()
        {
            List<Product> get = _productDal.GetAll();
            return new SuccessDataResult<List<Product>>(get, ProductMessages.ProductGetAll);
        }


        //Metodlar--------------->
        [CacheAspect]
        public IDataResult<Product> GetByProductId(int productId)
        {
            Product get = _productDal.Get(p => p.Id == productId);
            if (get == null)
            {
                return new ErrorDataResult<Product>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<Product>(get, ProductMessages.ProductFound);
        }



        //DTOs------------------------------------>
        [CacheAspect]
        public IDataResult<List<ProducViewDetailDto>> GetProductViewDetails()
        {
            List<ProducViewDetailDto> get = _productDal.GetProductViewDetails();
            if (get == null)
            {
                return new ErrorDataResult<List<ProducViewDetailDto>>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<List<ProducViewDetailDto>>(get, ProductMessages.ProductGetAll);
        }

        [CacheAspect]
        public IDataResult<List<ProductViewDashboardDetailDto>> GetProductViewDasgboardDetails()
        {
            List<ProductViewDashboardDetailDto> get = _productDal.GetProductViewDashboardDetails();
            if (get == null)
            {
                return new ErrorDataResult<List<ProductViewDashboardDetailDto>>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<List<ProductViewDashboardDetailDto>>(get, ProductMessages.ProductGetAll);
        }

        [CacheAspect]
        public IDataResult<List<ProductCompactDetailDto>> GetProductCompactDetails()
        {
            List<ProductCompactDetailDto> get = _productDal.GetProductCompactDetails();
            if (get == null)
            {
                return new ErrorDataResult<List<ProductCompactDetailDto>>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<List<ProductCompactDetailDto>>(get, ProductMessages.ProductGetAll);

        }

        [CacheAspect]
        public IDataResult<List<ProductCompactDetailDto>> GetByPrdouctNameCompactDetails(string productName)
        {
            List<ProductCompactDetailDto> get = _productDal.GetProductCompactDetails(p => p.MehsulAdi == productName);
            if (get == null)
            {
                return new ErrorDataResult<List<ProductCompactDetailDto>>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<List<ProductCompactDetailDto>>(get, ProductMessages.ProductGetAll);
        }

        public IDataResult<ProductCompactDetailDto> GetByProductCompacProductIdDetail(int productId)
        {
            ProductCompactDetailDto get = _productDal.GetByProductCompactDetail(p => p.ProductId == productId);

            if (get == null)
            {
                return new ErrorDataResult<ProductCompactDetailDto>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<ProductCompactDetailDto>(get, ProductMessages.ProductFound);
        }

        public IDataResult<ProducViewDetailDto> GetProductViewProductIdDetail(int productId)
        {
            ProducViewDetailDto get = _productDal.GetProductIdProductViewDetail(productId);
            if (get == null)
            {
                return new ErrorDataResult<ProducViewDetailDto>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<ProducViewDetailDto>(get, ProductMessages.ProductFound);
        }


        //Elave Metodlar------------------------->
        private IResult IsBarcodeNumberExists(int barcodeNumber)
        {
            List<Product> getAll = _productDal.GetAll();
            foreach (Product product in getAll)
            {
                if (product.BarcodeNumber == barcodeNumber)
                {
                    return new ErrorResult(ProductMessages.BarcodeNumberAvailable);
                }
            }
            return new SuccessResult();
        }

        private IResult IsProductNameExists(string productName)
        {
            List<Product> getAll = _productDal.GetAll();
            foreach (Product product in getAll)
            {
                if (product.ProductName.Equals(productName))
                {
                    return new ErrorResult(ProductMessages.ProductNameAvailable);
                }
            }
            return new SuccessResult();
        }



    }
}

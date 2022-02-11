using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Business.Abstract;
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
            //product.LastModifiedDate = DateTime.Now;
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

        [CacheAspect]
        public IDataResult<Product> GetByProductBarcodeNumber(string barodeNumber)
        {
            Product get = _productDal.Get(p => p.BarcodeNumber== barodeNumber);
            if (get == null)
            {
                return new ErrorDataResult<Product>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<Product>(get, ProductMessages.ProductFound);
        }



        //DTOs------------------------------------>
        [CacheAspect]
        public IDataResult<List<ProductViewDetailDto>> GetProductViewDetails()
        {
            List<ProductViewDetailDto> get = _productDal.GetProductViewDetails();
            if (get == null)
            {
                return new ErrorDataResult<List<ProductViewDetailDto>>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<List<ProductViewDetailDto>>(get, ProductMessages.ProductGetAll);
        }

        [CacheAspect]
        public IDataResult<List<ProductViewDashboardDetailDto>> GetAllProductViewDasboardDetails()
        {
            List<ProductViewDashboardDetailDto> get = _productDal.GetProductViewDashboardDetails();
            if (get == null)
            {
                return new ErrorDataResult<List<ProductViewDashboardDetailDto>>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<List<ProductViewDashboardDetailDto>>(get, ProductMessages.ProductGetAll);
        }

        public IDataResult<List<ProductViewDashboardDetailDto>> GetProductViewDasboardDetailByBarcodeNumber(string barcodeNumber)
        {
            List<ProductViewDashboardDetailDto> get = _productDal.GetProductViewDashboardDetails(p => p.BarcodeNomresi==barcodeNumber);
            if (get.Count == 0)
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

        public IDataResult<ProductViewDetailDto> GetProductViewProductIdDetail(int productId)
        {
            ProductViewDetailDto get = _productDal.GetProductIdProductViewDetail(productId);
            if (get == null)
            {
                return new ErrorDataResult<ProductViewDetailDto>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<ProductViewDetailDto>(get, ProductMessages.ProductFound);
        }


        //Elave Metodlar------------------------->
        private IResult IsBarcodeNumberExists(string barcodeNumber)
        {
            List<Product> getAll = _productDal.GetAll();
            foreach (Product product in getAll)
            {
                if (product.BarcodeNumber.Equals(barcodeNumber))
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

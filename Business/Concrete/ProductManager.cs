using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation.ProductValidators;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.ProductDtos;
using Entities.DTOs.ProductDtos.ForAPI;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        [ValidationAspect(typeof(CreateProductValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Add(Product product)
        {
            IResult result = BusinessRules.Run(IsBarcodeNumberExists(product.BarcodeNumber)
                                               , IsProductNameExists(product.ProductName)
                                               ,ProductNameToTitleCase(product)
                                               );

            if (result != null)
            {
                return new ErrorResult(result.Message);
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

        [ValidationAspect(typeof(UpdateProductValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Update(Product product)
        {
            IResult rules = BusinessRules.Run(IsBarcodeNumberExistsForUpdate(product),
                                              IsProductNameExistsForUpdate(product),
                                              ProductNameToTitleCase(product)
                                              );
            if (rules != null)
            {
                return new ErrorResult(rules.Message);
            }
            //product.LastModifiedDate = DateTime.Now;
            _productDal.Update(product);
            return new SuccessResult(ProductMessages.ProductUpdated);
        }

        [CacheAspect]
        [SecuredOperation("product.getall")]
        public IDataResult<List<Product>> GetAll()
        {
            List<Product> get = _productDal.GetAll();
            return new SuccessDataResult<List<Product>>(get, ProductMessages.ProductGetAll);
        }


        //Metodlar--------------->
        [CacheAspect]
        public IDataResult<Product> GetById(int productId)
        {
            Product get = _productDal.Get(p => p.Id == productId);
            if (get == null)
            {
                return new ErrorDataResult<Product>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<Product>(get, ProductMessages.ProductFound);
        }

        [CacheAspect]
        public IDataResult<Product> GetByBarcodeNumber(string barodeNumber)
        {
            Product get = _productDal.Get(p => p.BarcodeNumber == barodeNumber);
            if (get == null)
            {
                return new ErrorDataResult<Product>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<Product>(get, ProductMessages.ProductFound);
        }

        [CacheAspect]
        public IDataResult<Product> GetByProductName(string productName)
        {
            Product get = _productDal.Get(p => p.ProductName == productName);
            if (get == null)
            {
                return new ErrorDataResult<Product>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<Product>(get, ProductMessages.ProductFound);
        }


        //DTOs____APi------------------------------------>
        public IDataResult<List<ProductDetailDto>> GetAllProductDetail()
        {
            List<ProductDetailDto> get = _productDal.GetAllProductDetail();
            if (get.Count == 0)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<List<ProductDetailDto>>(get, ProductMessages.ProductGetAll);
        }

        public IDataResult<ProductDetailDto> GetProductDetailById(int id)
        {
            ProductDetailDto get = _productDal.GetProductDetail(p => p.Id == id);
            if (get == null)
            {
                return new ErrorDataResult<ProductDetailDto>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<ProductDetailDto>(get, ProductMessages.ProductFound);
        }
        //DTOs___________WInForms------------------------------------>
        [CacheAspect]
        public IDataResult<List<ProductViewDetailDto>> GetAllProductViewDetail()
        {
            List<ProductViewDetailDto> get = _productDal.GetProductViewDetails();
            if (get == null)
            {
                return new ErrorDataResult<List<ProductViewDetailDto>>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<List<ProductViewDetailDto>>(get, ProductMessages.ProductGetAll);
        }

        [CacheAspect]
        public IDataResult<List<ProductViewDashboardDetailDto>> GetAllProductViewDasboardDetail()
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
            List<ProductViewDashboardDetailDto> get = _productDal.GetProductViewDashboardDetails(p => p.BarcodeNomresi == barcodeNumber);
            if (get.Count == 0)
            {
                return new ErrorDataResult<List<ProductViewDashboardDetailDto>>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<List<ProductViewDashboardDetailDto>>(get, ProductMessages.ProductGetAll);
        }

        [CacheAspect]
        public IDataResult<List<ProductCompactDetailDto>> GetAllProductCompactDetail()
        {
            List<ProductCompactDetailDto> get = _productDal.GetProductCompactDetails();
            if (get == null)
            {
                return new ErrorDataResult<List<ProductCompactDetailDto>>(ProductMessages.ProductNotFound);
            }
            return new SuccessDataResult<List<ProductCompactDetailDto>>(get, ProductMessages.ProductGetAll);

        }

        [CacheAspect]
        public IDataResult<List<ProductCompactDetailDto>> GetAllCompactDetailByPrdouctName(string productName)
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

        public IDataResult<ProductViewDetailDto> GetProductViewDetailByProductId(int productId)
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
            Product product = _productDal.Get(p => p.BarcodeNumber == barcodeNumber);
            if (product != null)
            {
                return new ErrorResult(ProductMessages.BarcodeNumberAvailable);
            }
            return new SuccessResult();
        }

        private IResult IsBarcodeNumberExistsForUpdate(Product product)
        {
            Product getProduct = _productDal.Get(p => p.BarcodeNumber == product.BarcodeNumber);
            if (getProduct != null && getProduct.Id != product.Id)
            {
                return new ErrorResult(ProductMessages.BarcodeNumberAvailable);
            }
            return new SuccessResult();
        }

        private IResult IsProductNameExists(string productName)
        {
            Product product = _productDal.Get(p => p.ProductName.ToLower() == productName.ToLower());
            if (product != null)
            {
                return new ErrorResult(ProductMessages.ProductNameAvailable);
            }
            return new SuccessResult();
        }

        private IResult IsProductNameExistsForUpdate(Product product)
        {
            Product getProduct = _productDal.Get(p => p.ProductName.ToLower() == product.ProductName.ToLower());
            if (getProduct != null && getProduct.Id != product.Id)
            {
                return new ErrorResult(ProductMessages.ProductNameAvailable);
            }
            return new SuccessResult();
        }

        private IResult ProductNameToTitleCase(Product  product)
        {
            product.ProductName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(product.ProductName);
            return new SuccessResult();
        }




        //public IDataResult<List<ProductViewDashboardDetailDto>> GetAllProductViewDashboardDetailByTopSelling()
        //{
        //    //List<ProductViewDashboardDetailDto> get = _productDal.GetAllProductViewDashboardDetailByTopSelling();
        //    //if (get == null)
        //    //{
        //    //    return new ErrorDataResult<List<ProductViewDashboardDetailDto>>(ProductMessages.ProductNotFound);
        //    //}
        //    //return new SuccessDataResult<List<ProductViewDashboardDetailDto>>(get, ProductMessages.ProductGetAll);
        //    throw new Exception();
        //}

        //public IDataResult<List<ProductViewDashboardDetailDto>> GetAllProductViewDashboardDetailByDecreasingProducts()
        //{
        //    //List<ProductViewDashboardDetailDto> get = _productDal.GetAllProductViewDashboardDetailByDecreasingProducts();
        //    //if (get == null)
        //    //{
        //    //    return new ErrorDataResult<List<ProductViewDashboardDetailDto>>(ProductMessages.ProductNotFound);
        //    //}
        //    //return new SuccessDataResult<List<ProductViewDashboardDetailDto>>(get, ProductMessages.ProductGetAll);
        //    throw new Exception();
        //}

        //public IDataResult<List<ProductViewDashboardDetailDto>> GetAllProductViewDashboardDetailByProductsThatNeverSell()
        //{
        //    //List<ProductViewDashboardDetailDto> get = _productDal.GetAllProductViewDashboardDetailByProductsThatNeverSell();
        //    //if (get == null)
        //    //{
        //    //    return new ErrorDataResult<List<ProductViewDashboardDetailDto>>(ProductMessages.ProductNotFound);
        //    //}
        //    //return new SuccessDataResult<List<ProductViewDashboardDetailDto>>(get, ProductMessages.ProductGetAll);
        //    throw new Exception();
        //}

        //public IDataResult<List<ProductViewDashboardDetailDto>> GetAllProductViewDashboardDetailByFinishedProducts()
        //{
        //    //List<ProductViewDashboardDetailDto> get = _productDal.GetAllProductViewDashboardDetailByFinishedProducts();
        //    //if (get == null)
        //    //{
        //    //    return new ErrorDataResult<List<ProductViewDashboardDetailDto>>(ProductMessages.ProductNotFound);
        //    //}
        //    //return new SuccessDataResult<List<ProductViewDashboardDetailDto>>(get, ProductMessages.ProductGetAll);
        //    throw new Exception();
        //}
    }
}

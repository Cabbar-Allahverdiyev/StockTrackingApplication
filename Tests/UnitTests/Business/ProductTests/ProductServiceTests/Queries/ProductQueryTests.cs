using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.ProductDtos.ForAPI;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.UnitTests.TestSetup;
using Xunit;

namespace Tests.UnitTests.Business.ProductTests.ProductServiceTests.Queries
{
    public class ProductQueryTests : IClassFixture<CommonTestFixture>
    {
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;
        private readonly ICategoryService _categoryService;
        private readonly ISupplierService _supplierService;
        public ProductQueryTests(CommonTestFixture testFixture)
        {
            _productService = testFixture.ProductService;
            _brandService = testFixture.BrandService;
            _categoryService = testFixture.CategoryService; 
            _supplierService = testFixture.SupplierService; 
        }

        [Fact]
        public void WhenAlreadyExistsProductNameGiven_SuccessDataResultOfProduct_ShouldBeReturnProductFound()
        {
            Product product = new Product()
            {
                ProductName = "GetProductName",
                BarcodeNumber = "1234567891119",
                BrandId = 2,
                CategoryId = 2,
                SupplierId = 1,
                PurchasePrice = 2,
                UnitPrice = 4,
                UnitsInStock = 4,
                QuantityPerUnit = "1x"
            };
            _productService.Add(product);

            IDataResult<Product> getProduct = _productService.GetByProductName(product.ProductName);

            getProduct.Data.Should().NotBeNull();
            getProduct.Should().BeOfType(typeof(SuccessDataResult<Product>));
            getProduct.Data.ProductName.Should().Be(product.ProductName);
            getProduct.Data.BarcodeNumber.Should().Be(product.BarcodeNumber);
            getProduct.Data.BrandId.Should().Be(product.BrandId);
            getProduct.Data.CategoryId.Should().Be(product.CategoryId);
            getProduct.Data.SupplierId.Should().Be(product.SupplierId);
            getProduct.Data.PurchasePrice.Should().Be(product.PurchasePrice);
            getProduct.Data.UnitPrice.Should().Be(product.UnitPrice);
            getProduct.Data.UnitsInStock.Should().Be(product.UnitsInStock);
            getProduct.Data.QuantityPerUnit.Should().Be(product.QuantityPerUnit);
        }

        [Fact]
        public void WhenNotExistsProductNameGiven_ErrorDataResultOfProduct_ShouldBeReturnProductNotFound()
        {
            IDataResult<Product> getProduct = _productService.GetByProductName("ProductNameIsNotfound");

            getProduct.Data.Should().BeNull();
            getProduct.Should().BeOfType(typeof(ErrorDataResult<Product>));
            
        }

        [Fact]
        public void WhenAlreadyExistsBarcodeNumberGiven_SuccessDataResultOfProduct_ShouldBeReturnProductFound()
        {
            Product product = new Product()
            {
                ProductName = "GetProductBarcode",
                BarcodeNumber = "1234567891245",
                BrandId = 2,
                CategoryId = 2,
                SupplierId = 1,
                PurchasePrice = 2,
                UnitPrice = 4,
                UnitsInStock = 4,
                QuantityPerUnit = "1x"
            };
            _productService.Add(product);

            IDataResult<Product> getProduct = _productService.GetByBarcodeNumber(product.BarcodeNumber);

            getProduct.Data.Should().NotBeNull();
            getProduct.Should().BeOfType(typeof(SuccessDataResult<Product>));
            getProduct.Data.ProductName.Should().Be(product.ProductName);
            getProduct.Data.BarcodeNumber.Should().Be(product.BarcodeNumber);
            getProduct.Data.BrandId.Should().Be(product.BrandId);
            getProduct.Data.CategoryId.Should().Be(product.CategoryId);
            getProduct.Data.SupplierId.Should().Be(product.SupplierId);
            getProduct.Data.PurchasePrice.Should().Be(product.PurchasePrice);
            getProduct.Data.UnitPrice.Should().Be(product.UnitPrice);
            getProduct.Data.UnitsInStock.Should().Be(product.UnitsInStock);
            getProduct.Data.QuantityPerUnit.Should().Be(product.QuantityPerUnit);
        }

        [Fact]
        public void WhenNotExistsBarcoeNumberGiven_ErrorDataResultOfProduct_ShouldBeReturnProductNotFound()
        {
            IDataResult<Product> getProduct = _productService.GetByProductName("1598352528294");

            getProduct.Data.Should().BeNull();
            getProduct.Should().BeOfType(typeof(ErrorDataResult<Product>));

        }

       // [Fact]
        public void WhenAlreadyExistsProductGiven_SuccessDataResultOfProductDetailDto_ShouldBeReturnProductDetailDtoFound()
        {
            //Product product = new Product()
            //{
            //    ProductName = "GetProductDetailDtoBarcode",
            //    BarcodeNumber = "1234567891245",
            //    BrandId = 2,
            //    CategoryId = 2,
            //    SupplierId = 1,
            //    PurchasePrice = 2,
            //    UnitPrice = 4,
            //    UnitsInStock = 4,
            //    QuantityPerUnit = "1x"
            //};
            //_productService.Add(product);
            List<Brand> brands = _brandService.GetAll().Data;
            List<Supplier> suppliers = _supplierService.GetAll().Data;
            List<Category> categories = _categoryService.GetAll().Data;

            IDataResult<List<ProductDetailDto>> getProducts = _productService.GetAllProductDetail();
            foreach (var product in getProducts.Data)
            {
               
                product.BrandName.Should().Be(brands.SingleOrDefault(b=>b.BrandName==product.BrandName).BrandName);
                product.CategoryName.Should().Be(categories.SingleOrDefault(b=>b.CategoryName==product.CategoryName).CategoryName);
                product.SupplierContactName.Should().Be(suppliers.SingleOrDefault(s=>s.ContactName==product.SupplierContactName).ContactName);
                product.SupplierName.Should().Be(suppliers.SingleOrDefault(s=>s.CompanyName==product.SupplierName).CompanyName);
            }

            getProducts.Data.Should().NotBeNull();
            getProducts.Should().BeOfType(typeof(SuccessDataResult<List<ProductDetailDto>>));

           
        }

    }
}

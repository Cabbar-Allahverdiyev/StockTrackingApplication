using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.UnitTests.TestSetup;
using Xunit;

namespace Tests.UnitTests.Business.ProductServiceTests.Add
{
    public class AddProductTest : IClassFixture<CommonTestFixture>
    {
        private readonly IProductService _productService;

        public AddProductTest(CommonTestFixture testFixture)
        {
            _productService = testFixture.ProductService;
        }

        [Fact]
        public void WhenAlreadyExistProductNameGiven_ErrorResult_ShouldBeReturnProductNameAvailable()
        {
            //arrange(Hazirliq)
            Product product = new Product()
            {
                ProductName = "L30",
                BarcodeNumber = "9873214563698",
                BrandId = 2,
                CategoryId = 2,
                SupplierId = 1,
                PurchasePrice = 2,
                UnitPrice = 4,
                UnitsInStock = 4,
                QuantityPerUnit = "1x"
            };

            var re=_productService.Add(product);
            product.BarcodeNumber = "1234567865432";
            //act(Ise Salma)
            IResult result = FluentActions.Invoking(() => _productService.Add(product)).Invoke();

            //  assert(Tesdiqleme)
            result.Should().BeOfType(typeof(ErrorResult));
            result.Success.Should().BeFalse();
            result.Message.Should().Be(ProductMessages.ProductNameAvailable);
        }

        [Fact]
        public void WhenAlreadyExistBarcodeNumberGiven_ErrorResult_ShouldBeReturnBarcodeNumberAvailable()
        {
            //arrange(Hazirliq)
            Product product = new Product()
            {
                ProductName = "L12",
                BarcodeNumber = "1234567891117",
                BrandId = 2,
                CategoryId = 2,
                SupplierId = 1,
                PurchasePrice = 2,
                UnitPrice = 4,
                UnitsInStock = 4,
                QuantityPerUnit = "1x"
            };

            _productService.Add(product);
            product.ProductName = "Abcdef";
            //act(Ise Salma)
            IResult result = FluentActions.Invoking(() => _productService.Add(product)).Invoke();

            //  assert(Tesdiqleme)
            result.Should().BeOfType(typeof(ErrorResult));
            result.Success.Should().BeFalse();

            result.Message.Should().Be(ProductMessages.BarcodeNumberAvailable);
        }

        [Fact]
        public void WhenValidInputsAreGiven_Product_ShouldBeAdded()
        {
            //arrange
            Product product = new Product()
            {
                ProductName = "L14",
                BarcodeNumber = "9876543210111",
                BrandId = 2,
                CategoryId = 2,
                SupplierId = 1,
                PurchasePrice = 2,
                UnitPrice = 4,
                UnitsInStock = 4,
                QuantityPerUnit = "1x"
            };
            //act
            IResult result = FluentActions.Invoking(() => _productService.Add(product)).Invoke();

            //assert
            IDataResult<Product> getProduct = _productService.GetByProductName(product.ProductName);

            result.Should().BeOfType(typeof(SuccessResult));
            result.Success.Should().BeTrue();

            getProduct.Should().NotBeNull();
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
    }
}

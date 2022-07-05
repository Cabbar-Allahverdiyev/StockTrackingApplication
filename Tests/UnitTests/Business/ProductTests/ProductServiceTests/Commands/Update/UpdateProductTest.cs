
using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using Entities.Concrete;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.UnitTests.TestSetup;
using Xunit;

namespace Tests.UnitTests.Business.ProductTests.ProductServiceTests.Update
{
    public class UpdateProductTest : IClassFixture<CommonTestFixture>
    {
        private readonly IProductService _productService;
        public UpdateProductTest(CommonTestFixture testFixture)
        {
            _productService = testFixture.ProductService;
        }

        [Fact]
        public void WhenAlreadyExistProductNameGiven_ErrorResult_ShouldBeReturnProductNameAvailable()
        {
            Product productToBeCreated = new Product()
            {
                ProductName = "L41",
                BarcodeNumber = "1234567891121",
                BrandId = 2,
                CategoryId = 2,
                SupplierId = 1,
                PurchasePrice = 2,
                UnitPrice = 4,
                UnitsInStock = 4,
                QuantityPerUnit = "1x"
            };
            Product productToBeUpdated = new Product()
            {
                ProductName = "L42",
                BarcodeNumber = "1234567891131",
                BrandId = 2,
                CategoryId = 2,
                SupplierId = 1,
                PurchasePrice = 2,
                UnitPrice = 4,
                UnitsInStock = 4,
                QuantityPerUnit = "1x"
            };
            _productService.Add(productToBeCreated);
            _productService.Add(productToBeUpdated);
            productToBeUpdated.ProductName = productToBeCreated.ProductName;
           // product.BarcodeNumber = "1234567891130";
           

            IResult result = FluentActions.Invoking(() => _productService.Update(productToBeUpdated)).Invoke();

            result.Should().BeOfType(typeof(ErrorResult));
            result.Success.Should().BeFalse();
            result.Message.Should().Be(ProductMessages.ProductNameAvailable);
        }

        [Fact]
        public void WhenAlreadyExistBarcodeNumberGiven_ErrorResult_ShouldBeReturnBarcodeNumberAvailable()
        {
            Product productToBeCreated = new Product()
            {
                ProductName = "L43",
                BarcodeNumber = "1234567891120",
                BrandId = 2,
                CategoryId = 2,
                SupplierId = 1,
                PurchasePrice = 2,
                UnitPrice = 4,
                UnitsInStock = 4,
                QuantityPerUnit = "1x"
            };
            Product productToBeUpdated = new Product()
            {
                ProductName = "L44",
                BarcodeNumber = "1234567891130",
                BrandId = 2,
                CategoryId = 2,
                SupplierId = 1,
                PurchasePrice = 2,
                UnitPrice = 4,
                UnitsInStock = 4,
                QuantityPerUnit = "1x"
            };
            _productService.Add(productToBeCreated);
            _productService.Add(productToBeUpdated);
            productToBeUpdated.BarcodeNumber = productToBeCreated.BarcodeNumber;

            IResult result = FluentActions.Invoking(() => _productService.Update(productToBeUpdated)).Invoke();

            result.Should().BeOfType(typeof(ErrorResult));
            result.Success.Should().BeFalse();
            result.Message.Should().Be(ProductMessages.BarcodeNumberAvailable);
        }
    }
}

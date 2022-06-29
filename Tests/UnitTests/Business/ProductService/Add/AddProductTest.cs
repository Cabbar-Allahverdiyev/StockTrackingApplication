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

namespace Tests.UnitTests.Business.ProductService.Add
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
                BarcodeNumber = "1234567891117",
                BrandId = 2,
                CategoryId = 2,
                SupplierId = 1,
                Description = "",
                Discontinued = true,
                LastModifiedDate = DateTime.Now,
                PurchasePrice = 2,
                UnitPrice = 4,
                UnitsInStock = 4,
                QuantityPerUnit = "1x"
            };

            _productService.Add(product);
            product.BarcodeNumber = "1234567891023";
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
                Description = "",
                Discontinued = true,
                LastModifiedDate = DateTime.Now,
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
    }
}

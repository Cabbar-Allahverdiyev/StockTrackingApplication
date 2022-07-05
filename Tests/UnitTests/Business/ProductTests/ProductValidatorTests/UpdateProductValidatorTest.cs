using Business.ValidationRules.FluentValidation.ProductValidators;
using Entities.Concrete;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.UnitTests.TestSetup;
using Xunit;

namespace Tests.UnitTests.Business.ProductTests.ProductValidatorTests
{
    public class UpdateProductValidatorTest : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData("", "L21", 1, 2, 2, 2, 4, "1x")]
        [InlineData("1", "L21", 1, 2, 2, 2, 4, "1x")]
        [InlineData("12", "L21", 1, 2, 2, 2, 4, "1x")]//2
        [InlineData("123456", "L21", 1, 2, 2, 2, 4, "1x")]//6
        [InlineData("1234567890", "L21", 1, 2, 2, 2, 4, "1x")]//10
        [InlineData("123456789012", "L21", 1, 2, 2, 2, 4, "1x")]//12
        [InlineData("12345678901124", "L21", 1, 2, 2, 2, 4, "1x")]//14
        [InlineData("1234567891112", "", 1, 2, 2, 2, 4, "1x")]
        [InlineData("1234567891112", "a", 1, 2, 2, 2, 4, "1x")]
        [InlineData("1234567891112", "qwertyuiopqwertyuiopqwertyuiopqwertyuiop123456", 1, 2, 2, 2, 4, "1x")]//length 46
        [InlineData("1234567891112", "L21", null, 2, 2, 2, 4, "1x")]
        [InlineData("1234567891112", "L21", -1, 2, 2, 2, 4, "1x")]
        [InlineData("1234567891112", "L21", 0, 2, 2, 2, 4, "1x")]
        [InlineData("1234567891112", "L21", 1, null, 2, 2, 4, "1x")]
        [InlineData("1234567891112", "L21", 1, -1, 2, 2, 4, "1x")]
        [InlineData("1234567891112", "L21", 1, 0, 2, 2, 4, "1x")]
        [InlineData("1234567891112", "L21", 1, 2, null, 2, 4, "1x")]
        [InlineData("1234567891112", "L21", 1, 2, -1, 2, 4, "1x")]
        [InlineData("1234567891112", "L21", 1, 2, 0, 2, 4, "1x")]
        [InlineData("1234567891112", "L21", 1, 2, 1, null, 4, "1x")]
        [InlineData("1234567891112", "L21", 1, 2, 1, -1, 4, "1x")]
        [InlineData("1234567891112", "L21", 1, 2, 1, 4, null, "1x")]
        [InlineData("1234567891112", "L21", 1, 2, 1, 4, 0, "1x")]
        [InlineData("1234567891112", "L21", 1, 2, 1, 4, -1, "1x")]
        [InlineData("1234567891112", "L21", 1, 2, 2, 2, 4, "1x")]
        [InlineData("1234567891112", "L21", 1, 2, 2, 2, 4, "1x")]
        [InlineData("1234567891112", "L21", 1, 2, 2, 2, 4, "1x")]
        [InlineData("1234567891112", "L21", 1, 2, 2, 2, 4, null)]
        [InlineData("1234567891112", "L21", 1, 2, 2, 2, 4, "")]
        [InlineData("1234567891112", "L21", 1, 2, 2, 2, 4, "a")]
        [InlineData("1234567891112", "L21", 1, 2, 2, 2, 4, "123456789012345678901")]//length 21
        [InlineData("12345678911124", "L", 0, 0, 0, -1, -1, "123456789012345678901")]//length 21
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(string productName,
                                                                            string barcodeNumber,
                                                                            int brandId,
                                                                            int categoryId,
                                                                            int supplierId,
                                                                            decimal purchasePrice,
                                                                            decimal unitPrice,
                                                                            string quantityPerUnit)
        {
            //arrange
            Product product = new Product()
            {
                ProductName = productName,
                BarcodeNumber = barcodeNumber,
                BrandId = brandId,
                CategoryId = categoryId,
                SupplierId = supplierId,
                Description = "qwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiop1",//501
                PurchasePrice = purchasePrice,
                UnitPrice = unitPrice,
                QuantityPerUnit = quantityPerUnit
            };

            UpdateProductValidator validator = new UpdateProductValidator();
            var errors = validator.Validate(product);

            //act & assert
            errors.Errors.Count.Should().BeGreaterThan(0);
        }
    }
}

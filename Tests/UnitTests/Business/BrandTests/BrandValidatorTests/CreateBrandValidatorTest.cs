using Business.ValidationRules.FluentValidation.BrandValidators;
using Entities.Concrete;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.UnitTests.TestSetup;
using Xunit;

namespace Tests.UnitTests.Business.BrandTests.BrandValidatorTests
{
    public class CreateBrandValidatorTest : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData("")]
        [InlineData("a")]
        [InlineData("12345678901234567890123456789012345678901")]//41
        public void WhenBrandInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(string brandName)
        {
            Brand brand = new Brand();
            brand.BrandName = brandName;

            CreateBrandValidator brandValidator = new CreateBrandValidator();
            var errors = brandValidator.Validate(brand);

            errors.Errors.Count.Should().BeGreaterThan(0);
        }

        [Theory]
        [InlineData("Samsung")]
        [InlineData("aaa")]
        [InlineData("1234567890123456789012345678901234567890")]//40
        public void WhenBrandValidInputsAreGiven_Validator_ShouldBeReturn(string brandName)
        {
            Brand brand = new Brand();
            brand.BrandName = brandName;

            CreateBrandValidator brandValidator = new CreateBrandValidator();
            var errors = brandValidator.Validate(brand);

            errors.Errors.Count.Should().Be(0);
        }


    }
}

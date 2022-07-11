﻿using Business.ValidationRules.FluentValidation.BrandValidators;
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
    public class UpdateBrandValidatorTest : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData(null, "Samsung")]
        [InlineData(0, "Samsung")]
        [InlineData(1,"")]
        [InlineData(1,"a")]
        [InlineData(1,"12345678901234567890123456789012345678901")]//41
        public void WhenBrandInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(int brandId,string brandName)
        {
            Brand brand = new Brand();
            brand.BrandName = brandName;
            brand.Id = brandId;

            UpdateBrandValidator brandValidator = new UpdateBrandValidator();
            var errors = brandValidator.Validate(brand);

            errors.Errors.Count.Should().BeGreaterThan(0);
        }

        [Theory]
        [InlineData(1, "Samsung")]
        [InlineData(1,"Samsung")]
        [InlineData(1,"aaa")]
        [InlineData(2,"1234567890123456789012345678901234567890")]//40
        public void WhenBrandValidInputsAreGiven_Validator_ShouldBeReturn(int brandId,string brandName)
        {
            Brand brand = new Brand();
            brand.BrandName = brandName;
            brand.Id = brandId;

            UpdateBrandValidator brandValidator = new UpdateBrandValidator();
            var errors = brandValidator.Validate(brand);

            errors.Errors.Count.Should().Be(0);
        }


    }
}

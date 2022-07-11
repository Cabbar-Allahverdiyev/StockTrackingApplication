using Business.Abstract;
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

namespace Tests.UnitTests.Business.BrandTest.BrandServiceTests.Queries
{
    public class BrandQueryTest : IClassFixture<CommonTestFixture>
    {
        IBrandService _brandService;
        public BrandQueryTest(CommonTestFixture commonTestFixture)
        {
            _brandService = commonTestFixture.BrandService;
        }
    

        [Fact]
        public void WhenAlreadyExistsBrandNameGiven_SuccessDataResultOfBrand_ShouldBeReturnBrandFound()
        {
            Brand brand = new Brand()
            {
                BrandName= "WhenAlreadyExistsBrandNameGiven_SuccessDataResultOfBrand_ShouldBeReturnBrandFound"
            };
            _brandService.Add(brand);

            IDataResult<Brand> getBrand = _brandService.GetByName(brand.BrandName);

            getBrand.Data.Should().NotBeNull();
            getBrand.Should().BeOfType(typeof(SuccessDataResult<Brand>));
            getBrand.Data.BrandName.Should().Be(brand.BrandName);
            getBrand.Data.Id.Should().Be(brand.Id);
        }

        [Fact]
        public void WhenNotExistsBrandNameGiven_ErrorDataResultOfBrand_ShouldBeReturnBrandNotFound()
        {
            IDataResult<Brand> getBrand = _brandService.GetByName("BrandNameIsNotfound");

            getBrand.Data.Should().BeNull();
            getBrand.Should().BeOfType(typeof(ErrorDataResult<Brand>));

        }
    }
}

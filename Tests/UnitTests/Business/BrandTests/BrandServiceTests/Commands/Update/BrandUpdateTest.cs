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

namespace Tests.UnitTests.Business.BrandTest.BrandServiceTests.Commands.Update
{
    public class BrandUpdateTest : IClassFixture<CommonTestFixture>
    {
        IBrandService _brandService;
        public BrandUpdateTest(CommonTestFixture commonTestFixture)
        {
            _brandService = commonTestFixture.BrandService;
        }

        [Fact]
        public void WhenAlreadyExistaBrandNameGiven_ErrorResult_ShouldBeReturnBrandNameAvailable()
        {
            Brand brand1 = new Brand() { BrandName = "Update_WhenAlreadyExistaBrandNameGiven_ErrorResult_ShouldBeReturnBrandNameAvailable" };
            Brand brand2 = new Brand() { BrandName = "Update_WhenAlreadyExistaBrandNameGiven_ErrorResult_ShouldBeReturnBrandName123465Available" };
            IResult brandCreated1= _brandService.Add(brand1);
            IResult brandCreated2 = _brandService.Add(brand2);
            brand2.BrandName = brand1.BrandName;
            
            IResult result = FluentActions.Invoking(() => _brandService.Update(brand2)).Invoke();
            brand1.Should().NotBeNull();
            brandCreated1.Should().BeOfType(typeof(SuccessResult));
            result.Should().BeOfType(typeof(ErrorResult));

        }

    }
}

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

namespace Tests.UnitTests.Business.BrandTest.BrandServiceTests.Commands.Add
{
    public  class BrandAddTest:IClassFixture<CommonTestFixture>
    {
        IBrandService _brandService;
        public BrandAddTest(CommonTestFixture commonTestFixture)
        {
            _brandService = commonTestFixture.BrandService;
        }

        [Fact]
        public void WhenAlreadyExistBrandNameGiven_ErrorResult_ShouldBeReturnBrandNameAvailable()
        {
            Brand brand = new Brand() { BrandName = "WhenAlreadyExistaBrandNameGiven" };
            IResult brandCreated=_brandService.Add(brand);

            IResult result = FluentActions.Invoking(()=>_brandService.Add(brand)).Invoke();
            brandCreated.Should().BeOfType(typeof(SuccessResult));
            result.Should().BeOfType(typeof(ErrorResult));
            result.Message.Should().Be(BrandMessages.AlreadyExistsName);

        }

        [Fact]
        public void WhenNotAlreadyExistBrandNameGiven_SuccessResult_ShouldBeReturnBrandAdded()
        {
            Brand brand = new Brand() { BrandName = "WhenNotAlreadyExistBrandNameGiven_SuccessResult_ShouldBeReturnBrandAdded" };
            //IResult brandCreated = _brandService.Add(brand);

            IResult result = FluentActions.Invoking(() => _brandService.Add(brand)).Invoke();
           // brandCreated.Should().BeOfType(typeof(SuccessResult));
            result.Should().BeOfType(typeof(SuccessResult));
            result.Message.Should().Be(BrandMessages.BrandAdded);

        }

    }
}

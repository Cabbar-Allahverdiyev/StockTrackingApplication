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

namespace Tests.UnitTests.Business.BrandTest.BrandServiceTests.Commands.Delete
{
    public  class BrandDeleteTest : IClassFixture<CommonTestFixture>
    {
        IBrandService _brandService;
        public BrandDeleteTest(CommonTestFixture commonTestFixture)
        {
            _brandService = commonTestFixture.BrandService;
        }

        [Fact]
        public void WhenAlreadyExistBrandNameGiven_SuccessResult_ShouldBeReturnDeleted()
        {
            Brand brand = new Brand() { BrandName = "WhenAlreadyExistBrandNameGiven_SuccessResult_ShouldBeReturnDeleted" };
            IResult brandCreated = _brandService.Add(brand);
            IDataResult<Brand> dataResult = _brandService.GetByName(brand.BrandName);

            IResult result = FluentActions.Invoking(() => _brandService.Delete(dataResult.Data)).Invoke();
            brandCreated.Should().BeOfType(typeof(SuccessResult));
            dataResult.Should().BeOfType(typeof(SuccessDataResult<Brand>));
            result.Should().BeOfType(typeof(SuccessResult));
            result.Message.Should().Be(BrandMessages.BrandDeleted);

        }

        [Fact]
        public void WhenBrandIdIsNullGiven_ErrorResult_ShouldBeReturnNotDeleted()
        {
            Brand brand = new Brand() {Id=0, BrandName = "WhenBrandIdIsNullGiven_ErrorResult_ShouldBeReturnNotDeleted" };
            
            IResult result = FluentActions.Invoking(() => _brandService.Delete(brand)).Invoke();
           
            result.Should().BeOfType(typeof(ErrorResult));
            result.Message.Should().Be(BrandMessages.BrandIdIsEmpty);

        }
    }
}

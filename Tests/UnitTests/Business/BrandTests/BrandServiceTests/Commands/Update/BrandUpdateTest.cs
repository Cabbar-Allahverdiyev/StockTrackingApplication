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
        public void WhenAlreadyExistBrandNameGiven_ErrorResult_ShouldBeReturnBrandNameAvailable()
        {
            Brand brand1 = new Brand() { BrandName = "Update_WhenAlreadyExistaBrandNameGiven" };
            Brand brand2 = new Brand() { BrandName = "Update_WhenAlreadyExistaBrandNameGiven "};
            IResult brandCreated1= _brandService.Add(brand1);
            IResult brandCreated2 = _brandService.Add(brand2);
            brand2.BrandName = brand1.BrandName;
            
            IResult result = FluentActions.Invoking(() => _brandService.Update(brand2)).Invoke();
            brand1.Should().NotBeNull();
            brandCreated1.Should().BeOfType(typeof(SuccessResult));
            result.Should().BeOfType(typeof(ErrorResult));
            result.Message.Should().Be(BrandMessages.AlreadyExistsName);

        }

        [Fact]
        public void WhenNotAlreadyExistBrandNameGiven_SuccessResult_ShouldBeReturnBrandUpdated()
        {
            Brand brand1 = new Brand() { BrandName = "WhenNotAlreadyExistBrandNameGiven_SuccessResult_ShouldBeReturnBrandUpdated" };
           // Brand brand2 = new Brand() { BrandName = "UpdatedWhenNotAlreadyExistBrandNameGiven_SuccessResult_ShouldBeReturnBrandUpdated" };
            IResult brandCreated1 = _brandService.Add(brand1);
            brand1.BrandName = "UpdatedWhenNotAlreadyExistBrandNameGiven_SuccessResult_ShouldBeReturnBrandUpdated";
            //IResult brandCreated2 = _brandService.Add(brand2);
            //brand2.BrandName = brand1.BrandName;

            IResult result = FluentActions.Invoking(() => _brandService.Update(brand1)).Invoke();
            brand1.Should().NotBeNull();

            brandCreated1.Should().BeOfType(typeof(SuccessResult));

            result.Should().BeOfType(typeof(SuccessResult));
            result.Message.Should().Be(BrandMessages.BrandUpdated);

        }

    }
}

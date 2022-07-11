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

namespace Tests.UnitTests.Business.CategoryTests.Commands.Update
{
    public class CategoryUpdateTest : IClassFixture<CommonTestFixture>
    {
        ICategoryService _categoryService;
        public CategoryUpdateTest(CommonTestFixture commonTestFixture)
        {
            _categoryService = commonTestFixture.CategoryService;
        }

        [Fact]
        public void WhenAlreadyExistCategoryNameGiven_ErrorResult_ShouldBeReturnCategoryNameAvailable()
        {
            Category category1 = new Category() { CategoryName = "Update_WhenAlreadyExistCategoryNameGiven_ErrorResult_ShouldBeReturnCategoryNameAvailable1" };
            Category category2 = new Category() { CategoryName = "Update_WhenAlreadyExistCategoryNameGiven_ErrorResult_ShouldBeReturnCategoryNameAvailable2" };
            IResult categoryCreated1 = _categoryService.Add(category1);
            IResult categoryCreated2 = _categoryService.Add(category2);
            category2.CategoryName = category1.CategoryName;

            IResult result = FluentActions.Invoking(() => _categoryService.Update(category2)).Invoke();
            category1.Should().NotBeNull();
            categoryCreated1.Should().BeOfType(typeof(SuccessResult));
            categoryCreated2.Should().BeOfType(typeof(SuccessResult));

            result.Should().BeOfType(typeof(ErrorResult));
            result.Message.Should().Be(CategoryMessages.CategoryNameAvailable);

        }

        [Fact]
        public void WhenNotAlreadyExistCategoryNameGiven_SuccessResult_ShouldBeReturnCategoryUpdated()
        {
            Category category = new Category() { CategoryName = "WhenNotAlreadyExistCategoryNameGiven_SuccessResult_ShouldBeReturnCategoryUpdated" };
            // Brand brand2 = new Brand() { BrandName = "UpdatedWhenNotAlreadyExistBrandNameGiven_SuccessResult_ShouldBeReturnBrandUpdated" };
            IResult categoryCreated1 = _categoryService.Add(category);
            category.CategoryName = "UpdatedWhenNotAlreadyExistBrandNameGiven_SuccessResult_ShouldBeReturnBrandUpdated";
            //IResult brandCreated2 = _brandService.Add(brand2);
            //brand2.BrandName = brand1.BrandName;

            IResult result = FluentActions.Invoking(() => _categoryService.Update(  category)).Invoke();
                category.Should().NotBeNull();

            categoryCreated1.Should().BeOfType(typeof(SuccessResult));

            result.Should().BeOfType(typeof(SuccessResult));
            result.Message.Should().Be(CategoryMessages.CategoryUpdated);

        }

    }

}

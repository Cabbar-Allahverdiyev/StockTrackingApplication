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

namespace Tests.UnitTests.Business.CategoryTests.Commands.Delete
{
    public class CategoryDeleteTest : IClassFixture<CommonTestFixture>
    {
        ICategoryService _categoryService;
        public CategoryDeleteTest(CommonTestFixture commonTestFixture)
        {
            _categoryService = commonTestFixture.CategoryService;
        }

        [Fact]
        public void WhenAlreadyExistCategoryNameGiven_SuccessResult_ShouldBeReturnDeleted()
        {
            Category category = new Category() { CategoryName = "WhenAlreadyExistCategoryNameGiven" };
            IResult categoryCreated = _categoryService.Add(category);
            IDataResult<Category> dataResult = _categoryService.GetByName(category.CategoryName);

            IResult result = FluentActions.Invoking(() => _categoryService.Delete(dataResult.Data)).Invoke();
            categoryCreated.Should().BeOfType(typeof(SuccessResult));
            dataResult.Should().BeOfType(typeof(SuccessDataResult<Category>));
            result.Should().BeOfType(typeof(SuccessResult));
            result.Message.Should().Be(CategoryMessages.CategoryDeleted);

        }

    }
}

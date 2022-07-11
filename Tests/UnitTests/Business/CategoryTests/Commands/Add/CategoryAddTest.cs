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

namespace Tests.UnitTests.Business.CategoryTests.Commands.Add
{
    public class CategoryAddTest : IClassFixture<CommonTestFixture>
    {
        ICategoryService _categoryService;
        public CategoryAddTest(CommonTestFixture commonTestFixture)
        {
            _categoryService = commonTestFixture.CategoryService;
        }

        [Fact]
        public void WhenAlreadyExistCategoryNameGiven_ErrorResult_ShouldBeReturnCategoryNameAvailable()
        {
            Category category = new Category() { CategoryName = "WhenAlreadyExistCategoryNameGiven" };
            IResult categoryCreated = _categoryService.Add(category);

            IResult result = FluentActions.Invoking(() => _categoryService.Add(category)).Invoke();
            categoryCreated.Should().BeOfType(typeof(SuccessResult));

            result.Should().BeOfType(typeof(ErrorResult));
            result.Message.Should().Be(CategoryMessages.AlreadyExistsName);

        }

        [Fact]
        public void WhenNotAlreadyExistCategoryNameGiven_SuccessResult_ShouldBeReturnCategoryAdded()
        {
            Category category = new Category() { CategoryName = "WhenNotAlreadyExistCategoryNameGiven" };
            IResult result = FluentActions.Invoking(() => _categoryService.Add(category)).Invoke();
            result.Should().BeOfType(typeof(SuccessResult));
            result.Message.Should().Be(CategoryMessages.CategoryAdded);

        }

    }
}

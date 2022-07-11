using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.UnitTests.Business.CategoryTests.Commands.Update
{
    public class CategoryUpdateTest : IClassFixture<CommonTestFixture>
    {
        ICategoryService _categoryService;
        public CategoryUpdateTest(CommonTestFixture commonTestFixture)
        {
            _categoryService = commonTestFixture.CategoryService;
        }

}
    
}

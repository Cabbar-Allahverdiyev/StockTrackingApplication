using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.UnitTests.TestSetup;
using Xunit;

namespace Tests.UnitTests.Business.ProductTests.ProductServiceTests.Delete
{
    public class DeleteProductTest:IClassFixture<CommonTestFixture>
    {
        private readonly IProductService _productService;

        public DeleteProductTest(CommonTestFixture testFixture)
        {
            _productService = testFixture.ProductService;
        }

        

    }
}

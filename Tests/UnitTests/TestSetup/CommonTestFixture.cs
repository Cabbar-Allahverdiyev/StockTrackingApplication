using DataAccess.Abstract;
using DataAccess.Concrete.EfInMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.UnitTests.DataAccess;

namespace Tests.UnitTests.TestSetup
{
    public class CommonTestFixture
    {
        public EfInMemoryContext Context;
        public CommonTestFixture()
        {
            Context.Database.EnsureCreated();

            Context.AddProducts();
            Context.AddBrands();
            Context.AddCategories();
            Context.AddSuppliers();

            Context.SaveChanges();
        }
        
    }
}

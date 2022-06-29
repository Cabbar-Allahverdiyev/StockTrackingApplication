using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EfInMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.UnitTests.DataAccess
{
    public  class TestCategoryManager : EfEntityRepositoryBase<Category, EfInMemoryContext>
                                , ICategoryDal
    {
    }
}

using Business.Abstract;
using Business.Concrete;
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
        
        private IProductDal ProductDal { get; set; }
        private ICategoryDal CategoryDal { get; set; }
        private IBrandDal BrandDal { get; set; }
        private ISupplierDal SupplierDal { get; set; }

        public IProductService ProductService { get; set; }

        public CommonTestFixture()
        {
            ProductDal = new TestProductManager();
            CategoryDal = new TestCategoryManager(); ;
            BrandDal = new TestBrandManager(); ;
            SupplierDal = new TestSupplierManager(); ;

            ProductService = new ProductManager(ProductDal);
            CategoryDal.AddCategories();
            BrandDal.AddBrands();
            SupplierDal.AddSuppliers();
            ProductDal.AddProducts();
            
        }
        
    }
}

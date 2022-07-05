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
        public ICategoryService CategoryService { get; set; }
        public IBrandService     BrandService { get; set; }
        public ISupplierService SupplierService { get; set; }

        private EfInMemoryContext EfInMemoryContext;

        public CommonTestFixture()
        {
            EfInMemoryContext = new EfInMemoryContext();
            ProductDal = new TestProductDal();
            CategoryDal = new TestCategoryDal(); 
            BrandDal = new TestBrandDal(); 
            SupplierDal = new TestSupplierDal(); 

            ProductService = new ProductManager(ProductDal);
            CategoryService = new CategoryManager(CategoryDal);
            BrandService = new BrandManager(BrandDal);
            SupplierService = new SupplierManager(SupplierDal);

            //EfInMemoryContext.AddProducts();
            //EfInMemoryContext.AddBrands();
            //EfInMemoryContext.AddCategories();
            //EfInMemoryContext.AddSuppliers();
            //if (CategoryDal.GetAll().Count() == 0
            //    && BrandDal.GetAll().Count() == 0
            //    && SupplierDal.GetAll().Count() == 0
            //    && ProductDal.GetAll().Count() == 0)
            //{
                CategoryService.AddCategories();
                BrandDal.AddBrands();
                SupplierDal.AddSuppliers();
                ProductDal.AddProducts();
            //}
           

        }
        
    }
}

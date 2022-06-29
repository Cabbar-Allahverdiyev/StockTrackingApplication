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
        //public EfInMemoryContext Context;
        public IProductDal ProductDal { get; set; }
        public ICategoryDal CategoryDal { get; set; }
        public IBrandDal BrandDal { get; set; }
        public ISupplierDal SupplierDal { get; set; }

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
            //Context.Database.EnsureCreated();

            //Context.AddProducts();
            //Context.AddBrands();
            //Context.AddCategories();
            //Context.AddSuppliers();

            //Context.SaveChanges();
        }
        
    }
}

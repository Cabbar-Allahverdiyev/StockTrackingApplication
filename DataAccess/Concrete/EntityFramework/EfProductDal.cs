using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, StockTrackingProjectContext>
                               , IProductDal
    {

        public List<ProducViewDetailDto> GetProductViewDetails(Expression<Func<ProducViewDetailDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.Id
                             join b in context.Brands on p.BrandId equals b.Id
                             join s in context.Suppliers on p.SupplierId equals s.Id
                             select new ProducViewDetailDto
                             {
                                 ProductId = p.Id,
                                 Kateqoriya = c.CategoryName,
                                 Marka = b.BrandName,
                                 TedarikciSirket = s.CompanyName,
                                 TedarikEdenInsan = s.ContactName,
                                 TedarikciNeZamanGelir = s.WhenWillCome,
                                 StokdakiVahid = p.UnitsInStock - p.UnitsOnOrder,
                                 SifaristekiVahid = p.UnitsOnOrder,
                                 YeniSifarisEdedi = p.ReorderLevel,
                                 AlisQiymeti = p.PurchasePrice,
                                 Qiymet = p.UnitPrice,
                                 MehsulAdi = p.ProductName,
                                 BarcodeNomresi = p.BarcodeNumber,
                                 Kemiyyet = p.QuantityPerUnit,
                                 Aciqlama = p.Description,
                                 SonDeyistirilmeTaixi = p.LastModifiedDate,
                                 Sonlanmis = p.Discontinued

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }

        public List<ProductViewDashboardDetailDto> GetProductViewDashboardDetails(Expression<Func<ProductViewDashboardDetailDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.Id
                             join b in context.Brands on p.BrandId equals b.Id
                             join s in context.Suppliers on p.SupplierId equals s.Id
                             select new ProductViewDashboardDetailDto
                             {
                                 ProductId = p.Id,
                                 Kateqoriya = c.CategoryName,
                                 Marka = b.BrandName,
                                 TedarikciSirket = s.CompanyName,
                                 StokdakiVahid = p.UnitsInStock-p.UnitsOnOrder,
                                 Qiymet = p.UnitPrice,
                                 MehsulAdi = p.ProductName,
                                 BarcodeNomresi = p.BarcodeNumber,
                                 Kemiyyet = p.QuantityPerUnit,
                                 Aciqlama = p.Description,
                                 SonDeyistirilmeTaixi = p.LastModifiedDate,
                                 Sonlanmis = p.Discontinued

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }

        public List<ProductCompactDetailDto> GetProductCompactDetails(Expression<Func<ProductCompactDetailDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from p in context.Products
                             join b in context.Brands on p.BrandId equals b.Id
                             select new ProductCompactDetailDto
                             {
                                 ProductId = p.Id,
                                 Marka = b.BrandName,
                                 MehsulAdi = p.ProductName,
                                 BarcodeNomresi = p.BarcodeNumber
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
        public ProductCompactDetailDto GetByProductCompactDetail(Expression<Func<ProductCompactDetailDto, bool>> filter)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from p in context.Products
                             join b in context.Brands on p.BrandId equals b.Id
                             select new ProductCompactDetailDto
                             {
                                 ProductId = p.Id,
                                 Marka = b.BrandName,
                                 MehsulAdi = p.ProductName,
                                 BarcodeNomresi = p.BarcodeNumber
                             };
                return context.Set<ProductCompactDetailDto>().SingleOrDefault(filter);

            }
        }
        public ProducViewDetailDto GetProductIdProductViewDetail(int productId)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from p in context.Products.Where(p=>p.Id==productId)
                             join c in context.Categories on p.CategoryId equals c.Id
                             join b in context.Brands on p.BrandId equals b.Id
                             join s in context.Suppliers on p.SupplierId equals s.Id
                             select new ProducViewDetailDto
                             {
                                 ProductId = p.Id,
                                 Kateqoriya = c.CategoryName,
                                 Marka = b.BrandName,
                                 TedarikciSirket = s.CompanyName,
                                 TedarikEdenInsan = s.ContactName,
                                 StokdakiVahid = p.UnitsInStock - p.UnitsOnOrder,
                                 SifaristekiVahid = p.UnitsOnOrder,
                                 YeniSifarisEdedi = p.ReorderLevel,
                                 AlisQiymeti = p.PurchasePrice,
                                 Qiymet = p.UnitPrice,
                                 MehsulAdi = p.ProductName,
                                 BarcodeNomresi = p.BarcodeNumber,
                                 Kemiyyet = p.QuantityPerUnit,
                                 Aciqlama = p.Description,
                                 SonDeyistirilmeTaixi = p.LastModifiedDate,
                                 Sonlanmis = p.Discontinued

                             };

                return result.SingleOrDefault();
                

            }
        }


    }
}

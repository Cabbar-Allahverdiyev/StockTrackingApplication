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
        public List<ProducViewtDto> GetProductViewDetails(Expression<Func<ProducViewtDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext context=new StockTrackingProjectContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.Id
                             join b in context.Brands on p.BrandId equals b.Id
                             join s in context.Suppliers on p.SupplierId equals s.Id
                             select new ProducViewtDto
                             {
                                 ProductId = p.Id,
                                 Kateqoriya = c.CategoryName,
                                 Marka = b.BrandName,
                                 TedarikciSirket = s.CompanyName,
                                 TedarikEdenInsan = s.ContactName,
                                 TedarikciNeZamanGelir=s.WhenWillCome,
                                 StokdakiVahid = p.UnitsInStock,
                                 SifaristekiVahid = p.UnitsOnOder,
                                 YeniSifarisEdedi = p.ReorderLevel,
                                 AlisQiymeti = p.PurchasePrice,
                                 Qiymet = p.UnitPrice,
                                 MehsulAdi = p.ProductName,
                                 BarcodeNomresi = p.BarcoodeNumber,
                                 Kemiyyet = p.QuantityPerUnit,
                                 Aciqlama = p.Description,
                                 SonDeyistirilmeTaixi = p.LastModifiedDate,
                                 Sonlanmis = p.Discontinued

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }

        public ProducViewtDto GetProductViewDetail(int productId)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.Id
                             join b in context.Brands on p.BrandId equals b.Id
                             join s in context.Suppliers on p.SupplierId equals s.Id
                             select new ProducViewtDto
                             {
                                 ProductId = p.Id,
                                 Kateqoriya = c.CategoryName,
                                 Marka = b.BrandName,
                                 MehsuluGonderenSirket = s.CompanyName,
                                 MehsuluGonderenAdi = s.ContactName,
                                 StokdakiVahid = p.UnitsInStock,
                                 SifaristekiVahid = p.UnitsOnOder,
                                 YeniSifarisEdedi = p.ReorderLevel,
                                 AlisQiymeti = p.PurchasePrice,
                                 Qiymet = p.UnitPrice,
                                 MehsulAdi = p.ProductName,
                                 BarcodeNomresi = p.BarcoodeNumber,
                                 VahidBasinaKemiyyet = p.QuantityPerUnit,
                                 Aciqlama = p.Description,
                                 SonDeyistirilmeTaixi = p.LastModifiedDate,
                                 Sonlanmis = p.Discontinued

                             };

                return result.SingleOrDefault();
            }
        }
    }
}

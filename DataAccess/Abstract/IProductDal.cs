using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs.ProductDtos;
using Entities.DTOs.ProductDtos.ForAPI;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {

        //List<ProductViewDashboardDetailDto> GetAllProductViewDashboardDetailByTopSelling(Expression<Func<ProductViewDashboardDetailDto, bool>> filter = null);
        //List<ProductViewDashboardDetailDto> GetAllProductViewDashboardDetailByDecreasingProducts(Expression<Func<ProductViewDashboardDetailDto, bool>> filter = null);
        //List<ProductViewDashboardDetailDto> GetAllProductViewDashboardDetailByProductsThatNeverSell(Expression<Func<ProductViewDashboardDetailDto, bool>> filter = null);
        //List<ProductViewDashboardDetailDto> GetAllProductViewDashboardDetailByFinishedProducts(Expression<Func<ProductViewDashboardDetailDto, bool>> filter = null);
        //For win forms------------------------------->
        List<ProductViewDetailDto> GetProductViewDetails(Expression<Func<ProductViewDetailDto, bool>> filter = null);
        List<ProductViewDashboardDetailDto> GetProductViewDashboardDetails(Expression<Func<ProductViewDashboardDetailDto, bool>> filter = null);
        List<ProductCompactDetailDto> GetProductCompactDetails(Expression<Func<ProductCompactDetailDto, bool>> filter = null);
        ProductCompactDetailDto GetByProductCompactDetail(Expression<Func<ProductCompactDetailDto, bool>> filter);
        ProductViewDetailDto GetProductIdProductViewDetail(int productId);

        //for api ----------------------->
        ProductDetailDto GetProductDetail(Expression<Func<ProductDetailDto, bool>> filter);
        List<ProductDetailDto> GetAllProductDetail(Expression<Func<ProductDetailDto, bool>> filter=null);
        List<ExcelDto> GetAllProductExcelDetail(Expression<Func<ExcelDto, bool>> filter = null);
    }
}

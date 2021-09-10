using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProducViewDetailDto> GetProductViewDetails(Expression<Func<ProducViewDetailDto, bool>> filter = null);
        List<ProductViewDashboardDetailDto> GetProductViewDashboardDetails(Expression<Func<ProductViewDashboardDetailDto, bool>> filter = null);
        List<ProductCompactDetailDto> GetProductCompactDetails(Expression<Func<ProductCompactDetailDto, bool>> filter = null);
        ProductCompactDetailDto GetByProductCompactDetail(Expression<Func<ProductCompactDetailDto, bool>> filter);
        ProducViewDetailDto GetProductIdProductViewDetail(int productId);
    }
}

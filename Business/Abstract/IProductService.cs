using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
        IDataResult<Product> GetByProductId(int productId);
        IDataResult<Product> GetByProductBarodeNumber(int barcodeNumber);
        IDataResult<List<ProductViewDetailDto>> GetProductViewDetails();
        IDataResult<List<ProductViewDashboardDetailDto>> GetAllProductViewDasgboardDetails();
        IDataResult<List<ProductViewDashboardDetailDto>> GetProductViewDasgboardDetailByBarcodeNumber(int barcodeNumber);
        IDataResult<List<ProductCompactDetailDto>> GetProductCompactDetails();
        IDataResult<List<ProductCompactDetailDto>> GetByPrdouctNameCompactDetails(string productName);
        IDataResult<ProductViewDetailDto> GetProductViewProductIdDetail(int productId);

    }
}

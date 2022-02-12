using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.ProductDtos;
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
        IDataResult<Product> GetByProductBarcodeNumber(string barcodeNumber);
        IDataResult<List<ProductViewDetailDto>> GetProductViewDetails();
        IDataResult<List<ProductViewDashboardDetailDto>> GetAllProductViewDasboardDetails();
        IDataResult<List<ProductViewDashboardDetailDto>> GetProductViewDasboardDetailByBarcodeNumber(string barcodeNumber);
        IDataResult<List<ProductCompactDetailDto>> GetProductCompactDetails();
        IDataResult<List<ProductCompactDetailDto>> GetByPrdouctNameCompactDetails(string productName);
        IDataResult<ProductViewDetailDto> GetProductViewProductIdDetail(int productId);

    }
}

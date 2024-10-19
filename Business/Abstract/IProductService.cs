using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.ProductDtos;
using Entities.DTOs.ProductDtos.ForAPI;
using Entities.DTOs.ProductDtos.ForWinForms;
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
        IDataResult<Product> GetById(int productId);
        IDataResult<Product> GetByBarcodeNumber(string barcodeNumber);
        IDataResult<Product> GetByProductName(string productName);

        IDataResult<List<ProductDetailDto>> GetAllProductDetail();
        IDataResult<ProductDetailDto> GetProductDetailById(int id);
       
        //for forms
        IDataResult<List<ProductViewDetailDto>> GetAllProductViewDetail();
        IDataResult<List<ProductViewDashboardDetailDto>> GetAllProductViewDasboardDetail();
        IDataResult<List<ProductViewUserDashboardDetailDto>> GetAllProductViewUserDasboardDetail();
        IDataResult<List<ProductViewDashboardDetailDto>> GetProductViewDasboardDetailByBarcodeNumber(string barcodeNumber);
        IDataResult<List<ProductCompactDetailDto>> GetAllProductCompactDetail();
        IDataResult<List<ProductCompactDetailDto>> GetAllCompactDetailByPrdouctName(string productName);
        IDataResult<ProductViewDetailDto> GetProductViewDetailByProductId(int productId);

        IDataResult<List<ExcelDto>> GetAllByForExcelDto();
        //IDataResult<List<ProductViewDashboardDetailDto>> GetAllProductViewDashboardDetailByTopSelling();
        //IDataResult<List<ProductViewDashboardDetailDto>> GetAllProductViewDashboardDetailByDecreasingProducts();
        //IDataResult<List<ProductViewDashboardDetailDto>> GetAllProductViewDashboardDetailByProductsThatNeverSell();
        //IDataResult<List<ProductViewDashboardDetailDto>> GetAllProductViewDashboardDetailByFinishedProducts();




    }
}

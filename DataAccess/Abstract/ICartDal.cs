using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICartDal : IEntityRepository<Cart>
    {
        CartDto GetCartDtoDetailByProductId(int productId);
        CartAddDto GetCartAddDetailByBarcodeNumber(int barcodeNumber);
        CartAddDto GetCartAddDetailByProductId(int productId);
        List<CartViewDto> GetAllCartViewDetails(Expression<Func<CartViewDto, bool>> filter = null);
    }
}

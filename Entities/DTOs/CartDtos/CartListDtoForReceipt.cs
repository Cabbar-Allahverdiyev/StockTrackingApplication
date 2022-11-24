using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.CartDtos
{
    public class CartListDtoForReceipt:IDto
    {
        public CartListDtoForReceipt()
        {
            Total = 0;
        }
        public List<CartDtoForReceipt> Carts { get; set; }
        public decimal Total { get; set; }
    }
}

using Business.Concrete;
using Business.Constants.Messages;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.ProductSearch
{
    //public class ProductViewDetailSearch : IWinFormsSearch<ProductViewDetailDto>
    //{
       
    //    public void GetDataWriteGridView(List<ProductViewDetailDto> data ,string seachText, DataGridView dataGridView)
    //    {
    //        dataGridView.DataSource= Search(data,  seachText );
    //    }

    //    public List<ProductViewDetailDto> Search(List<ProductViewDetailDto> data, string searchText )
    //    {
    //        return data.Where(p => $"{p.ProductId} {p.BarcodeNomresi} {p.Kateqoriya} {p.Marka} {p.MehsulAdi} {p.StokdakiVahid} {p.Qiymet} {p.AlısQiymet} {p.TedarikciSirket} {p.Kemiyyet} {p.Aciqlama} {p.SonDeyistirilmeTaixi} {p.Sonlanmis}"
    //       .ToLower().Contains(searchText.ToLower())).ToList();

    //    }

        
    //}
}

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
    public class ProductViewDashboardDetailsSearch : IWinFormsSearch<ProductViewDashboardDetailDto>
    {
        
        public void GetDataWriteGridView(List<ProductViewDashboardDetailDto> data, string seachText, DataGridView dataGridView)
        {
            dataGridView.DataSource = Search(data, seachText);
        }
       
        public List<ProductViewDashboardDetailDto> Search(List<ProductViewDashboardDetailDto> data, string searchText)
        {
            return data.Where(p => $"{p.ProductId} {p.BarcodeNomresi} {p.Kateqoriya} {p.Marka} {p.MehsulAdi} {p.StokdakiVahid} {p.Qiymet} {p.AlisQiymet} {p.TedarikciSirket} {p.Kemiyyet} {p.Aciqlama} {p.SonDeyistirilmeTaixi.Day}.{p.SonDeyistirilmeTaixi.Month} {p.SonDeyistirilmeTaixi.Hour} {p.Sonlanmis}"
            .ToLower().Contains(searchText.ToLower())).ToList();
        }
    }
}

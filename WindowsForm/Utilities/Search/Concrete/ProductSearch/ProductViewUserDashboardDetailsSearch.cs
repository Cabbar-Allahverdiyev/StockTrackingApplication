using Entities.DTOs.ProductDtos;
using Entities.DTOs.ProductDtos.ForWinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.ProductSearch
{
    public class ProductViewUserDashboardDetailsSearch : IWinFormsSearch<ProductViewUserDashboardDetailDto>
    {
        public void GetDataWriteGridView(List<ProductViewUserDashboardDetailDto> data, string seachText, DataGridView dataGridView)
        {
            dataGridView.DataSource = Search(data, seachText);
        }

        public List<ProductViewUserDashboardDetailDto> Search(List<ProductViewUserDashboardDetailDto> data, string searchText)
        {
            return data.Where(p => $"{p.ProductId} {p.BarcodeNomresi} {p.Kateqoriya} {p.Marka} {p.MehsulAdi} {p.StokdakiVahid} {p.Qiymet} {p.TedarikciSirket} {p.Kemiyyet} {p.Aciqlama} {p.SonDeyistirilmeTaixi.Day}.{p.SonDeyistirilmeTaixi.Month} {p.SonDeyistirilmeTaixi.Hour} {p.Sonlanmis}"
            .ToLower().Contains(searchText.ToLower())).ToList();
        }
    }
}

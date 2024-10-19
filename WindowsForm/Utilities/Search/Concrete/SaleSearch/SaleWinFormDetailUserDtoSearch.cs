using Entities.DTOs.SaleWinFormDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.SaleSearch
{
    public class SaleWinFormDetailUserDtoSearch : IWinFormsSearch<SaleWinFormUserDto>
    {
        public void GetDataWriteGridView(List<SaleWinFormUserDto> data, string seachText, DataGridView dataGridView)
        {
            dataGridView.DataSource = Search(data, seachText);
        }

        public List<SaleWinFormUserDto> Search(List<SaleWinFormUserDto> data, string searchText)
        {
            return data.Where(s => $"{s.SaleId} {s.ProductId} {s.MehsulAdi} {s.Kateqoriya} {s.Marka} {s.Istifadeci} {s.SatilanQiymet} {s.Miqdar} {s.Cem} {s.Tarix} {s.SatisinVeziyyeti}"
            .ToLower().Contains(searchText.ToLower())).ToList();
        }
    }
}

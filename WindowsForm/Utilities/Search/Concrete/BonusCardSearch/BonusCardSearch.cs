using Entities.Concrete;
using Entities.DTOs.BonusCardDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.BonusCardSearch
{
    public class BonusCardSearch : IWinFormsSearch<BonusCardForFormsDto>
    {
        public void GetDataWriteGridView(List<BonusCardForFormsDto> data, string seachText, DataGridView dataGridView)
        {
            dataGridView.DataSource = Search(data, seachText);
        }

        public List<BonusCardForFormsDto> Search(List<BonusCardForFormsDto> data, string searchText)
        {
            return data.Where(c => $"{c.BonusCardId} {c.BarkodNomresi} {c.Ad} {c.Soyad} {c.Balans} {c.MusteriGuzesti}"
            .ToLower().Contains(searchText.ToLower())).ToList();
        }
    }

   
}

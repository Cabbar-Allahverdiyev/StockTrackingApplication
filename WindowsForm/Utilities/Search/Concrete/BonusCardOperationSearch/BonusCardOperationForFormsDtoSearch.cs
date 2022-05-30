using Entities.DTOs.BonusCardOperationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.BonusCardOperationSearch
{
    public class BonusCardOperationForFormsDtoSearch : IWinFormsSearch<BonusCardOperationForFormsDto>
    {
        public void GetDataWriteGridView(List<BonusCardOperationForFormsDto> data, string seachText, DataGridView dataGridView)
        {
            dataGridView.DataSource = this.Search(data,seachText);
        }

        public List<BonusCardOperationForFormsDto> Search(List<BonusCardOperationForFormsDto> data, string searchText)
        {
            return data.Where(c => $"{c.OperationId} {c.Satici} {c.BonusKartNomresi} {c.Musteri} {c.Mebleg} {c.Status}"
           .ToLower().Contains(searchText.ToLower())).ToList();
        }
    }
}

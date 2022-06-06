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
            return data.Where(o => $"{o.OperationId} {o.Satici} {o.BonusKartNomresi} {o.Musteri} {o.Mebleg} {o.Tarix} {o.EmeliyyatVeziyyeti} {o.Status}"
           .ToLower().Contains(searchText.ToLower())).ToList();
        }
    }
}

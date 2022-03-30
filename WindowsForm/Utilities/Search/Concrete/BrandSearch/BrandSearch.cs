using Business.Concrete;
using Business.Constants.Messages;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Utilities.Search.Abstract;

namespace WindowsForm.Utilities.Search.Concrete.BrandSearch
{
    public class BrandSearch : IWinFormsSearch<Brand>
    {

        public void GetDataWriteGridView(List<Brand> data, string seachText, DataGridView dataGridView)
        {
            dataGridView.DataSource = Search(data, seachText);
        }

        public List<Brand> Search(List<Brand> data, string searchText)
        {
            return data.Where(b =>$"{b.Id} {b.BrandName}" .ToLower().Contains(searchText.ToLower())).ToList();
        }

    }
}

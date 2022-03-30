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

namespace WindowsForm.Utilities.Search.Concrete.CategorySearch
{
    public class CategorySearch : IWinFormsSearch<Category>
    {
      
        public void GetDataWriteGridView(List<Category> data,string seachText, DataGridView dataGridView)
        {
            dataGridView.DataSource= Search(data, seachText);
        }

        public List<Category> Search(List<Category> data, string searchText)
        {
            return  data.Where(c=>$"{c.Id} {c.CategoryName}".ToLower().Contains(searchText.ToLower())).ToList();
            
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Utilities.Search.Abstract
{
    public interface IWinFormsSearch
    {
       void GetDataWriteGridView(string seachText, DataGridView dataGridView);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Utilities.Search.Abstract
{
    public interface IWinFormsSearch<T> where T : class, new()

    {
        List<T> Search(List<T> data, string searchText);
        void GetDataWriteGridView(List<T> data,string seachText, DataGridView dataGridView);
        //void SearchBySelectedValueOfComboBoxAndWriteToDataGridView(List<T> data,TextBox textBox, DataGridView dataGridView, ComboBox comboBox);
    }
}

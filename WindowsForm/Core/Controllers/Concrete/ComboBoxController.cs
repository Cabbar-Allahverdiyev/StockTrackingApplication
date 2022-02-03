using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Core.Controllers.Concrete
{
    public class ComboBoxController
    {
        public static void ClearAllComboBoxes(Control control)
        {
            if (control is ComboBox)
            {
                control.Text = "";
            }
        }

        public static void ClearAllComboBoxByGroupBox(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                ClearAllComboBoxes(control);

            }
        }

        public static void WriteDaysInComboBox(ComboBox comboBox)
        {
            for (int i = 1; i < 32; i++)
            {
                comboBox.Items.Add(i);
            }

        }
        public static void WriteMonthsInComboBox(ComboBox comboBox)
        {
            for (int i = 1; i < 13; i++)
            {
                comboBox.Items.Add(i);
            }
        }
        public static void WriteYearsInComboBox(ComboBox comboBox)
        {
            List<int> years = new List<int>() { 2021, 2022, 2023, 2024 };
            foreach (int year in years)
            {
                comboBox.Items.Add(year);
            }
        }
    }
}

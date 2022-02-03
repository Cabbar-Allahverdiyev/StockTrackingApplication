using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Core.Controllers.Concrete
{
    public class TextBoxController
    {
        public static void ClearAllTextBoxesByGroupBox(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                ClearAllTextBoxes(control);

            }
        }

        public static void ClearAllTextBoxesAndCmboBoxesByGroupBox(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                ClearAllTextBoxes(control);
                ComboBoxController.ClearAllComboBoxes(control);
            }
        }


        public static void ClearAllTextBoxes(Control control)
        {
            if (control is TextBox)
            {
                control.Text = "";
            }
        }

       
    }
}

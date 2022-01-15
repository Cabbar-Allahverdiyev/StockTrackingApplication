using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsForm.MyControls
{
    public class Int32TextBox : ValidatingTextBox
    {
        protected override void OnTextValidating(object sender, TextValidatingEventArgs e)
        {
           e.Cancel = !int.TryParse(e.NewText.Replace(Environment.NewLine, string.Empty), out int i);
        }
    }
}

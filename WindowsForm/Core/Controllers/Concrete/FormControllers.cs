using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Core.Controllers.Concrete
{
    public class FormControllers
    {
        public void AdjustForm(Form form)
        {
            int borderSize = 2;
            switch (form.WindowState)
            {
                case FormWindowState.Maximized:
                    form.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (form.Top != borderSize)
                        form.Padding = new Padding(borderSize);

                    break;
            }
        }


    }
}

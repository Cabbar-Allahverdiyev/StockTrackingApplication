using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsForm;
using System.Drawing;

namespace WindowsForm.MyControls
{
    public class MenuColorTable: ProfessionalColorTable
    {
        private Color backColor;
        private Color leftColumnColor;
        private Color borderColor;
        private Color menuItemBorderColor;
        private Color menuItemSelectedColor;

        public MenuColorTable(bool isMainMenu,Color primaryColor)
        {
            if (isMainMenu)
            {
                backColor = Color.FromArgb(37,39,60);
                //backColor = Color.FromArgb(98, 102, 244);
                leftColumnColor = Color.FromArgb(32,33,51);
                borderColor = Color.FromArgb(32, 33, 51);
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor;
            }
            else
            {
                backColor = Color.White;
                leftColumnColor = Color.LightGray;
                borderColor = Color.LightGray;
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor;
            }
        }

        //overrides

        public override Color ToolStripDropDownBackground
        {
            get
            {
                return backColor;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return borderColor;
            }
        }
        public override Color MenuItemBorder
        {
            get
            {
                return menuItemBorderColor;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return menuItemSelectedColor;
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return leftColumnColor;
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return leftColumnColor;
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return leftColumnColor;
            }
        }
    }
}

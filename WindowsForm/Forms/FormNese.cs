using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Forms
{
    public partial class FormNese : Form
    {
        public FormNese()
        {
            InitializeComponent();
           
        }

        private void FormNese_Load(object sender, EventArgs e)
        {
            //LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control buttons in this.Controls)
            {
                if (buttons.GetType() == typeof(Button))
                {
                    Button button = (Button)buttons;
                    //bura yeiden bax
                    // previousBtn.BackColor = Color.FromArgb(152, 158, 161);
                    buttons.BackColor = ThemeColor.PrimaryColor;
                    buttons.ForeColor = Color.White;
                    button.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    //buttons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                }
            }
           // label1.ForeColor = ThemeColor.SecondaryColor;
        }

        public void Alert(string message,AlertForm.EnumType type)
        {
            AlertForm form = new AlertForm();
            form.ShowAlert(message,type);
        }
        private void ButtonFormCategoryElaveEt_Click(object sender, EventArgs e)
        {
            this.Alert("Uğurlu əməliyyat",AlertForm.EnumType.Success);
        }

        private void buttonError_Click(object sender, EventArgs e)
        {
            this.Alert("Xəta baş verdi", AlertForm.EnumType.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Alert("Məlumat " +path, AlertForm.EnumType.Info);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Alert("Diqqət təlükə", AlertForm.EnumType.Warning);
        }
    }
}

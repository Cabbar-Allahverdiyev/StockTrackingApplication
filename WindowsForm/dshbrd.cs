using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class dshbrd : Form
    {
       //// private int borderSize = 2;
        //--------------------------->
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;

        public dshbrd()
        {
            
            //==================>
            InitializeComponent();
            //=====================>
            ////this.Padding = new Padding(borderSize);
            ////this.BackColor = Color.FromArgb(98,102,244);
            //----------------------->
            random = new Random();
            buttonCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Dashboard_Load(object sender, EventArgs e)
        {
            //panelLogo.BackColor= Color.FromArgb(51,51,76);
            //panelMenu.BackColor= Color.FromArgb(152, 158, 161);
         

            //panelMenu.BackColor= Color.FromArgb(152, 161,155);
            panelMenu.BackColor = Color.FromArgb(98,102,244);
            panelDesktopPane.BackColor = Color.FromArgb(245,245,254);
            // panelLogo.BackColor= Color.FromArgb(192,196,198);
            //91,96,93
            //113,124,116
            //106,112,108
            //panelLogo.BackColor = Color.FromArgb(76, 80, 77);
            //panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);         
            
            panelLogo.BackColor = Color.FromArgb(98, 102, 244);
           
           // OpenChildForm(new SalesForm(), sender);
            DisableButton();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    buttonCloseChildForm.Visible = true;

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    //bura yeiden bax
                    previousBtn.BackColor = Color.FromArgb(98, 102, 244);
                    //previousBtn.BackColor = Color.FromArgb(152, 161, 155);
                    // previousBtn.BackColor = Color.FromArgb(152, 158, 161);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm!=null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            // ActivateButton(sender);
            //OpenChildForm(new FormProductList(), sender);
            //OpenChildForm(new Forms.SalesForm(), sender);
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSalesList(), sender);
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProductAdd(), sender);
        }

        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNese(), sender);
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCategory(), sender);
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUserListed(), sender);
        }

        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SupplierForm(), sender);
        }

        private void buttonCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activateForm!= null)
            {
                activateForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "Home";
            panelTitleBar.BackColor = Color.FromArgb(0,150,136);
            panelLogo.BackColor = Color.FromArgb(76, 80, 77);
            currentButton = null;
            buttonCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
    }
}

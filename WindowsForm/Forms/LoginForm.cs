using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Controllers.Concrete;

namespace WindowsForm.Forms
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxSifre_Click(object sender, EventArgs e)
        {
            textBoxSifre.BackColor = Color.White;
            panelSifre.BackColor = Color.White;
            textBoxEmail.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            textBoxEmail.BackColor = Color.White;
            panelEmail.BackColor = Color.White;
            textBoxSifre.BackColor = SystemColors.Control;
            panelSifre.BackColor = SystemColors.Control;
        }

        

        private void pictureBoxSifre_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxSifre.UseSystemPasswordChar = false;

        }

        private void pictureBoxSifre_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxSifre.UseSystemPasswordChar = true;
        }
        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.Crimson;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = SystemColors.Control;
        }


        private void LoginForm_Resize(object sender, EventArgs e)
        {
            FormControllers form = new FormControllers();
            form.AdjustForm(this);
        }

        
       
    }
}

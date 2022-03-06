using Business.Concrete;
using Business.Constants.Messages;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Forms.UserForms;

namespace WindowsForm.Forms
{
    public partial class LoginForm : Form
    {
        UserManager _userManager = new UserManager(new EfUserDal());
        public static int UserId;

        public LoginForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(41, 128, 185);


        }

        //Click------------------------------->

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxSifre_Click(object sender, EventArgs e)
        {
            ColorChangePassword();
        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            ColorChangeEmail();
        }

        private void buttonDaxilOl_Click(object sender, EventArgs e)
        {
            try
            {
                string thisComputerMacAddress = "E8039AB2FF83";
                if (thisComputerMacAddress!=GetMacAddress())
                {
                    
                    FormsMessage.ErrorMessage("Zəhmət olmasa istehsalçı ilə əlaqə qurun");
                    FormsMessage.ErrorMessage("Bu kompyuterin icazəsi yoxdur");
                    return;
                }
                if (textBoxEmail.Text == "" || textBoxPassword.Text == "")
                {
                    FormsMessage.WarningMessage(FormsTextMessages.PasswordOrEmailIsBlank);
                    return;
                }
                UserForLoginDto userForLoginDto = new UserForLoginDto();
                userForLoginDto.Email = textBoxEmail.Text;
                userForLoginDto.Password = textBoxPassword.Text;

                IDataResult<User> userToLogin = _userManager.Login(userForLoginDto);
                if (!userToLogin.Success)
                {
                    FormsMessage.ErrorMessage(userToLogin.Message);
                    return;
                }

                User user = _userManager.GetByMail(userForLoginDto.Email).Data;
                UserId = user.Id;
                if (user.Id == 3002 || user.Id == 2004)
                {
                    Dashboard dashboard = new Dashboard();
                    this.Hide();
                    dashboard.Show();
                    return;
                }
                UserDashboard userDashboard = new UserDashboard();
                this.Hide();
                userDashboard.Show();


            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }
        //Text Changed------------------------------->

        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {
            ColorChangePassword();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            ColorChangeEmail();
        }

        //Key down----------------------->

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonDaxilOl.PerformClick();
            }
        }
        //Mouse Down ------------------------------->


        private void pictureBoxSifre_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;

        }
        //Mouse Up ------------------------------->

        private void pictureBoxSifre_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }
        //Mouse Move---------------------------->
        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(255, 0, 21);
        }

        private void panelEmail_MouseMove(object sender, MouseEventArgs e)
        {
            ColorChangeEmail();
        }

        private void textBoxEmail_MouseMove(object sender, MouseEventArgs e)
        {
            ColorChangeEmail();
        }

        private void panelSifre_MouseMove(object sender, MouseEventArgs e)
        {
            ColorChangePassword();
        }

        private void pictureBoxEmail_MouseMove(object sender, MouseEventArgs e)
        {
            ColorChangeEmail();
        }

        private void pictureBoxSifre_MouseMove(object sender, MouseEventArgs e)
        {
            ColorChangePassword();
        }

        private void textBoxSifre_MouseMove(object sender, MouseEventArgs e)
        {
            ColorChangePassword();
        }

        //Mouse Leave ------------------------------->

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = SystemColors.Control;
        }

        private void panelEmail_MouseLeave(object sender, EventArgs e)
        {
            ColorChangeControl();
        }

        private void panelSifre_MouseLeave(object sender, EventArgs e)
        {
            ColorChangeControl();
        }

        private void pictureBoxEmail_MouseLeave(object sender, EventArgs e)
        {
            ColorChangeControl();
        }

        private void pictureBoxSifre_MouseLeave(object sender, EventArgs e)
        {
            ColorChangeControl();
        }

        private void textBoxEmail_MouseLeave(object sender, EventArgs e)
        {
            ColorChangeControl();
        }

        private void textBoxSifre_MouseLeave(object sender, EventArgs e)
        {
            ColorChangeControl();
        }

        //Resize ------------------------------->
        private void LoginForm_Resize(object sender, EventArgs e)
        {
            FormControllers form = new FormControllers();
            form.AdjustForm(this);
        }


        //Elave Metodlar ------------------------------->
        private void ColorChangeControl()
        {
            textBoxEmail.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            textBoxPassword.BackColor = SystemColors.Control;
            panelSifre.BackColor = SystemColors.Control;
        }

        private void ColorChangeEmail()
        {
            textBoxEmail.BackColor = Color.White;
            panelEmail.BackColor = Color.White;
            textBoxPassword.BackColor = SystemColors.Control;
            panelSifre.BackColor = SystemColors.Control;
        }
        private void ColorChangePassword()
        {
            textBoxPassword.BackColor = Color.White;
            panelSifre.BackColor = Color.White;
            textBoxEmail.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonDaxilOl.PerformClick();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Process.Start("https://cabar.allahverrdiyev@gmail.com");
            Clipboard.SetText("cabbar.allahverdiyev@gmail.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText("+994554926939");
        }

        private string GetMacAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            string sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == string.Empty)
                {
                    sMacAddress = adapter.GetPhysicalAddress().ToString();

                }
            }
            return sMacAddress;
        }
    }
}

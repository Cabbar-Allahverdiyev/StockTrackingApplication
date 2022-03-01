using Business.Constants.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Properties;

namespace WindowsForm.Forms
{
    public partial class AlertForm : Form
    {
        public AlertForm()
        {
            InitializeComponent();
        }

        public enum EnumAction
        {
            wait,
            start,
            close
        }

        public enum EnumType
        {
            Success,
            Warning,
            Error,
            Info
        }
        private AlertForm.EnumAction action;
        private int x, y;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = EnumAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case EnumAction.wait:
                    timer1.Interval = 5000;
                    action = EnumAction.close;
                    break;
                case EnumAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;

                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = EnumAction.wait;
                        }
                    }
                    break;
                case EnumAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }

                    break;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = EnumAction.close;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.timer1.Interval=20000;
            MessageBox.Show(labelMessage.Text, BaseMessages.InformationMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        public void ShowAlert(string message, EnumType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;
            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                AlertForm form = (AlertForm)Application.OpenForms[fname];
                if (form == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case EnumType.Success:
                    this.pictureBox1.Image = Resources.succes_ios7_ligt;
                    this.BackColor = Color.SeaGreen;
                    break;
                case EnumType.Error:
                    this.pictureBox1.Image = Resources.errorCloud_light;
                    this.BackColor = Color.DarkRed;
                    break;
                case EnumType.Info:
                    this.pictureBox1.Image = Resources.info_light_normal;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case EnumType.Warning:
                    this.pictureBox1.Image = Resources.warning_light;
                    this.BackColor = Color.DarkOrange;
                    break;

            }

            this.labelMessage.Text = message;
            this.Show();
            this.action = EnumAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }


    }
}

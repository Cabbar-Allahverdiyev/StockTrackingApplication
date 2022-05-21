using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.MyControls;

namespace WindowsForm.Forms.SettingForms
{
    public partial class SettingForm : Form
    {
        IFormSettingService _formSettingService;

        public SettingForm(IFormSettingService formSettingService)
        {
            _formSettingService = formSettingService;
            InitializeComponent();
        }

        //Load--------------------------------->
        private void SettingForm_Load(object sender, EventArgs e)
        {
            SetAllParametersToControl(textBoxIGeneralInterestRate, textBoxWeeklyInterestRate);
        }
        //Click---------------------------------->
        //Text Changed---------------------------------->
        

        //Key Press--------------------------------->
        private void textBoxIGeneralInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyControl.MakeTextBoxDecimalBox(textBoxIGeneralInterestRate, e);
        }

        private void textBoxWeeklyInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyControl.MakeTextBoxDecimalBox(textBoxWeeklyInterestRate, e);
        }
        //Elave----------------------------------->

        private void SetAllParametersToControl(params Control[] controls)
        {
            List<FormSetting> formSettings = _formSettingService.GetAll().Data;
            foreach (Control control in controls)
            {

                control.Text = formSettings.SingleOrDefault(s=>s.Name==control.Name).Value;
            }
        }
    }
}

using Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.MyControls;

namespace WindowsForm.Forms.SettingForms
{
    public partial class ConfigurationSettingForm : Form
    {
        IFormSettingService _formSettingService;
        private MyControl _myControl;

        public ConfigurationSettingForm(IFormSettingService formSettingService)
        {
            _formSettingService = formSettingService;
            _myControl = new MyControl(_formSettingService);
          
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _myControl.UpdateAllSetting(textBoxSignsDecimalPoint);
        }

        private void ConfigurationSettingForm_Load(object sender, EventArgs e)
        {
            textBoxSignsDecimalPoint.MaxLength = 1;
            _myControl.SetAllParametersToControl(textBoxSignsDecimalPoint);

        }
    }
}

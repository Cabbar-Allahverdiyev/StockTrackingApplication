using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results;
using Entities.Concrete.ForForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Constants.Messages.WeekMessgaes;
using WindowsForm.Core.Controllers.Concrete.ValidatorControllers;
using WindowsForm.MyControls;

namespace WindowsForm.Forms.SettingForms
{
    public partial class BonusCardSettingForm : Form
    {
        IFormSettingService _formSettingService;
        private MyControl _myControl;

        public BonusCardSettingForm(IFormSettingService formSettingService)
        {
            _formSettingService = formSettingService;
            _myControl = new MyControl(_formSettingService);
            InitializeComponent();
        }

        //Load--------------------------------->
        private void SettingForm_Load(object sender, EventArgs e)
        {
            _myControl.SetAllParametersToControl(textBoxIGeneralInterestRate,
                                                 textBoxWeeklyInterestRate,
                                                 textBoxBonusCardBarcodeLenth,
                                                 textBoxBonusType);
            WriteDaysOfWeekInComboBox(comboBoxWhichDays);
        }
        //Click---------------------------------->
        private void buttonSave_Click(object sender, EventArgs e)
        {
            _myControl.UpdateAllSetting(textBoxWeeklyInterestRate,
                                        textBoxIGeneralInterestRate,
                                        comboBoxWhichDays,
                                        textBoxBonusCardBarcodeLenth,
                                        textBoxBonusType);
        }
        //Text Changed---------------------------------->


        //Key Press--------------------------------->
        private void textBoxIGeneralInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            _myControl.MakeTextBoxDecimalBox(textBoxIGeneralInterestRate, e);
        }

        private void textBoxWeeklyInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            _myControl.MakeTextBoxDecimalBox(textBoxWeeklyInterestRate, e);
        }
        //Elave----------------------------------->

        

        private void WriteDaysOfWeekInComboBox(params ComboBox[] comboBoxes)
        {
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.DataSource = WeekMessages.AzerbaijaniMessages();
                comboBox.Text = _formSettingService.GetByName(comboBox.Name).Data.Value;
            }
        }

        private void groupBoxBonuCardVisualParams_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxIGeneralInterestRate_TextChanged(object sender, EventArgs e)
        {

        }
        //private void UpdateAllSetting(params Control[] controls)
        //{
        //    List<FormSetting> settings = _formSettingService.GetAll().Data;

        //    foreach (Control control in controls)
        //    {
        //        if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(ComboBox))
        //        {
        //            FormSetting formSetting = settings.SingleOrDefault(s => s.Name == control.Name);
        //            formSetting.Value = control.Text;
        //            if (!FormValidationTool.IsValid(new FormSettingValidator(),formSetting))
        //            {
        //                return;
        //            }
        //            IResult result = _formSettingService.Update(formSetting);
        //            if (!result.Success)
        //            {
        //                FormsMessage.WarningMessage(control.Name + " : " + result.Message);
        //                FormsMessage.WarningMessage(control.Name +" -"+"a görə parametlər yaddaşa yazıla bilmədi");
        //                return;
        //            }
        //        }
        //    }
        //    FormsMessage.SuccessMessage(FormSettingMessaeges.SaveSuccess);
        //}


    }
}

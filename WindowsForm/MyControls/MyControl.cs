using Business.Abstract;
using Business.Concrete;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.ForForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.ControllerNames.SettingForm;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete.ValidatorControllers;
using WindowsForm.Forms;

namespace WindowsForm.MyControls
{
    public class MyControl
    {
        IFormSettingService _formSettingService;

        public MyControl(IFormSettingService formSettingService)
        {
            _formSettingService = formSettingService;
        }

        public static string meselen = "məsələn :";


        public static void MakeAsteriskPasswordCharacterAndMaxLengthFourTen(params TextBox[] textBoxesPaswords)
        {
            foreach (TextBox textBox in textBoxesPaswords)
            {
                textBox.UseSystemPasswordChar = true;
                //textBox.Text = "";
                //textBox.PasswordChar = '*';
                textBox.MaxLength = 14;
            }
        }
        public static void NotAAsteriks(params TextBox[] textBoxesPaswords)
        {
            foreach (TextBox textBox in textBoxesPaswords)
            {
                textBox.UseSystemPasswordChar = false;
                //textBox.Text = "";
                //textBox.PasswordChar = '*';
                //textBox.MaxLength = 14;
            }
        }


        public static void WritePlaceholdersForTextBoxPhoneNumberAndMaxLengthTen(TextBox textBoxPhoneNumber)
        {
            textBoxPhoneNumber.PlaceholderText = $"{meselen} : 0554926939";
            textBoxPhoneNumber.MaxLength = 10;

        }

        public static void WritePlaceholdersForTextBoxEmail(TextBox textBoxEmail)
        {
            textBoxEmail.PlaceholderText = $"{meselen} cabbar@cabbar.com";
            textBoxEmail.MaxLength = 40;
        }

        public static void WritePlaceholdersForTextBoxAddress(TextBox textBoxAddress)
        {
            textBoxAddress.PlaceholderText = $"{meselen} Yevlax";
            textBoxAddress.MaxLength = 40;
        }

        public static void WritePlaceholdersForTextBoxSearch(TextBox textBoxSearch)
        {
            textBoxSearch.PlaceholderText = "Axtar";
            textBoxSearch.MaxLength = 20;
        }

        public static void WritePlaceholdersForTextBoxSearchByProductName(TextBox textBoxBarcodeNumber)
        {
            textBoxBarcodeNumber.PlaceholderText = "Axtar : Məhsul adı";
            textBoxBarcodeNumber.MaxLength = 30;
        }

        public static void WritePlaceholdersForTextBoxBarcodeNo(TextBox textBoxBarcodeNumber)
        {
            textBoxBarcodeNumber.PlaceholderText = "13 rəqəmdən az olmamalıdır !";
            textBoxBarcodeNumber.MaxLength = 30;
        }

        public static void WritePlaceholdersForTextBoxQuantityPerUnit(TextBox textBoxQuantityPerUnit)
        {
            textBoxQuantityPerUnit.PlaceholderText = $"{meselen} 1 qutu , 1x və.s";
            textBoxQuantityPerUnit.MaxLength = 20;
        }

        public  void MakeTextBoxNumberBox(KeyPressEventArgs keyPressEventArgs)
        {
            
            if (!char.IsControl(keyPressEventArgs.KeyChar) && !char.IsDigit(keyPressEventArgs.KeyChar))
            {
                keyPressEventArgs.Handled = true;
            }
        }

        public  void MakeTextBoxDecimalBox(object sender, KeyPressEventArgs keyPressEventArgs)
        {
            char deciamlPoint = (_formSettingService.GetByName(SettingControllerName.DecimalPoint).Data.Value)[0];
           if (!char.IsControl(keyPressEventArgs.KeyChar)
                && !char.IsDigit(keyPressEventArgs.KeyChar) 
                && (keyPressEventArgs.KeyChar != deciamlPoint))
            {
                keyPressEventArgs.Handled = true;
            }

            if ((keyPressEventArgs.KeyChar == deciamlPoint) && ((sender as TextBox).Text.IndexOf(deciamlPoint) > -1))
            {
                keyPressEventArgs.Handled = true;
            }
        }

        public static void WriteProductPropertiesInComboBox(ComboBox comboBox)
        {
            comboBox.Items.Add("Barkod");
            comboBox.Items.Add("Məhsul");

        }

        public static void CloseYesNo(Form formToHide, Form formToShow)
        {
            MessageBoxButtons messageButtons = MessageBoxButtons.YesNo;
            string title = "Çıxış pəncərəsi";
            string message = "Bu profildən çıxmaq istəyirsinizmi ?";
            DialogResult dialogResult = MessageBox.Show(message, title, messageButtons);
            if (dialogResult == DialogResult.Yes)
            {

                //LoginForm loginForm = new LoginForm(new UserOperationClaimForFormsManager(new EfUserOperationClaimForFormsDal())
                //   , new UserManager(new EfUserDal()));

                formToHide.Hide();
                formToShow.Show();
                return;
            }
        }

        public static void MakeDataGridViewCurrentRowRedColor(DataGridView dataGridView, int rowIndex)
        {
            dataGridView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
            //foreach (DataGridViewRow row in dataGridView.Rows)
            //{

            //    if (row.Index == rowIndex)
            //    {
            //        row.DefaultCellStyle.BackColor = Color.Red;
            //    }

            //}
        }

        public static void MakeDataGridViewCurrentRowGreenColor(DataGridView dataGridView, int rowIndex)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index == rowIndex)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }

        public static void MakeDataGridViewCurrentColumnCurrentColor(DataGridView dataGridView, string columnName, Color color)
        {
            dataGridView.Columns[columnName].DefaultCellStyle.BackColor = color;
        }

        public void SetAllParametersToControl(params Control[] controls)
        {

            foreach (Control control in controls)
            {
                IDataResult<FormSetting> getSettings = _formSettingService.GetByName(control.Name);
                if (!getSettings.Success)
                {
                    FormsMessage.WarningMessage(getSettings.Message);
                    return;
                }
                if (control.Name == getSettings.Data.Name)
                {
                    control.Text = getSettings.Data.Value;
                }

            }
        }

        public void UpdateAllSetting(params Control[] controls)
        {
            List<FormSetting> settings = _formSettingService.GetAll().Data;

            foreach (Control control in controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(ComboBox))
                {
                    FormSetting formSetting = settings.SingleOrDefault(s => s.Name == control.Name);
                    formSetting.Value = control.Text;
                    if (!FormValidationTool.IsValid(new FormSettingValidator(), formSetting))
                    {
                        return;
                    }
                    IResult result = _formSettingService.Update(formSetting);
                    if (!result.Success)
                    {
                        FormsMessage.WarningMessage(control.Name + " : " + result.Message);
                        FormsMessage.WarningMessage(control.Name + " -" + "a görə parametlər yaddaşa yazıla bilmədi");
                        return;
                    }
                }
            }
            FormsMessage.SuccessMessage(FormSettingMessaeges.SaveSuccess);
        }
    }
}

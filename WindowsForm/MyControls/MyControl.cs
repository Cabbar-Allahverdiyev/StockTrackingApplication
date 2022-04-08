using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Forms;

namespace WindowsForm.MyControls
{
    public class MyControl
    {
        public void MakeAsteriskPasswordCharacterAndMaxLengthFourTen(params TextBox[] textBoxesPaswords)
        {
            foreach (TextBox textBox in textBoxesPaswords)
            {
                textBox.UseSystemPasswordChar = true;
                //textBox.Text = "";
                //textBox.PasswordChar = '*';
                textBox.MaxLength = 14;
            }
        }
        public void NotAAsteriks(params TextBox[] textBoxesPaswords)
        {
            foreach (TextBox textBox in textBoxesPaswords)
            {
                textBox.UseSystemPasswordChar = false;
                //textBox.Text = "";
                //textBox.PasswordChar = '*';
                //textBox.MaxLength = 14;
            }
        }

        string meselen = "məsələn :";
        public void WritePlaceholdersForTextBoxPhoneNumberAndMaxLengthTen(TextBox textBoxPhoneNumber)
        {
            textBoxPhoneNumber.PlaceholderText = "məsələn : 0554926939";
            textBoxPhoneNumber.MaxLength = 10;

        }

        public void WritePlaceholdersForTextBoxEmail(TextBox textBoxEmail)
        {
            textBoxEmail.PlaceholderText = $"{meselen} cabbar@cabbar.com";
            textBoxEmail.MaxLength = 40;
        }

        public void WritePlaceholdersForTextBoxAddress(TextBox textBoxAddress)
        {
            textBoxAddress.PlaceholderText = $"{meselen} Yevlax";
            textBoxAddress.MaxLength = 40;
        }

        public void WritePlaceholdersForTextBoxSearch(TextBox textBoxSearch)
        {
            textBoxSearch.PlaceholderText = "Axtar";
            textBoxSearch.MaxLength = 20;
        }

        public void WritePlaceholdersForTextBoxSearchByProductName(TextBox textBoxBarcodeNumber)
        {
            textBoxBarcodeNumber.PlaceholderText = "Axtar : Məhsul adı";
            textBoxBarcodeNumber.MaxLength = 30;
        }

        public void WritePlaceholdersForTextBoxBarcodeNo(TextBox textBoxBarcodeNumber)
        {
            textBoxBarcodeNumber.PlaceholderText = "13 rəqəmdən az olmamalıdır !";
            textBoxBarcodeNumber.MaxLength = 30;
        }

        public void WritePlaceholdersForTextBoxQuantityPerUnit(TextBox textBoxQuantityPerUnit)
        {
            textBoxQuantityPerUnit.PlaceholderText = $"{meselen} 1 qutu , 1x və.s";
            textBoxQuantityPerUnit.MaxLength = 20;
        }

        public static void MakeTextBoxNumberBox(KeyPressEventArgs keyPressEventArgs)
        {
            if (!char.IsControl(keyPressEventArgs.KeyChar) && !char.IsDigit(keyPressEventArgs.KeyChar))
            {
                keyPressEventArgs.Handled = true;
            }
        }

        public static void MakeTextBoxDecimalBox(object sender, KeyPressEventArgs keyPressEventArgs)
        {
            if (!char.IsControl(keyPressEventArgs.KeyChar) && !char.IsDigit(keyPressEventArgs.KeyChar) && (keyPressEventArgs.KeyChar != '.'))
            {
                keyPressEventArgs.Handled = true;
            }

            if ((keyPressEventArgs.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                keyPressEventArgs.Handled = true;
            }
        }

        public void WriteProductPropertiesInComboBox(ComboBox comboBox)
        {
            comboBox.Items.Add("Barkod");
            comboBox.Items.Add("Məhsul");

        }

        public void CloseYesNo(Form form)
        {
            MessageBoxButtons messageButtons = MessageBoxButtons.YesNo;
            string title = "Çıxış pəncərəsi";
            string message = "Bu profildən çıxmaq istəyirsinizmi ?";
            DialogResult dialogResult = MessageBox.Show(message, title, messageButtons);
            if (dialogResult == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                form.Hide();
                loginForm.Show();
                return;
            }
        }
       
    }
}

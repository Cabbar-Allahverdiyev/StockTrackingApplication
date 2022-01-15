using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.MyControls
{
    public class MyControl
    {
        public void MakeAsteriskPasswordCharacterAndMaxLengthFourTen(params TextBox[] textBoxesPaswords)
        {
            foreach (TextBox textBox in textBoxesPaswords)
            {
                textBox.Text = "";
                textBox.PasswordChar = '*';
                textBox.MaxLength = 14;
            }
        }

        public void WritePlaceholdersForTextBoxPhoneNumberAndMaxLengthTen(TextBox textBoxPhoneNumber)
        {
            textBoxPhoneNumber.PlaceholderText = "məsələn : 0554926939";
            textBoxPhoneNumber.MaxLength = 10;

        }

        public void WritePlaceholdersForTextBoxEmail(TextBox textBoxEmail)
        {
            textBoxEmail.PlaceholderText = "məsələn : cabbar@cabbar.com";
        }

        public void WritePlaceholdersForTextBoxAddress(TextBox textBoxPhoneNumber)
        {
            textBoxPhoneNumber.PlaceholderText = "məsələn : Yevlax";
        }

        public void WritePlaceholdersForTextBoxSearch(TextBox textBoxPhoneNumber)
        {
            textBoxPhoneNumber.PlaceholderText = "Axtar";
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

            // only allow one decimal point
            if ((keyPressEventArgs.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                keyPressEventArgs.Handled = true;
            }
        }

        private void textBoxTelefonNomresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

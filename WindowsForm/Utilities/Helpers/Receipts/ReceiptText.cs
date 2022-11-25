using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WindowsForm.Utilities.Helpers.Receipts
{
    public class ReceiptText
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public string FontType { get; set; }
        public float FontSize { get; set; }
        public FontStyle Style { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public ReceiptText()
        {

        }

        public ReceiptText(string text,
                           string value = "",
                           string fontType = "Arial",
                           float fontSize = 8,
                           FontStyle style = FontStyle.Regular,
                           int x = 10,
                           int y = 0)
        {
            Text = text;
            Value = value;
            FontType = fontType;
            FontSize = fontSize;
            Style = style;
            X = x;
            Y = y;
        }


    }
}

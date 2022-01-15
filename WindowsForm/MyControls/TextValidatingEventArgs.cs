using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WindowsForm.MyControls
{

    public class TextValidatingEventArgs : CancelEventArgs
    {
        public TextValidatingEventArgs(string newText) => NewText = newText;
        public string NewText { get; }
    }
}

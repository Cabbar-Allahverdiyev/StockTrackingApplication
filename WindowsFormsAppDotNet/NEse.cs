using MessagingToolkit.Barcode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormAppDotNet.Utilities.BarcodeGenerate;

namespace WindowsFormsAppDotNet
{
    public partial class NEse : Form
    {
        BarcodeGenerator barcodeGenerator = new BarcodeGenerator();
        public NEse()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            generator = new BarcodeEncoder();
            generator.IncludeLabel = true;
            generator.CustomLabel = textBox1.Text;
            if (textBox1.Text != "")
            {
                Image result = new Bitmap(generator.Encode(BarcodeFormat.EAN13, textBox1.Text));
                //Image result = new Bitmap(generator.Encode(BarcodeFormat.EAN13, text));
                pictureBox1.Image = result;
                return ;
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = barcodeGenerator.RandomBarcodeNumberGenerator();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        BarcodeEncoder generator;
        BarcodeDecoder scanner;

        OpenFileDialog openDialog;

        
    }
}

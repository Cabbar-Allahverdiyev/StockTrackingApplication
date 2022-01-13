using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using USB_Barcode_Scanner;

namespace WindowsForm.Forms
{
    public partial class USBBarcodeScannerForm : Form
    {
        public USBBarcodeScannerForm()
        {
            InitializeComponent();
            BarcodeScanner barcodeScanner = new BarcodeScanner(textBox1);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
            dataGridViewFormPrdouctList.DataSource = productManager.GetAll().Data;


        }
        ProductManager productManager = new ProductManager(new EfProductDal());

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            textBox1.Text = e.Barcode;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dataGridViewFormPrdouctList.DataSource = null;
            string brcode = textBox1.Text;
            if (brcode.Length >= 13)
            {
                IDataResult<List<ProductViewDashboardDetailDto>> data = productManager.GetProductViewDasboardDetailByBarcodeNumber(brcode);
                if (data.Success == false)
                {
                    textBox3.Text = textBox1.Text;
                    return;
                }
                dataGridViewFormPrdouctList.DataSource = data.Data;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            string brcode = textBox1.Text;
            textBox3.Text = brcode.Length.ToString();

            IDataResult<Product> data = productManager.GetByProductBarcodeNumber(brcode);
            if (data.Success == false)
            {
                textBox3.Text = textBox1.Text;
                return;
            }
            dataGridViewFormPrdouctList.DataSource = data.Data;

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        //public IDataResult<ProductViewDashboardDetailDto> GetProductByBarcodeNumber(string barcodeNumber)
        //{

        //} 
    }
}
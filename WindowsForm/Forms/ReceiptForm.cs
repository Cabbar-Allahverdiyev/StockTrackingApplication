using AForge.Imaging.Filters;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.ForForms;
using Entities.DTOs.CartDtos;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Forms
{
    public partial class ReceiptForm : Form
    {
        private IProductService _productService;
        private ICartService _cartService;
        private IFormSettingService _formSettingService;
        public ReceiptForm(IProductService productService, ICartService cartService, IFormSettingService formSettingService)
        {
            _productService = productService;
            _cartService = cartService;
            _formSettingService = formSettingService;
            InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocReceipt;
            printPreviewDialog1.ShowDialog();
            //Aclas Printer
            // printDocReceipt.DefaultPageSettings.PrinterSettings.PrinterName = "Aclas Printer";
            //printDocReceipt.DefaultPageSettings.Landscape = true;


            //printDocReceipt.Print();
        }

        

        private void printDocReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var carts = _cartService.GetAllCartListDtoForReceiptByUserId(1004);
             //PrepareAReceipt(e, carts);
        }

       

       

    }



   
}

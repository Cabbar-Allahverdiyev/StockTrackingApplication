using Business.Abstract;
using Business.Concrete;
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

namespace WindowsForm
{
    public partial class SalesForm : Form
    {
        ProductManager _productManager = new ProductManager(new EfProductDal());

        FormUserAdd _formUserAdd = new FormUserAdd(new UserManager(new EfUserDal()));
        FormUserListed _formUserListed = new FormUserListed(new UserManager(new EfUserDal()));
        FormProductAdd _formProductAdd = new FormProductAdd();
        FormBrand _formBrand = new FormBrand();
        FormCategory _formCategory = new FormCategory();
        SupplierForm _supplierForm = new SupplierForm();
        FormProductList _formProductList = new FormProductList();


        public SalesForm()
        {
            InitializeComponent();


        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            dataGridViewProductList.DataSource = _productManager.GetAllProductViewDasgboardDetails().Data;
        }

        private void ButtonSalesFormIstifadeciElaveEtmek_Click(object sender, EventArgs e)
        {

            _formUserAdd.ShowDialog();


        }

        private void ButtonSalesFormIstifadecileriSirala_Click(object sender, EventArgs e)
        {
            _formUserListed.ShowDialog();

        }

        private void ButtonSalesFormMehsulElaveEtmek_Click(object sender, EventArgs e)
        {
            _formProductAdd.ShowDialog();
        }

        private void ButtonSalesFormMarka_Click(object sender, EventArgs e)
        {
            _formBrand.ShowDialog();
        }

        private void ButtonFormKateqoriya_Click(object sender, EventArgs e)
        {
            _formCategory.ShowDialog();
        }

        private void ButtonSalesFormTedarukculer_Click(object sender, EventArgs e)
        {
            _supplierForm.ShowDialog();
        }

        private void ButtonSalesFormMehsullariSirala_Click(object sender, EventArgs e)
        {
            _formProductList.ShowDialog();
        }

        private void ButtonSalesFormYenile_Click(object sender, EventArgs e)
        {
            dataGridViewProductList.DataSource = _productManager.GetAllProductViewDasgboardDetails().Data;
        }

        private void ButtonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonSalesFormSil_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewSalesForm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxBarkodNo.Text = dataGridViewProductList.CurrentRow.Cells["BarcodeNomresi"].Value.ToString();
            textBoxMehsulAdi.Text = dataGridViewProductList.CurrentRow.Cells["MehsulAdi"].Value.ToString();
            textBoxMaxQiymet.Text = dataGridViewProductList.CurrentRow.Cells["Qiymet"].Value.ToString();
        }

        private void ButtonSalesFormElaveEt_Click(object sender, EventArgs e)
        {
            CartAddDto cartAddDto = new CartAddDto();
            cartAddDto.BarcodeNumber = int.Parse(textBoxBarkodNo.Text);
            cartAddDto.UnitPrice = decimal.Parse(textBoxMaxQiymet.Text);
        }

        private void textBoxMiqdar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMiqdar.Text=="")
            {
                textBoxCem.Text = "";
                return;
            }
            textBoxCem.Text = (Convert.ToDecimal(textBoxQiymet.Text) * Convert.ToInt32(textBoxMiqdar.Text)).ToString();

        }

        private void textBoxQiymet_TextChanged(object sender, EventArgs e)
        {
            
            if (textBoxQiymet.Text == "")
            {
                textBoxCem.Text = "";
                return;
            }
            if (textBoxMiqdar.Text=="")
            {
                textBoxCem.Text = "";
                return;
            }
            int miqdar = Convert.ToInt32(textBoxMiqdar.Text);
            decimal qiymet = Convert.ToDecimal(textBoxQiymet.Text);
            textBoxCem.Text = ( qiymet*miqdar ).ToString();

        }
    }
}

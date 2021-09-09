using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class FormProductAdd : Form
    {
        public FormProductAdd()
        {
            InitializeComponent();
        }
        ProductManager _productManager = new ProductManager(new EfProductDal());
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        BrandManager _brandManager = new BrandManager(new EfBrandDal());
        SupplierManager _supplierManager = new SupplierManager(new EfSupplierDal);

        private void FormProductAdd_Load(object sender, EventArgs e)
        {

            CategoryGetComboBox();
            BrandGetComboBox();
            SupplierGetComboBox();
        }

        private void ButtonFormProductAddYeniMehsulElaveEt_Click(object sender, EventArgs e)
        {
            Product product = new Product();


        }




        private void CategoryGetComboBox()
        {
            var categoryGetAll = _categoryManager.GetAll();
            foreach (var c in categoryGetAll.Data)
            {
                ComboBoxFormProductAddKategoriya.Items.Add(c.CategoryName);
            }
        }

        private void BrandGetComboBox()
        {
            var brandGetAll = _brandManager.GetAll();
            foreach (var b in brandGetAll.Data)
            {
                ComboBoxFormProductAddMarka.Items.Add(b.BrandName);
            }
        }

        private void SupplierGetComboBox()
        {
            var supplierGetAll = _supplierManager.GetAll();
            foreach (var s in supplierGetAll.Data)
            {
                ComboBoxFormProductAddTedarikci.Items.Add(s.CompanyName);
            }
        }
        
    }
}

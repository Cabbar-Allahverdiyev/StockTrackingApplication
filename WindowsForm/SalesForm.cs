using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
        
       
        FormUserAdd _formUserAdd = new FormUserAdd(new UserManager(new EfUserDal()));
        FormUserListed _formUserListed = new FormUserListed(new UserManager(new EfUserDal()));
        FormProductAdd _formProductAdd = new FormProductAdd();
        FormBrand _formBrand = new FormBrand();
        FormCategory _formCategory = new FormCategory();
        



        //public SalesForm(FormUserAdd formUserAdd)
        //{

        //  
        //}

        public SalesForm()
        {
            InitializeComponent();
             
            
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

        }
    }
}

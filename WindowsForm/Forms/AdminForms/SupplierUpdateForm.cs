using Business.Concrete;
using Business.Constants.Messages;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.ValidatorControllers;
using WindowsForm.Utilities.Search.Concrete.SupplierSearch;

namespace WindowsForm.Forms
{
    public partial class SupplierUpdateForm : Form
    {
        SupplierManager _suplierManager = new SupplierManager(new EfSupplierDal());
        SupplierValidationTool validationTool = new SupplierValidationTool();
        SupplierSearch search = new SupplierSearch();

        public SupplierUpdateForm()
        {
            InitializeComponent();
            SupplierRefresh();
        }



        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            SupplierRefresh();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBox1);
        }

        private void buttonSupplierYenile_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = new Supplier();
                supplier.Id =int.Parse(textBoxSupplierId.Text);
                supplier.CompanyName = textBoxSirketAdi.Text;
                supplier.ContactName = textBoxAd.Text;
                supplier.City = textBoxSeher.Text;
                supplier.Address = textBoxAdres.Text;
                supplier.Email = textBoxEmail.Text;
                supplier.Phone = textBoxTelefon.Text;
                supplier.WhenWillCome = textBoxNeZamanGelir.Text;

                if (!validationTool.IsValid(supplier))
                {
                    return;
                }

                var supplierUpdate = _suplierManager.Update(supplier);
                if (!supplierUpdate.Success)
                {
                    FormsMessage.WarningMessage(supplierUpdate.Message);
                    return;
                }
                FormsMessage.SuccessMessage(supplierUpdate.Message);
                SupplierRefresh();
                TextBoxClear();

            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = new Supplier();
                supplier.Id = int.Parse(textBoxSupplierId.Text);

                var supplierDelete = _suplierManager.Delete(supplier);
                if (!supplierDelete.Success)
                {
                    FormsMessage.WarningMessage(supplierDelete.Message);
                    return;
                }
                FormsMessage.SuccessMessage(supplierDelete.Message);
                SupplierRefresh();
                TextBoxClear();
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }

        //Cell Double Click--------------------------------------->
        private void dataGridViewSupplierListed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxClear();
            if (dataGridViewSupplierListed.CurrentRow == null)
            {
                FormsMessage.WarningMessage(BaseMessages.SelectedValueIsNull);
                return;
            }
            textBoxSupplierId.Text = dataGridViewSupplierListed.CurrentRow.Cells["Id"].Value.ToString();
            textBoxSirketAdi.Text = dataGridViewSupplierListed.CurrentRow.Cells["CompanyName"].Value.ToString();
            textBoxAd.Text = dataGridViewSupplierListed.CurrentRow.Cells["ContactName"].Value.ToString();
            textBoxSeher.Text = dataGridViewSupplierListed.CurrentRow.Cells["City"].Value.ToString();
            textBoxAdres.Text = dataGridViewSupplierListed.CurrentRow.Cells["Address"].Value.ToString();
            textBoxEmail.Text = dataGridViewSupplierListed.CurrentRow.Cells["Email"].Value.ToString();
            textBoxTelefon.Text = dataGridViewSupplierListed.CurrentRow.Cells["Phone"].Value.ToString();
            textBoxNeZamanGelir.Text = dataGridViewSupplierListed.CurrentRow.Cells["WhenWillCome"].Value.ToString();
        }

        //text Changed--------------------------------------->
        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            search.GetDataWriteGridView(textBoxAxtar.Text, dataGridViewSupplierListed);
        }

        //elave ---------------------------->
        private void SupplierRefresh()
        {
            dataGridViewSupplierListed.DataSource = _suplierManager.GetAll().Data;
        }

        private void TextBoxClear()
        {
            foreach (Control control in this.Controls)
            {
                TextBoxController.ClearAllTextBoxes(control);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

using Business.Concrete;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.ValidatorControllers;
using WindowsForm.Utilities.Search.Concrete.BrandSearch;
using WindowsForm.Utilities.Search.Concrete.CategorySearch;

namespace WindowsForm.Forms
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        CategoryValidationTool validationTool = new CategoryValidationTool();
       

        private void FormCategory_Load(object sender, EventArgs e)
        {
            var getAll = _categoryManager.GetAll();
            DataGridViewFormCategory.DataSource = getAll.Data;
        }

        private void ButtonFormCategoryElaveEt_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = TextBoxFormCategoryKategoriya.Text;

            if (!validationTool.IsValid(category))
            {
                return;
            }

            IResult categoryAdd = _categoryManager.Add(category);
            if (categoryAdd.Success)
            {
                FormsMessage.SuccessMessage(categoryAdd.Message);
                DataGridViewFormCategory.DataSource = _categoryManager.GetAll().Data;

            }
            else
            {
                FormsMessage.WarningMessage(CategoryMessages.CategoryNotAdded);

            }

            foreach (Control control in this.Controls)
            {
                if (control is TextBox && categoryAdd.Success)
                {
                    control.Text = "";
                }
            }

        }

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            CategorySearch search = new CategorySearch();
            List<Category> data = _categoryManager.GetAll().Data;
            List<Category> oldData = _categoryManager.GetAll().Data;
            search.Search(data,oldData,textBoxAxtar.Text, DataGridViewFormCategory);
        }
    }
}

using Business.Concrete;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.ValidatorControllers;

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

       
    }
}

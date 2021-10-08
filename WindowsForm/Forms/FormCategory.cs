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

namespace WindowsForm
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
       

        private void FormCategory_Load(object sender, EventArgs e)
        {
            var getAll = _categoryManager.GetAll();
            DataGridViewFormCategory.DataSource = getAll.Data;
        }

        private void ButtonFormCategoryElaveEt_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = TextBoxFormCategoryKategoriya.Text;

            CategoryValidator validationRules = new CategoryValidator();
            ValidationResult results = validationRules.Validate(category);

            if (results.IsValid == false)
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    FormsMessage.ErrorMessage(failure.ErrorMessage);
                    return;
                }
               
            }

            IResult categoryAdd = _categoryManager.Add(category);
            if (categoryAdd.Success)
            {
                FormsMessage.InformationMessage(categoryAdd.Message);
                DataGridViewFormCategory.DataSource = _categoryManager.GetAll().Data;

            }
            else
            {
                FormsMessage.ErrorMessage(CategoryMessages.CategoryNotAdded);

            }

            foreach (Control control in this.Controls)
            {
                if (control is TextBox && categoryAdd.Success)
                {
                    control.Text = "";
                }
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}

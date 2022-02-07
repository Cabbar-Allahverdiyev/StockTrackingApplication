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
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.ValidatorControllers;
using WindowsForm.MyControls;
using WindowsForm.Utilities.Search.Concrete.BrandSearch;
using WindowsForm.Utilities.Search.Concrete.CategorySearch;

namespace WindowsForm.Forms
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
            MyControl myControl = new MyControl();
            myControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
        }

        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        CategoryValidationTool validationTool = new CategoryValidationTool();
        CategorySearch search = new CategorySearch();

        private void FormCategory_Load(object sender, EventArgs e)
        {
            var getAll = _categoryManager.GetAll();
            DataGridViewFormCategory.DataSource = getAll.Data;
        }

        //Click-------------------------------------------->
        private void ButtonFormCategoryElaveEt_Click(object sender, EventArgs e)
        {
            try
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
                    CategoryRefresh();
                }
                else
                {
                    FormsMessage.WarningMessage(CategoryMessages.CategoryNotAdded);

                }

                foreach (Control control in this.Controls)
                {
                    if (categoryAdd.Success)
                    {
                        TextBoxController.ClearAllTextBoxes(control);
                    }

                }
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage($"{AuthMessages.ErrorMessage}| {ex.Message}");
            }

        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            CategoryRefresh();
        }

        //Text Changed------------------------------>
        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            search.GetDataWriteGridView(textBoxAxtar.Text, DataGridViewFormCategory);
        }

        //Elave metodlar------->
        private void CategoryRefresh()
        {
            DataGridViewFormCategory.DataSource = _categoryManager.GetAll().Data;
        }
    }
}

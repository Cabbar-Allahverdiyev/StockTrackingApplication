using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results;
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
using WindowsForm.Core.Controllers.Concrete.ValidatorControllers;
using WindowsForm.MyControls;
using WindowsForm.Utilities.Search.Concrete.CategorySearch;

namespace WindowsForm.Forms
{
    public partial class FormCategory : Form
    {
        ICategoryService _categoryService;
       // IFormSettingService _formSettingService;
          // private  MyControl _myControl ;
        public FormCategory(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            //_formSettingService = formSettingService;
         //   _myControl = new MyControl(_formSettingService);
            InitializeComponent();
            MyControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
        }

        CategorySearch search = new CategorySearch();

        private void FormCategory_Load(object sender, EventArgs e)
        {
            var getAll = _categoryService.GetAll();
            DataGridViewFormCategory.DataSource = getAll.Data;
        }

        //Click-------------------------------------------->
        private void ButtonFormCategoryElaveEt_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category();
                category.CategoryName = TextBoxFormCategoryKategoriya.Text;


                if (!FormValidationTool.IsValid(new CategoryValidator(), category))
                {
                    return;
                }

                IResult categoryAdd = _categoryService.Add(category);
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
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }

        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            CategoryRefresh();
        }

        //Text Changed------------------------------>
        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            List<Category> data = _categoryService.GetAll().Data;
            search.GetDataWriteGridView(data, textBoxAxtar.Text, DataGridViewFormCategory);
        }

        //Elave metodlar------->
        private void CategoryRefresh()
        {
            DataGridViewFormCategory.DataSource = _categoryService.GetAll().Data;
        }
    }
}

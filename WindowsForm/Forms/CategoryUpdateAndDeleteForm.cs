using Business.Abstract;
using Business.Constants.Messages;
using Business.ValidationRules.FluentValidation.CategoryValidators;
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
using WindowsForm.Utilities.Search.Concrete.CategorySearch;

namespace WindowsForm.Forms
{
    public partial class CategoryUpdateAndDeleteForm : Form
    {
        //CategoryManager _categoryService = new CategoryManager(new EfCategoryDal());
        ICategoryService _categoryService;
        CategorySearch search = new CategorySearch();

        public CategoryUpdateAndDeleteForm(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            InitializeComponent();
            CategoryRefresh();
        }



        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            CategoryRefresh();
        }

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            List<Category> data = _categoryService.GetAll().Data;
            search.GetDataWriteGridView(data, textBoxAxtar.Text, dataGridViewCategoryList);
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category();
                category.Id = int.Parse(textBoxId.Text);
                category.CategoryName = textBoxCategory.Text;
                if (!FormValidationTool.IsValid(new UpdateCategoryValidator(), category))
                {
                    return;
                }

                var categoryUpdated = _categoryService.Update(category);
                if (!categoryUpdated.Success)
                {
                    FormsMessage.WarningMessage(categoryUpdated.Message);
                    return;
                }
                FormsMessage.SuccessMessage(categoryUpdated.Message);
                CategoryRefresh();
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
                Category category = new Category();
                category.Id = int.Parse(textBoxId.Text);

                var categryDeleted = _categoryService.Delete(category);
                if (!categryDeleted.Success)
                {
                    FormsMessage.WarningMessage(categryDeleted.Message);
                    return;
                }
                FormsMessage.SuccessMessage(categryDeleted.Message);
                CategoryRefresh();
                TextBoxClear();

            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }

        private void dataGridViewCategoryList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCategoryList.CurrentRow == null)
            {
                FormsMessage.WarningMessage(BaseMessages.SelectedValueIsNull);
                return;
            }
            textBoxId.Text = dataGridViewCategoryList.CurrentRow.Cells["Id"].Value.ToString();
            textBoxCategory.Text = dataGridViewCategoryList.CurrentRow.Cells["CategoryName"].Value.ToString();
        }

        private void CategoryRefresh()
        {
            dataGridViewCategoryList.DataSource = _categoryService.GetAll().Data;
        }
        private void TextBoxClear()
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBox1);
        }

    }
}

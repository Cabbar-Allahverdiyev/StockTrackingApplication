using Business.Concrete;
using Business.Constants.Messages;
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
using WindowsForm.Utilities.Search.Concrete.CategorySearch;

namespace WindowsForm.Forms
{
    public partial class CategoryUpdateAndDeleteForm : Form
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        CategoryValidationTool validationTool = new CategoryValidationTool();
        CategorySearch search = new CategorySearch();
        
        public CategoryUpdateAndDeleteForm()
        {
            InitializeComponent();
            CategoryRefresh();
        }

        

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            CategoryRefresh();
        }

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            search.GetDataWriteGridView(textBoxAxtar.Text, dataGridViewCategoryList);
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

                if (!validationTool.IsValid(category))
                {
                    return;
                }

                var categoryUpdated = _categoryManager.Update(category);
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
                FormsMessage.ErrorMessage($"{AuthMessages.ErrorMessage} | {ex.Message}");
                return;
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category();
                category.Id = int.Parse(textBoxId.Text);
               
                var categryDeleted = _categoryManager.Update(category);
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
                FormsMessage.ErrorMessage($"{AuthMessages.ErrorMessage} | {ex.Message}");
                return;
            }
        }

        private void dataGridViewCategoryList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewCategoryList.CurrentRow.Cells["Id"].Value.ToString();
            textBoxCategory.Text = dataGridViewCategoryList.CurrentRow.Cells["CategoryName"].Value.ToString();
        }

        private void CategoryRefresh()
        {
            dataGridViewCategoryList.DataSource = _categoryManager.GetAll().Data;
        }
        private void TextBoxClear()
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBox1);
        }
        
    }
}

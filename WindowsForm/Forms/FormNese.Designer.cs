
namespace WindowsForm.Forms
{
    partial class FormNese
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridViewFormCategory = new System.Windows.Forms.DataGridView();
            this.TextBoxFormCategoryKategoriya = new System.Windows.Forms.TextBox();
            this.ButtonFormCategoryElaveEt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFormCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewFormCategory
            // 
            this.DataGridViewFormCategory.AllowUserToAddRows = false;
            this.DataGridViewFormCategory.AllowUserToDeleteRows = false;
            this.DataGridViewFormCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewFormCategory.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridViewFormCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewFormCategory.Location = new System.Drawing.Point(352, 69);
            this.DataGridViewFormCategory.Name = "DataGridViewFormCategory";
            this.DataGridViewFormCategory.ReadOnly = true;
            this.DataGridViewFormCategory.RowTemplate.Height = 25;
            this.DataGridViewFormCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewFormCategory.Size = new System.Drawing.Size(393, 313);
            this.DataGridViewFormCategory.TabIndex = 7;
            // 
            // TextBoxFormCategoryKategoriya
            // 
            this.TextBoxFormCategoryKategoriya.Location = new System.Drawing.Point(142, 69);
            this.TextBoxFormCategoryKategoriya.Name = "TextBoxFormCategoryKategoriya";
            this.TextBoxFormCategoryKategoriya.Size = new System.Drawing.Size(180, 23);
            this.TextBoxFormCategoryKategoriya.TabIndex = 6;
            // 
            // ButtonFormCategoryElaveEt
            // 
            this.ButtonFormCategoryElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFormCategoryElaveEt.Location = new System.Drawing.Point(247, 98);
            this.ButtonFormCategoryElaveEt.Name = "ButtonFormCategoryElaveEt";
            this.ButtonFormCategoryElaveEt.Size = new System.Drawing.Size(75, 23);
            this.ButtonFormCategoryElaveEt.TabIndex = 5;
            this.ButtonFormCategoryElaveEt.Text = "Elave Et";
            this.ButtonFormCategoryElaveEt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kateqoriya:";
            // 
            // FormNese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewFormCategory);
            this.Controls.Add(this.TextBoxFormCategoryKategoriya);
            this.Controls.Add(this.ButtonFormCategoryElaveEt);
            this.Controls.Add(this.label1);
            this.Name = "FormNese";
            this.Text = "FormNese";
            this.Load += new System.EventHandler(this.FormNese_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFormCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewFormCategory;
        private System.Windows.Forms.TextBox TextBoxFormCategoryKategoriya;
        private System.Windows.Forms.Button ButtonFormCategoryElaveEt;
        private System.Windows.Forms.Label label1;
    }
}
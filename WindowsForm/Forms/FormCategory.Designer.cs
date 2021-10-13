
namespace WindowsForm.Forms

{
    partial class FormCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonFormCategoryElaveEt = new System.Windows.Forms.Button();
            this.TextBoxFormCategoryKategoriya = new System.Windows.Forms.TextBox();
            this.DataGridViewFormCategory = new System.Windows.Forms.DataGridView();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFormCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kateqoriya:";
            // 
            // ButtonFormCategoryElaveEt
            // 
            this.ButtonFormCategoryElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFormCategoryElaveEt.Location = new System.Drawing.Point(204, 59);
            this.ButtonFormCategoryElaveEt.Name = "ButtonFormCategoryElaveEt";
            this.ButtonFormCategoryElaveEt.Size = new System.Drawing.Size(75, 23);
            this.ButtonFormCategoryElaveEt.TabIndex = 1;
            this.ButtonFormCategoryElaveEt.Text = "Elave Et";
            this.ButtonFormCategoryElaveEt.UseVisualStyleBackColor = true;
            this.ButtonFormCategoryElaveEt.Click += new System.EventHandler(this.ButtonFormCategoryElaveEt_Click);
            // 
            // TextBoxFormCategoryKategoriya
            // 
            this.TextBoxFormCategoryKategoriya.Location = new System.Drawing.Point(99, 30);
            this.TextBoxFormCategoryKategoriya.Name = "TextBoxFormCategoryKategoriya";
            this.TextBoxFormCategoryKategoriya.Size = new System.Drawing.Size(180, 23);
            this.TextBoxFormCategoryKategoriya.TabIndex = 2;
            // 
            // DataGridViewFormCategory
            // 
            this.DataGridViewFormCategory.AllowUserToAddRows = false;
            this.DataGridViewFormCategory.AllowUserToDeleteRows = false;
            this.DataGridViewFormCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewFormCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.DataGridViewFormCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewFormCategory.Location = new System.Drawing.Point(309, 30);
            this.DataGridViewFormCategory.Name = "DataGridViewFormCategory";
            this.DataGridViewFormCategory.ReadOnly = true;
            this.DataGridViewFormCategory.RowTemplate.Height = 25;
            this.DataGridViewFormCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewFormCategory.Size = new System.Drawing.Size(406, 331);
            this.DataGridViewFormCategory.TabIndex = 3;
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Location = new System.Drawing.Point(533, 1);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(180, 23);
            this.textBoxAxtar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Axtar:";
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(716, 356);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridViewFormCategory);
            this.Controls.Add(this.TextBoxFormCategoryKategoriya);
            this.Controls.Add(this.ButtonFormCategoryElaveEt);
            this.Controls.Add(this.label1);
            this.Name = "FormCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Category";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFormCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonFormCategoryElaveEt;
        private System.Windows.Forms.TextBox TextBoxFormCategoryKategoriya;
        private System.Windows.Forms.DataGridView DataGridViewFormCategory;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.Label label2;
    }
}
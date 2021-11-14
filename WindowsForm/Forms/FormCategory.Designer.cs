
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory));
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kateqoriya:";
            // 
            // ButtonFormCategoryElaveEt
            // 
            this.ButtonFormCategoryElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFormCategoryElaveEt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonFormCategoryElaveEt.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFormCategoryElaveEt.Image")));
            this.ButtonFormCategoryElaveEt.Location = new System.Drawing.Point(194, 77);
            this.ButtonFormCategoryElaveEt.Name = "ButtonFormCategoryElaveEt";
            this.ButtonFormCategoryElaveEt.Size = new System.Drawing.Size(85, 26);
            this.ButtonFormCategoryElaveEt.TabIndex = 1;
            this.ButtonFormCategoryElaveEt.Text = "Əlavə et";
            this.ButtonFormCategoryElaveEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonFormCategoryElaveEt.UseVisualStyleBackColor = true;
            this.ButtonFormCategoryElaveEt.Click += new System.EventHandler(this.ButtonFormCategoryElaveEt_Click);
            // 
            // TextBoxFormCategoryKategoriya
            // 
            this.TextBoxFormCategoryKategoriya.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxFormCategoryKategoriya.Location = new System.Drawing.Point(113, 45);
            this.TextBoxFormCategoryKategoriya.Name = "TextBoxFormCategoryKategoriya";
            this.TextBoxFormCategoryKategoriya.Size = new System.Drawing.Size(166, 22);
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
            this.DataGridViewFormCategory.Location = new System.Drawing.Point(309, 45);
            this.DataGridViewFormCategory.Name = "DataGridViewFormCategory";
            this.DataGridViewFormCategory.ReadOnly = true;
            this.DataGridViewFormCategory.RowTemplate.Height = 25;
            this.DataGridViewFormCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewFormCategory.Size = new System.Drawing.Size(395, 345);
            this.DataGridViewFormCategory.TabIndex = 3;
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(524, 14);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(180, 22);
            this.textBoxAxtar.TabIndex = 5;
            this.textBoxAxtar.TextChanged += new System.EventHandler(this.textBoxAxtar_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(473, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Axtar:";
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(716, 403);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridViewFormCategory);
            this.Controls.Add(this.TextBoxFormCategoryKategoriya);
            this.Controls.Add(this.ButtonFormCategoryElaveEt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
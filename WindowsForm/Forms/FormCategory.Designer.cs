
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
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFormCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kateqoriya:";
            // 
            // ButtonFormCategoryElaveEt
            // 
            this.ButtonFormCategoryElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFormCategoryElaveEt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonFormCategoryElaveEt.Image = global::WindowsForm.Properties.Resources.elaveEtBlack;
            this.ButtonFormCategoryElaveEt.Location = new System.Drawing.Point(169, 72);
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
            this.TextBoxFormCategoryKategoriya.Location = new System.Drawing.Point(88, 40);
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
            this.DataGridViewFormCategory.Location = new System.Drawing.Point(309, 40);
            this.DataGridViewFormCategory.Name = "DataGridViewFormCategory";
            this.DataGridViewFormCategory.ReadOnly = true;
            this.DataGridViewFormCategory.RowTemplate.Height = 25;
            this.DataGridViewFormCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewFormCategory.Size = new System.Drawing.Size(395, 350);
            this.DataGridViewFormCategory.TabIndex = 3;
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(496, 12);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(180, 22);
            this.textBoxAxtar.TabIndex = 5;
            this.textBoxAxtar.TextChanged += new System.EventHandler(this.textBoxAxtar_TextChanged);
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRefresh.ErrorImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Image = global::WindowsForm.Properties.Resources.refreshBlack_16px_;
            this.pictureBoxRefresh.InitialImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(682, 12);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefresh.TabIndex = 33;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.label12.Location = new System.Drawing.Point(467, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "     ";
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(716, 403);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.DataGridViewFormCategory);
            this.Controls.Add(this.TextBoxFormCategoryKategoriya);
            this.Controls.Add(this.ButtonFormCategoryElaveEt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kateqoriya Səhifəsi";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFormCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonFormCategoryElaveEt;
        private System.Windows.Forms.TextBox TextBoxFormCategoryKategoriya;
        private System.Windows.Forms.DataGridView DataGridViewFormCategory;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.Label label12;
    }
}
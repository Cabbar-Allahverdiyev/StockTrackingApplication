
namespace WindowsForm.Forms
{
    partial class FormBrand
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
            this.TextBoxFormBrandMarkaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonFormBrandElaveEt = new System.Windows.Forms.Button();
            this.dataGridViewBrandsListed = new System.Windows.Forms.DataGridView();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrandsListed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxFormBrandMarkaAdi
            // 
            this.TextBoxFormBrandMarkaAdi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxFormBrandMarkaAdi.Location = new System.Drawing.Point(88, 37);
            this.TextBoxFormBrandMarkaAdi.Name = "TextBoxFormBrandMarkaAdi";
            this.TextBoxFormBrandMarkaAdi.Size = new System.Drawing.Size(164, 22);
            this.TextBoxFormBrandMarkaAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka adı:";
            // 
            // ButtonFormBrandElaveEt
            // 
            this.ButtonFormBrandElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFormBrandElaveEt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonFormBrandElaveEt.Image = global::WindowsForm.Properties.Resources.elaveEtBlack;
            this.ButtonFormBrandElaveEt.Location = new System.Drawing.Point(167, 69);
            this.ButtonFormBrandElaveEt.Name = "ButtonFormBrandElaveEt";
            this.ButtonFormBrandElaveEt.Size = new System.Drawing.Size(85, 26);
            this.ButtonFormBrandElaveEt.TabIndex = 2;
            this.ButtonFormBrandElaveEt.Text = "Əlavə et";
            this.ButtonFormBrandElaveEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonFormBrandElaveEt.UseVisualStyleBackColor = true;
            this.ButtonFormBrandElaveEt.Click += new System.EventHandler(this.ButtonFormBrandElaveEt_Click);
            // 
            // dataGridViewBrandsListed
            // 
            this.dataGridViewBrandsListed.AllowUserToAddRows = false;
            this.dataGridViewBrandsListed.AllowUserToDeleteRows = false;
            this.dataGridViewBrandsListed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBrandsListed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.dataGridViewBrandsListed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBrandsListed.Location = new System.Drawing.Point(321, 40);
            this.dataGridViewBrandsListed.Name = "dataGridViewBrandsListed";
            this.dataGridViewBrandsListed.ReadOnly = true;
            this.dataGridViewBrandsListed.RowTemplate.Height = 25;
            this.dataGridViewBrandsListed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBrandsListed.Size = new System.Drawing.Size(517, 394);
            this.dataGridViewBrandsListed.TabIndex = 3;
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(632, 12);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(173, 22);
            this.textBoxAxtar.TabIndex = 4;
            this.textBoxAxtar.TextChanged += new System.EventHandler(this.textBoxAxtar_TextChanged);
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRefresh.ErrorImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Image = global::WindowsForm.Properties.Resources.refreshBlack_16px_;
            this.pictureBoxRefresh.InitialImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(811, 12);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefresh.TabIndex = 32;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.label12.Location = new System.Drawing.Point(603, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "     ";
            // 
            // FormBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(850, 448);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.dataGridViewBrandsListed);
            this.Controls.Add(this.ButtonFormBrandElaveEt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxFormBrandMarkaAdi);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka səhifəsi";
            this.Load += new System.EventHandler(this.FormBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrandsListed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxFormBrandMarkaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonFormBrandElaveEt;
        private System.Windows.Forms.DataGridView dataGridViewBrandsListed;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.Label label12;
    }
}
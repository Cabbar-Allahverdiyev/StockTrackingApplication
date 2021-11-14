
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrand));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TextBoxFormBrandMarkaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonFormBrandElaveEt = new System.Windows.Forms.Button();
            this.dataGridViewBrandsListed = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrandsListed)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxFormBrandMarkaAdi
            // 
            this.TextBoxFormBrandMarkaAdi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxFormBrandMarkaAdi.Location = new System.Drawing.Point(91, 32);
            this.TextBoxFormBrandMarkaAdi.Name = "TextBoxFormBrandMarkaAdi";
            this.TextBoxFormBrandMarkaAdi.Size = new System.Drawing.Size(164, 22);
            this.TextBoxFormBrandMarkaAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka adı:";
            // 
            // ButtonFormBrandElaveEt
            // 
            this.ButtonFormBrandElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFormBrandElaveEt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonFormBrandElaveEt.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFormBrandElaveEt.Image")));
            this.ButtonFormBrandElaveEt.Location = new System.Drawing.Point(170, 60);
            this.ButtonFormBrandElaveEt.Name = "ButtonFormBrandElaveEt";
            this.ButtonFormBrandElaveEt.Size = new System.Drawing.Size(85, 23);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBrandsListed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBrandsListed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBrandsListed.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBrandsListed.Location = new System.Drawing.Point(321, 40);
            this.dataGridViewBrandsListed.Name = "dataGridViewBrandsListed";
            this.dataGridViewBrandsListed.ReadOnly = true;
            this.dataGridViewBrandsListed.RowTemplate.Height = 25;
            this.dataGridViewBrandsListed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBrandsListed.Size = new System.Drawing.Size(517, 343);
            this.dataGridViewBrandsListed.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(614, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Axtar:";
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(665, 12);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(173, 22);
            this.textBoxAxtar.TabIndex = 4;
            this.textBoxAxtar.TextChanged += new System.EventHandler(this.textBoxAxtar_TextChanged);
            // 
            // FormBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(850, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.dataGridViewBrandsListed);
            this.Controls.Add(this.ButtonFormBrandElaveEt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxFormBrandMarkaAdi);
            this.Name = "FormBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Brand";
            this.Load += new System.EventHandler(this.FormBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrandsListed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxFormBrandMarkaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonFormBrandElaveEt;
        private System.Windows.Forms.DataGridView dataGridViewBrandsListed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAxtar;
    }
}

namespace WindowsForm
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
            this.DataGridViewFormBrand = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFormBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxFormBrandMarkaAdi
            // 
            this.TextBoxFormBrandMarkaAdi.Location = new System.Drawing.Point(82, 29);
            this.TextBoxFormBrandMarkaAdi.Name = "TextBoxFormBrandMarkaAdi";
            this.TextBoxFormBrandMarkaAdi.Size = new System.Drawing.Size(173, 23);
            this.TextBoxFormBrandMarkaAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka Adi:";
            // 
            // ButtonFormBrandElaveEt
            // 
            this.ButtonFormBrandElaveEt.Location = new System.Drawing.Point(180, 58);
            this.ButtonFormBrandElaveEt.Name = "ButtonFormBrandElaveEt";
            this.ButtonFormBrandElaveEt.Size = new System.Drawing.Size(75, 23);
            this.ButtonFormBrandElaveEt.TabIndex = 2;
            this.ButtonFormBrandElaveEt.Text = "Elave Et";
            this.ButtonFormBrandElaveEt.UseVisualStyleBackColor = true;
            this.ButtonFormBrandElaveEt.Click += new System.EventHandler(this.ButtonFormBrandElaveEt_Click);
            // 
            // DataGridViewFormBrand
            // 
            this.DataGridViewFormBrand.AllowUserToAddRows = false;
            this.DataGridViewFormBrand.AllowUserToDeleteRows = false;
            this.DataGridViewFormBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewFormBrand.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridViewFormBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewFormBrand.Location = new System.Drawing.Point(300, 29);
            this.DataGridViewFormBrand.Name = "DataGridViewFormBrand";
            this.DataGridViewFormBrand.ReadOnly = true;
            this.DataGridViewFormBrand.RowTemplate.Height = 25;
            this.DataGridViewFormBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewFormBrand.Size = new System.Drawing.Size(368, 324);
            this.DataGridViewFormBrand.TabIndex = 3;
            // 
            // FormBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 400);
            this.Controls.Add(this.DataGridViewFormBrand);
            this.Controls.Add(this.ButtonFormBrandElaveEt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxFormBrandMarkaAdi);
            this.Name = "FormBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Brand";
            this.Load += new System.EventHandler(this.FormBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFormBrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxFormBrandMarkaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonFormBrandElaveEt;
        private System.Windows.Forms.DataGridView DataGridViewFormBrand;
    }
}
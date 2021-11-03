
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
            this.ButtonFormCategoryElaveEt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonFormCategoryElaveEt
            // 
            this.ButtonFormCategoryElaveEt.BackColor = System.Drawing.Color.SeaGreen;
            this.ButtonFormCategoryElaveEt.FlatAppearance.BorderSize = 0;
            this.ButtonFormCategoryElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFormCategoryElaveEt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonFormCategoryElaveEt.Location = new System.Drawing.Point(64, 51);
            this.ButtonFormCategoryElaveEt.Name = "ButtonFormCategoryElaveEt";
            this.ButtonFormCategoryElaveEt.Size = new System.Drawing.Size(86, 28);
            this.ButtonFormCategoryElaveEt.TabIndex = 5;
            this.ButtonFormCategoryElaveEt.Text = "Success";
            this.ButtonFormCategoryElaveEt.UseVisualStyleBackColor = false;
            this.ButtonFormCategoryElaveEt.Click += new System.EventHandler(this.ButtonFormCategoryElaveEt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(64, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Elave Et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(64, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Information";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonError
            // 
            this.buttonError.BackColor = System.Drawing.Color.DarkRed;
            this.buttonError.FlatAppearance.BorderSize = 0;
            this.buttonError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonError.Location = new System.Drawing.Point(64, 85);
            this.buttonError.Name = "buttonError";
            this.buttonError.Size = new System.Drawing.Size(86, 28);
            this.buttonError.TabIndex = 8;
            this.buttonError.Text = "Xəta";
            this.buttonError.UseVisualStyleBackColor = false;
            this.buttonError.Click += new System.EventHandler(this.buttonError_Click);
            // 
            // FormNese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 420);
            this.Controls.Add(this.buttonError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonFormCategoryElaveEt);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormNese";
            this.Text = "FormNese";
            this.Load += new System.EventHandler(this.FormNese_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonFormCategoryElaveEt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonError;
    }
}
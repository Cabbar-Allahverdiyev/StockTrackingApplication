
namespace WindowsForm
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kateqoriya:";
            // 
            // ButtonFormCategoryElaveEt
            // 
            this.ButtonFormCategoryElaveEt.Location = new System.Drawing.Point(204, 59);
            this.ButtonFormCategoryElaveEt.Name = "ButtonFormCategoryElaveEt";
            this.ButtonFormCategoryElaveEt.Size = new System.Drawing.Size(75, 23);
            this.ButtonFormCategoryElaveEt.TabIndex = 1;
            this.ButtonFormCategoryElaveEt.Text = "Elave Et";
            this.ButtonFormCategoryElaveEt.UseVisualStyleBackColor = true;
            // 
            // TextBoxFormCategoryKategoriya
            // 
            this.TextBoxFormCategoryKategoriya.Location = new System.Drawing.Point(99, 30);
            this.TextBoxFormCategoryKategoriya.Name = "TextBoxFormCategoryKategoriya";
            this.TextBoxFormCategoryKategoriya.Size = new System.Drawing.Size(180, 23);
            this.TextBoxFormCategoryKategoriya.TabIndex = 2;
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(291, 158);
            this.Controls.Add(this.TextBoxFormCategoryKategoriya);
            this.Controls.Add(this.ButtonFormCategoryElaveEt);
            this.Controls.Add(this.label1);
            this.Name = "FormCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonFormCategoryElaveEt;
        private System.Windows.Forms.TextBox TextBoxFormCategoryKategoriya;
    }
}

namespace WindowsForm.Forms.SettingForms
{
    partial class ConfigurationSettingForm
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
            this.groupBoxSigns = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSignsDecimalPoint = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxSigns.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSigns
            // 
            this.groupBoxSigns.Controls.Add(this.label1);
            this.groupBoxSigns.Controls.Add(this.textBoxSignsDecimalPoint);
            this.groupBoxSigns.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSigns.Name = "groupBoxSigns";
            this.groupBoxSigns.Size = new System.Drawing.Size(214, 49);
            this.groupBoxSigns.TabIndex = 3;
            this.groupBoxSigns.TabStop = false;
            this.groupBoxSigns.Text = "İşarələr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kəsr rəqəmlərin işarəsi :";
            // 
            // textBoxSignsDecimalPoint
            // 
            this.textBoxSignsDecimalPoint.Location = new System.Drawing.Point(155, 15);
            this.textBoxSignsDecimalPoint.Name = "textBoxSignsDecimalPoint";
            this.textBoxSignsDecimalPoint.Size = new System.Drawing.Size(53, 23);
            this.textBoxSignsDecimalPoint.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Image = global::WindowsForm.Properties.Resources.save_all_16px;
            this.buttonSave.Location = new System.Drawing.Point(664, 413);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(124, 25);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "  Yadda saxla";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ConfigurationSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxSigns);
            this.Name = "ConfigurationSettingForm";
            this.Text = "Tənzimləmələr";
            this.Load += new System.EventHandler(this.ConfigurationSettingForm_Load);
            this.groupBoxSigns.ResumeLayout(false);
            this.groupBoxSigns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSigns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSignsDecimalPoint;
        private System.Windows.Forms.Button buttonSave;
    }
}
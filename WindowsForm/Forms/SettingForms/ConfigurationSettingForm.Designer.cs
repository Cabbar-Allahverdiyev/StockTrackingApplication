
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
            this.groupBoxShopInfo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxVoen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxShopNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxShopAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxShopName = new System.Windows.Forms.TextBox();
            this.groupBoxVaultInfo = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxVaultSerialNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxVaultModel = new System.Windows.Forms.TextBox();
            this.groupBoxPrinterInfo = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBarcodePrinterModel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxReceiptPrinterModel = new System.Windows.Forms.TextBox();
            this.groupBoxSigns.SuspendLayout();
            this.groupBoxShopInfo.SuspendLayout();
            this.groupBoxVaultInfo.SuspendLayout();
            this.groupBoxPrinterInfo.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(6, 19);
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
            // groupBoxShopInfo
            // 
            this.groupBoxShopInfo.Controls.Add(this.label5);
            this.groupBoxShopInfo.Controls.Add(this.textBoxVoen);
            this.groupBoxShopInfo.Controls.Add(this.label4);
            this.groupBoxShopInfo.Controls.Add(this.textBoxShopNumber);
            this.groupBoxShopInfo.Controls.Add(this.label3);
            this.groupBoxShopInfo.Controls.Add(this.textBoxShopAddress);
            this.groupBoxShopInfo.Controls.Add(this.label2);
            this.groupBoxShopInfo.Controls.Add(this.textBoxShopName);
            this.groupBoxShopInfo.Location = new System.Drawing.Point(12, 67);
            this.groupBoxShopInfo.Name = "groupBoxShopInfo";
            this.groupBoxShopInfo.Size = new System.Drawing.Size(274, 137);
            this.groupBoxShopInfo.TabIndex = 4;
            this.groupBoxShopInfo.TabStop = false;
            this.groupBoxShopInfo.Text = "Mağaza məlumatları";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "VÖEN :";
            // 
            // textBoxVoen
            // 
            this.textBoxVoen.Location = new System.Drawing.Point(119, 102);
            this.textBoxVoen.Name = "textBoxVoen";
            this.textBoxVoen.Size = new System.Drawing.Size(149, 23);
            this.textBoxVoen.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Obyektin nömrəsi :";
            // 
            // textBoxShopNumber
            // 
            this.textBoxShopNumber.Location = new System.Drawing.Point(119, 73);
            this.textBoxShopNumber.Name = "textBoxShopNumber";
            this.textBoxShopNumber.Size = new System.Drawing.Size(149, 23);
            this.textBoxShopNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address :";
            // 
            // textBoxShopAddress
            // 
            this.textBoxShopAddress.Location = new System.Drawing.Point(119, 44);
            this.textBoxShopAddress.Name = "textBoxShopAddress";
            this.textBoxShopAddress.Size = new System.Drawing.Size(149, 23);
            this.textBoxShopAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mağaza adı :";
            // 
            // textBoxShopName
            // 
            this.textBoxShopName.Location = new System.Drawing.Point(119, 15);
            this.textBoxShopName.Name = "textBoxShopName";
            this.textBoxShopName.Size = new System.Drawing.Size(149, 23);
            this.textBoxShopName.TabIndex = 1;
            // 
            // groupBoxVaultInfo
            // 
            this.groupBoxVaultInfo.Controls.Add(this.label7);
            this.groupBoxVaultInfo.Controls.Add(this.textBoxVaultSerialNumber);
            this.groupBoxVaultInfo.Controls.Add(this.label6);
            this.groupBoxVaultInfo.Controls.Add(this.textBoxVaultModel);
            this.groupBoxVaultInfo.Location = new System.Drawing.Point(12, 210);
            this.groupBoxVaultInfo.Name = "groupBoxVaultInfo";
            this.groupBoxVaultInfo.Size = new System.Drawing.Size(274, 83);
            this.groupBoxVaultInfo.TabIndex = 4;
            this.groupBoxVaultInfo.TabStop = false;
            this.groupBoxVaultInfo.Text = "Kassa aparatı məlumatları";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kassa aparat Seriya nömrəsi :";
            // 
            // textBoxVaultSerialNumber
            // 
            this.textBoxVaultSerialNumber.Location = new System.Drawing.Point(170, 44);
            this.textBoxVaultSerialNumber.Name = "textBoxVaultSerialNumber";
            this.textBoxVaultSerialNumber.Size = new System.Drawing.Size(98, 23);
            this.textBoxVaultSerialNumber.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kassa aparat modeli :";
            // 
            // textBoxVaultModel
            // 
            this.textBoxVaultModel.Location = new System.Drawing.Point(170, 15);
            this.textBoxVaultModel.Name = "textBoxVaultModel";
            this.textBoxVaultModel.Size = new System.Drawing.Size(98, 23);
            this.textBoxVaultModel.TabIndex = 1;
            // 
            // groupBoxPrinterInfo
            // 
            this.groupBoxPrinterInfo.Controls.Add(this.label8);
            this.groupBoxPrinterInfo.Controls.Add(this.textBoxBarcodePrinterModel);
            this.groupBoxPrinterInfo.Controls.Add(this.label9);
            this.groupBoxPrinterInfo.Controls.Add(this.textBoxReceiptPrinterModel);
            this.groupBoxPrinterInfo.Location = new System.Drawing.Point(12, 299);
            this.groupBoxPrinterInfo.Name = "groupBoxPrinterInfo";
            this.groupBoxPrinterInfo.Size = new System.Drawing.Size(274, 83);
            this.groupBoxPrinterInfo.TabIndex = 5;
            this.groupBoxPrinterInfo.TabStop = false;
            this.groupBoxPrinterInfo.Text = "Printer məlumatarı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Barkod printer modeli :";
            // 
            // textBoxBarcodePrinterModel
            // 
            this.textBoxBarcodePrinterModel.Location = new System.Drawing.Point(140, 44);
            this.textBoxBarcodePrinterModel.Name = "textBoxBarcodePrinterModel";
            this.textBoxBarcodePrinterModel.Size = new System.Drawing.Size(128, 23);
            this.textBoxBarcodePrinterModel.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Çek printer modeli :";
            // 
            // textBoxReceiptPrinterModel
            // 
            this.textBoxReceiptPrinterModel.Location = new System.Drawing.Point(140, 15);
            this.textBoxReceiptPrinterModel.Name = "textBoxReceiptPrinterModel";
            this.textBoxReceiptPrinterModel.Size = new System.Drawing.Size(128, 23);
            this.textBoxReceiptPrinterModel.TabIndex = 1;
            // 
            // ConfigurationSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxPrinterInfo);
            this.Controls.Add(this.groupBoxVaultInfo);
            this.Controls.Add(this.groupBoxShopInfo);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxSigns);
            this.Name = "ConfigurationSettingForm";
            this.Text = "Tənzimləmələr";
            this.Load += new System.EventHandler(this.ConfigurationSettingForm_Load);
            this.groupBoxSigns.ResumeLayout(false);
            this.groupBoxSigns.PerformLayout();
            this.groupBoxShopInfo.ResumeLayout(false);
            this.groupBoxShopInfo.PerformLayout();
            this.groupBoxVaultInfo.ResumeLayout(false);
            this.groupBoxVaultInfo.PerformLayout();
            this.groupBoxPrinterInfo.ResumeLayout(false);
            this.groupBoxPrinterInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSigns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSignsDecimalPoint;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxShopInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxVoen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxShopNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxShopAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxShopName;
        private System.Windows.Forms.GroupBox groupBoxVaultInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxVaultSerialNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxVaultModel;
        private System.Windows.Forms.GroupBox groupBoxPrinterInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBarcodePrinterModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxReceiptPrinterModel;
    }
}

namespace WindowsForm.Forms
{
    partial class USBBarcodeScannerForm
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
            this.textBoxBarcodeNumber = new System.Windows.Forms.TextBox();
            this.buttonScan = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonQrCode = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBarcodeNumber
            // 
            this.textBoxBarcodeNumber.Location = new System.Drawing.Point(154, 21);
            this.textBoxBarcodeNumber.Name = "textBoxBarcodeNumber";
            this.textBoxBarcodeNumber.Size = new System.Drawing.Size(220, 22);
            this.textBoxBarcodeNumber.TabIndex = 1;
            this.textBoxBarcodeNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonScan
            // 
            this.buttonScan.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonScan.Location = new System.Drawing.Point(62, 48);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(86, 21);
            this.buttonScan.TabIndex = 5;
            this.buttonScan.Text = "Skan et";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(22, 75);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(126, 21);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Yaddaşa yaz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerate.Location = new System.Drawing.Point(382, 75);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(122, 21);
            this.buttonGenerate.TabIndex = 7;
            this.buttonGenerate.Text = "Barkod yarat";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.Location = new System.Drawing.Point(22, 102);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(127, 21);
            this.buttonLoad.TabIndex = 8;
            this.buttonLoad.Text = "Yaddaşdan yüklə";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(154, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRandom
            // 
            this.buttonRandom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRandom.Location = new System.Drawing.Point(382, 21);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(122, 49);
            this.buttonRandom.TabIndex = 10;
            this.buttonRandom.Text = "Təsadüfi rəqəm yarat";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonQrCode
            // 
            this.buttonQrCode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQrCode.Location = new System.Drawing.Point(382, 102);
            this.buttonQrCode.Name = "buttonQrCode";
            this.buttonQrCode.Size = new System.Drawing.Size(122, 21);
            this.buttonQrCode.TabIndex = 11;
            this.buttonQrCode.Text = "QR yarat";
            this.buttonQrCode.UseVisualStyleBackColor = true;
            this.buttonQrCode.Click += new System.EventHandler(this.buttonQrCode_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrint.Location = new System.Drawing.Point(418, 129);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(86, 21);
            this.buttonPrint.TabIndex = 12;
            this.buttonPrint.Text = "Çap et";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(3, 21);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(145, 22);
            this.textBoxInfo.TabIndex = 13;
            // 
            // USBBarcodeScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 420);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonQrCode);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.textBoxBarcodeNumber);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "USBBarcodeScannerForm";
            this.Text = "Barkod səhifəsi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxBarcodeNumber;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonQrCode;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.TextBox textBoxInfo;
    }
}
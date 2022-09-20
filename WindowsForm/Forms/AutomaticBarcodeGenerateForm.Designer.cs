namespace WindowsForm.Forms
{
    partial class AutomaticBarcodeGenerateForm
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
            this.trackBarHeight = new System.Windows.Forms.TrackBar();
            this.trackBarWith = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonQrCode = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonScan = new System.Windows.Forms.Button();
            this.textBoxBarcodeNumber = new System.Windows.Forms.TextBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWith)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarHeight
            // 
            this.trackBarHeight.Location = new System.Drawing.Point(143, 110);
            this.trackBarHeight.Name = "trackBarHeight";
            this.trackBarHeight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarHeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarHeight.Size = new System.Drawing.Size(45, 162);
            this.trackBarHeight.TabIndex = 31;
            this.trackBarHeight.Scroll += new System.EventHandler(this.trackBarHeight_Scroll);
            // 
            // trackBarWith
            // 
            this.trackBarWith.Location = new System.Drawing.Point(184, 68);
            this.trackBarWith.Name = "trackBarWith";
            this.trackBarWith.Size = new System.Drawing.Size(162, 45);
            this.trackBarWith.TabIndex = 30;
            this.trackBarWith.Scroll += new System.EventHandler(this.trackBarWith_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = ": Barkod";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = ": Say";
            // 
            // buttonQrCode
            // 
            this.buttonQrCode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQrCode.Location = new System.Drawing.Point(12, 95);
            this.buttonQrCode.Name = "buttonQrCode";
            this.buttonQrCode.Size = new System.Drawing.Size(122, 21);
            this.buttonQrCode.TabIndex = 25;
            this.buttonQrCode.Text = "QR yarat";
            this.buttonQrCode.UseVisualStyleBackColor = true;
            this.buttonQrCode.Click += new System.EventHandler(this.buttonQrCode_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRandom.Location = new System.Drawing.Point(12, 12);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(122, 51);
            this.buttonRandom.TabIndex = 24;
            this.buttonRandom.Text = "Təsadüfi rəqəm yarat";
            this.buttonRandom.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(194, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerate.Location = new System.Drawing.Point(12, 68);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(122, 21);
            this.buttonGenerate.TabIndex = 21;
            this.buttonGenerate.Text = "Barkod yarat";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(12, 149);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 21);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Yaddaşa yaz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonScan
            // 
            this.buttonScan.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonScan.Location = new System.Drawing.Point(12, 122);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(121, 21);
            this.buttonScan.TabIndex = 19;
            this.buttonScan.Text = "Skan et";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // textBoxBarcodeNumber
            // 
            this.textBoxBarcodeNumber.Location = new System.Drawing.Point(139, 12);
            this.textBoxBarcodeNumber.Name = "textBoxBarcodeNumber";
            this.textBoxBarcodeNumber.Size = new System.Drawing.Size(128, 23);
            this.textBoxBarcodeNumber.TabIndex = 18;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrint.Location = new System.Drawing.Point(12, 176);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(121, 21);
            this.buttonPrint.TabIndex = 26;
            this.buttonPrint.Text = "Çap et";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(223, 39);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(44, 23);
            this.textBoxCount.TabIndex = 32;
            // 
            // AutomaticBarcodeGenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.trackBarHeight);
            this.Controls.Add(this.trackBarWith);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonQrCode);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.textBoxBarcodeNumber);
            this.Name = "AutomaticBarcodeGenerateForm";
            this.Text = "AutomaticBarcodeGenerateForm";
            this.Load += new System.EventHandler(this.AutomaticBarcodeGenerateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWith)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarHeight;
        private System.Windows.Forms.TrackBar trackBarWith;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQrCode;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.TextBox textBoxBarcodeNumber;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.TextBox textBoxCount;
    }
}
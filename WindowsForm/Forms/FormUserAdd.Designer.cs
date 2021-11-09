
namespace WindowsForm.Forms
{
    partial class FormUserAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxAd = new System.Windows.Forms.TextBox();
            this.TextBoxSoyad = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.TextBoxSifre = new System.Windows.Forms.TextBox();
            this.TextBoxSifreTekrari = new System.Windows.Forms.TextBox();
            this.TextBoxFormUserAddAddress = new System.Windows.Forms.TextBox();
            this.ButtonEalveEt = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifrə";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şifrə təkrarı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres";
            // 
            // TextBoxAd
            // 
            this.TextBoxAd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxAd.Location = new System.Drawing.Point(119, 27);
            this.TextBoxAd.Name = "TextBoxAd";
            this.TextBoxAd.Size = new System.Drawing.Size(194, 22);
            this.TextBoxAd.TabIndex = 7;
            // 
            // TextBoxSoyad
            // 
            this.TextBoxSoyad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxSoyad.Location = new System.Drawing.Point(119, 70);
            this.TextBoxSoyad.Name = "TextBoxSoyad";
            this.TextBoxSoyad.Size = new System.Drawing.Size(194, 22);
            this.TextBoxSoyad.TabIndex = 8;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxEmail.Location = new System.Drawing.Point(119, 113);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(194, 22);
            this.TextBoxEmail.TabIndex = 9;
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(119, 156);
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(194, 22);
            this.TextBoxPhoneNumber.TabIndex = 10;
            // 
            // TextBoxSifre
            // 
            this.TextBoxSifre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxSifre.Location = new System.Drawing.Point(119, 199);
            this.TextBoxSifre.Name = "TextBoxSifre";
            this.TextBoxSifre.Size = new System.Drawing.Size(194, 22);
            this.TextBoxSifre.TabIndex = 11;
            // 
            // TextBoxSifreTekrari
            // 
            this.TextBoxSifreTekrari.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxSifreTekrari.Location = new System.Drawing.Point(119, 243);
            this.TextBoxSifreTekrari.Name = "TextBoxSifreTekrari";
            this.TextBoxSifreTekrari.Size = new System.Drawing.Size(194, 22);
            this.TextBoxSifreTekrari.TabIndex = 12;
            // 
            // TextBoxFormUserAddAddress
            // 
            this.TextBoxFormUserAddAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxFormUserAddAddress.Location = new System.Drawing.Point(119, 286);
            this.TextBoxFormUserAddAddress.Name = "TextBoxFormUserAddAddress";
            this.TextBoxFormUserAddAddress.Size = new System.Drawing.Size(194, 22);
            this.TextBoxFormUserAddAddress.TabIndex = 13;
            // 
            // ButtonEalveEt
            // 
            this.ButtonEalveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEalveEt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonEalveEt.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEalveEt.Image")));
            this.ButtonEalveEt.Location = new System.Drawing.Point(228, 317);
            this.ButtonEalveEt.Name = "ButtonEalveEt";
            this.ButtonEalveEt.Size = new System.Drawing.Size(85, 26);
            this.ButtonEalveEt.TabIndex = 14;
            this.ButtonEalveEt.Text = "Əlavə et";
            this.ButtonEalveEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonEalveEt.UseVisualStyleBackColor = true;
            this.ButtonEalveEt.Click += new System.EventHandler(this.ButtonFormUserAddEalveEt_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(328, 357);
            this.Controls.Add(this.ButtonEalveEt);
            this.Controls.Add(this.TextBoxFormUserAddAddress);
            this.Controls.Add(this.TextBoxSifreTekrari);
            this.Controls.Add(this.TextBoxSifre);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxSoyad);
            this.Controls.Add(this.TextBoxAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormUserAdd";
            this.Text = "İstifadəçi əlavə etmək səhifəsi";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxAd;
        private System.Windows.Forms.TextBox TextBoxSoyad;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxPhoneNumber;
        private System.Windows.Forms.TextBox TextBoxSifre;
        private System.Windows.Forms.TextBox TextBoxSifreTekrari;
        private System.Windows.Forms.TextBox TextBoxFormUserAddAddress;
        private System.Windows.Forms.Button ButtonEalveEt;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}
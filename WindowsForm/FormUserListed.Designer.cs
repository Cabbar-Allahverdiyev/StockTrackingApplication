
namespace WindowsForm
{
    partial class FormUserListed
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
            this.DataGridViewUserListed = new System.Windows.Forms.DataGridView();
            this.ButtonFormUserListedGuncelle = new System.Windows.Forms.Button();
            this.TextBoxFormUserListedAddress = new System.Windows.Forms.TextBox();
            this.TextBoxFormUserListedPhoneNumber = new System.Windows.Forms.TextBox();
            this.TextBoxFormUserListedEmail = new System.Windows.Forms.TextBox();
            this.TextBoxFormUserListedSoyad = new System.Windows.Forms.TextBox();
            this.TextBoxFormUserListedAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonFormUserListedSil = new System.Windows.Forms.Button();
            this.TextBoxFormUserListedAxtar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonAxtar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserListed)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewUserListed
            // 
            this.DataGridViewUserListed.AllowUserToAddRows = false;
            this.DataGridViewUserListed.AllowUserToDeleteRows = false;
            this.DataGridViewUserListed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewUserListed.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridViewUserListed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUserListed.Location = new System.Drawing.Point(213, 41);
            this.DataGridViewUserListed.Name = "DataGridViewUserListed";
            this.DataGridViewUserListed.ReadOnly = true;
            this.DataGridViewUserListed.RowTemplate.Height = 25;
            this.DataGridViewUserListed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewUserListed.Size = new System.Drawing.Size(701, 425);
            this.DataGridViewUserListed.TabIndex = 0;
            this.DataGridViewUserListed.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUserListed_CellDoubleClick);
            // 
            // ButtonFormUserListedGuncelle
            // 
            this.ButtonFormUserListedGuncelle.Location = new System.Drawing.Point(132, 222);
            this.ButtonFormUserListedGuncelle.Name = "ButtonFormUserListedGuncelle";
            this.ButtonFormUserListedGuncelle.Size = new System.Drawing.Size(75, 23);
            this.ButtonFormUserListedGuncelle.TabIndex = 29;
            this.ButtonFormUserListedGuncelle.Text = "Yenile";
            this.ButtonFormUserListedGuncelle.UseVisualStyleBackColor = true;
            this.ButtonFormUserListedGuncelle.Click += new System.EventHandler(this.ButtonFormUserListedGuncelle_Click);
            // 
            // TextBoxFormUserListedAddress
            // 
            this.TextBoxFormUserListedAddress.Location = new System.Drawing.Point(105, 193);
            this.TextBoxFormUserListedAddress.Name = "TextBoxFormUserListedAddress";
            this.TextBoxFormUserListedAddress.Size = new System.Drawing.Size(102, 23);
            this.TextBoxFormUserListedAddress.TabIndex = 28;
            // 
            // TextBoxFormUserListedPhoneNumber
            // 
            this.TextBoxFormUserListedPhoneNumber.Location = new System.Drawing.Point(105, 155);
            this.TextBoxFormUserListedPhoneNumber.Name = "TextBoxFormUserListedPhoneNumber";
            this.TextBoxFormUserListedPhoneNumber.Size = new System.Drawing.Size(102, 23);
            this.TextBoxFormUserListedPhoneNumber.TabIndex = 25;
            // 
            // TextBoxFormUserListedEmail
            // 
            this.TextBoxFormUserListedEmail.Location = new System.Drawing.Point(105, 117);
            this.TextBoxFormUserListedEmail.Name = "TextBoxFormUserListedEmail";
            this.TextBoxFormUserListedEmail.Size = new System.Drawing.Size(102, 23);
            this.TextBoxFormUserListedEmail.TabIndex = 24;
            // 
            // TextBoxFormUserListedSoyad
            // 
            this.TextBoxFormUserListedSoyad.Location = new System.Drawing.Point(105, 79);
            this.TextBoxFormUserListedSoyad.Name = "TextBoxFormUserListedSoyad";
            this.TextBoxFormUserListedSoyad.Size = new System.Drawing.Size(102, 23);
            this.TextBoxFormUserListedSoyad.TabIndex = 23;
            // 
            // TextBoxFormUserListedAd
            // 
            this.TextBoxFormUserListedAd.Location = new System.Drawing.Point(105, 41);
            this.TextBoxFormUserListedAd.Name = "TextBoxFormUserListedAd";
            this.TextBoxFormUserListedAd.Size = new System.Drawing.Size(102, 23);
            this.TextBoxFormUserListedAd.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad";
            // 
            // ButtonFormUserListedSil
            // 
            this.ButtonFormUserListedSil.Location = new System.Drawing.Point(920, 44);
            this.ButtonFormUserListedSil.Name = "ButtonFormUserListedSil";
            this.ButtonFormUserListedSil.Size = new System.Drawing.Size(75, 23);
            this.ButtonFormUserListedSil.TabIndex = 30;
            this.ButtonFormUserListedSil.Text = "Sil";
            this.ButtonFormUserListedSil.UseVisualStyleBackColor = true;
            this.ButtonFormUserListedSil.Click += new System.EventHandler(this.ButtonFormUserListedSil_Click);
            // 
            // TextBoxFormUserListedAxtar
            // 
            this.TextBoxFormUserListedAxtar.Location = new System.Drawing.Point(741, 15);
            this.TextBoxFormUserListedAxtar.Name = "TextBoxFormUserListedAxtar";
            this.TextBoxFormUserListedAxtar.Size = new System.Drawing.Size(173, 23);
            this.TextBoxFormUserListedAxtar.TabIndex = 31;
            this.TextBoxFormUserListedAxtar.TextChanged += new System.EventHandler(this.TextBoxFormUserListedAxtar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(698, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Axtar:";
            // 
            // ButtonAxtar
            // 
            this.ButtonAxtar.Location = new System.Drawing.Point(920, 15);
            this.ButtonAxtar.Name = "ButtonAxtar";
            this.ButtonAxtar.Size = new System.Drawing.Size(75, 23);
            this.ButtonAxtar.TabIndex = 33;
            this.ButtonAxtar.Text = "Axtar";
            this.ButtonAxtar.UseVisualStyleBackColor = true;
            this.ButtonAxtar.Click += new System.EventHandler(this.ButtonAxtar_Click);
            // 
            // FormUserListed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1012, 513);
            this.Controls.Add(this.ButtonAxtar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxFormUserListedAxtar);
            this.Controls.Add(this.ButtonFormUserListedSil);
            this.Controls.Add(this.ButtonFormUserListedGuncelle);
            this.Controls.Add(this.TextBoxFormUserListedAddress);
            this.Controls.Add(this.TextBoxFormUserListedPhoneNumber);
            this.Controls.Add(this.TextBoxFormUserListedEmail);
            this.Controls.Add(this.TextBoxFormUserListedSoyad);
            this.Controls.Add(this.TextBoxFormUserListedAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewUserListed);
            this.Name = "FormUserListed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Listed";
            this.Load += new System.EventHandler(this.FormUserListed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserListed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewUserListed;
        private System.Windows.Forms.Button ButtonFormUserListedGuncelle;
        private System.Windows.Forms.TextBox TextBoxFormUserListedAddress;
        private System.Windows.Forms.TextBox TextBoxFormUserListedPhoneNumber;
        private System.Windows.Forms.TextBox TextBoxFormUserListedEmail;
        private System.Windows.Forms.TextBox TextBoxFormUserListedSoyad;
        private System.Windows.Forms.TextBox TextBoxFormUserListedAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonFormUserListedSil;
        private System.Windows.Forms.TextBox TextBoxFormUserListedAxtar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonAxtar;
    }
}
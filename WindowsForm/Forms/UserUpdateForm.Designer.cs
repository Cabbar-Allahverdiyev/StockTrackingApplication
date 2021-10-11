
namespace WindowsForm.Forms
{
    partial class UserUpdateForm
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
            this.dataGridViewUserListed = new System.Windows.Forms.DataGridView();
            this.ButtonAxtar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxFormUserListedAxtar = new System.Windows.Forms.TextBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserListed)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonFormUserListedGuncelle
            // 
            this.ButtonFormUserListedGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFormUserListedGuncelle.Location = new System.Drawing.Point(134, 250);
            this.ButtonFormUserListedGuncelle.Name = "ButtonFormUserListedGuncelle";
            this.ButtonFormUserListedGuncelle.Size = new System.Drawing.Size(75, 23);
            this.ButtonFormUserListedGuncelle.TabIndex = 40;
            this.ButtonFormUserListedGuncelle.Text = "Yenile";
            this.ButtonFormUserListedGuncelle.UseVisualStyleBackColor = true;
            this.ButtonFormUserListedGuncelle.Click += new System.EventHandler(this.ButtonFormUserListedGuncelle_Click);
            // 
            // TextBoxFormUserListedAddress
            // 
            this.TextBoxFormUserListedAddress.Enabled = false;
            this.TextBoxFormUserListedAddress.Location = new System.Drawing.Point(107, 221);
            this.TextBoxFormUserListedAddress.Name = "TextBoxFormUserListedAddress";
            this.TextBoxFormUserListedAddress.Size = new System.Drawing.Size(102, 23);
            this.TextBoxFormUserListedAddress.TabIndex = 39;
            // 
            // TextBoxFormUserListedPhoneNumber
            // 
            this.TextBoxFormUserListedPhoneNumber.Enabled = false;
            this.TextBoxFormUserListedPhoneNumber.Location = new System.Drawing.Point(107, 183);
            this.TextBoxFormUserListedPhoneNumber.Name = "TextBoxFormUserListedPhoneNumber";
            this.TextBoxFormUserListedPhoneNumber.Size = new System.Drawing.Size(102, 23);
            this.TextBoxFormUserListedPhoneNumber.TabIndex = 38;
            // 
            // TextBoxFormUserListedEmail
            // 
            this.TextBoxFormUserListedEmail.Enabled = false;
            this.TextBoxFormUserListedEmail.Location = new System.Drawing.Point(107, 145);
            this.TextBoxFormUserListedEmail.Name = "TextBoxFormUserListedEmail";
            this.TextBoxFormUserListedEmail.Size = new System.Drawing.Size(102, 23);
            this.TextBoxFormUserListedEmail.TabIndex = 37;
            // 
            // TextBoxFormUserListedSoyad
            // 
            this.TextBoxFormUserListedSoyad.Enabled = false;
            this.TextBoxFormUserListedSoyad.Location = new System.Drawing.Point(107, 107);
            this.TextBoxFormUserListedSoyad.Name = "TextBoxFormUserListedSoyad";
            this.TextBoxFormUserListedSoyad.Size = new System.Drawing.Size(102, 23);
            this.TextBoxFormUserListedSoyad.TabIndex = 36;
            // 
            // TextBoxFormUserListedAd
            // 
            this.TextBoxFormUserListedAd.Enabled = false;
            this.TextBoxFormUserListedAd.Location = new System.Drawing.Point(107, 69);
            this.TextBoxFormUserListedAd.Name = "TextBoxFormUserListedAd";
            this.TextBoxFormUserListedAd.Size = new System.Drawing.Size(102, 23);
            this.TextBoxFormUserListedAd.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Phone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ad";
            // 
            // dataGridViewUserListed
            // 
            this.dataGridViewUserListed.AllowUserToAddRows = false;
            this.dataGridViewUserListed.AllowUserToDeleteRows = false;
            this.dataGridViewUserListed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUserListed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUserListed.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewUserListed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserListed.Location = new System.Drawing.Point(333, 41);
            this.dataGridViewUserListed.Name = "dataGridViewUserListed";
            this.dataGridViewUserListed.ReadOnly = true;
            this.dataGridViewUserListed.RowTemplate.Height = 25;
            this.dataGridViewUserListed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUserListed.Size = new System.Drawing.Size(378, 371);
            this.dataGridViewUserListed.TabIndex = 41;
            this.dataGridViewUserListed.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUserListed_CellDoubleClick);
            // 
            // ButtonAxtar
            // 
            this.ButtonAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAxtar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAxtar.Location = new System.Drawing.Point(636, 12);
            this.ButtonAxtar.Name = "ButtonAxtar";
            this.ButtonAxtar.Size = new System.Drawing.Size(75, 23);
            this.ButtonAxtar.TabIndex = 44;
            this.ButtonAxtar.Text = "Axtar";
            this.ButtonAxtar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "Axtar:";
            // 
            // TextBoxFormUserListedAxtar
            // 
            this.TextBoxFormUserListedAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFormUserListedAxtar.Location = new System.Drawing.Point(457, 12);
            this.TextBoxFormUserListedAxtar.Name = "TextBoxFormUserListedAxtar";
            this.TextBoxFormUserListedAxtar.Size = new System.Drawing.Size(173, 23);
            this.TextBoxFormUserListedAxtar.TabIndex = 42;
            this.TextBoxFormUserListedAxtar.TextChanged += new System.EventHandler(this.TextBoxFormUserListedAxtar_TextChanged);
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Enabled = false;
            this.textBoxUserId.Location = new System.Drawing.Point(107, 28);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(102, 23);
            this.textBoxUserId.TabIndex = 45;
            // 
            // UserUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 412);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.ButtonAxtar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxFormUserListedAxtar);
            this.Controls.Add(this.dataGridViewUserListed);
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
            this.MinimumSize = new System.Drawing.Size(650, 450);
            this.Name = "UserUpdateForm";
            this.Text = "UserUpdateForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserListed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dataGridViewUserListed;
        private System.Windows.Forms.Button ButtonAxtar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxFormUserListedAxtar;
        private System.Windows.Forms.TextBox textBoxUserId;
    }
}
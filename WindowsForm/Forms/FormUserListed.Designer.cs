
namespace WindowsForm.Forms
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
            this.dataGridViewUserListed = new System.Windows.Forms.DataGridView();
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
            this.textBoxFormUserListedAxtar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserListed)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUserListed
            // 
            this.dataGridViewUserListed.AllowUserToAddRows = false;
            this.dataGridViewUserListed.AllowUserToDeleteRows = false;
            this.dataGridViewUserListed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUserListed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUserListed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.dataGridViewUserListed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserListed.Location = new System.Drawing.Point(218, 42);
            this.dataGridViewUserListed.Name = "dataGridViewUserListed";
            this.dataGridViewUserListed.ReadOnly = true;
            this.dataGridViewUserListed.RowTemplate.Height = 25;
            this.dataGridViewUserListed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUserListed.Size = new System.Drawing.Size(782, 525);
            this.dataGridViewUserListed.TabIndex = 0;
            this.dataGridViewUserListed.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUserListed_CellDoubleClick);
            // 
            // TextBoxFormUserListedAddress
            // 
            this.TextBoxFormUserListedAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxFormUserListedAddress.Location = new System.Drawing.Point(105, 219);
            this.TextBoxFormUserListedAddress.Name = "TextBoxFormUserListedAddress";
            this.TextBoxFormUserListedAddress.Size = new System.Drawing.Size(102, 22);
            this.TextBoxFormUserListedAddress.TabIndex = 28;
            // 
            // TextBoxFormUserListedPhoneNumber
            // 
            this.TextBoxFormUserListedPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxFormUserListedPhoneNumber.Location = new System.Drawing.Point(105, 176);
            this.TextBoxFormUserListedPhoneNumber.Name = "TextBoxFormUserListedPhoneNumber";
            this.TextBoxFormUserListedPhoneNumber.Size = new System.Drawing.Size(102, 22);
            this.TextBoxFormUserListedPhoneNumber.TabIndex = 25;
            // 
            // TextBoxFormUserListedEmail
            // 
            this.TextBoxFormUserListedEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxFormUserListedEmail.Location = new System.Drawing.Point(105, 133);
            this.TextBoxFormUserListedEmail.Name = "TextBoxFormUserListedEmail";
            this.TextBoxFormUserListedEmail.Size = new System.Drawing.Size(102, 22);
            this.TextBoxFormUserListedEmail.TabIndex = 24;
            // 
            // TextBoxFormUserListedSoyad
            // 
            this.TextBoxFormUserListedSoyad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxFormUserListedSoyad.Location = new System.Drawing.Point(105, 90);
            this.TextBoxFormUserListedSoyad.Name = "TextBoxFormUserListedSoyad";
            this.TextBoxFormUserListedSoyad.Size = new System.Drawing.Size(102, 22);
            this.TextBoxFormUserListedSoyad.TabIndex = 23;
            // 
            // TextBoxFormUserListedAd
            // 
            this.TextBoxFormUserListedAd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxFormUserListedAd.Location = new System.Drawing.Point(105, 46);
            this.TextBoxFormUserListedAd.Name = "TextBoxFormUserListedAd";
            this.TextBoxFormUserListedAd.Size = new System.Drawing.Size(102, 22);
            this.TextBoxFormUserListedAd.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(7, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad";
            // 
            // textBoxFormUserListedAxtar
            // 
            this.textBoxFormUserListedAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFormUserListedAxtar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFormUserListedAxtar.Location = new System.Drawing.Point(827, 14);
            this.textBoxFormUserListedAxtar.Name = "textBoxFormUserListedAxtar";
            this.textBoxFormUserListedAxtar.Size = new System.Drawing.Size(173, 22);
            this.textBoxFormUserListedAxtar.TabIndex = 31;
            this.textBoxFormUserListedAxtar.TextChanged += new System.EventHandler(this.TextBoxFormUserListedAxtar_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(778, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Axtar:";
            // 
            // FormUserListed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1012, 581);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFormUserListedAxtar);
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
            this.Controls.Add(this.dataGridViewUserListed);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormUserListed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Listed";
            this.Load += new System.EventHandler(this.FormUserListed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserListed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUserListed;
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
        private System.Windows.Forms.TextBox textBoxFormUserListedAxtar;
        private System.Windows.Forms.Label label5;
    }
}
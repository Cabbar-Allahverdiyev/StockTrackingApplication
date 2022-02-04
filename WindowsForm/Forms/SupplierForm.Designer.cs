
namespace WindowsForm.Forms
{
    partial class SupplierForm
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
            this.textBoxSirketAdi = new System.Windows.Forms.TextBox();
            this.dataGridViewSupplierListed = new System.Windows.Forms.DataGridView();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNeZamanGelir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSeher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonElaveEt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplierListed)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şirkət adı:";
            // 
            // textBoxSirketAdi
            // 
            this.textBoxSirketAdi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSirketAdi.Location = new System.Drawing.Point(112, 21);
            this.textBoxSirketAdi.Name = "textBoxSirketAdi";
            this.textBoxSirketAdi.Size = new System.Drawing.Size(177, 22);
            this.textBoxSirketAdi.TabIndex = 2;
            // 
            // dataGridViewSupplierListed
            // 
            this.dataGridViewSupplierListed.AllowUserToAddRows = false;
            this.dataGridViewSupplierListed.AllowUserToDeleteRows = false;
            this.dataGridViewSupplierListed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSupplierListed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSupplierListed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.dataGridViewSupplierListed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplierListed.Location = new System.Drawing.Point(313, 40);
            this.dataGridViewSupplierListed.Name = "dataGridViewSupplierListed";
            this.dataGridViewSupplierListed.ReadOnly = true;
            this.dataGridViewSupplierListed.RowTemplate.Height = 25;
            this.dataGridViewSupplierListed.Size = new System.Drawing.Size(723, 557);
            this.dataGridViewSupplierListed.TabIndex = 3;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAd.Location = new System.Drawing.Point(112, 54);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(177, 22);
            this.textBoxAd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(77, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad:";
            // 
            // textBoxNeZamanGelir
            // 
            this.textBoxNeZamanGelir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNeZamanGelir.Location = new System.Drawing.Point(112, 86);
            this.textBoxNeZamanGelir.Name = "textBoxNeZamanGelir";
            this.textBoxNeZamanGelir.Size = new System.Drawing.Size(177, 22);
            this.textBoxNeZamanGelir.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nə zaman gəlir:";
            // 
            // textBoxSeher
            // 
            this.textBoxSeher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSeher.Location = new System.Drawing.Point(112, 119);
            this.textBoxSeher.Name = "textBoxSeher";
            this.textBoxSeher.Size = new System.Drawing.Size(177, 22);
            this.textBoxSeher.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(62, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adres:";
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAdres.Location = new System.Drawing.Point(112, 152);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(177, 22);
            this.textBoxAdres.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(63, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şəhər:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(112, 185);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(177, 22);
            this.textBoxEmail.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(63, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email:";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTelefon.Location = new System.Drawing.Point(112, 218);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(177, 22);
            this.textBoxTelefon.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(52, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefon:";
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(862, 12);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(143, 22);
            this.textBoxAxtar.TabIndex = 17;
            this.textBoxAxtar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizle.Image = global::WindowsForm.Properties.Resources.TemizleBlack;
            this.buttonTemizle.Location = new System.Drawing.Point(113, 246);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(85, 26);
            this.buttonTemizle.TabIndex = 26;
            this.buttonTemizle.Text = "Təmizlə";
            this.buttonTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonElaveEt
            // 
            this.buttonElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElaveEt.Image = global::WindowsForm.Properties.Resources.elaveEtBlack;
            this.buttonElaveEt.Location = new System.Drawing.Point(204, 246);
            this.buttonElaveEt.Name = "buttonElaveEt";
            this.buttonElaveEt.Size = new System.Drawing.Size(85, 26);
            this.buttonElaveEt.TabIndex = 25;
            this.buttonElaveEt.Text = "Əlavə et";
            this.buttonElaveEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonElaveEt.UseVisualStyleBackColor = true;
            this.buttonElaveEt.Click += new System.EventHandler(this.buttonElaveEt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSirketAdi);
            this.groupBox1.Controls.Add(this.buttonTemizle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonElaveEt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTelefon);
            this.groupBox1.Controls.Add(this.textBoxNeZamanGelir);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxSeher);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxAdres);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 282);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRefresh.ErrorImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Image = global::WindowsForm.Properties.Resources.refreshBlack_16px_;
            this.pictureBoxRefresh.InitialImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(1011, 12);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefresh.TabIndex = 34;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.label12.Location = new System.Drawing.Point(833, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "     ";
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1048, 635);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.dataGridViewSupplierListed);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "SupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tədarikçi əlavə etmə səhifəsi";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplierListed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSirketAdi;
        private System.Windows.Forms.DataGridView dataGridViewSupplierListed;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNeZamanGelir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSeher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonElaveEt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.Label label12;
    }
}
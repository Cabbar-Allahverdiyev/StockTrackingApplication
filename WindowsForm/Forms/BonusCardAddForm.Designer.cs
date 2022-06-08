
namespace WindowsForm.Forms
{
    partial class BonusCardAddForm
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
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGuzest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAxtar = new System.Windows.Forms.Button();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.groupBoxMusteri = new System.Windows.Forms.GroupBox();
            this.buttonSec = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonElaveEt = new System.Windows.Forms.Button();
            this.textBoxMusteriId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.groupBoxMusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(645, 14);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(138, 22);
            this.textBoxAxtar.TabIndex = 46;
            this.textBoxAxtar.TextChanged += new System.EventHandler(this.textBoxAxtar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(130, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "%";
            // 
            // textBoxGuzest
            // 
            this.textBoxGuzest.Location = new System.Drawing.Point(78, 151);
            this.textBoxGuzest.Name = "textBoxGuzest";
            this.textBoxGuzest.Size = new System.Drawing.Size(49, 22);
            this.textBoxGuzest.TabIndex = 44;
            this.textBoxGuzest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGuzest_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Güzəşt :";
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.Location = new System.Drawing.Point(78, 24);
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.Size = new System.Drawing.Size(176, 22);
            this.textBoxBarkod.TabIndex = 41;
            this.textBoxBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBonusCardBarcode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Barkod :";
            // 
            // buttonAxtar
            // 
            this.buttonAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAxtar.FlatAppearance.BorderSize = 0;
            this.buttonAxtar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAxtar.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.buttonAxtar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAxtar.Location = new System.Drawing.Point(619, 16);
            this.buttonAxtar.Name = "buttonAxtar";
            this.buttonAxtar.Size = new System.Drawing.Size(23, 22);
            this.buttonAxtar.TabIndex = 48;
            this.buttonAxtar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAxtar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            this.dataGridViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Location = new System.Drawing.Point(293, 45);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            this.dataGridViewList.RowTemplate.Height = 25;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(521, 465);
            this.dataGridViewList.TabIndex = 45;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Enabled = false;
            this.textBoxSoyad.Location = new System.Drawing.Point(78, 119);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(176, 22);
            this.textBoxSoyad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad :";
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRefresh.ErrorImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Image = global::WindowsForm.Properties.Resources.refreshBlack_16px_;
            this.pictureBoxRefresh.InitialImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(789, 14);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(25, 32);
            this.pictureBoxRefresh.TabIndex = 47;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Enabled = false;
            this.textBoxAd.Location = new System.Drawing.Point(78, 87);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(176, 22);
            this.textBoxAd.TabIndex = 3;
            // 
            // groupBoxMusteri
            // 
            this.groupBoxMusteri.Controls.Add(this.buttonSec);
            this.groupBoxMusteri.Controls.Add(this.buttonTemizle);
            this.groupBoxMusteri.Controls.Add(this.buttonElaveEt);
            this.groupBoxMusteri.Controls.Add(this.textBoxMusteriId);
            this.groupBoxMusteri.Controls.Add(this.label4);
            this.groupBoxMusteri.Controls.Add(this.label7);
            this.groupBoxMusteri.Controls.Add(this.textBoxGuzest);
            this.groupBoxMusteri.Controls.Add(this.label6);
            this.groupBoxMusteri.Controls.Add(this.textBoxBarkod);
            this.groupBoxMusteri.Controls.Add(this.label1);
            this.groupBoxMusteri.Controls.Add(this.textBoxSoyad);
            this.groupBoxMusteri.Controls.Add(this.textBoxAd);
            this.groupBoxMusteri.Controls.Add(this.label3);
            this.groupBoxMusteri.Controls.Add(this.label2);
            this.groupBoxMusteri.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxMusteri.Location = new System.Drawing.Point(11, 39);
            this.groupBoxMusteri.Name = "groupBoxMusteri";
            this.groupBoxMusteri.Size = new System.Drawing.Size(267, 235);
            this.groupBoxMusteri.TabIndex = 44;
            this.groupBoxMusteri.TabStop = false;
            // 
            // buttonSec
            // 
            this.buttonSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSec.Location = new System.Drawing.Point(210, 53);
            this.buttonSec.Name = "buttonSec";
            this.buttonSec.Size = new System.Drawing.Size(44, 27);
            this.buttonSec.TabIndex = 50;
            this.buttonSec.Text = "Seç";
            this.buttonSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSec.UseVisualStyleBackColor = true;
            this.buttonSec.Click += new System.EventHandler(this.buttonSec_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizle.Image = global::WindowsForm.Properties.Resources.TemizleBlack;
            this.buttonTemizle.Location = new System.Drawing.Point(78, 182);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(85, 29);
            this.buttonTemizle.TabIndex = 49;
            this.buttonTemizle.Text = "Təmizlə";
            this.buttonTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonElaveEt
            // 
            this.buttonElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElaveEt.Image = global::WindowsForm.Properties.Resources.elaveEtBlack;
            this.buttonElaveEt.Location = new System.Drawing.Point(169, 182);
            this.buttonElaveEt.Name = "buttonElaveEt";
            this.buttonElaveEt.Size = new System.Drawing.Size(85, 29);
            this.buttonElaveEt.TabIndex = 48;
            this.buttonElaveEt.Text = "Əlavə et";
            this.buttonElaveEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonElaveEt.UseVisualStyleBackColor = true;
            this.buttonElaveEt.Click += new System.EventHandler(this.buttonElaveEt_Click);
            // 
            // textBoxMusteriId
            // 
            this.textBoxMusteriId.Enabled = false;
            this.textBoxMusteriId.Location = new System.Drawing.Point(78, 56);
            this.textBoxMusteriId.Name = "textBoxMusteriId";
            this.textBoxMusteriId.Size = new System.Drawing.Size(126, 22);
            this.textBoxMusteriId.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "MusteriID :";
            // 
            // BonusCardAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(826, 524);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.buttonAxtar);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.groupBoxMusteri);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "BonusCardAddForm";
            this.Text = "BonusCardAddForm";
            this.Load += new System.EventHandler(this.BonusCardAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.groupBoxMusteri.ResumeLayout(false);
            this.groupBoxMusteri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGuzest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAxtar;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.GroupBox groupBoxMusteri;
        private System.Windows.Forms.TextBox textBoxMusteriId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonElaveEt;
        private System.Windows.Forms.Button buttonSec;
    }
}
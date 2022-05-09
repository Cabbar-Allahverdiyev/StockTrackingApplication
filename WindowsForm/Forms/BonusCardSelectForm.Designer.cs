
namespace WindowsForm.Forms
{
    partial class BonusCardSelectForm
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
            this.groupBoxMusteri = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGuzest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBonusCardBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBonusCardId = new System.Windows.Forms.TextBox();
            this.buttonSec = new System.Windows.Forms.Button();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.buttonAxtar = new System.Windows.Forms.Button();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.groupBoxMusteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMusteri
            // 
            this.groupBoxMusteri.Controls.Add(this.label7);
            this.groupBoxMusteri.Controls.Add(this.textBoxGuzest);
            this.groupBoxMusteri.Controls.Add(this.label6);
            this.groupBoxMusteri.Controls.Add(this.label5);
            this.groupBoxMusteri.Controls.Add(this.textBoxBonusCardBarcode);
            this.groupBoxMusteri.Controls.Add(this.label1);
            this.groupBoxMusteri.Controls.Add(this.textBoxBonusCardId);
            this.groupBoxMusteri.Controls.Add(this.buttonSec);
            this.groupBoxMusteri.Controls.Add(this.textBoxBalance);
            this.groupBoxMusteri.Controls.Add(this.textBoxSoyad);
            this.groupBoxMusteri.Controls.Add(this.textBoxAd);
            this.groupBoxMusteri.Controls.Add(this.label4);
            this.groupBoxMusteri.Controls.Add(this.label3);
            this.groupBoxMusteri.Controls.Add(this.label2);
            this.groupBoxMusteri.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxMusteri.Location = new System.Drawing.Point(12, 44);
            this.groupBoxMusteri.Name = "groupBoxMusteri";
            this.groupBoxMusteri.Size = new System.Drawing.Size(244, 251);
            this.groupBoxMusteri.TabIndex = 9;
            this.groupBoxMusteri.TabStop = false;
            this.groupBoxMusteri.Enter += new System.EventHandler(this.groupBoxMusteri_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(133, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "%";
            // 
            // textBoxGuzest
            // 
            this.textBoxGuzest.Enabled = false;
            this.textBoxGuzest.Location = new System.Drawing.Point(78, 173);
            this.textBoxGuzest.Name = "textBoxGuzest";
            this.textBoxGuzest.Size = new System.Drawing.Size(49, 22);
            this.textBoxGuzest.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Güzəşt :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Bonus :";
            // 
            // textBoxBonusCardBarcode
            // 
            this.textBoxBonusCardBarcode.Enabled = false;
            this.textBoxBonusCardBarcode.Location = new System.Drawing.Point(78, 48);
            this.textBoxBonusCardBarcode.Name = "textBoxBonusCardBarcode";
            this.textBoxBonusCardBarcode.Size = new System.Drawing.Size(160, 22);
            this.textBoxBonusCardBarcode.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Barkod :";
            // 
            // textBoxBonusCardId
            // 
            this.textBoxBonusCardId.Enabled = false;
            this.textBoxBonusCardId.Location = new System.Drawing.Point(78, 18);
            this.textBoxBonusCardId.Name = "textBoxBonusCardId";
            this.textBoxBonusCardId.Size = new System.Drawing.Size(160, 22);
            this.textBoxBonusCardId.TabIndex = 39;
            // 
            // buttonSec
            // 
            this.buttonSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSec.Image = global::WindowsForm.Properties.Resources.choose_page_16px;
            this.buttonSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSec.Location = new System.Drawing.Point(150, 207);
            this.buttonSec.Name = "buttonSec";
            this.buttonSec.Size = new System.Drawing.Size(88, 28);
            this.buttonSec.TabIndex = 38;
            this.buttonSec.Text = "  Seç";
            this.buttonSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSec.UseVisualStyleBackColor = true;
            this.buttonSec.Click += new System.EventHandler(this.buttonSec_Click);
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Enabled = false;
            this.textBoxBalance.Location = new System.Drawing.Point(78, 145);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(160, 22);
            this.textBoxBalance.TabIndex = 5;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Enabled = false;
            this.textBoxSoyad.Location = new System.Drawing.Point(78, 111);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(160, 22);
            this.textBoxSoyad.TabIndex = 4;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Enabled = false;
            this.textBoxAd.Location = new System.Drawing.Point(78, 80);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(160, 22);
            this.textBoxAd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Movcud ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad :";
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
            this.dataGridViewList.Location = new System.Drawing.Point(262, 50);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            this.dataGridViewList.RowTemplate.Height = 25;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(542, 346);
            this.dataGridViewList.TabIndex = 10;
            this.dataGridViewList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellDoubleClick);
            // 
            // buttonAxtar
            // 
            this.buttonAxtar.FlatAppearance.BorderSize = 0;
            this.buttonAxtar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAxtar.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.buttonAxtar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAxtar.Location = new System.Drawing.Point(617, 24);
            this.buttonAxtar.Name = "buttonAxtar";
            this.buttonAxtar.Size = new System.Drawing.Size(23, 19);
            this.buttonAxtar.TabIndex = 43;
            this.buttonAxtar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAxtar.UseVisualStyleBackColor = true;
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRefresh.ErrorImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Image = global::WindowsForm.Properties.Resources.refreshBlack_16px_;
            this.pictureBoxRefresh.InitialImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(787, 22);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(25, 28);
            this.pictureBoxRefresh.TabIndex = 42;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(643, 22);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(138, 22);
            this.textBoxAxtar.TabIndex = 41;
            this.textBoxAxtar.TextChanged += new System.EventHandler(this.textBoxAxtar_TextChanged);
            // 
            // BonusCardSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(816, 510);
            this.Controls.Add(this.buttonAxtar);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.groupBoxMusteri);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "BonusCardSelectForm";
            this.Text = "BonusCardSelectForm";
            this.Load += new System.EventHandler(this.BonusCardSelectForm_Load);
            this.groupBoxMusteri.ResumeLayout(false);
            this.groupBoxMusteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMusteri;
        private System.Windows.Forms.TextBox textBoxBonusCardId;
        private System.Windows.Forms.Button buttonSec;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button buttonAxtar;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBonusCardBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGuzest;
        private System.Windows.Forms.Label label6;
    }
}
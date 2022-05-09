
namespace WindowsForm.Forms
{
    partial class CustomerSelectForm
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
            this.buttonAxtar = new System.Windows.Forms.Button();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.groupBoxMusteri = new System.Windows.Forms.GroupBox();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.buttonSec = new System.Windows.Forms.Button();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.groupBoxMusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAxtar
            // 
            this.buttonAxtar.FlatAppearance.BorderSize = 0;
            this.buttonAxtar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAxtar.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.buttonAxtar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAxtar.Location = new System.Drawing.Point(618, 16);
            this.buttonAxtar.Name = "buttonAxtar";
            this.buttonAxtar.Size = new System.Drawing.Size(23, 22);
            this.buttonAxtar.TabIndex = 48;
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
            this.pictureBoxRefresh.Location = new System.Drawing.Point(788, 14);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(25, 32);
            this.pictureBoxRefresh.TabIndex = 47;
            this.pictureBoxRefresh.TabStop = false;
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(644, 14);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(138, 22);
            this.textBoxAxtar.TabIndex = 46;
            this.textBoxAxtar.TextChanged += new System.EventHandler(this.textBoxAxtar_TextChanged);
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
            this.dataGridViewList.Location = new System.Drawing.Point(263, 45);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            this.dataGridViewList.RowTemplate.Height = 25;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(542, 392);
            this.dataGridViewList.TabIndex = 45;
            this.dataGridViewList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellDoubleClick);
            // 
            // groupBoxMusteri
            // 
            this.groupBoxMusteri.Controls.Add(this.textBoxCustomerId);
            this.groupBoxMusteri.Controls.Add(this.buttonSec);
            this.groupBoxMusteri.Controls.Add(this.textBoxSoyad);
            this.groupBoxMusteri.Controls.Add(this.textBoxAd);
            this.groupBoxMusteri.Controls.Add(this.label3);
            this.groupBoxMusteri.Controls.Add(this.label2);
            this.groupBoxMusteri.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxMusteri.Location = new System.Drawing.Point(13, 39);
            this.groupBoxMusteri.Name = "groupBoxMusteri";
            this.groupBoxMusteri.Size = new System.Drawing.Size(244, 168);
            this.groupBoxMusteri.TabIndex = 44;
            this.groupBoxMusteri.TabStop = false;
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Enabled = false;
            this.textBoxCustomerId.Location = new System.Drawing.Point(78, 20);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(160, 22);
            this.textBoxCustomerId.TabIndex = 39;
            // 
            // buttonSec
            // 
            this.buttonSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSec.Image = global::WindowsForm.Properties.Resources.choose_page_16px;
            this.buttonSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSec.Location = new System.Drawing.Point(150, 119);
            this.buttonSec.Name = "buttonSec";
            this.buttonSec.Size = new System.Drawing.Size(88, 32);
            this.buttonSec.TabIndex = 38;
            this.buttonSec.Text = "  Seç";
            this.buttonSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSec.UseVisualStyleBackColor = true;
            this.buttonSec.Click += new System.EventHandler(this.buttonSec_Click);
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Enabled = false;
            this.textBoxSoyad.Location = new System.Drawing.Point(78, 87);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(160, 22);
            this.textBoxSoyad.TabIndex = 4;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Enabled = false;
            this.textBoxAd.Location = new System.Drawing.Point(78, 52);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(160, 22);
            this.textBoxAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad :";
            // 
            // CustomerSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(825, 496);
            this.Controls.Add(this.buttonAxtar);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.groupBoxMusteri);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CustomerSelectForm";
            this.Text = "CustomerSelectForm";
            this.Load += new System.EventHandler(this.CustomerSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.groupBoxMusteri.ResumeLayout(false);
            this.groupBoxMusteri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAxtar;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.GroupBox groupBoxMusteri;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Button buttonSec;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
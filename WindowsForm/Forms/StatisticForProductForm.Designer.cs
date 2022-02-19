
namespace WindowsForm.Forms
{
    partial class StatisticForProductForm
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
            this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
            this.buttonEnCoxSatilan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBitenler = new System.Windows.Forms.Button();
            this.buttonSatilmayan = new System.Windows.Forms.Button();
            this.buttonAzalan = new System.Windows.Forms.Button();
            this.comboBoxAxtar = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductList
            // 
            this.dataGridViewProductList.AllowUserToAddRows = false;
            this.dataGridViewProductList.AllowUserToDeleteRows = false;
            this.dataGridViewProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.dataGridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductList.Location = new System.Drawing.Point(218, 40);
            this.dataGridViewProductList.Name = "dataGridViewProductList";
            this.dataGridViewProductList.ReadOnly = true;
            this.dataGridViewProductList.RowTemplate.Height = 25;
            this.dataGridViewProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductList.Size = new System.Drawing.Size(727, 305);
            this.dataGridViewProductList.TabIndex = 2;
            // 
            // buttonEnCoxSatilan
            // 
            this.buttonEnCoxSatilan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnCoxSatilan.Image = global::WindowsForm.Properties.Resources.choose_page_16px;
            this.buttonEnCoxSatilan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnCoxSatilan.Location = new System.Drawing.Point(118, 14);
            this.buttonEnCoxSatilan.Name = "buttonEnCoxSatilan";
            this.buttonEnCoxSatilan.Size = new System.Drawing.Size(50, 25);
            this.buttonEnCoxSatilan.TabIndex = 39;
            this.buttonEnCoxSatilan.Text = "  ";
            this.buttonEnCoxSatilan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEnCoxSatilan.UseVisualStyleBackColor = true;
            this.buttonEnCoxSatilan.Click += new System.EventHandler(this.buttonEnCoxSatilan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ən çox satılanlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Satılmayanlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Bitənlər";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "ən son nə zaman satılıb";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Azalanlar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAzalan);
            this.groupBox1.Controls.Add(this.buttonSatilmayan);
            this.groupBox1.Controls.Add(this.buttonBitenler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonEnCoxSatilan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 197);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // buttonBitenler
            // 
            this.buttonBitenler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBitenler.Image = global::WindowsForm.Properties.Resources.choose_page_16px;
            this.buttonBitenler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBitenler.Location = new System.Drawing.Point(118, 107);
            this.buttonBitenler.Name = "buttonBitenler";
            this.buttonBitenler.Size = new System.Drawing.Size(50, 25);
            this.buttonBitenler.TabIndex = 45;
            this.buttonBitenler.Text = "  ";
            this.buttonBitenler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBitenler.UseVisualStyleBackColor = true;
            this.buttonBitenler.Click += new System.EventHandler(this.buttonBitenler_Click);
            // 
            // buttonSatilmayan
            // 
            this.buttonSatilmayan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSatilmayan.Image = global::WindowsForm.Properties.Resources.choose_page_16px;
            this.buttonSatilmayan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSatilmayan.Location = new System.Drawing.Point(118, 76);
            this.buttonSatilmayan.Name = "buttonSatilmayan";
            this.buttonSatilmayan.Size = new System.Drawing.Size(50, 25);
            this.buttonSatilmayan.TabIndex = 46;
            this.buttonSatilmayan.Text = "  ";
            this.buttonSatilmayan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSatilmayan.UseVisualStyleBackColor = true;
            this.buttonSatilmayan.Click += new System.EventHandler(this.buttonSatilmayan_Click);
            // 
            // buttonAzalan
            // 
            this.buttonAzalan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAzalan.Image = global::WindowsForm.Properties.Resources.choose_page_16px;
            this.buttonAzalan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAzalan.Location = new System.Drawing.Point(118, 45);
            this.buttonAzalan.Name = "buttonAzalan";
            this.buttonAzalan.Size = new System.Drawing.Size(50, 25);
            this.buttonAzalan.TabIndex = 47;
            this.buttonAzalan.Text = "  ";
            this.buttonAzalan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAzalan.UseVisualStyleBackColor = true;
            this.buttonAzalan.Click += new System.EventHandler(this.buttonAzalan_Click);
            // 
            // comboBoxAxtar
            // 
            this.comboBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAxtar.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAxtar.FormattingEnabled = true;
            this.comboBoxAxtar.Location = new System.Drawing.Point(842, 12);
            this.comboBoxAxtar.Name = "comboBoxAxtar";
            this.comboBoxAxtar.Size = new System.Drawing.Size(71, 21);
            this.comboBoxAxtar.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.label12.Location = new System.Drawing.Point(669, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 17);
            this.label12.TabIndex = 48;
            this.label12.Text = "     ";
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(698, 12);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(138, 22);
            this.textBoxAxtar.TabIndex = 47;
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRefresh.ErrorImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Image = global::WindowsForm.Properties.Resources.refreshBlack_16px_;
            this.pictureBoxRefresh.InitialImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(920, 12);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefresh.TabIndex = 46;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // StatisticForProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(957, 510);
            this.Controls.Add(this.comboBoxAxtar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewProductList);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "StatisticForProductForm";
            this.Text = "Məhsul üçün statistika səhifəsi";
            this.Load += new System.EventHandler(this.StatisticForProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductList;
        private System.Windows.Forms.Button buttonEnCoxSatilan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAzalan;
        private System.Windows.Forms.Button buttonSatilmayan;
        private System.Windows.Forms.Button buttonBitenler;
        private System.Windows.Forms.ComboBox comboBoxAxtar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
    }
}
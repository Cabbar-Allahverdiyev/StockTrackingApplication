
namespace WindowsForm.Forms
{
    partial class ProductUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUpdateForm));
            this.GroupBoxVarOlanMehsul = new System.Windows.Forms.GroupBox();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.TextBoxAciqlama = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxTedarikci = new System.Windows.Forms.ComboBox();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.comboBoxKateqoriya = new System.Windows.Forms.ComboBox();
            this.LabelMiqdarVB = new System.Windows.Forms.Label();
            this.buttonYenile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSatisQiymet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAlisQiymet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxStokaElaveEdilecekMiqdar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxBarkodNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxMehsulAdi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewPrdouctList = new System.Windows.Forms.DataGridView();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBoxVarOlanMehsul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrdouctList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxVarOlanMehsul
            // 
            this.GroupBoxVarOlanMehsul.Controls.Add(this.buttonTemizle);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label17);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.TextBoxAciqlama);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label15);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.comboBoxTedarikci);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.comboBoxMarka);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.comboBoxKateqoriya);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.LabelMiqdarVB);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.buttonYenile);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label7);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxSatisQiymet);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label8);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxAlisQiymet);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label9);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label10);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxStokaElaveEdilecekMiqdar);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label11);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxBarkodNo);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label12);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxMehsulAdi);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label13);
            this.GroupBoxVarOlanMehsul.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxVarOlanMehsul.Location = new System.Drawing.Point(21, 45);
            this.GroupBoxVarOlanMehsul.Name = "GroupBoxVarOlanMehsul";
            this.GroupBoxVarOlanMehsul.Size = new System.Drawing.Size(281, 410);
            this.GroupBoxVarOlanMehsul.TabIndex = 3;
            this.GroupBoxVarOlanMehsul.TabStop = false;
            this.GroupBoxVarOlanMehsul.Text = "Var olan məhsul";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTemizle.Image = global::WindowsForm.Properties.Resources.TemizleBlack;
            this.buttonTemizle.Location = new System.Drawing.Point(96, 316);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(85, 25);
            this.buttonTemizle.TabIndex = 29;
            this.buttonTemizle.Text = " Təmizlə";
            this.buttonTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(25, 291);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 14);
            this.label17.TabIndex = 27;
            this.label17.Text = "Açıqlama:";
            // 
            // TextBoxAciqlama
            // 
            this.TextBoxAciqlama.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxAciqlama.Location = new System.Drawing.Point(96, 288);
            this.TextBoxAciqlama.Name = "TextBoxAciqlama";
            this.TextBoxAciqlama.Size = new System.Drawing.Size(179, 22);
            this.TextBoxAciqlama.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(30, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 14);
            this.label15.TabIndex = 25;
            this.label15.Text = "Tedarikçi:";
            // 
            // comboBoxTedarikci
            // 
            this.comboBoxTedarikci.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTedarikci.FormattingEnabled = true;
            this.comboBoxTedarikci.Location = new System.Drawing.Point(96, 124);
            this.comboBoxTedarikci.Name = "comboBoxTedarikci";
            this.comboBoxTedarikci.Size = new System.Drawing.Size(177, 22);
            this.comboBoxTedarikci.TabIndex = 24;
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Location = new System.Drawing.Point(96, 91);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(177, 22);
            this.comboBoxMarka.TabIndex = 23;
            // 
            // comboBoxKateqoriya
            // 
            this.comboBoxKateqoriya.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxKateqoriya.FormattingEnabled = true;
            this.comboBoxKateqoriya.Location = new System.Drawing.Point(96, 58);
            this.comboBoxKateqoriya.Name = "comboBoxKateqoriya";
            this.comboBoxKateqoriya.Size = new System.Drawing.Size(177, 22);
            this.comboBoxKateqoriya.TabIndex = 22;
            // 
            // LabelMiqdarVB
            // 
            this.LabelMiqdarVB.AutoSize = true;
            this.LabelMiqdarVB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelMiqdarVB.ForeColor = System.Drawing.Color.Firebrick;
            this.LabelMiqdarVB.Location = new System.Drawing.Point(5, 321);
            this.LabelMiqdarVB.Name = "LabelMiqdarVB";
            this.LabelMiqdarVB.Size = new System.Drawing.Size(19, 21);
            this.LabelMiqdarVB.TabIndex = 21;
            this.LabelMiqdarVB.Text = "#";
            // 
            // buttonYenile
            // 
            this.buttonYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYenile.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonYenile.Image = ((System.Drawing.Image)(resources.GetObject("buttonYenile.Image")));
            this.buttonYenile.Location = new System.Drawing.Point(190, 316);
            this.buttonYenile.Name = "buttonYenile";
            this.buttonYenile.Size = new System.Drawing.Size(85, 25);
            this.buttonYenile.TabIndex = 3;
            this.buttonYenile.Text = "Yenilə";
            this.buttonYenile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonYenile.UseVisualStyleBackColor = true;
            this.buttonYenile.Click += new System.EventHandler(this.ButtonVarOlanYenile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "Satiş qiyməti:";
            // 
            // textBoxSatisQiymet
            // 
            this.textBoxSatisQiymet.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSatisQiymet.Location = new System.Drawing.Point(96, 255);
            this.textBoxSatisQiymet.Name = "textBoxSatisQiymet";
            this.textBoxSatisQiymet.Size = new System.Drawing.Size(179, 22);
            this.textBoxSatisQiymet.TabIndex = 15;
            this.textBoxSatisQiymet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSatisQiymet_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(17, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 14);
            this.label8.TabIndex = 19;
            this.label8.Text = "Aliş qiyməti:";
            // 
            // textBoxAlisQiymet
            // 
            this.textBoxAlisQiymet.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAlisQiymet.Location = new System.Drawing.Point(96, 222);
            this.textBoxAlisQiymet.Name = "textBoxAlisQiymet";
            this.textBoxAlisQiymet.Size = new System.Drawing.Size(179, 22);
            this.textBoxAlisQiymet.TabIndex = 7;
            this.textBoxAlisQiymet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlisQiymet_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(4, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "Əlavə miqdar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(21, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 14);
            this.label10.TabIndex = 17;
            this.label10.Text = "Məhsul adı:";
            // 
            // textBoxStokaElaveEdilecekMiqdar
            // 
            this.textBoxStokaElaveEdilecekMiqdar.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStokaElaveEdilecekMiqdar.Location = new System.Drawing.Point(96, 189);
            this.textBoxStokaElaveEdilecekMiqdar.Name = "textBoxStokaElaveEdilecekMiqdar";
            this.textBoxStokaElaveEdilecekMiqdar.Size = new System.Drawing.Size(179, 22);
            this.textBoxStokaElaveEdilecekMiqdar.TabIndex = 6;
            this.textBoxStokaElaveEdilecekMiqdar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStokaElaveEdilecekMiqdar_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(46, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 14);
            this.label11.TabIndex = 16;
            this.label11.Text = "Marka:";
            // 
            // textBoxBarkodNo
            // 
            this.textBoxBarkodNo.Enabled = false;
            this.textBoxBarkodNo.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBarkodNo.Location = new System.Drawing.Point(96, 25);
            this.textBoxBarkodNo.Name = "textBoxBarkodNo";
            this.textBoxBarkodNo.Size = new System.Drawing.Size(179, 22);
            this.textBoxBarkodNo.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(18, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 14);
            this.label12.TabIndex = 15;
            this.label12.Text = "Kategoriya:";
            // 
            // textBoxMehsulAdi
            // 
            this.textBoxMehsulAdi.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMehsulAdi.Location = new System.Drawing.Point(96, 156);
            this.textBoxMehsulAdi.Name = "textBoxMehsulAdi";
            this.textBoxMehsulAdi.Size = new System.Drawing.Size(179, 22);
            this.textBoxMehsulAdi.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(25, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 14);
            this.label13.TabIndex = 14;
            this.label13.Text = "BarkodNo:";
            // 
            // dataGridViewPrdouctList
            // 
            this.dataGridViewPrdouctList.AllowUserToAddRows = false;
            this.dataGridViewPrdouctList.AllowUserToDeleteRows = false;
            this.dataGridViewPrdouctList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPrdouctList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.dataGridViewPrdouctList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrdouctList.Location = new System.Drawing.Point(308, 45);
            this.dataGridViewPrdouctList.Name = "dataGridViewPrdouctList";
            this.dataGridViewPrdouctList.ReadOnly = true;
            this.dataGridViewPrdouctList.RowTemplate.Height = 25;
            this.dataGridViewPrdouctList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrdouctList.Size = new System.Drawing.Size(613, 474);
            this.dataGridViewPrdouctList.TabIndex = 4;
            this.dataGridViewPrdouctList.DoubleClick += new System.EventHandler(this.dataGridViewFormPrdouctList_DoubleClick);
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(745, 12);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(145, 22);
            this.textBoxAxtar.TabIndex = 8;
            this.textBoxAxtar.TextChanged += new System.EventHandler(this.textBoxAxtar_TextChanged);
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRefresh.ErrorImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Image = global::WindowsForm.Properties.Resources.refreshBlack_16px_;
            this.pictureBoxRefresh.InitialImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(896, 12);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefresh.TabIndex = 32;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.label1.Location = new System.Drawing.Point(716, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "     ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(933, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.dataGridViewPrdouctList);
            this.Controls.Add(this.GroupBoxVarOlanMehsul);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ProductUpdateForm";
            this.Text = "Məhsul yeniləmə səhifəsi";
            this.Load += new System.EventHandler(this.ProductUpdateForm_Load);
            this.GroupBoxVarOlanMehsul.ResumeLayout(false);
            this.GroupBoxVarOlanMehsul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrdouctList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxVarOlanMehsul;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TextBoxAciqlama;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxTedarikci;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.ComboBox comboBoxKateqoriya;
        private System.Windows.Forms.Label LabelMiqdarVB;
        private System.Windows.Forms.Button buttonYenile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSatisQiymet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAlisQiymet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxStokaElaveEdilecekMiqdar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxBarkodNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxMehsulAdi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewPrdouctList;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.Label label1;
    }
}
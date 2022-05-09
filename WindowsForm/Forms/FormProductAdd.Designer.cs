
namespace WindowsForm.Forms
{
    partial class FormProductAdd
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
            this.GroupBoxFormProductAddYeniMehsul = new System.Windows.Forms.GroupBox();
            this.buttonBarcodeGenerate = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.pictureBoxProductImage = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxAciqlama = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxKemiyyet = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxTedarikci = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonElaveEt = new System.Windows.Forms.Button();
            this.textBoxMehsulAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKategoriya = new System.Windows.Forms.ComboBox();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.textBoxSatisQiymet = new System.Windows.Forms.TextBox();
            this.textBoxAlisQiymet = new System.Windows.Forms.TextBox();
            this.textBoxMiqdar = new System.Windows.Forms.TextBox();
            this.textBoxBarkodNo = new System.Windows.Forms.TextBox();
            this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.GroupBoxFormProductAddYeniMehsul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxFormProductAddYeniMehsul
            // 
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.buttonBarcodeGenerate);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.buttonTemizle);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.pictureBoxProductImage);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.label17);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.textBoxAciqlama);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.label16);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.textBoxKemiyyet);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.label15);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.comboBoxTedarikci);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.label14);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.buttonElaveEt);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.textBoxMehsulAdi);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.label6);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.label5);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.label4);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.label3);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.label2);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.label1);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.comboBoxKategoriya);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.comboBoxMarka);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.textBoxSatisQiymet);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.textBoxAlisQiymet);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.textBoxMiqdar);
            this.GroupBoxFormProductAddYeniMehsul.Controls.Add(this.textBoxBarkodNo);
            this.GroupBoxFormProductAddYeniMehsul.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBoxFormProductAddYeniMehsul.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxFormProductAddYeniMehsul.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxFormProductAddYeniMehsul.Name = "GroupBoxFormProductAddYeniMehsul";
            this.GroupBoxFormProductAddYeniMehsul.Size = new System.Drawing.Size(313, 619);
            this.GroupBoxFormProductAddYeniMehsul.TabIndex = 0;
            this.GroupBoxFormProductAddYeniMehsul.TabStop = false;
            // 
            // buttonBarcodeGenerate
            // 
            this.buttonBarcodeGenerate.FlatAppearance.BorderSize = 0;
            this.buttonBarcodeGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarcodeGenerate.Image = global::WindowsForm.Properties.Resources.refresh_barcode_16px;
            this.buttonBarcodeGenerate.Location = new System.Drawing.Point(279, 172);
            this.buttonBarcodeGenerate.Name = "buttonBarcodeGenerate";
            this.buttonBarcodeGenerate.Size = new System.Drawing.Size(27, 26);
            this.buttonBarcodeGenerate.TabIndex = 25;
            this.buttonBarcodeGenerate.UseVisualStyleBackColor = true;
            this.buttonBarcodeGenerate.Click += new System.EventHandler(this.buttonBarcodeGenerate_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizle.Image = global::WindowsForm.Properties.Resources.TemizleBlack;
            this.buttonTemizle.Location = new System.Drawing.Point(97, 501);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(85, 26);
            this.buttonTemizle.TabIndex = 24;
            this.buttonTemizle.Text = "Təmizlə";
            this.buttonTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // pictureBoxProductImage
            // 
            this.pictureBoxProductImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxProductImage.Location = new System.Drawing.Point(3, 18);
            this.pictureBoxProductImage.Name = "pictureBoxProductImage";
            this.pictureBoxProductImage.Size = new System.Drawing.Size(307, 138);
            this.pictureBoxProductImage.TabIndex = 0;
            this.pictureBoxProductImage.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 473);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 17);
            this.label17.TabIndex = 19;
            this.label17.Text = "Açiqlama:";
            // 
            // textBoxAciqlama
            // 
            this.textBoxAciqlama.Location = new System.Drawing.Point(99, 469);
            this.textBoxAciqlama.Name = "textBoxAciqlama";
            this.textBoxAciqlama.Size = new System.Drawing.Size(174, 22);
            this.textBoxAciqlama.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 440);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 17);
            this.label16.TabIndex = 17;
            this.label16.Text = "Kəmiyyət:";
            // 
            // textBoxKemiyyet
            // 
            this.textBoxKemiyyet.Location = new System.Drawing.Point(99, 437);
            this.textBoxKemiyyet.Name = "textBoxKemiyyet";
            this.textBoxKemiyyet.Size = new System.Drawing.Size(174, 22);
            this.textBoxKemiyyet.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 276);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "Tedarikçi:";
            // 
            // comboBoxTedarikci
            // 
            this.comboBoxTedarikci.FormattingEnabled = true;
            this.comboBoxTedarikci.Location = new System.Drawing.Point(99, 272);
            this.comboBoxTedarikci.Name = "comboBoxTedarikci";
            this.comboBoxTedarikci.Size = new System.Drawing.Size(174, 25);
            this.comboBoxTedarikci.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 407);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Satiş qiyməti:";
            // 
            // buttonElaveEt
            // 
            this.buttonElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElaveEt.Image = global::WindowsForm.Properties.Resources.elaveEtBlack;
            this.buttonElaveEt.Location = new System.Drawing.Point(188, 501);
            this.buttonElaveEt.Name = "buttonElaveEt";
            this.buttonElaveEt.Size = new System.Drawing.Size(85, 26);
            this.buttonElaveEt.TabIndex = 11;
            this.buttonElaveEt.Text = "Əlavə et";
            this.buttonElaveEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonElaveEt.UseVisualStyleBackColor = true;
            this.buttonElaveEt.Click += new System.EventHandler(this.ButtonFormProductAddYeniMehsulElaveEt_Click);
            // 
            // textBoxMehsulAdi
            // 
            this.textBoxMehsulAdi.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxMehsulAdi.Location = new System.Drawing.Point(99, 305);
            this.textBoxMehsulAdi.Name = "textBoxMehsulAdi";
            this.textBoxMehsulAdi.Size = new System.Drawing.Size(174, 22);
            this.textBoxMehsulAdi.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Aliş qiyməti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Miqdar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Məhsul adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kategoriya:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "BarkodNo:";
            // 
            // comboBoxKategoriya
            // 
            this.comboBoxKategoriya.FormattingEnabled = true;
            this.comboBoxKategoriya.Location = new System.Drawing.Point(99, 206);
            this.comboBoxKategoriya.Name = "comboBoxKategoriya";
            this.comboBoxKategoriya.Size = new System.Drawing.Size(174, 25);
            this.comboBoxKategoriya.TabIndex = 2;
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Location = new System.Drawing.Point(99, 239);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(174, 25);
            this.comboBoxMarka.TabIndex = 3;
            // 
            // textBoxSatisQiymet
            // 
            this.textBoxSatisQiymet.Location = new System.Drawing.Point(99, 404);
            this.textBoxSatisQiymet.Name = "textBoxSatisQiymet";
            this.textBoxSatisQiymet.Size = new System.Drawing.Size(174, 22);
            this.textBoxSatisQiymet.TabIndex = 8;
            this.textBoxSatisQiymet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSatisQiymet_KeyPress);
            // 
            // textBoxAlisQiymet
            // 
            this.textBoxAlisQiymet.Location = new System.Drawing.Point(99, 371);
            this.textBoxAlisQiymet.Name = "textBoxAlisQiymet";
            this.textBoxAlisQiymet.Size = new System.Drawing.Size(174, 22);
            this.textBoxAlisQiymet.TabIndex = 7;
            this.textBoxAlisQiymet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlisQiymet_KeyPress);
            // 
            // textBoxMiqdar
            // 
            this.textBoxMiqdar.Location = new System.Drawing.Point(99, 338);
            this.textBoxMiqdar.Name = "textBoxMiqdar";
            this.textBoxMiqdar.Size = new System.Drawing.Size(174, 22);
            this.textBoxMiqdar.TabIndex = 6;
            this.textBoxMiqdar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMiqdar_KeyPress);
            // 
            // textBoxBarkodNo
            // 
            this.textBoxBarkodNo.Location = new System.Drawing.Point(99, 174);
            this.textBoxBarkodNo.Name = "textBoxBarkodNo";
            this.textBoxBarkodNo.Size = new System.Drawing.Size(174, 22);
            this.textBoxBarkodNo.TabIndex = 1;
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
            this.dataGridViewProductList.Location = new System.Drawing.Point(344, 40);
            this.dataGridViewProductList.Name = "dataGridViewProductList";
            this.dataGridViewProductList.ReadOnly = true;
            this.dataGridViewProductList.RowTemplate.Height = 25;
            this.dataGridViewProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductList.Size = new System.Drawing.Size(624, 542);
            this.dataGridViewProductList.TabIndex = 24;
            this.dataGridViewProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProductList_CellDoubleClick);
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(802, 12);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(135, 22);
            this.textBoxAxtar.TabIndex = 26;
            this.textBoxAxtar.TextChanged += new System.EventHandler(this.textBoxAxtar_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.label12.Location = new System.Drawing.Point(773, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "     ";
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRefresh.ErrorImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Image = global::WindowsForm.Properties.Resources.refreshBlack_16px_;
            this.pictureBoxRefresh.InitialImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(943, 12);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefresh.TabIndex = 35;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // FormProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(980, 619);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.dataGridViewProductList);
            this.Controls.Add(this.GroupBoxFormProductAddYeniMehsul);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormProductAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Məhsul əlavə etmə səhifəsi";
            this.Load += new System.EventHandler(this.FormProductAdd_Load);
            this.GroupBoxFormProductAddYeniMehsul.ResumeLayout(false);
            this.GroupBoxFormProductAddYeniMehsul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxFormProductAddYeniMehsul;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonElaveEt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKategoriya;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.TextBox textBoxSatisQiymet;
        private System.Windows.Forms.TextBox textBoxAlisQiymet;
        private System.Windows.Forms.TextBox textBoxMiqdar;
        private System.Windows.Forms.TextBox textBoxMehsulAdi;
        private System.Windows.Forms.TextBox textBoxBarkodNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxTedarikci;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxAciqlama;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxKemiyyet;
        private System.Windows.Forms.DataGridView dataGridViewProductList;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.PictureBox pictureBoxProductImage;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.Button buttonBarcodeGenerate;
    }
}
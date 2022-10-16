
namespace WindowsForm.Forms
{
    partial class FormProductList
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
            this.dataGridViewFormPrdouctList = new System.Windows.Forms.DataGridView();
            this.GroupBoxVarOlanMehsul = new System.Windows.Forms.GroupBox();
            this.buttonBarcodeGenerate = new System.Windows.Forms.Button();
            this.pictureBoxProductImage = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TextBoxVarOlanAciqlama = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxVarOlanTedarikci = new System.Windows.Forms.ComboBox();
            this.comboBoxVarOlanMarka = new System.Windows.Forms.ComboBox();
            this.comboBoxVarOlanKateqoriya = new System.Windows.Forms.ComboBox();
            this.LabelMiqdarVB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxVarOlanSatisQiymet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxVarOlanAlisQiymet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxStokdakiMiqdar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxVarOlanBarkodNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxVarOlanMehsulAdi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormPrdouctList)).BeginInit();
            this.GroupBoxVarOlanMehsul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFormPrdouctList
            // 
            this.dataGridViewFormPrdouctList.AllowUserToAddRows = false;
            this.dataGridViewFormPrdouctList.AllowUserToDeleteRows = false;
            this.dataGridViewFormPrdouctList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFormPrdouctList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.dataGridViewFormPrdouctList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormPrdouctList.Location = new System.Drawing.Point(302, 42);
            this.dataGridViewFormPrdouctList.Name = "dataGridViewFormPrdouctList";
            this.dataGridViewFormPrdouctList.ReadOnly = true;
            this.dataGridViewFormPrdouctList.RowTemplate.Height = 25;
            this.dataGridViewFormPrdouctList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFormPrdouctList.Size = new System.Drawing.Size(564, 434);
            this.dataGridViewFormPrdouctList.TabIndex = 0;
            this.dataGridViewFormPrdouctList.DoubleClick += new System.EventHandler(this.dataGridViewFormPrdouctList_DoubleClick);
            // 
            // GroupBoxVarOlanMehsul
            // 
            this.GroupBoxVarOlanMehsul.Controls.Add(this.buttonBarcodeGenerate);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.pictureBoxProductImage);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label17);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.TextBoxVarOlanAciqlama);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label15);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.comboBoxVarOlanTedarikci);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.comboBoxVarOlanMarka);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.comboBoxVarOlanKateqoriya);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.LabelMiqdarVB);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label7);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxVarOlanSatisQiymet);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label8);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxVarOlanAlisQiymet);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label9);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label10);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxStokdakiMiqdar);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label11);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxVarOlanBarkodNo);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label12);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxVarOlanMehsulAdi);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label13);
            this.GroupBoxVarOlanMehsul.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBoxVarOlanMehsul.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxVarOlanMehsul.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxVarOlanMehsul.Name = "GroupBoxVarOlanMehsul";
            this.GroupBoxVarOlanMehsul.Size = new System.Drawing.Size(296, 574);
            this.GroupBoxVarOlanMehsul.TabIndex = 2;
            this.GroupBoxVarOlanMehsul.TabStop = false;
            // 
            // buttonBarcodeGenerate
            // 
            this.buttonBarcodeGenerate.FlatAppearance.BorderSize = 0;
            this.buttonBarcodeGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarcodeGenerate.Image = global::WindowsForm.Properties.Resources.refresh_barcode_16px;
            this.buttonBarcodeGenerate.Location = new System.Drawing.Point(263, 193);
            this.buttonBarcodeGenerate.Name = "buttonBarcodeGenerate";
            this.buttonBarcodeGenerate.Size = new System.Drawing.Size(27, 26);
            this.buttonBarcodeGenerate.TabIndex = 29;
            this.buttonBarcodeGenerate.UseVisualStyleBackColor = true;
            this.buttonBarcodeGenerate.Click += new System.EventHandler(this.buttonBarcodeGenerate_Click);
            // 
            // pictureBoxProductImage
            // 
            this.pictureBoxProductImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxProductImage.Location = new System.Drawing.Point(3, 18);
            this.pictureBoxProductImage.Name = "pictureBoxProductImage";
            this.pictureBoxProductImage.Size = new System.Drawing.Size(290, 169);
            this.pictureBoxProductImage.TabIndex = 28;
            this.pictureBoxProductImage.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 429);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 14);
            this.label17.TabIndex = 27;
            this.label17.Text = "Aciqlama:";
            // 
            // TextBoxVarOlanAciqlama
            // 
            this.TextBoxVarOlanAciqlama.Enabled = false;
            this.TextBoxVarOlanAciqlama.Location = new System.Drawing.Point(110, 426);
            this.TextBoxVarOlanAciqlama.Name = "TextBoxVarOlanAciqlama";
            this.TextBoxVarOlanAciqlama.Size = new System.Drawing.Size(150, 22);
            this.TextBoxVarOlanAciqlama.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 284);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 14);
            this.label15.TabIndex = 25;
            this.label15.Text = "Tedarikci:";
            // 
            // comboBoxVarOlanTedarikci
            // 
            this.comboBoxVarOlanTedarikci.Enabled = false;
            this.comboBoxVarOlanTedarikci.FormattingEnabled = true;
            this.comboBoxVarOlanTedarikci.Location = new System.Drawing.Point(110, 281);
            this.comboBoxVarOlanTedarikci.Name = "comboBoxVarOlanTedarikci";
            this.comboBoxVarOlanTedarikci.Size = new System.Drawing.Size(148, 22);
            this.comboBoxVarOlanTedarikci.TabIndex = 24;
            // 
            // comboBoxVarOlanMarka
            // 
            this.comboBoxVarOlanMarka.Enabled = false;
            this.comboBoxVarOlanMarka.FormattingEnabled = true;
            this.comboBoxVarOlanMarka.Location = new System.Drawing.Point(110, 252);
            this.comboBoxVarOlanMarka.Name = "comboBoxVarOlanMarka";
            this.comboBoxVarOlanMarka.Size = new System.Drawing.Size(148, 22);
            this.comboBoxVarOlanMarka.TabIndex = 23;
            // 
            // comboBoxVarOlanKateqoriya
            // 
            this.comboBoxVarOlanKateqoriya.Enabled = false;
            this.comboBoxVarOlanKateqoriya.FormattingEnabled = true;
            this.comboBoxVarOlanKateqoriya.Location = new System.Drawing.Point(110, 223);
            this.comboBoxVarOlanKateqoriya.Name = "comboBoxVarOlanKateqoriya";
            this.comboBoxVarOlanKateqoriya.Size = new System.Drawing.Size(148, 22);
            this.comboBoxVarOlanKateqoriya.TabIndex = 22;
            // 
            // LabelMiqdarVB
            // 
            this.LabelMiqdarVB.AutoSize = true;
            this.LabelMiqdarVB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelMiqdarVB.ForeColor = System.Drawing.Color.Firebrick;
            this.LabelMiqdarVB.Location = new System.Drawing.Point(5, 455);
            this.LabelMiqdarVB.Name = "LabelMiqdarVB";
            this.LabelMiqdarVB.Size = new System.Drawing.Size(19, 21);
            this.LabelMiqdarVB.TabIndex = 21;
            this.LabelMiqdarVB.Text = "#";
            this.LabelMiqdarVB.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "Satis qiymeti:";
            // 
            // textBoxVarOlanSatisQiymet
            // 
            this.textBoxVarOlanSatisQiymet.Enabled = false;
            this.textBoxVarOlanSatisQiymet.Location = new System.Drawing.Point(110, 397);
            this.textBoxVarOlanSatisQiymet.Name = "textBoxVarOlanSatisQiymet";
            this.textBoxVarOlanSatisQiymet.Size = new System.Drawing.Size(150, 22);
            this.textBoxVarOlanSatisQiymet.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 14);
            this.label8.TabIndex = 19;
            this.label8.Text = "Alis qiymeti:";
            // 
            // textBoxVarOlanAlisQiymet
            // 
            this.textBoxVarOlanAlisQiymet.Enabled = false;
            this.textBoxVarOlanAlisQiymet.Location = new System.Drawing.Point(110, 368);
            this.textBoxVarOlanAlisQiymet.Name = "textBoxVarOlanAlisQiymet";
            this.textBoxVarOlanAlisQiymet.Size = new System.Drawing.Size(150, 22);
            this.textBoxVarOlanAlisQiymet.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "Miqdar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 14);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mehsul adi:";
            // 
            // textBoxStokdakiMiqdar
            // 
            this.textBoxStokdakiMiqdar.Enabled = false;
            this.textBoxStokdakiMiqdar.Location = new System.Drawing.Point(110, 339);
            this.textBoxStokdakiMiqdar.Name = "textBoxStokdakiMiqdar";
            this.textBoxStokdakiMiqdar.Size = new System.Drawing.Size(150, 22);
            this.textBoxStokdakiMiqdar.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 14);
            this.label11.TabIndex = 16;
            this.label11.Text = "Marka:";
            // 
            // textBoxVarOlanBarkodNo
            // 
            this.textBoxVarOlanBarkodNo.Enabled = false;
            this.textBoxVarOlanBarkodNo.Location = new System.Drawing.Point(110, 194);
            this.textBoxVarOlanBarkodNo.Name = "textBoxVarOlanBarkodNo";
            this.textBoxVarOlanBarkodNo.Size = new System.Drawing.Size(150, 22);
            this.textBoxVarOlanBarkodNo.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 14);
            this.label12.TabIndex = 15;
            this.label12.Text = "Kategoriya:";
            // 
            // textBoxVarOlanMehsulAdi
            // 
            this.textBoxVarOlanMehsulAdi.Enabled = false;
            this.textBoxVarOlanMehsulAdi.Location = new System.Drawing.Point(110, 310);
            this.textBoxVarOlanMehsulAdi.Name = "textBoxVarOlanMehsulAdi";
            this.textBoxVarOlanMehsulAdi.Size = new System.Drawing.Size(150, 22);
            this.textBoxVarOlanMehsulAdi.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 14);
            this.label13.TabIndex = 14;
            this.label13.Text = "BarkodNo:";
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(687, 13);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(145, 22);
            this.textBoxAxtar.TabIndex = 6;
            this.textBoxAxtar.TextChanged += new System.EventHandler(this.textBoxAxtar_TextChanged);
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRefresh.ErrorImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Image = global::WindowsForm.Properties.Resources.refreshBlack_16px_;
            this.pictureBoxRefresh.InitialImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(838, 13);
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
            this.label1.Location = new System.Drawing.Point(658, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "     ";
            // 
            // buttonToExcel
            // 
            this.buttonToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToExcel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonToExcel.Location = new System.Drawing.Point(753, 482);
            this.buttonToExcel.Name = "buttonToExcel";
            this.buttonToExcel.Size = new System.Drawing.Size(113, 23);
            this.buttonToExcel.TabIndex = 29;
            this.buttonToExcel.Text = "Excel-ə yaz";
            this.buttonToExcel.UseVisualStyleBackColor = true;
            this.buttonToExcel.Click += new System.EventHandler(this.buttonToExcel_Click);
            // 
            // FormProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(878, 574);
            this.Controls.Add(this.buttonToExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.GroupBoxVarOlanMehsul);
            this.Controls.Add(this.dataGridViewFormPrdouctList);
            this.Name = "FormProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Məhsul sıralama səhifəsi";
            this.Load += new System.EventHandler(this.FormProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormPrdouctList)).EndInit();
            this.GroupBoxVarOlanMehsul.ResumeLayout(false);
            this.GroupBoxVarOlanMehsul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFormPrdouctList;
        private System.Windows.Forms.GroupBox GroupBoxVarOlanMehsul;
        private System.Windows.Forms.Label LabelMiqdarVB;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.PictureBox pictureBoxProductImage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TextBoxVarOlanAciqlama;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxVarOlanTedarikci;
        private System.Windows.Forms.ComboBox comboBoxVarOlanMarka;
        private System.Windows.Forms.ComboBox comboBoxVarOlanKateqoriya;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxVarOlanSatisQiymet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxVarOlanAlisQiymet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxStokdakiMiqdar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxVarOlanBarkodNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxVarOlanMehsulAdi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonToExcel;
        private System.Windows.Forms.Button buttonBarcodeGenerate;
    }
}
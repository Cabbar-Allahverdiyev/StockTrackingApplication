
namespace WindowsForm
{
    partial class SalesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
            this.ButtonSalesFormSil = new System.Windows.Forms.Button();
            this.ButonSalesFormSatisIptal = new System.Windows.Forms.Button();
            this.groupBoxMusteri = new System.Windows.Forms.GroupBox();
            this.TextBoxSalesFormTelefon = new System.Windows.Forms.TextBox();
            this.TextBoxSalesFormSoyad = new System.Windows.Forms.TextBox();
            this.TextBoxSalesFormAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxMehsul = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAxtarBarcodeNumber = new System.Windows.Forms.TextBox();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.textBoxMaxQiymet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCem = new System.Windows.Forms.TextBox();
            this.textBoxQiymet = new System.Windows.Forms.TextBox();
            this.ButtonSalesFormElaveEt = new System.Windows.Forms.Button();
            this.textBoxMehsulAdi = new System.Windows.Forms.TextBox();
            this.textBoxMiqdar = new System.Windows.Forms.TextBox();
            this.textBoxBarkodNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonSalesFormSatisEtmek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelSalesFormUmuniCem_qiymet = new System.Windows.Forms.Label();
            this.ButtonSalesFormYenile = new System.Windows.Forms.Button();
            this.dataGridViewCartList = new System.Windows.Forms.DataGridView();
            this.buttonTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
            this.groupBoxMusteri.SuspendLayout();
            this.groupBoxMehsul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductList
            // 
            this.dataGridViewProductList.AllowUserToAddRows = false;
            this.dataGridViewProductList.AllowUserToDeleteRows = false;
            this.dataGridViewProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProductList.Location = new System.Drawing.Point(263, 25);
            this.dataGridViewProductList.Name = "dataGridViewProductList";
            this.dataGridViewProductList.ReadOnly = true;
            this.dataGridViewProductList.RowTemplate.Height = 25;
            this.dataGridViewProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductList.Size = new System.Drawing.Size(806, 287);
            this.dataGridViewProductList.TabIndex = 1;
            this.dataGridViewProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSalesForm_CellDoubleClick);
            // 
            // ButtonSalesFormSil
            // 
            this.ButtonSalesFormSil.Location = new System.Drawing.Point(167, 289);
            this.ButtonSalesFormSil.Name = "ButtonSalesFormSil";
            this.ButtonSalesFormSil.Size = new System.Drawing.Size(71, 23);
            this.ButtonSalesFormSil.TabIndex = 2;
            this.ButtonSalesFormSil.Text = "Sil";
            this.ButtonSalesFormSil.UseVisualStyleBackColor = true;
            this.ButtonSalesFormSil.Click += new System.EventHandler(this.ButtonSalesFormSil_Click);
            // 
            // ButonSalesFormSatisIptal
            // 
            this.ButonSalesFormSatisIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButonSalesFormSatisIptal.Location = new System.Drawing.Point(1080, 54);
            this.ButonSalesFormSatisIptal.Name = "ButonSalesFormSatisIptal";
            this.ButonSalesFormSatisIptal.Size = new System.Drawing.Size(75, 23);
            this.ButonSalesFormSatisIptal.TabIndex = 3;
            this.ButonSalesFormSatisIptal.Text = "Satis iptal";
            this.ButonSalesFormSatisIptal.UseVisualStyleBackColor = true;
            this.ButonSalesFormSatisIptal.Click += new System.EventHandler(this.ButonSalesFormSatisIptal_Click);
            // 
            // groupBoxMusteri
            // 
            this.groupBoxMusteri.Controls.Add(this.TextBoxSalesFormTelefon);
            this.groupBoxMusteri.Controls.Add(this.TextBoxSalesFormSoyad);
            this.groupBoxMusteri.Controls.Add(this.TextBoxSalesFormAd);
            this.groupBoxMusteri.Controls.Add(this.label4);
            this.groupBoxMusteri.Controls.Add(this.label3);
            this.groupBoxMusteri.Controls.Add(this.label2);
            this.groupBoxMusteri.Location = new System.Drawing.Point(13, 25);
            this.groupBoxMusteri.Name = "groupBoxMusteri";
            this.groupBoxMusteri.Size = new System.Drawing.Size(244, 130);
            this.groupBoxMusteri.TabIndex = 8;
            this.groupBoxMusteri.TabStop = false;
            this.groupBoxMusteri.Text = "Musteri";
            // 
            // TextBoxSalesFormTelefon
            // 
            this.TextBoxSalesFormTelefon.Location = new System.Drawing.Point(84, 100);
            this.TextBoxSalesFormTelefon.Name = "TextBoxSalesFormTelefon";
            this.TextBoxSalesFormTelefon.Size = new System.Drawing.Size(145, 23);
            this.TextBoxSalesFormTelefon.TabIndex = 5;
            // 
            // TextBoxSalesFormSoyad
            // 
            this.TextBoxSalesFormSoyad.Location = new System.Drawing.Point(84, 61);
            this.TextBoxSalesFormSoyad.Name = "TextBoxSalesFormSoyad";
            this.TextBoxSalesFormSoyad.Size = new System.Drawing.Size(145, 23);
            this.TextBoxSalesFormSoyad.TabIndex = 4;
            // 
            // TextBoxSalesFormAd
            // 
            this.TextBoxSalesFormAd.Location = new System.Drawing.Point(84, 22);
            this.TextBoxSalesFormAd.Name = "TextBoxSalesFormAd";
            this.TextBoxSalesFormAd.Size = new System.Drawing.Size(145, 23);
            this.TextBoxSalesFormAd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // groupBoxMehsul
            // 
            this.groupBoxMehsul.Controls.Add(this.label11);
            this.groupBoxMehsul.Controls.Add(this.textBoxAxtarBarcodeNumber);
            this.groupBoxMehsul.Controls.Add(this.textBoxProductId);
            this.groupBoxMehsul.Controls.Add(this.textBoxMaxQiymet);
            this.groupBoxMehsul.Controls.Add(this.label10);
            this.groupBoxMehsul.Controls.Add(this.textBoxCem);
            this.groupBoxMehsul.Controls.Add(this.textBoxQiymet);
            this.groupBoxMehsul.Controls.Add(this.ButtonSalesFormElaveEt);
            this.groupBoxMehsul.Controls.Add(this.textBoxMehsulAdi);
            this.groupBoxMehsul.Controls.Add(this.textBoxMiqdar);
            this.groupBoxMehsul.Controls.Add(this.ButtonSalesFormSil);
            this.groupBoxMehsul.Controls.Add(this.textBoxBarkodNo);
            this.groupBoxMehsul.Controls.Add(this.label9);
            this.groupBoxMehsul.Controls.Add(this.label8);
            this.groupBoxMehsul.Controls.Add(this.label6);
            this.groupBoxMehsul.Controls.Add(this.label5);
            this.groupBoxMehsul.Controls.Add(this.label7);
            this.groupBoxMehsul.Location = new System.Drawing.Point(13, 203);
            this.groupBoxMehsul.Name = "groupBoxMehsul";
            this.groupBoxMehsul.Size = new System.Drawing.Size(244, 318);
            this.groupBoxMehsul.TabIndex = 9;
            this.groupBoxMehsul.TabStop = false;
            this.groupBoxMehsul.Text = "Mehsul";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Axtar:";
            // 
            // textBoxAxtarBarcodeNumber
            // 
            this.textBoxAxtarBarcodeNumber.Location = new System.Drawing.Point(100, 17);
            this.textBoxAxtarBarcodeNumber.Name = "textBoxAxtarBarcodeNumber";
            this.textBoxAxtarBarcodeNumber.Size = new System.Drawing.Size(138, 23);
            this.textBoxAxtarBarcodeNumber.TabIndex = 16;
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Enabled = false;
            this.textBoxProductId.Location = new System.Drawing.Point(100, 46);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(138, 23);
            this.textBoxProductId.TabIndex = 14;
            // 
            // textBoxMaxQiymet
            // 
            this.textBoxMaxQiymet.Enabled = false;
            this.textBoxMaxQiymet.Location = new System.Drawing.Point(100, 135);
            this.textBoxMaxQiymet.Name = "textBoxMaxQiymet";
            this.textBoxMaxQiymet.Size = new System.Drawing.Size(138, 23);
            this.textBoxMaxQiymet.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Max qiymet:";
            // 
            // textBoxCem
            // 
            this.textBoxCem.Enabled = false;
            this.textBoxCem.Location = new System.Drawing.Point(100, 224);
            this.textBoxCem.Name = "textBoxCem";
            this.textBoxCem.Size = new System.Drawing.Size(138, 23);
            this.textBoxCem.TabIndex = 9;
            // 
            // textBoxQiymet
            // 
            this.textBoxQiymet.Location = new System.Drawing.Point(100, 164);
            this.textBoxQiymet.Name = "textBoxQiymet";
            this.textBoxQiymet.Size = new System.Drawing.Size(138, 23);
            this.textBoxQiymet.TabIndex = 8;
            this.textBoxQiymet.TextChanged += new System.EventHandler(this.textBoxQiymet_TextChanged);
            // 
            // ButtonSalesFormElaveEt
            // 
            this.ButtonSalesFormElaveEt.Location = new System.Drawing.Point(167, 253);
            this.ButtonSalesFormElaveEt.Name = "ButtonSalesFormElaveEt";
            this.ButtonSalesFormElaveEt.Size = new System.Drawing.Size(71, 30);
            this.ButtonSalesFormElaveEt.TabIndex = 11;
            this.ButtonSalesFormElaveEt.Text = "Elave Et";
            this.ButtonSalesFormElaveEt.UseVisualStyleBackColor = true;
            this.ButtonSalesFormElaveEt.Click += new System.EventHandler(this.ButtonSalesFormElaveEt_Click);
            // 
            // textBoxMehsulAdi
            // 
            this.textBoxMehsulAdi.Enabled = false;
            this.textBoxMehsulAdi.Location = new System.Drawing.Point(100, 105);
            this.textBoxMehsulAdi.Name = "textBoxMehsulAdi";
            this.textBoxMehsulAdi.Size = new System.Drawing.Size(138, 23);
            this.textBoxMehsulAdi.TabIndex = 6;
            // 
            // textBoxMiqdar
            // 
            this.textBoxMiqdar.Location = new System.Drawing.Point(100, 195);
            this.textBoxMiqdar.Name = "textBoxMiqdar";
            this.textBoxMiqdar.Size = new System.Drawing.Size(138, 23);
            this.textBoxMiqdar.TabIndex = 7;
            this.textBoxMiqdar.TextChanged += new System.EventHandler(this.textBoxMiqdar_TextChanged);
            // 
            // textBoxBarkodNo
            // 
            this.textBoxBarkodNo.Location = new System.Drawing.Point(100, 75);
            this.textBoxBarkodNo.Name = "textBoxBarkodNo";
            this.textBoxBarkodNo.Size = new System.Drawing.Size(138, 23);
            this.textBoxBarkodNo.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cem:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Qiymet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mehsul adi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "BarkodNo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Miqdar:";
            // 
            // ButtonSalesFormSatisEtmek
            // 
            this.ButtonSalesFormSatisEtmek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSalesFormSatisEtmek.Location = new System.Drawing.Point(1075, 476);
            this.ButtonSalesFormSatisEtmek.Name = "ButtonSalesFormSatisEtmek";
            this.ButtonSalesFormSatisEtmek.Size = new System.Drawing.Size(80, 45);
            this.ButtonSalesFormSatisEtmek.TabIndex = 10;
            this.ButtonSalesFormSatisEtmek.Text = "Satis Etmek";
            this.ButtonSalesFormSatisEtmek.UseVisualStyleBackColor = true;
            this.ButtonSalesFormSatisEtmek.Click += new System.EventHandler(this.ButtonSalesFormSatisEtmek_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(714, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Umumi Cem:";
            // 
            // LabelSalesFormUmuniCem_qiymet
            // 
            this.LabelSalesFormUmuniCem_qiymet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSalesFormUmuniCem_qiymet.AutoSize = true;
            this.LabelSalesFormUmuniCem_qiymet.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelSalesFormUmuniCem_qiymet.ForeColor = System.Drawing.Color.Red;
            this.LabelSalesFormUmuniCem_qiymet.Location = new System.Drawing.Point(840, 524);
            this.LabelSalesFormUmuniCem_qiymet.Name = "LabelSalesFormUmuniCem_qiymet";
            this.LabelSalesFormUmuniCem_qiymet.Size = new System.Drawing.Size(23, 25);
            this.LabelSalesFormUmuniCem_qiymet.TabIndex = 13;
            this.LabelSalesFormUmuniCem_qiymet.Text = "#";
            // 
            // ButtonSalesFormYenile
            // 
            this.ButtonSalesFormYenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSalesFormYenile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonSalesFormYenile.FlatAppearance.BorderSize = 0;
            this.ButtonSalesFormYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalesFormYenile.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSalesFormYenile.Image")));
            this.ButtonSalesFormYenile.Location = new System.Drawing.Point(1099, 150);
            this.ButtonSalesFormYenile.Name = "ButtonSalesFormYenile";
            this.ButtonSalesFormYenile.Size = new System.Drawing.Size(55, 45);
            this.ButtonSalesFormYenile.TabIndex = 14;
            this.ButtonSalesFormYenile.UseVisualStyleBackColor = false;
            this.ButtonSalesFormYenile.Click += new System.EventHandler(this.ButtonSalesFormYenile_Click);
            // 
            // dataGridViewCartList
            // 
            this.dataGridViewCartList.AllowUserToAddRows = false;
            this.dataGridViewCartList.AllowUserToDeleteRows = false;
            this.dataGridViewCartList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCartList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCartList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCartList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCartList.Location = new System.Drawing.Point(263, 457);
            this.dataGridViewCartList.Name = "dataGridViewCartList";
            this.dataGridViewCartList.ReadOnly = true;
            this.dataGridViewCartList.RowTemplate.Height = 25;
            this.dataGridViewCartList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCartList.Size = new System.Drawing.Size(806, 64);
            this.dataGridViewCartList.TabIndex = 15;
            this.dataGridViewCartList.DoubleClick += new System.EventHandler(this.dataGridViewCartList_DoubleClick);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(180, 528);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(70, 26);
            this.buttonTemizle.TabIndex = 16;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // SalesForm
            // 
            this.AcceptButton = this.ButtonSalesFormElaveEt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1174, 641);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.dataGridViewCartList);
            this.Controls.Add(this.ButtonSalesFormYenile);
            this.Controls.Add(this.LabelSalesFormUmuniCem_qiymet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSalesFormSatisEtmek);
            this.Controls.Add(this.groupBoxMehsul);
            this.Controls.Add(this.groupBoxMusteri);
            this.Controls.Add(this.ButonSalesFormSatisIptal);
            this.Controls.Add(this.dataGridViewProductList);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Form";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).EndInit();
            this.groupBoxMusteri.ResumeLayout(false);
            this.groupBoxMusteri.PerformLayout();
            this.groupBoxMehsul.ResumeLayout(false);
            this.groupBoxMehsul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProductList;
        private System.Windows.Forms.Button ButtonSalesFormSil;
        private System.Windows.Forms.Button ButonSalesFormSatisIptal;
        private System.Windows.Forms.GroupBox groupBoxMusteri;
        private System.Windows.Forms.TextBox TextBoxSalesFormTelefon;
        private System.Windows.Forms.TextBox TextBoxSalesFormSoyad;
        private System.Windows.Forms.TextBox TextBoxSalesFormAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxMehsul;
        private System.Windows.Forms.TextBox textBoxCem;
        private System.Windows.Forms.TextBox textBoxQiymet;
        private System.Windows.Forms.TextBox textBoxMiqdar;
        private System.Windows.Forms.TextBox textBoxMehsulAdi;
        private System.Windows.Forms.TextBox textBoxBarkodNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonSalesFormElaveEt;
        private System.Windows.Forms.Button ButtonSalesFormSatisEtmek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelSalesFormUmuniCem_qiymet;
        private System.Windows.Forms.Button ButtonSalesFormYenile;
        private System.Windows.Forms.DataGridView dataGridViewCartList;
        private System.Windows.Forms.TextBox textBoxMaxQiymet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxAxtarBarcodeNumber;
        private System.Windows.Forms.Button buttonTemizle;
    }
}
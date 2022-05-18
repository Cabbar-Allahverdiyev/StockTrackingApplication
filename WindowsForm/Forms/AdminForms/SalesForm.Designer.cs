
namespace WindowsForm.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
            this.ButtonSalesFormSil = new System.Windows.Forms.Button();
            this.ButonSalesFormSatisIptal = new System.Windows.Forms.Button();
            this.groupBoxMusteri = new System.Windows.Forms.GroupBox();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.buttonSec = new System.Windows.Forms.Button();
            this.buttonBorcElaveEt = new System.Windows.Forms.Button();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxMehsul = new System.Windows.Forms.GroupBox();
            this.buttonDuzelt = new System.Windows.Forms.Button();
            this.buttonBarkodNoAxtar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttoElaveEt = new System.Windows.Forms.Button();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.textBoxMaxQiymet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCem = new System.Windows.Forms.TextBox();
            this.textBoxQiymet = new System.Windows.Forms.TextBox();
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
            this.dataGridViewCartList = new System.Windows.Forms.DataGridView();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.checkBoxBarkodNo = new System.Windows.Forms.CheckBox();
            this.comboBoxCategoryList = new System.Windows.Forms.ComboBox();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.buttonAxtar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxSupplierList = new System.Windows.Forms.ComboBox();
            this.comboBoxBrandList = new System.Windows.Forms.ComboBox();
            this.textBoxBonusCardCustomerName = new System.Windows.Forms.TextBox();
            this.buttonBonusCardSelect = new System.Windows.Forms.Button();
            this.buttonTemizleBonusCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
            this.groupBoxMusteri.SuspendLayout();
            this.groupBoxMehsul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.groupBoxFilter.SuspendLayout();
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
            this.dataGridViewProductList.Location = new System.Drawing.Point(263, 45);
            this.dataGridViewProductList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProductList.Name = "dataGridViewProductList";
            this.dataGridViewProductList.ReadOnly = true;
            this.dataGridViewProductList.RowTemplate.Height = 25;
            this.dataGridViewProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductList.Size = new System.Drawing.Size(806, 332);
            this.dataGridViewProductList.TabIndex = 1;
            this.dataGridViewProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSalesForm_CellDoubleClick);
            // 
            // ButtonSalesFormSil
            // 
            this.ButtonSalesFormSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalesFormSil.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSalesFormSil.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSalesFormSil.Image")));
            this.ButtonSalesFormSil.Location = new System.Drawing.Point(150, 396);
            this.ButtonSalesFormSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSalesFormSil.Name = "ButtonSalesFormSil";
            this.ButtonSalesFormSil.Size = new System.Drawing.Size(88, 28);
            this.ButtonSalesFormSil.TabIndex = 2;
            this.ButtonSalesFormSil.Text = "Sil";
            this.ButtonSalesFormSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSalesFormSil.UseVisualStyleBackColor = true;
            this.ButtonSalesFormSil.Click += new System.EventHandler(this.ButtonSalesFormSil_Click);
            // 
            // ButonSalesFormSatisIptal
            // 
            this.ButonSalesFormSatisIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButonSalesFormSatisIptal.FlatAppearance.BorderSize = 0;
            this.ButonSalesFormSatisIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonSalesFormSatisIptal.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButonSalesFormSatisIptal.Image = ((System.Drawing.Image)(resources.GetObject("ButonSalesFormSatisIptal.Image")));
            this.ButonSalesFormSatisIptal.Location = new System.Drawing.Point(1075, 45);
            this.ButonSalesFormSatisIptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButonSalesFormSatisIptal.Name = "ButonSalesFormSatisIptal";
            this.ButonSalesFormSatisIptal.Size = new System.Drawing.Size(75, 45);
            this.ButonSalesFormSatisIptal.TabIndex = 3;
            this.ButonSalesFormSatisIptal.Text = "Satışın ləğvi";
            this.ButonSalesFormSatisIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButonSalesFormSatisIptal.UseVisualStyleBackColor = true;
            this.ButonSalesFormSatisIptal.Click += new System.EventHandler(this.ButonSalesFormSatisIptal_Click);
            // 
            // groupBoxMusteri
            // 
            this.groupBoxMusteri.Controls.Add(this.textBoxCustomerId);
            this.groupBoxMusteri.Controls.Add(this.buttonSec);
            this.groupBoxMusteri.Controls.Add(this.buttonBorcElaveEt);
            this.groupBoxMusteri.Controls.Add(this.textBoxTelefon);
            this.groupBoxMusteri.Controls.Add(this.textBoxSoyad);
            this.groupBoxMusteri.Controls.Add(this.textBoxAd);
            this.groupBoxMusteri.Controls.Add(this.label4);
            this.groupBoxMusteri.Controls.Add(this.label3);
            this.groupBoxMusteri.Controls.Add(this.label2);
            this.groupBoxMusteri.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxMusteri.Location = new System.Drawing.Point(13, 36);
            this.groupBoxMusteri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMusteri.Name = "groupBoxMusteri";
            this.groupBoxMusteri.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMusteri.Size = new System.Drawing.Size(244, 188);
            this.groupBoxMusteri.TabIndex = 8;
            this.groupBoxMusteri.TabStop = false;
            this.groupBoxMusteri.Text = "Müştəri";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Enabled = false;
            this.textBoxCustomerId.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCustomerId.Location = new System.Drawing.Point(78, 24);
            this.textBoxCustomerId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(160, 22);
            this.textBoxCustomerId.TabIndex = 39;
            // 
            // buttonSec
            // 
            this.buttonSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSec.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSec.Image = global::WindowsForm.Properties.Resources.choose_page_16px;
            this.buttonSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSec.Location = new System.Drawing.Point(55, 151);
            this.buttonSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSec.Name = "buttonSec";
            this.buttonSec.Size = new System.Drawing.Size(88, 28);
            this.buttonSec.TabIndex = 38;
            this.buttonSec.Text = "  Seç";
            this.buttonSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSec.UseVisualStyleBackColor = true;
            this.buttonSec.Click += new System.EventHandler(this.buttonSec_Click);
            // 
            // buttonBorcElaveEt
            // 
            this.buttonBorcElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorcElaveEt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBorcElaveEt.Image = global::WindowsForm.Properties.Resources.payment_history_16px_3;
            this.buttonBorcElaveEt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBorcElaveEt.Location = new System.Drawing.Point(149, 151);
            this.buttonBorcElaveEt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBorcElaveEt.Name = "buttonBorcElaveEt";
            this.buttonBorcElaveEt.Size = new System.Drawing.Size(88, 28);
            this.buttonBorcElaveEt.TabIndex = 36;
            this.buttonBorcElaveEt.Text = "  Borc et";
            this.buttonBorcElaveEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBorcElaveEt.UseVisualStyleBackColor = true;
            this.buttonBorcElaveEt.Click += new System.EventHandler(this.buttonBorcElaveEt_Click);
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Enabled = false;
            this.textBoxTelefon.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTelefon.Location = new System.Drawing.Point(77, 119);
            this.textBoxTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(160, 22);
            this.textBoxTelefon.TabIndex = 5;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Enabled = false;
            this.textBoxSoyad.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSoyad.Location = new System.Drawing.Point(77, 87);
            this.textBoxSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(160, 22);
            this.textBoxSoyad.TabIndex = 4;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Enabled = false;
            this.textBoxAd.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAd.Location = new System.Drawing.Point(77, 56);
            this.textBoxAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(160, 22);
            this.textBoxAd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad :";
            // 
            // groupBoxMehsul
            // 
            this.groupBoxMehsul.Controls.Add(this.buttonDuzelt);
            this.groupBoxMehsul.Controls.Add(this.buttonBarkodNoAxtar);
            this.groupBoxMehsul.Controls.Add(this.pictureBox1);
            this.groupBoxMehsul.Controls.Add(this.buttonTemizle);
            this.groupBoxMehsul.Controls.Add(this.buttoElaveEt);
            this.groupBoxMehsul.Controls.Add(this.textBoxProductId);
            this.groupBoxMehsul.Controls.Add(this.textBoxMaxQiymet);
            this.groupBoxMehsul.Controls.Add(this.label10);
            this.groupBoxMehsul.Controls.Add(this.textBoxCem);
            this.groupBoxMehsul.Controls.Add(this.textBoxQiymet);
            this.groupBoxMehsul.Controls.Add(this.textBoxMehsulAdi);
            this.groupBoxMehsul.Controls.Add(this.textBoxMiqdar);
            this.groupBoxMehsul.Controls.Add(this.ButtonSalesFormSil);
            this.groupBoxMehsul.Controls.Add(this.textBoxBarkodNo);
            this.groupBoxMehsul.Controls.Add(this.label9);
            this.groupBoxMehsul.Controls.Add(this.label8);
            this.groupBoxMehsul.Controls.Add(this.label6);
            this.groupBoxMehsul.Controls.Add(this.label5);
            this.groupBoxMehsul.Controls.Add(this.label7);
            this.groupBoxMehsul.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxMehsul.Location = new System.Drawing.Point(13, 232);
            this.groupBoxMehsul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMehsul.Name = "groupBoxMehsul";
            this.groupBoxMehsul.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMehsul.Size = new System.Drawing.Size(244, 488);
            this.groupBoxMehsul.TabIndex = 9;
            this.groupBoxMehsul.TabStop = false;
            this.groupBoxMehsul.Text = "Məhsul";
            // 
            // buttonDuzelt
            // 
            this.buttonDuzelt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDuzelt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDuzelt.Image = global::WindowsForm.Properties.Resources.editBlack_16px_2;
            this.buttonDuzelt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDuzelt.Location = new System.Drawing.Point(57, 396);
            this.buttonDuzelt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDuzelt.Name = "buttonDuzelt";
            this.buttonDuzelt.Size = new System.Drawing.Size(88, 28);
            this.buttonDuzelt.TabIndex = 21;
            this.buttonDuzelt.Text = "Düzəlt";
            this.buttonDuzelt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDuzelt.UseVisualStyleBackColor = true;
            this.buttonDuzelt.Click += new System.EventHandler(this.buttonDuzelt_Click);
            // 
            // buttonBarkodNoAxtar
            // 
            this.buttonBarkodNoAxtar.FlatAppearance.BorderSize = 0;
            this.buttonBarkodNoAxtar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarkodNoAxtar.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.buttonBarkodNoAxtar.Location = new System.Drawing.Point(6, 162);
            this.buttonBarkodNoAxtar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBarkodNoAxtar.Name = "buttonBarkodNoAxtar";
            this.buttonBarkodNoAxtar.Size = new System.Drawing.Size(18, 19);
            this.buttonBarkodNoAxtar.TabIndex = 20;
            this.buttonBarkodNoAxtar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBarkodNoAxtar.UseVisualStyleBackColor = true;
            this.buttonBarkodNoAxtar.Visible = false;
            this.buttonBarkodNoAxtar.Click += new System.EventHandler(this.buttonBarkodNoAxtar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 78);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.Image")));
            this.buttonTemizle.Location = new System.Drawing.Point(57, 363);
            this.buttonTemizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(88, 28);
            this.buttonTemizle.TabIndex = 16;
            this.buttonTemizle.Text = "Təmizlə";
            this.buttonTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttoElaveEt
            // 
            this.buttoElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoElaveEt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttoElaveEt.Image = ((System.Drawing.Image)(resources.GetObject("buttoElaveEt.Image")));
            this.buttoElaveEt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoElaveEt.Location = new System.Drawing.Point(150, 363);
            this.buttoElaveEt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttoElaveEt.Name = "buttoElaveEt";
            this.buttoElaveEt.Size = new System.Drawing.Size(88, 28);
            this.buttoElaveEt.TabIndex = 18;
            this.buttoElaveEt.Text = "Əlavə et";
            this.buttoElaveEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttoElaveEt.UseVisualStyleBackColor = true;
            this.buttoElaveEt.Click += new System.EventHandler(this.buttoElaveEt_Click);
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Enabled = false;
            this.textBoxProductId.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProductId.Location = new System.Drawing.Point(100, 128);
            this.textBoxProductId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(138, 22);
            this.textBoxProductId.TabIndex = 14;
            // 
            // textBoxMaxQiymet
            // 
            this.textBoxMaxQiymet.Enabled = false;
            this.textBoxMaxQiymet.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaxQiymet.Location = new System.Drawing.Point(100, 228);
            this.textBoxMaxQiymet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaxQiymet.Name = "textBoxMaxQiymet";
            this.textBoxMaxQiymet.Size = new System.Drawing.Size(138, 22);
            this.textBoxMaxQiymet.TabIndex = 13;
            this.textBoxMaxQiymet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaxQiymet_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(19, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 14);
            this.label10.TabIndex = 12;
            this.label10.Text = "Max qiymət:";
            // 
            // textBoxCem
            // 
            this.textBoxCem.Enabled = false;
            this.textBoxCem.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCem.Location = new System.Drawing.Point(100, 330);
            this.textBoxCem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCem.Name = "textBoxCem";
            this.textBoxCem.Size = new System.Drawing.Size(138, 22);
            this.textBoxCem.TabIndex = 9;
            // 
            // textBoxQiymet
            // 
            this.textBoxQiymet.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxQiymet.Location = new System.Drawing.Point(100, 262);
            this.textBoxQiymet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxQiymet.Name = "textBoxQiymet";
            this.textBoxQiymet.Size = new System.Drawing.Size(138, 22);
            this.textBoxQiymet.TabIndex = 8;
            this.textBoxQiymet.TextChanged += new System.EventHandler(this.textBoxQiymet_TextChanged);
            this.textBoxQiymet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQiymet_KeyPress);
            // 
            // textBoxMehsulAdi
            // 
            this.textBoxMehsulAdi.Enabled = false;
            this.textBoxMehsulAdi.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMehsulAdi.Location = new System.Drawing.Point(100, 194);
            this.textBoxMehsulAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMehsulAdi.Name = "textBoxMehsulAdi";
            this.textBoxMehsulAdi.Size = new System.Drawing.Size(138, 22);
            this.textBoxMehsulAdi.TabIndex = 6;
            // 
            // textBoxMiqdar
            // 
            this.textBoxMiqdar.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMiqdar.Location = new System.Drawing.Point(100, 296);
            this.textBoxMiqdar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMiqdar.Name = "textBoxMiqdar";
            this.textBoxMiqdar.Size = new System.Drawing.Size(138, 22);
            this.textBoxMiqdar.TabIndex = 7;
            this.textBoxMiqdar.TextChanged += new System.EventHandler(this.textBoxMiqdar_TextChanged);
            this.textBoxMiqdar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMiqdar_KeyPress);
            // 
            // textBoxBarkodNo
            // 
            this.textBoxBarkodNo.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBarkodNo.Location = new System.Drawing.Point(100, 160);
            this.textBoxBarkodNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBarkodNo.Name = "textBoxBarkodNo";
            this.textBoxBarkodNo.Size = new System.Drawing.Size(138, 22);
            this.textBoxBarkodNo.TabIndex = 5;
            this.textBoxBarkodNo.TextChanged += new System.EventHandler(this.textBoxBarkodNo_TextChanged);
            this.textBoxBarkodNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarkodNo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(60, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 14);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cəm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(45, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 14);
            this.label8.TabIndex = 3;
            this.label8.Text = "Qiymət:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "Məhsul adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "BarkodNo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(45, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "Miqdar:";
            // 
            // ButtonSalesFormSatisEtmek
            // 
            this.ButtonSalesFormSatisEtmek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSalesFormSatisEtmek.FlatAppearance.BorderSize = 0;
            this.ButtonSalesFormSatisEtmek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalesFormSatisEtmek.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSalesFormSatisEtmek.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSalesFormSatisEtmek.Image")));
            this.ButtonSalesFormSatisEtmek.Location = new System.Drawing.Point(1075, 617);
            this.ButtonSalesFormSatisEtmek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSalesFormSatisEtmek.Name = "ButtonSalesFormSatisEtmek";
            this.ButtonSalesFormSatisEtmek.Size = new System.Drawing.Size(98, 39);
            this.ButtonSalesFormSatisEtmek.TabIndex = 10;
            this.ButtonSalesFormSatisEtmek.Text = "  Sat";
            this.ButtonSalesFormSatisEtmek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSalesFormSatisEtmek.UseVisualStyleBackColor = true;
            this.ButtonSalesFormSatisEtmek.Click += new System.EventHandler(this.ButtonSalesFormSatisEtmek_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(261, 658);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ümumi Cəm:";
            // 
            // LabelSalesFormUmuniCem_qiymet
            // 
            this.LabelSalesFormUmuniCem_qiymet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelSalesFormUmuniCem_qiymet.AutoSize = true;
            this.LabelSalesFormUmuniCem_qiymet.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelSalesFormUmuniCem_qiymet.ForeColor = System.Drawing.Color.Red;
            this.LabelSalesFormUmuniCem_qiymet.Location = new System.Drawing.Point(387, 658);
            this.LabelSalesFormUmuniCem_qiymet.Name = "LabelSalesFormUmuniCem_qiymet";
            this.LabelSalesFormUmuniCem_qiymet.Size = new System.Drawing.Size(21, 22);
            this.LabelSalesFormUmuniCem_qiymet.TabIndex = 13;
            this.LabelSalesFormUmuniCem_qiymet.Text = "#";
            // 
            // dataGridViewCartList
            // 
            this.dataGridViewCartList.AllowUserToAddRows = false;
            this.dataGridViewCartList.AllowUserToDeleteRows = false;
            this.dataGridViewCartList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCartList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.dataGridViewCartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCartList.Location = new System.Drawing.Point(263, 431);
            this.dataGridViewCartList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCartList.Name = "dataGridViewCartList";
            this.dataGridViewCartList.ReadOnly = true;
            this.dataGridViewCartList.RowTemplate.Height = 25;
            this.dataGridViewCartList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCartList.Size = new System.Drawing.Size(806, 225);
            this.dataGridViewCartList.TabIndex = 15;
            this.dataGridViewCartList.DoubleClick += new System.EventHandler(this.dataGridViewCartList_DoubleClick);
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(670, 15);
            this.textBoxAxtar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(138, 22);
            this.textBoxAxtar.TabIndex = 18;
            this.textBoxAxtar.TextChanged += new System.EventHandler(this.textBoxAxtar_TextChanged);
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRefresh.ErrorImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Image = global::WindowsForm.Properties.Resources.refreshBlack_16px_;
            this.pictureBoxRefresh.InitialImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(814, 15);
            this.pictureBoxRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(25, 28);
            this.pictureBoxRefresh.TabIndex = 32;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // checkBoxBarkodNo
            // 
            this.checkBoxBarkodNo.AutoSize = true;
            this.checkBoxBarkodNo.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxBarkodNo.Location = new System.Drawing.Point(263, 392);
            this.checkBoxBarkodNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBarkodNo.Name = "checkBoxBarkodNo";
            this.checkBoxBarkodNo.Size = new System.Drawing.Size(79, 18);
            this.checkBoxBarkodNo.TabIndex = 35;
            this.checkBoxBarkodNo.Text = "Avtomatik";
            this.checkBoxBarkodNo.UseVisualStyleBackColor = true;
            this.checkBoxBarkodNo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxCategoryList
            // 
            this.comboBoxCategoryList.FormattingEnabled = true;
            this.comboBoxCategoryList.Location = new System.Drawing.Point(81, 15);
            this.comboBoxCategoryList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCategoryList.Name = "comboBoxCategoryList";
            this.comboBoxCategoryList.Size = new System.Drawing.Size(121, 22);
            this.comboBoxCategoryList.TabIndex = 36;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxFilter.Controls.Add(this.buttonAxtar);
            this.groupBoxFilter.Controls.Add(this.label14);
            this.groupBoxFilter.Controls.Add(this.label13);
            this.groupBoxFilter.Controls.Add(this.pictureBoxRefresh);
            this.groupBoxFilter.Controls.Add(this.textBoxAxtar);
            this.groupBoxFilter.Controls.Add(this.label11);
            this.groupBoxFilter.Controls.Add(this.comboBoxSupplierList);
            this.groupBoxFilter.Controls.Add(this.comboBoxBrandList);
            this.groupBoxFilter.Controls.Add(this.comboBoxCategoryList);
            this.groupBoxFilter.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxFilter.Location = new System.Drawing.Point(261, -1);
            this.groupBoxFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFilter.Size = new System.Drawing.Size(889, 42);
            this.groupBoxFilter.TabIndex = 37;
            this.groupBoxFilter.TabStop = false;
            // 
            // buttonAxtar
            // 
            this.buttonAxtar.FlatAppearance.BorderSize = 0;
            this.buttonAxtar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAxtar.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.buttonAxtar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAxtar.Location = new System.Drawing.Point(641, 16);
            this.buttonAxtar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAxtar.Name = "buttonAxtar";
            this.buttonAxtar.Size = new System.Drawing.Size(23, 19);
            this.buttonAxtar.TabIndex = 40;
            this.buttonAxtar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAxtar.UseVisualStyleBackColor = true;
            this.buttonAxtar.Click += new System.EventHandler(this.buttonAxtar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(387, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 14);
            this.label14.TabIndex = 41;
            this.label14.Text = "Tedarükçü :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(208, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 14);
            this.label13.TabIndex = 40;
            this.label13.Text = "Marka :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 14);
            this.label11.TabIndex = 39;
            this.label11.Text = "Kateqoriya :";
            // 
            // comboBoxSupplierList
            // 
            this.comboBoxSupplierList.FormattingEnabled = true;
            this.comboBoxSupplierList.Location = new System.Drawing.Point(460, 15);
            this.comboBoxSupplierList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSupplierList.Name = "comboBoxSupplierList";
            this.comboBoxSupplierList.Size = new System.Drawing.Size(121, 22);
            this.comboBoxSupplierList.TabIndex = 38;
            // 
            // comboBoxBrandList
            // 
            this.comboBoxBrandList.FormattingEnabled = true;
            this.comboBoxBrandList.Location = new System.Drawing.Point(260, 15);
            this.comboBoxBrandList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBrandList.Name = "comboBoxBrandList";
            this.comboBoxBrandList.Size = new System.Drawing.Size(121, 22);
            this.comboBoxBrandList.TabIndex = 37;
            // 
            // textBoxBonusCardCustomerName
            // 
            this.textBoxBonusCardCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBonusCardCustomerName.Enabled = false;
            this.textBoxBonusCardCustomerName.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBonusCardCustomerName.Location = new System.Drawing.Point(676, 391);
            this.textBoxBonusCardCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBonusCardCustomerName.Name = "textBoxBonusCardCustomerName";
            this.textBoxBonusCardCustomerName.Size = new System.Drawing.Size(167, 22);
            this.textBoxBonusCardCustomerName.TabIndex = 38;
            this.textBoxBonusCardCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonBonusCardSelect
            // 
            this.buttonBonusCardSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBonusCardSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBonusCardSelect.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBonusCardSelect.Image = global::WindowsForm.Properties.Resources.bonus_card_16px_2;
            this.buttonBonusCardSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBonusCardSelect.Location = new System.Drawing.Point(849, 386);
            this.buttonBonusCardSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBonusCardSelect.Name = "buttonBonusCardSelect";
            this.buttonBonusCardSelect.Size = new System.Drawing.Size(126, 29);
            this.buttonBonusCardSelect.TabIndex = 39;
            this.buttonBonusCardSelect.Text = "Bonus kart seç";
            this.buttonBonusCardSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBonusCardSelect.UseVisualStyleBackColor = true;
            this.buttonBonusCardSelect.Click += new System.EventHandler(this.buttonBonusCardSelect_Click);
            // 
            // buttonTemizleBonusCard
            // 
            this.buttonTemizleBonusCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTemizleBonusCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizleBonusCard.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTemizleBonusCard.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizleBonusCard.Image")));
            this.buttonTemizleBonusCard.Location = new System.Drawing.Point(981, 387);
            this.buttonTemizleBonusCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTemizleBonusCard.Name = "buttonTemizleBonusCard";
            this.buttonTemizleBonusCard.Size = new System.Drawing.Size(88, 28);
            this.buttonTemizleBonusCard.TabIndex = 40;
            this.buttonTemizleBonusCard.Text = "Təmizlə";
            this.buttonTemizleBonusCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTemizleBonusCard.UseVisualStyleBackColor = true;
            this.buttonTemizleBonusCard.Click += new System.EventHandler(this.buttonTemizleBonusCard_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1174, 726);
            this.Controls.Add(this.buttonTemizleBonusCard);
            this.Controls.Add(this.buttonBonusCardSelect);
            this.Controls.Add(this.textBoxBonusCardCustomerName);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.checkBoxBarkodNo);
            this.Controls.Add(this.dataGridViewCartList);
            this.Controls.Add(this.LabelSalesFormUmuniCem_qiymet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSalesFormSatisEtmek);
            this.Controls.Add(this.groupBoxMehsul);
            this.Controls.Add(this.groupBoxMusteri);
            this.Controls.Add(this.ButonSalesFormSatisIptal);
            this.Controls.Add(this.dataGridViewProductList);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış səhifəsi";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).EndInit();
            this.groupBoxMusteri.ResumeLayout(false);
            this.groupBoxMusteri.PerformLayout();
            this.groupBoxMehsul.ResumeLayout(false);
            this.groupBoxMehsul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProductList;
        private System.Windows.Forms.Button ButtonSalesFormSil;
        private System.Windows.Forms.Button ButonSalesFormSatisIptal;
        private System.Windows.Forms.GroupBox groupBoxMusteri;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxAd;
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
        private System.Windows.Forms.Button ButtonSalesFormSatisEtmek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelSalesFormUmuniCem_qiymet;
        private System.Windows.Forms.DataGridView dataGridViewCartList;
        private System.Windows.Forms.TextBox textBoxMaxQiymet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxProductId;
       // private System.Windows.Forms.TextBox textBoxAxtarBarcodeNumber;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttoElaveEt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.CheckBox checkBoxBarkodNo;
        private System.Windows.Forms.Button buttonBarkodNoAxtar;
        private System.Windows.Forms.Button buttonBorcElaveEt;
        private System.Windows.Forms.Button buttonSec;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Button buttonDuzelt;
        private System.Windows.Forms.ComboBox comboBoxCategoryList;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxSupplierList;
        private System.Windows.Forms.ComboBox comboBoxBrandList;
        private System.Windows.Forms.Button buttonAxtar;
        private System.Windows.Forms.TextBox textBoxBonusCardCustomerName;
        private System.Windows.Forms.Button buttonBonusCardSelect;
        private System.Windows.Forms.Label labelBonusValue;
        private System.Windows.Forms.Button buttonTemizleBonusCard;
    }
}
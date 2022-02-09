
namespace WindowsForm.Forms.UserForms
{
    partial class SalesFormForUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesFormForUser));
            this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
            this.groupBoxMusteri = new System.Windows.Forms.GroupBox();
            this.TextBoxSalesFormTelefon = new System.Windows.Forms.TextBox();
            this.TextBoxSalesFormSoyad = new System.Windows.Forms.TextBox();
            this.TextBoxSalesFormAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxMehsul = new System.Windows.Forms.GroupBox();
            this.ButtonSalesFormSil = new System.Windows.Forms.Button();
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
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxBarkodNo = new System.Windows.Forms.CheckBox();
            this.buttonBarkodNoAxtar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
            this.groupBoxMusteri.SuspendLayout();
            this.groupBoxMehsul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartList)).BeginInit();
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
            this.dataGridViewProductList.Location = new System.Drawing.Point(263, 40);
            this.dataGridViewProductList.Name = "dataGridViewProductList";
            this.dataGridViewProductList.ReadOnly = true;
            this.dataGridViewProductList.RowTemplate.Height = 25;
            this.dataGridViewProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductList.Size = new System.Drawing.Size(806, 305);
            this.dataGridViewProductList.TabIndex = 1;
            this.dataGridViewProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSalesForm_CellDoubleClick);
            // 
            // groupBoxMusteri
            // 
            this.groupBoxMusteri.Controls.Add(this.TextBoxSalesFormTelefon);
            this.groupBoxMusteri.Controls.Add(this.TextBoxSalesFormSoyad);
            this.groupBoxMusteri.Controls.Add(this.TextBoxSalesFormAd);
            this.groupBoxMusteri.Controls.Add(this.label4);
            this.groupBoxMusteri.Controls.Add(this.label3);
            this.groupBoxMusteri.Controls.Add(this.label2);
            this.groupBoxMusteri.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxMusteri.Location = new System.Drawing.Point(13, 40);
            this.groupBoxMusteri.Name = "groupBoxMusteri";
            this.groupBoxMusteri.Size = new System.Drawing.Size(244, 130);
            this.groupBoxMusteri.TabIndex = 8;
            this.groupBoxMusteri.TabStop = false;
            this.groupBoxMusteri.Text = "Müştəri";
            // 
            // TextBoxSalesFormTelefon
            // 
            this.TextBoxSalesFormTelefon.Location = new System.Drawing.Point(84, 100);
            this.TextBoxSalesFormTelefon.Name = "TextBoxSalesFormTelefon";
            this.TextBoxSalesFormTelefon.Size = new System.Drawing.Size(145, 22);
            this.TextBoxSalesFormTelefon.TabIndex = 5;
            // 
            // TextBoxSalesFormSoyad
            // 
            this.TextBoxSalesFormSoyad.Location = new System.Drawing.Point(84, 61);
            this.TextBoxSalesFormSoyad.Name = "TextBoxSalesFormSoyad";
            this.TextBoxSalesFormSoyad.Size = new System.Drawing.Size(145, 22);
            this.TextBoxSalesFormSoyad.TabIndex = 4;
            // 
            // TextBoxSalesFormAd
            // 
            this.TextBoxSalesFormAd.Location = new System.Drawing.Point(84, 22);
            this.TextBoxSalesFormAd.Name = "TextBoxSalesFormAd";
            this.TextBoxSalesFormAd.Size = new System.Drawing.Size(145, 22);
            this.TextBoxSalesFormAd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // groupBoxMehsul
            // 
            this.groupBoxMehsul.Controls.Add(this.ButtonSalesFormSil);
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
            this.groupBoxMehsul.Controls.Add(this.textBoxBarkodNo);
            this.groupBoxMehsul.Controls.Add(this.label9);
            this.groupBoxMehsul.Controls.Add(this.label8);
            this.groupBoxMehsul.Controls.Add(this.label6);
            this.groupBoxMehsul.Controls.Add(this.label5);
            this.groupBoxMehsul.Controls.Add(this.label7);
            this.groupBoxMehsul.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxMehsul.Location = new System.Drawing.Point(13, 176);
            this.groupBoxMehsul.Name = "groupBoxMehsul";
            this.groupBoxMehsul.Size = new System.Drawing.Size(244, 460);
            this.groupBoxMehsul.TabIndex = 9;
            this.groupBoxMehsul.TabStop = false;
            this.groupBoxMehsul.Text = "Məhsul";
            // 
            // ButtonSalesFormSil
            // 
            this.ButtonSalesFormSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalesFormSil.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSalesFormSil.Image")));
            this.ButtonSalesFormSil.Location = new System.Drawing.Point(150, 375);
            this.ButtonSalesFormSil.Name = "ButtonSalesFormSil";
            this.ButtonSalesFormSil.Size = new System.Drawing.Size(88, 23);
            this.ButtonSalesFormSil.TabIndex = 35;
            this.ButtonSalesFormSil.Text = "Sil";
            this.ButtonSalesFormSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSalesFormSil.UseVisualStyleBackColor = true;
            this.ButtonSalesFormSil.Click += new System.EventHandler(this.ButtonSalesFormSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 69);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.Image")));
            this.buttonTemizle.Location = new System.Drawing.Point(57, 346);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(88, 23);
            this.buttonTemizle.TabIndex = 16;
            this.buttonTemizle.Text = "Təmizlə";
            this.buttonTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttoElaveEt
            // 
            this.buttoElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoElaveEt.Image = ((System.Drawing.Image)(resources.GetObject("buttoElaveEt.Image")));
            this.buttoElaveEt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoElaveEt.Location = new System.Drawing.Point(150, 346);
            this.buttoElaveEt.Name = "buttoElaveEt";
            this.buttoElaveEt.Size = new System.Drawing.Size(88, 23);
            this.buttoElaveEt.TabIndex = 18;
            this.buttoElaveEt.Text = "Əlavə et";
            this.buttoElaveEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttoElaveEt.UseVisualStyleBackColor = true;
            this.buttoElaveEt.Click += new System.EventHandler(this.buttoElaveEt_Click);
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Enabled = false;
            this.textBoxProductId.Location = new System.Drawing.Point(100, 139);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(138, 22);
            this.textBoxProductId.TabIndex = 14;
            // 
            // textBoxMaxQiymet
            // 
            this.textBoxMaxQiymet.Enabled = false;
            this.textBoxMaxQiymet.Location = new System.Drawing.Point(100, 227);
            this.textBoxMaxQiymet.Name = "textBoxMaxQiymet";
            this.textBoxMaxQiymet.Size = new System.Drawing.Size(138, 22);
            this.textBoxMaxQiymet.TabIndex = 13;
            this.textBoxMaxQiymet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaxQiymet_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Max qiymət:";
            // 
            // textBoxCem
            // 
            this.textBoxCem.Enabled = false;
            this.textBoxCem.Location = new System.Drawing.Point(100, 317);
            this.textBoxCem.Name = "textBoxCem";
            this.textBoxCem.Size = new System.Drawing.Size(138, 22);
            this.textBoxCem.TabIndex = 9;
            // 
            // textBoxQiymet
            // 
            this.textBoxQiymet.Location = new System.Drawing.Point(100, 257);
            this.textBoxQiymet.Name = "textBoxQiymet";
            this.textBoxQiymet.Size = new System.Drawing.Size(138, 22);
            this.textBoxQiymet.TabIndex = 8;
            this.textBoxQiymet.TextChanged += new System.EventHandler(this.textBoxQiymet_TextChanged);
            this.textBoxQiymet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQiymet_KeyPress);
            // 
            // textBoxMehsulAdi
            // 
            this.textBoxMehsulAdi.Enabled = false;
            this.textBoxMehsulAdi.Location = new System.Drawing.Point(100, 197);
            this.textBoxMehsulAdi.Name = "textBoxMehsulAdi";
            this.textBoxMehsulAdi.Size = new System.Drawing.Size(138, 22);
            this.textBoxMehsulAdi.TabIndex = 6;
            // 
            // textBoxMiqdar
            // 
            this.textBoxMiqdar.Location = new System.Drawing.Point(100, 287);
            this.textBoxMiqdar.Name = "textBoxMiqdar";
            this.textBoxMiqdar.Size = new System.Drawing.Size(138, 22);
            this.textBoxMiqdar.TabIndex = 7;
            this.textBoxMiqdar.TextChanged += new System.EventHandler(this.textBoxMiqdar_TextChanged);
            this.textBoxMiqdar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMiqdar_KeyPress);
            // 
            // textBoxBarkodNo
            // 
            this.textBoxBarkodNo.Location = new System.Drawing.Point(100, 167);
            this.textBoxBarkodNo.Name = "textBoxBarkodNo";
            this.textBoxBarkodNo.Size = new System.Drawing.Size(138, 22);
            this.textBoxBarkodNo.TabIndex = 5;
            this.textBoxBarkodNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarkodNo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cəm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Qiymət:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Məhsul adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "BarkodNo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Miqdar:";
            // 
            // ButtonSalesFormSatisEtmek
            // 
            this.ButtonSalesFormSatisEtmek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSalesFormSatisEtmek.FlatAppearance.BorderSize = 0;
            this.ButtonSalesFormSatisEtmek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalesFormSatisEtmek.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSalesFormSatisEtmek.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSalesFormSatisEtmek.Image")));
            this.ButtonSalesFormSatisEtmek.Location = new System.Drawing.Point(1075, 476);
            this.ButtonSalesFormSatisEtmek.Name = "ButtonSalesFormSatisEtmek";
            this.ButtonSalesFormSatisEtmek.Size = new System.Drawing.Size(75, 40);
            this.ButtonSalesFormSatisEtmek.TabIndex = 10;
            this.ButtonSalesFormSatisEtmek.Text = "  Sat";
            this.ButtonSalesFormSatisEtmek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSalesFormSatisEtmek.UseVisualStyleBackColor = true;
            this.ButtonSalesFormSatisEtmek.Click += new System.EventHandler(this.ButtonSalesFormSatisEtmek_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(834, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ümumi Cəm:";
            // 
            // LabelSalesFormUmuniCem_qiymet
            // 
            this.LabelSalesFormUmuniCem_qiymet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSalesFormUmuniCem_qiymet.AutoSize = true;
            this.LabelSalesFormUmuniCem_qiymet.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelSalesFormUmuniCem_qiymet.ForeColor = System.Drawing.Color.Red;
            this.LabelSalesFormUmuniCem_qiymet.Location = new System.Drawing.Point(960, 583);
            this.LabelSalesFormUmuniCem_qiymet.Name = "LabelSalesFormUmuniCem_qiymet";
            this.LabelSalesFormUmuniCem_qiymet.Size = new System.Drawing.Size(26, 23);
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
            this.dataGridViewCartList.Location = new System.Drawing.Point(263, 381);
            this.dataGridViewCartList.Name = "dataGridViewCartList";
            this.dataGridViewCartList.ReadOnly = true;
            this.dataGridViewCartList.RowTemplate.Height = 25;
            this.dataGridViewCartList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCartList.Size = new System.Drawing.Size(806, 198);
            this.dataGridViewCartList.TabIndex = 15;
            this.dataGridViewCartList.DoubleClick += new System.EventHandler(this.dataGridViewCartList_DoubleClick);
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(931, 12);
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
            this.pictureBoxRefresh.Location = new System.Drawing.Point(1075, 12);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefresh.TabIndex = 32;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.label12.Location = new System.Drawing.Point(902, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "     ";
            // 
            // checkBoxBarkodNo
            // 
            this.checkBoxBarkodNo.AutoSize = true;
            this.checkBoxBarkodNo.Location = new System.Drawing.Point(263, 346);
            this.checkBoxBarkodNo.Name = "checkBoxBarkodNo";
            this.checkBoxBarkodNo.Size = new System.Drawing.Size(81, 19);
            this.checkBoxBarkodNo.TabIndex = 37;
            this.checkBoxBarkodNo.Text = "Avtomatik";
            this.checkBoxBarkodNo.UseVisualStyleBackColor = true;
            this.checkBoxBarkodNo.CheckedChanged += new System.EventHandler(this.checkBoxBarkodNo_CheckedChanged);
            // 
            // buttonBarkodNoAxtar
            // 
            this.buttonBarkodNoAxtar.FlatAppearance.BorderSize = 0;
            this.buttonBarkodNoAxtar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarkodNoAxtar.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.buttonBarkodNoAxtar.Location = new System.Drawing.Point(6, 169);
            this.buttonBarkodNoAxtar.Name = "buttonBarkodNoAxtar";
            this.buttonBarkodNoAxtar.Size = new System.Drawing.Size(18, 18);
            this.buttonBarkodNoAxtar.TabIndex = 36;
            this.buttonBarkodNoAxtar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBarkodNoAxtar.UseVisualStyleBackColor = true;
            this.buttonBarkodNoAxtar.Visible = false;
            this.buttonBarkodNoAxtar.Click += new System.EventHandler(this.buttonBarkodNoAxtar_Click);
            // 
            // SalesFormForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1174, 641);
            this.Controls.Add(this.checkBoxBarkodNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.dataGridViewCartList);
            this.Controls.Add(this.LabelSalesFormUmuniCem_qiymet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSalesFormSatisEtmek);
            this.Controls.Add(this.groupBoxMehsul);
            this.Controls.Add(this.groupBoxMusteri);
            this.Controls.Add(this.dataGridViewProductList);
            this.Name = "SalesFormForUser";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProductList;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ButtonSalesFormSil;
        private System.Windows.Forms.Button buttonBarkodNoAxtar;
        private System.Windows.Forms.CheckBox checkBoxBarkodNo;
    }
}
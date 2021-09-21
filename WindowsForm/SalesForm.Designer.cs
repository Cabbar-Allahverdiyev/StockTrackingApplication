
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonX = new System.Windows.Forms.Label();
            this.ButtonSalesFormTedarukculer = new System.Windows.Forms.Button();
            this.ButtonFormKateqoriya = new System.Windows.Forms.Button();
            this.ButtonSalesFormMarka = new System.Windows.Forms.Button();
            this.ButtonSalesFormSatislariSirala = new System.Windows.Forms.Button();
            this.ButtonSalesFormMehsullariSirala = new System.Windows.Forms.Button();
            this.ButtonSalesFormMehsulElaveEtmek = new System.Windows.Forms.Button();
            this.ButtonSalesFormIstifadecileriSirala = new System.Windows.Forms.Button();
            this.ButtonSalesFormIstifadeciElaveEtmek = new System.Windows.Forms.Button();
            this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
            this.ButtonSalesFormSil = new System.Windows.Forms.Button();
            this.ButonSalesFormSatisIptal = new System.Windows.Forms.Button();
            this.GroupBoxSalesFormMusteriEmeliyyatlari = new System.Windows.Forms.GroupBox();
            this.TextBoxSalesFormTelefon = new System.Windows.Forms.TextBox();
            this.TextBoxSalesFormSoyad = new System.Windows.Forms.TextBox();
            this.TextBoxSalesFormAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
            this.GroupBoxSalesFormMusteriEmeliyyatlari.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonX);
            this.panel1.Controls.Add(this.ButtonSalesFormTedarukculer);
            this.panel1.Controls.Add(this.ButtonFormKateqoriya);
            this.panel1.Controls.Add(this.ButtonSalesFormMarka);
            this.panel1.Controls.Add(this.ButtonSalesFormSatislariSirala);
            this.panel1.Controls.Add(this.ButtonSalesFormMehsullariSirala);
            this.panel1.Controls.Add(this.ButtonSalesFormMehsulElaveEtmek);
            this.panel1.Controls.Add(this.ButtonSalesFormIstifadecileriSirala);
            this.panel1.Controls.Add(this.ButtonSalesFormIstifadeciElaveEtmek);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 70);
            this.panel1.TabIndex = 0;
            // 
            // ButtonX
            // 
            this.ButtonX.AutoSize = true;
            this.ButtonX.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonX.Location = new System.Drawing.Point(1339, 0);
            this.ButtonX.Name = "ButtonX";
            this.ButtonX.Size = new System.Drawing.Size(19, 21);
            this.ButtonX.TabIndex = 8;
            this.ButtonX.Text = "X";
            this.ButtonX.Click += new System.EventHandler(this.ButtonX_Click);
            // 
            // ButtonSalesFormTedarukculer
            // 
            this.ButtonSalesFormTedarukculer.Location = new System.Drawing.Point(858, 12);
            this.ButtonSalesFormTedarukculer.Name = "ButtonSalesFormTedarukculer";
            this.ButtonSalesFormTedarukculer.Size = new System.Drawing.Size(92, 43);
            this.ButtonSalesFormTedarukculer.TabIndex = 7;
            this.ButtonSalesFormTedarukculer.Text = "Tedarukculer";
            this.ButtonSalesFormTedarukculer.UseVisualStyleBackColor = true;
            this.ButtonSalesFormTedarukculer.Click += new System.EventHandler(this.ButtonSalesFormTedarukculer_Click);
            // 
            // ButtonFormKateqoriya
            // 
            this.ButtonFormKateqoriya.Location = new System.Drawing.Point(744, 12);
            this.ButtonFormKateqoriya.Name = "ButtonFormKateqoriya";
            this.ButtonFormKateqoriya.Size = new System.Drawing.Size(92, 43);
            this.ButtonFormKateqoriya.TabIndex = 6;
            this.ButtonFormKateqoriya.Text = "Kateqoriya";
            this.ButtonFormKateqoriya.UseVisualStyleBackColor = true;
            this.ButtonFormKateqoriya.Click += new System.EventHandler(this.ButtonFormKateqoriya_Click);
            // 
            // ButtonSalesFormMarka
            // 
            this.ButtonSalesFormMarka.Location = new System.Drawing.Point(623, 12);
            this.ButtonSalesFormMarka.Name = "ButtonSalesFormMarka";
            this.ButtonSalesFormMarka.Size = new System.Drawing.Size(92, 43);
            this.ButtonSalesFormMarka.TabIndex = 5;
            this.ButtonSalesFormMarka.Text = "Marka";
            this.ButtonSalesFormMarka.UseVisualStyleBackColor = true;
            this.ButtonSalesFormMarka.Click += new System.EventHandler(this.ButtonSalesFormMarka_Click);
            // 
            // ButtonSalesFormSatislariSirala
            // 
            this.ButtonSalesFormSatislariSirala.Location = new System.Drawing.Point(512, 12);
            this.ButtonSalesFormSatislariSirala.Name = "ButtonSalesFormSatislariSirala";
            this.ButtonSalesFormSatislariSirala.Size = new System.Drawing.Size(92, 43);
            this.ButtonSalesFormSatislariSirala.TabIndex = 4;
            this.ButtonSalesFormSatislariSirala.Text = "Satislari sirala";
            this.ButtonSalesFormSatislariSirala.UseVisualStyleBackColor = true;
            // 
            // ButtonSalesFormMehsullariSirala
            // 
            this.ButtonSalesFormMehsullariSirala.Location = new System.Drawing.Point(387, 12);
            this.ButtonSalesFormMehsullariSirala.Name = "ButtonSalesFormMehsullariSirala";
            this.ButtonSalesFormMehsullariSirala.Size = new System.Drawing.Size(92, 43);
            this.ButtonSalesFormMehsullariSirala.TabIndex = 3;
            this.ButtonSalesFormMehsullariSirala.Text = "Mehsullari sirala";
            this.ButtonSalesFormMehsullariSirala.UseVisualStyleBackColor = true;
            this.ButtonSalesFormMehsullariSirala.Click += new System.EventHandler(this.ButtonSalesFormMehsullariSirala_Click);
            // 
            // ButtonSalesFormMehsulElaveEtmek
            // 
            this.ButtonSalesFormMehsulElaveEtmek.Location = new System.Drawing.Point(262, 12);
            this.ButtonSalesFormMehsulElaveEtmek.Name = "ButtonSalesFormMehsulElaveEtmek";
            this.ButtonSalesFormMehsulElaveEtmek.Size = new System.Drawing.Size(92, 43);
            this.ButtonSalesFormMehsulElaveEtmek.TabIndex = 2;
            this.ButtonSalesFormMehsulElaveEtmek.Text = "Mehsul elave etmek";
            this.ButtonSalesFormMehsulElaveEtmek.UseVisualStyleBackColor = true;
            this.ButtonSalesFormMehsulElaveEtmek.Click += new System.EventHandler(this.ButtonSalesFormMehsulElaveEtmek_Click);
            // 
            // ButtonSalesFormIstifadecileriSirala
            // 
            this.ButtonSalesFormIstifadecileriSirala.Location = new System.Drawing.Point(137, 12);
            this.ButtonSalesFormIstifadecileriSirala.Name = "ButtonSalesFormIstifadecileriSirala";
            this.ButtonSalesFormIstifadecileriSirala.Size = new System.Drawing.Size(92, 43);
            this.ButtonSalesFormIstifadecileriSirala.TabIndex = 1;
            this.ButtonSalesFormIstifadecileriSirala.Text = "Istifadecileri Sirala";
            this.ButtonSalesFormIstifadecileriSirala.UseVisualStyleBackColor = true;
            this.ButtonSalesFormIstifadecileriSirala.Click += new System.EventHandler(this.ButtonSalesFormIstifadecileriSirala_Click);
            // 
            // ButtonSalesFormIstifadeciElaveEtmek
            // 
            this.ButtonSalesFormIstifadeciElaveEtmek.Location = new System.Drawing.Point(12, 12);
            this.ButtonSalesFormIstifadeciElaveEtmek.Name = "ButtonSalesFormIstifadeciElaveEtmek";
            this.ButtonSalesFormIstifadeciElaveEtmek.Size = new System.Drawing.Size(92, 43);
            this.ButtonSalesFormIstifadeciElaveEtmek.TabIndex = 0;
            this.ButtonSalesFormIstifadeciElaveEtmek.Text = "Istifadeci elave etmek ";
            this.ButtonSalesFormIstifadeciElaveEtmek.UseVisualStyleBackColor = true;
            this.ButtonSalesFormIstifadeciElaveEtmek.Click += new System.EventHandler(this.ButtonSalesFormIstifadeciElaveEtmek_Click);
            // 
            // dataGridViewProductList
            // 
            this.dataGridViewProductList.AllowUserToAddRows = false;
            this.dataGridViewProductList.AllowUserToDeleteRows = false;
            this.dataGridViewProductList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductList.Location = new System.Drawing.Point(262, 86);
            this.dataGridViewProductList.Name = "dataGridViewProductList";
            this.dataGridViewProductList.ReadOnly = true;
            this.dataGridViewProductList.RowTemplate.Height = 25;
            this.dataGridViewProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductList.Size = new System.Drawing.Size(1010, 426);
            this.dataGridViewProductList.TabIndex = 1;
            this.dataGridViewProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSalesForm_CellDoubleClick);
            // 
            // ButtonSalesFormSil
            // 
            this.ButtonSalesFormSil.Location = new System.Drawing.Point(1283, 86);
            this.ButtonSalesFormSil.Name = "ButtonSalesFormSil";
            this.ButtonSalesFormSil.Size = new System.Drawing.Size(75, 23);
            this.ButtonSalesFormSil.TabIndex = 2;
            this.ButtonSalesFormSil.Text = "Sil";
            this.ButtonSalesFormSil.UseVisualStyleBackColor = true;
            this.ButtonSalesFormSil.Click += new System.EventHandler(this.ButtonSalesFormSil_Click);
            // 
            // ButonSalesFormSatisIptal
            // 
            this.ButonSalesFormSatisIptal.Location = new System.Drawing.Point(1283, 115);
            this.ButonSalesFormSatisIptal.Name = "ButonSalesFormSatisIptal";
            this.ButonSalesFormSatisIptal.Size = new System.Drawing.Size(75, 23);
            this.ButonSalesFormSatisIptal.TabIndex = 3;
            this.ButonSalesFormSatisIptal.Text = "Satis iptal";
            this.ButonSalesFormSatisIptal.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSalesFormMusteriEmeliyyatlari
            // 
            this.GroupBoxSalesFormMusteriEmeliyyatlari.Controls.Add(this.TextBoxSalesFormTelefon);
            this.GroupBoxSalesFormMusteriEmeliyyatlari.Controls.Add(this.TextBoxSalesFormSoyad);
            this.GroupBoxSalesFormMusteriEmeliyyatlari.Controls.Add(this.TextBoxSalesFormAd);
            this.GroupBoxSalesFormMusteriEmeliyyatlari.Controls.Add(this.label4);
            this.GroupBoxSalesFormMusteriEmeliyyatlari.Controls.Add(this.label3);
            this.GroupBoxSalesFormMusteriEmeliyyatlari.Controls.Add(this.label2);
            this.GroupBoxSalesFormMusteriEmeliyyatlari.Location = new System.Drawing.Point(12, 86);
            this.GroupBoxSalesFormMusteriEmeliyyatlari.Name = "GroupBoxSalesFormMusteriEmeliyyatlari";
            this.GroupBoxSalesFormMusteriEmeliyyatlari.Size = new System.Drawing.Size(244, 130);
            this.GroupBoxSalesFormMusteriEmeliyyatlari.TabIndex = 8;
            this.GroupBoxSalesFormMusteriEmeliyyatlari.TabStop = false;
            this.GroupBoxSalesFormMusteriEmeliyyatlari.Text = "Musteri";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxProductId);
            this.groupBox2.Controls.Add(this.textBoxMaxQiymet);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxCem);
            this.groupBox2.Controls.Add(this.textBoxQiymet);
            this.groupBox2.Controls.Add(this.ButtonSalesFormElaveEt);
            this.groupBox2.Controls.Add(this.textBoxMehsulAdi);
            this.groupBox2.Controls.Add(this.textBoxMiqdar);
            this.groupBox2.Controls.Add(this.textBoxBarkodNo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 284);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mehsul";
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Enabled = false;
            this.textBoxProductId.Location = new System.Drawing.Point(100, 17);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(138, 23);
            this.textBoxProductId.TabIndex = 14;
            // 
            // textBoxMaxQiymet
            // 
            this.textBoxMaxQiymet.Enabled = false;
            this.textBoxMaxQiymet.Location = new System.Drawing.Point(100, 106);
            this.textBoxMaxQiymet.Name = "textBoxMaxQiymet";
            this.textBoxMaxQiymet.Size = new System.Drawing.Size(138, 23);
            this.textBoxMaxQiymet.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Max qiymet:";
            // 
            // textBoxCem
            // 
            this.textBoxCem.Enabled = false;
            this.textBoxCem.Location = new System.Drawing.Point(100, 195);
            this.textBoxCem.Name = "textBoxCem";
            this.textBoxCem.Size = new System.Drawing.Size(138, 23);
            this.textBoxCem.TabIndex = 9;
            // 
            // textBoxQiymet
            // 
            this.textBoxQiymet.Location = new System.Drawing.Point(100, 135);
            this.textBoxQiymet.Name = "textBoxQiymet";
            this.textBoxQiymet.Size = new System.Drawing.Size(138, 23);
            this.textBoxQiymet.TabIndex = 8;
            this.textBoxQiymet.TextChanged += new System.EventHandler(this.textBoxQiymet_TextChanged);
            // 
            // ButtonSalesFormElaveEt
            // 
            this.ButtonSalesFormElaveEt.Location = new System.Drawing.Point(167, 224);
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
            this.textBoxMehsulAdi.Location = new System.Drawing.Point(100, 76);
            this.textBoxMehsulAdi.Name = "textBoxMehsulAdi";
            this.textBoxMehsulAdi.Size = new System.Drawing.Size(138, 23);
            this.textBoxMehsulAdi.TabIndex = 6;
            // 
            // textBoxMiqdar
            // 
            this.textBoxMiqdar.Location = new System.Drawing.Point(100, 166);
            this.textBoxMiqdar.Name = "textBoxMiqdar";
            this.textBoxMiqdar.Size = new System.Drawing.Size(138, 23);
            this.textBoxMiqdar.TabIndex = 7;
            this.textBoxMiqdar.TextChanged += new System.EventHandler(this.textBoxMiqdar_TextChanged);
            // 
            // textBoxBarkodNo
            // 
            this.textBoxBarkodNo.Enabled = false;
            this.textBoxBarkodNo.Location = new System.Drawing.Point(100, 46);
            this.textBoxBarkodNo.Name = "textBoxBarkodNo";
            this.textBoxBarkodNo.Size = new System.Drawing.Size(138, 23);
            this.textBoxBarkodNo.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cem:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Qiymet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mehsul adi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "BarkodNo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Miqdar:";
            // 
            // ButtonSalesFormSatisEtmek
            // 
            this.ButtonSalesFormSatisEtmek.Location = new System.Drawing.Point(1278, 676);
            this.ButtonSalesFormSatisEtmek.Name = "ButtonSalesFormSatisEtmek";
            this.ButtonSalesFormSatisEtmek.Size = new System.Drawing.Size(80, 45);
            this.ButtonSalesFormSatisEtmek.TabIndex = 10;
            this.ButtonSalesFormSatisEtmek.Text = "Satis Etmek";
            this.ButtonSalesFormSatisEtmek.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(917, 724);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Umumi Cem:";
            // 
            // LabelSalesFormUmuniCem_qiymet
            // 
            this.LabelSalesFormUmuniCem_qiymet.AutoSize = true;
            this.LabelSalesFormUmuniCem_qiymet.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelSalesFormUmuniCem_qiymet.ForeColor = System.Drawing.Color.Red;
            this.LabelSalesFormUmuniCem_qiymet.Location = new System.Drawing.Point(1043, 724);
            this.LabelSalesFormUmuniCem_qiymet.Name = "LabelSalesFormUmuniCem_qiymet";
            this.LabelSalesFormUmuniCem_qiymet.Size = new System.Drawing.Size(23, 25);
            this.LabelSalesFormUmuniCem_qiymet.TabIndex = 13;
            this.LabelSalesFormUmuniCem_qiymet.Text = "#";
            // 
            // ButtonSalesFormYenile
            // 
            this.ButtonSalesFormYenile.Location = new System.Drawing.Point(1289, 186);
            this.ButtonSalesFormYenile.Name = "ButtonSalesFormYenile";
            this.ButtonSalesFormYenile.Size = new System.Drawing.Size(50, 50);
            this.ButtonSalesFormYenile.TabIndex = 14;
            this.ButtonSalesFormYenile.Text = "Yenile";
            this.ButtonSalesFormYenile.UseVisualStyleBackColor = true;
            this.ButtonSalesFormYenile.Click += new System.EventHandler(this.ButtonSalesFormYenile_Click);
            // 
            // dataGridViewCartList
            // 
            this.dataGridViewCartList.AllowUserToAddRows = false;
            this.dataGridViewCartList.AllowUserToDeleteRows = false;
            this.dataGridViewCartList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewCartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCartList.Location = new System.Drawing.Point(262, 518);
            this.dataGridViewCartList.Name = "dataGridViewCartList";
            this.dataGridViewCartList.ReadOnly = true;
            this.dataGridViewCartList.RowTemplate.Height = 25;
            this.dataGridViewCartList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCartList.Size = new System.Drawing.Size(1010, 203);
            this.dataGridViewCartList.TabIndex = 15;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.dataGridViewCartList);
            this.Controls.Add(this.ButtonSalesFormYenile);
            this.Controls.Add(this.LabelSalesFormUmuniCem_qiymet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSalesFormSatisEtmek);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBoxSalesFormMusteriEmeliyyatlari);
            this.Controls.Add(this.ButonSalesFormSatisIptal);
            this.Controls.Add(this.ButtonSalesFormSil);
            this.Controls.Add(this.dataGridViewProductList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).EndInit();
            this.GroupBoxSalesFormMusteriEmeliyyatlari.ResumeLayout(false);
            this.GroupBoxSalesFormMusteriEmeliyyatlari.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonSalesFormSatislariSirala;
        private System.Windows.Forms.Button ButtonSalesFormMehsullariSirala;
        private System.Windows.Forms.Button ButtonSalesFormMehsulElaveEtmek;
        private System.Windows.Forms.Button ButtonSalesFormIstifadecileriSirala;
        private System.Windows.Forms.Button ButtonSalesFormIstifadeciElaveEtmek;
        private System.Windows.Forms.DataGridView dataGridViewProductList;
        private System.Windows.Forms.Button ButtonSalesFormSil;
        private System.Windows.Forms.Button ButonSalesFormSatisIptal;
        private System.Windows.Forms.GroupBox GroupBoxSalesFormMusteriEmeliyyatlari;
        private System.Windows.Forms.TextBox TextBoxSalesFormTelefon;
        private System.Windows.Forms.TextBox TextBoxSalesFormSoyad;
        private System.Windows.Forms.TextBox TextBoxSalesFormAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.Button ButtonFormKateqoriya;
        private System.Windows.Forms.Button ButtonSalesFormMarka;
        private System.Windows.Forms.Button ButtonSalesFormTedarukculer;
        private System.Windows.Forms.Button ButtonSalesFormElaveEt;
        private System.Windows.Forms.Button ButtonSalesFormSatisEtmek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelSalesFormUmuniCem_qiymet;
        private System.Windows.Forms.Button ButtonSalesFormYenile;
        private System.Windows.Forms.Label ButtonX;
        private System.Windows.Forms.DataGridView dataGridViewCartList;
        private System.Windows.Forms.TextBox textBoxMaxQiymet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxProductId;
    }
}
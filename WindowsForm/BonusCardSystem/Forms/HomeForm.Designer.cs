
namespace WindowsForm.BonusCardSystem.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.checkBoxBonusCard = new System.Windows.Forms.CheckBox();
            this.textBoxBonusCardSelect = new System.Windows.Forms.TextBox();
            this.buttonTemizleBonusCard = new System.Windows.Forms.Button();
            this.buttonBonusCardSelect = new System.Windows.Forms.Button();
            this.groupBoxMusteri = new System.Windows.Forms.GroupBox();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonElaveEt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGuzest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.groupBoxBonusCardSearch = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxDays = new System.Windows.Forms.ComboBox();
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.buttonAxtar = new System.Windows.Forms.Button();
            this.comboBoxMonths = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.groupBoxMusteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.groupBoxBonusCardSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRefresh.ErrorImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Image = global::WindowsForm.Properties.Resources.refreshBlack_16px_;
            this.pictureBoxRefresh.InitialImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(2182, 11);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(25, 30);
            this.pictureBoxRefresh.TabIndex = 51;
            this.pictureBoxRefresh.TabStop = false;
            // 
            // checkBoxBonusCard
            // 
            this.checkBoxBonusCard.AutoSize = true;
            this.checkBoxBonusCard.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxBonusCard.Location = new System.Drawing.Point(259, 26);
            this.checkBoxBonusCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBonusCard.Name = "checkBoxBonusCard";
            this.checkBoxBonusCard.Size = new System.Drawing.Size(79, 18);
            this.checkBoxBonusCard.TabIndex = 57;
            this.checkBoxBonusCard.Text = "Avtomatik";
            this.checkBoxBonusCard.UseVisualStyleBackColor = true;
            this.checkBoxBonusCard.CheckedChanged += new System.EventHandler(this.checkBoxBonusCard_CheckedChanged);
            // 
            // textBoxBonusCardSelect
            // 
            this.textBoxBonusCardSelect.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBonusCardSelect.Location = new System.Drawing.Point(78, 21);
            this.textBoxBonusCardSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBonusCardSelect.Name = "textBoxBonusCardSelect";
            this.textBoxBonusCardSelect.Size = new System.Drawing.Size(175, 23);
            this.textBoxBonusCardSelect.TabIndex = 56;
            this.textBoxBonusCardSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBonusCardSelect_KeyPress);
            // 
            // buttonTemizleBonusCard
            // 
            this.buttonTemizleBonusCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizleBonusCard.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTemizleBonusCard.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizleBonusCard.Image")));
            this.buttonTemizleBonusCard.Location = new System.Drawing.Point(78, 133);
            this.buttonTemizleBonusCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTemizleBonusCard.Name = "buttonTemizleBonusCard";
            this.buttonTemizleBonusCard.Size = new System.Drawing.Size(95, 27);
            this.buttonTemizleBonusCard.TabIndex = 55;
            this.buttonTemizleBonusCard.Text = "Təmizlə";
            this.buttonTemizleBonusCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTemizleBonusCard.UseVisualStyleBackColor = true;
            this.buttonTemizleBonusCard.Click += new System.EventHandler(this.buttonTemizleBonusCard_Click);
            // 
            // buttonBonusCardSelect
            // 
            this.buttonBonusCardSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBonusCardSelect.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBonusCardSelect.Image = global::WindowsForm.Properties.Resources.bonus_card_16px_2;
            this.buttonBonusCardSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBonusCardSelect.Location = new System.Drawing.Point(78, 21);
            this.buttonBonusCardSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBonusCardSelect.Name = "buttonBonusCardSelect";
            this.buttonBonusCardSelect.Size = new System.Drawing.Size(175, 23);
            this.buttonBonusCardSelect.TabIndex = 54;
            this.buttonBonusCardSelect.Text = "Bonus kart seç";
            this.buttonBonusCardSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBonusCardSelect.UseVisualStyleBackColor = true;
            this.buttonBonusCardSelect.Click += new System.EventHandler(this.buttonBonusCardSelect_Click);
            // 
            // groupBoxMusteri
            // 
            this.groupBoxMusteri.Controls.Add(this.textBoxCustomer);
            this.groupBoxMusteri.Controls.Add(this.label2);
            this.groupBoxMusteri.Controls.Add(this.textBoxValue);
            this.groupBoxMusteri.Controls.Add(this.label5);
            this.groupBoxMusteri.Controls.Add(this.buttonTemizleBonusCard);
            this.groupBoxMusteri.Controls.Add(this.checkBoxBonusCard);
            this.groupBoxMusteri.Controls.Add(this.textBoxBonusCardSelect);
            this.groupBoxMusteri.Controls.Add(this.buttonElaveEt);
            this.groupBoxMusteri.Controls.Add(this.buttonBonusCardSelect);
            this.groupBoxMusteri.Controls.Add(this.label7);
            this.groupBoxMusteri.Controls.Add(this.textBoxGuzest);
            this.groupBoxMusteri.Controls.Add(this.label6);
            this.groupBoxMusteri.Controls.Add(this.label1);
            this.groupBoxMusteri.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxMusteri.Location = new System.Drawing.Point(12, 34);
            this.groupBoxMusteri.Name = "groupBoxMusteri";
            this.groupBoxMusteri.Size = new System.Drawing.Size(339, 185);
            this.groupBoxMusteri.TabIndex = 58;
            this.groupBoxMusteri.TabStop = false;
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Enabled = false;
            this.textBoxCustomer.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCustomer.Location = new System.Drawing.Point(78, 49);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(175, 22);
            this.textBoxCustomer.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 60;
            this.label2.Text = "Musteri :";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxValue.Location = new System.Drawing.Point(78, 106);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(55, 22);
            this.textBoxValue.TabIndex = 59;
            this.textBoxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValue_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 14);
            this.label5.TabIndex = 58;
            this.label5.Text = "Məbləğ :";
            // 
            // buttonElaveEt
            // 
            this.buttonElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElaveEt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonElaveEt.Image = global::WindowsForm.Properties.Resources.bonus_card_16px;
            this.buttonElaveEt.Location = new System.Drawing.Point(179, 133);
            this.buttonElaveEt.Name = "buttonElaveEt";
            this.buttonElaveEt.Size = new System.Drawing.Size(95, 27);
            this.buttonElaveEt.TabIndex = 48;
            this.buttonElaveEt.Text = " Tətbiq et";
            this.buttonElaveEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonElaveEt.UseVisualStyleBackColor = true;
            this.buttonElaveEt.Click += new System.EventHandler(this.buttonElaveEt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(132, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "%";
            // 
            // textBoxGuzest
            // 
            this.textBoxGuzest.Enabled = false;
            this.textBoxGuzest.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGuzest.Location = new System.Drawing.Point(78, 77);
            this.textBoxGuzest.Name = "textBoxGuzest";
            this.textBoxGuzest.Size = new System.Drawing.Size(53, 22);
            this.textBoxGuzest.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 14);
            this.label6.TabIndex = 43;
            this.label6.Text = "Güzəşt :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 40;
            this.label1.Text = "Barkod :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBox1.Image = global::WindowsForm.Properties.Resources.refreshBlack_16px_;
            this.pictureBox1.InitialImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBox1.Location = new System.Drawing.Point(900, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.label12.Location = new System.Drawing.Point(730, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 17);
            this.label12.TabIndex = 60;
            this.label12.Text = "     ";
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(759, 9);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(135, 22);
            this.textBoxAxtar.TabIndex = 59;
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
            this.dataGridViewList.Location = new System.Drawing.Point(357, 40);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            this.dataGridViewList.RowTemplate.Height = 25;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(568, 421);
            this.dataGridViewList.TabIndex = 62;
            this.dataGridViewList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellDoubleClick);
            // 
            // groupBoxBonusCardSearch
            // 
            this.groupBoxBonusCardSearch.Controls.Add(this.label3);
            this.groupBoxBonusCardSearch.Controls.Add(this.label4);
            this.groupBoxBonusCardSearch.Controls.Add(this.labelIncome);
            this.groupBoxBonusCardSearch.Controls.Add(this.labelTotal);
            this.groupBoxBonusCardSearch.Controls.Add(this.buttonTemizle);
            this.groupBoxBonusCardSearch.Controls.Add(this.label8);
            this.groupBoxBonusCardSearch.Controls.Add(this.label9);
            this.groupBoxBonusCardSearch.Controls.Add(this.label10);
            this.groupBoxBonusCardSearch.Controls.Add(this.comboBoxDays);
            this.groupBoxBonusCardSearch.Controls.Add(this.comboBoxYears);
            this.groupBoxBonusCardSearch.Controls.Add(this.buttonAxtar);
            this.groupBoxBonusCardSearch.Controls.Add(this.comboBoxMonths);
            this.groupBoxBonusCardSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxBonusCardSearch.Location = new System.Drawing.Point(12, 225);
            this.groupBoxBonusCardSearch.Name = "groupBoxBonusCardSearch";
            this.groupBoxBonusCardSearch.Size = new System.Drawing.Size(248, 215);
            this.groupBoxBonusCardSearch.TabIndex = 63;
            this.groupBoxBonusCardSearch.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(114, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 37;
            this.label3.Text = "Alver :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(116, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 36;
            this.label4.Text = "Gəlir :";
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIncome.ForeColor = System.Drawing.Color.Red;
            this.labelIncome.Location = new System.Drawing.Point(161, 188);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(14, 14);
            this.labelIncome.TabIndex = 35;
            this.labelIncome.Text = "#";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.ForeColor = System.Drawing.Color.Red;
            this.labelTotal.Location = new System.Drawing.Point(161, 167);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(14, 14);
            this.labelTotal.TabIndex = 34;
            this.labelTotal.Text = "#";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.Image")));
            this.buttonTemizle.Location = new System.Drawing.Point(73, 118);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(88, 25);
            this.buttonTemizle.TabIndex = 30;
            this.buttonTemizle.Text = "Təmizlə";
            this.buttonTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(49, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 14);
            this.label8.TabIndex = 29;
            this.label8.Text = "İl :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(40, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 14);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ay :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(31, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 14);
            this.label10.TabIndex = 27;
            this.label10.Text = "Gün :";
            // 
            // comboBoxDays
            // 
            this.comboBoxDays.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDays.FormattingEnabled = true;
            this.comboBoxDays.Location = new System.Drawing.Point(73, 21);
            this.comboBoxDays.Name = "comboBoxDays";
            this.comboBoxDays.Size = new System.Drawing.Size(169, 22);
            this.comboBoxDays.TabIndex = 22;
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Location = new System.Drawing.Point(73, 87);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(169, 22);
            this.comboBoxYears.TabIndex = 26;
            // 
            // buttonAxtar
            // 
            this.buttonAxtar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAxtar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAxtar.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.buttonAxtar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAxtar.Location = new System.Drawing.Point(167, 118);
            this.buttonAxtar.Name = "buttonAxtar";
            this.buttonAxtar.Size = new System.Drawing.Size(75, 25);
            this.buttonAxtar.TabIndex = 17;
            this.buttonAxtar.Text = "   Axtar";
            this.buttonAxtar.UseVisualStyleBackColor = true;
            this.buttonAxtar.Click += new System.EventHandler(this.buttonAxtar_Click);
            // 
            // comboBoxMonths
            // 
            this.comboBoxMonths.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMonths.FormattingEnabled = true;
            this.comboBoxMonths.Location = new System.Drawing.Point(73, 54);
            this.comboBoxMonths.Name = "comboBoxMonths";
            this.comboBoxMonths.Size = new System.Drawing.Size(169, 22);
            this.comboBoxMonths.TabIndex = 24;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(937, 494);
            this.Controls.Add(this.groupBoxBonusCardSearch);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.groupBoxMusteri);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.groupBoxMusteri.ResumeLayout(false);
            this.groupBoxMusteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.groupBoxBonusCardSearch.ResumeLayout(false);
            this.groupBoxBonusCardSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.CheckBox checkBoxBonusCard;
        private System.Windows.Forms.TextBox textBoxBonusCardSelect;
        private System.Windows.Forms.Button buttonTemizleBonusCard;
        private System.Windows.Forms.Button buttonBonusCardSelect;
        private System.Windows.Forms.GroupBox groupBoxMusteri;
        private System.Windows.Forms.Button buttonElaveEt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGuzest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.GroupBox groupBoxBonusCardSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxDays;
        private System.Windows.Forms.ComboBox comboBoxYears;
        private System.Windows.Forms.Button buttonAxtar;
        private System.Windows.Forms.ComboBox comboBoxMonths;
    }
}
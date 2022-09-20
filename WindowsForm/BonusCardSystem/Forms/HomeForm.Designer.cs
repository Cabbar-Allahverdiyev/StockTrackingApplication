
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
            this.checkBoxBonusCard = new System.Windows.Forms.CheckBox();
            this.textBoxBonusCardSelect = new System.Windows.Forms.TextBox();
            this.buttonTemizleBonus = new System.Windows.Forms.Button();
            this.buttonBonusCardSelect = new System.Windows.Forms.Button();
            this.groupBoxBonus = new System.Windows.Forms.GroupBox();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTetbiqEt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGuzest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.groupBoxBonusCardSearch = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelGBTotalBonusMade = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelGBTotalBonusCardSales = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxDays = new System.Windows.Forms.ComboBox();
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.buttonAxtar = new System.Windows.Forms.Button();
            this.comboBoxMonths = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalBonus = new System.Windows.Forms.Label();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.textBoxGroupBoxPaymentCustomer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxGroupBoxPaymentValue = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonGroupBoxTemizlePayment = new System.Windows.Forms.Button();
            this.checkBoxGroupBoxPayment = new System.Windows.Forms.CheckBox();
            this.textBoxGroupBoxPaymentBonusCardSelect = new System.Windows.Forms.TextBox();
            this.buttonGroupBoxPaymentOdenisEt = new System.Windows.Forms.Button();
            this.buttonGroupBoxPaymentBonusCardSelect = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelTotalMadeBonus = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelTotalBonusCardSales = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelTotalActiveBonusCardSales = new System.Windows.Forms.Label();
            this.groupBoxBonus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.groupBoxBonusCardSearch.SuspendLayout();
            this.groupBoxPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxBonusCard
            // 
            this.checkBoxBonusCard.AutoSize = true;
            this.checkBoxBonusCard.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxBonusCard.Location = new System.Drawing.Point(259, 26);
            this.checkBoxBonusCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBonusCard.Name = "checkBoxBonusCard";
            this.checkBoxBonusCard.Size = new System.Drawing.Size(78, 19);
            this.checkBoxBonusCard.TabIndex = 57;
            this.checkBoxBonusCard.Text = "Avtomatik";
            this.checkBoxBonusCard.UseVisualStyleBackColor = true;
            this.checkBoxBonusCard.CheckedChanged += new System.EventHandler(this.checkBoxBonusCard_CheckedChanged);
            // 
            // textBoxBonusCardSelect
            // 
            this.textBoxBonusCardSelect.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBonusCardSelect.Location = new System.Drawing.Point(78, 21);
            this.textBoxBonusCardSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBonusCardSelect.Name = "textBoxBonusCardSelect";
            this.textBoxBonusCardSelect.Size = new System.Drawing.Size(175, 23);
            this.textBoxBonusCardSelect.TabIndex = 56;
            this.textBoxBonusCardSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBonusCardSelect_KeyPress);
            // 
            // buttonTemizleBonus
            // 
            this.buttonTemizleBonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizleBonus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTemizleBonus.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizleBonus.Image")));
            this.buttonTemizleBonus.Location = new System.Drawing.Point(78, 133);
            this.buttonTemizleBonus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTemizleBonus.Name = "buttonTemizleBonus";
            this.buttonTemizleBonus.Size = new System.Drawing.Size(100, 27);
            this.buttonTemizleBonus.TabIndex = 55;
            this.buttonTemizleBonus.Text = "Təmizlə";
            this.buttonTemizleBonus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTemizleBonus.UseVisualStyleBackColor = true;
            this.buttonTemizleBonus.Click += new System.EventHandler(this.buttonTemizleBonusCard_Click);
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
            // groupBoxBonus
            // 
            this.groupBoxBonus.Controls.Add(this.textBoxCustomer);
            this.groupBoxBonus.Controls.Add(this.label2);
            this.groupBoxBonus.Controls.Add(this.textBoxValue);
            this.groupBoxBonus.Controls.Add(this.label5);
            this.groupBoxBonus.Controls.Add(this.buttonTemizleBonus);
            this.groupBoxBonus.Controls.Add(this.checkBoxBonusCard);
            this.groupBoxBonus.Controls.Add(this.textBoxBonusCardSelect);
            this.groupBoxBonus.Controls.Add(this.buttonTetbiqEt);
            this.groupBoxBonus.Controls.Add(this.buttonBonusCardSelect);
            this.groupBoxBonus.Controls.Add(this.label7);
            this.groupBoxBonus.Controls.Add(this.textBoxGuzest);
            this.groupBoxBonus.Controls.Add(this.label6);
            this.groupBoxBonus.Controls.Add(this.label1);
            this.groupBoxBonus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxBonus.Location = new System.Drawing.Point(14, 257);
            this.groupBoxBonus.Name = "groupBoxBonus";
            this.groupBoxBonus.Size = new System.Drawing.Size(339, 185);
            this.groupBoxBonus.TabIndex = 58;
            this.groupBoxBonus.TabStop = false;
            this.groupBoxBonus.Text = "Bonus";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Enabled = false;
            this.textBoxCustomer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCustomer.Location = new System.Drawing.Point(78, 49);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(175, 21);
            this.textBoxCustomer.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 60;
            this.label2.Text = "Musteri :";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxValue.Location = new System.Drawing.Point(78, 106);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(55, 21);
            this.textBoxValue.TabIndex = 59;
            this.textBoxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValue_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 58;
            this.label5.Text = "Məbləğ :";
            // 
            // buttonTetbiqEt
            // 
            this.buttonTetbiqEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTetbiqEt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTetbiqEt.Image = global::WindowsForm.Properties.Resources.bonus_card_16px;
            this.buttonTetbiqEt.Location = new System.Drawing.Point(184, 133);
            this.buttonTetbiqEt.Name = "buttonTetbiqEt";
            this.buttonTetbiqEt.Size = new System.Drawing.Size(100, 27);
            this.buttonTetbiqEt.TabIndex = 48;
            this.buttonTetbiqEt.Text = " Tətbiq et";
            this.buttonTetbiqEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTetbiqEt.UseVisualStyleBackColor = true;
            this.buttonTetbiqEt.Click += new System.EventHandler(this.buttonElaveEt_Click);
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
            this.textBoxGuzest.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGuzest.Location = new System.Drawing.Point(78, 77);
            this.textBoxGuzest.Name = "textBoxGuzest";
            this.textBoxGuzest.Size = new System.Drawing.Size(53, 21);
            this.textBoxGuzest.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Güzəşt :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Barkod :";
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRefresh.ErrorImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Image = global::WindowsForm.Properties.Resources.refreshBlack_16px_;
            this.pictureBoxRefresh.InitialImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(900, 9);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefresh.TabIndex = 61;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
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
            this.textBoxAxtar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(759, 9);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(135, 21);
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
            this.dataGridViewList.Size = new System.Drawing.Size(568, 500);
            this.dataGridViewList.TabIndex = 62;
            this.dataGridViewList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellDoubleClick);
            // 
            // groupBoxBonusCardSearch
            // 
            this.groupBoxBonusCardSearch.Controls.Add(this.label11);
            this.groupBoxBonusCardSearch.Controls.Add(this.labelGBTotalBonusMade);
            this.groupBoxBonusCardSearch.Controls.Add(this.label4);
            this.groupBoxBonusCardSearch.Controls.Add(this.labelGBTotalBonusCardSales);
            this.groupBoxBonusCardSearch.Controls.Add(this.buttonTemizle);
            this.groupBoxBonusCardSearch.Controls.Add(this.label8);
            this.groupBoxBonusCardSearch.Controls.Add(this.label9);
            this.groupBoxBonusCardSearch.Controls.Add(this.label10);
            this.groupBoxBonusCardSearch.Controls.Add(this.comboBoxDays);
            this.groupBoxBonusCardSearch.Controls.Add(this.comboBoxYears);
            this.groupBoxBonusCardSearch.Controls.Add(this.buttonAxtar);
            this.groupBoxBonusCardSearch.Controls.Add(this.comboBoxMonths);
            this.groupBoxBonusCardSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxBonusCardSearch.Location = new System.Drawing.Point(12, 33);
            this.groupBoxBonusCardSearch.Name = "groupBoxBonusCardSearch";
            this.groupBoxBonusCardSearch.Size = new System.Drawing.Size(274, 211);
            this.groupBoxBonusCardSearch.TabIndex = 63;
            this.groupBoxBonusCardSearch.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(35, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 15);
            this.label11.TabIndex = 39;
            this.label11.Text = "Verilən cəmi bonuslar :";
            // 
            // labelGBTotalBonusMade
            // 
            this.labelGBTotalBonusMade.AutoSize = true;
            this.labelGBTotalBonusMade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGBTotalBonusMade.ForeColor = System.Drawing.Color.Red;
            this.labelGBTotalBonusMade.Location = new System.Drawing.Point(169, 170);
            this.labelGBTotalBonusMade.Name = "labelGBTotalBonusMade";
            this.labelGBTotalBonusMade.Size = new System.Drawing.Size(14, 15);
            this.labelGBTotalBonusMade.TabIndex = 38;
            this.labelGBTotalBonusMade.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Bonus kartla edilən satışlar :";
            // 
            // labelGBTotalBonusCardSales
            // 
            this.labelGBTotalBonusCardSales.AutoSize = true;
            this.labelGBTotalBonusCardSales.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGBTotalBonusCardSales.ForeColor = System.Drawing.Color.Red;
            this.labelGBTotalBonusCardSales.Location = new System.Drawing.Point(170, 152);
            this.labelGBTotalBonusCardSales.Name = "labelGBTotalBonusCardSales";
            this.labelGBTotalBonusCardSales.Size = new System.Drawing.Size(14, 15);
            this.labelGBTotalBonusCardSales.TabIndex = 35;
            this.labelGBTotalBonusCardSales.Text = "#";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.Image")));
            this.buttonTemizle.Location = new System.Drawing.Point(48, 109);
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
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(24, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "İl :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(15, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ay :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Gün :";
            // 
            // comboBoxDays
            // 
            this.comboBoxDays.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDays.FormattingEnabled = true;
            this.comboBoxDays.Location = new System.Drawing.Point(48, 15);
            this.comboBoxDays.Name = "comboBoxDays";
            this.comboBoxDays.Size = new System.Drawing.Size(182, 23);
            this.comboBoxDays.TabIndex = 22;
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Location = new System.Drawing.Point(48, 81);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(182, 23);
            this.comboBoxYears.TabIndex = 26;
            // 
            // buttonAxtar
            // 
            this.buttonAxtar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAxtar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAxtar.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.buttonAxtar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAxtar.Location = new System.Drawing.Point(142, 109);
            this.buttonAxtar.Name = "buttonAxtar";
            this.buttonAxtar.Size = new System.Drawing.Size(88, 25);
            this.buttonAxtar.TabIndex = 17;
            this.buttonAxtar.Text = "   Axtar";
            this.buttonAxtar.UseVisualStyleBackColor = true;
            this.buttonAxtar.Click += new System.EventHandler(this.buttonAxtar_Click);
            // 
            // comboBoxMonths
            // 
            this.comboBoxMonths.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMonths.FormattingEnabled = true;
            this.comboBoxMonths.Location = new System.Drawing.Point(48, 48);
            this.comboBoxMonths.Name = "comboBoxMonths";
            this.comboBoxMonths.Size = new System.Drawing.Size(182, 23);
            this.comboBoxMonths.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(669, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Sistemdə olan cəmi bonuslar :";
            // 
            // labelTotalBonus
            // 
            this.labelTotalBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalBonus.AutoSize = true;
            this.labelTotalBonus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalBonus.ForeColor = System.Drawing.Color.Red;
            this.labelTotalBonus.Location = new System.Drawing.Point(858, 551);
            this.labelTotalBonus.Name = "labelTotalBonus";
            this.labelTotalBonus.Size = new System.Drawing.Size(14, 16);
            this.labelTotalBonus.TabIndex = 34;
            this.labelTotalBonus.Text = "#";
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.textBoxGroupBoxPaymentCustomer);
            this.groupBoxPayment.Controls.Add(this.label13);
            this.groupBoxPayment.Controls.Add(this.textBoxGroupBoxPaymentValue);
            this.groupBoxPayment.Controls.Add(this.label14);
            this.groupBoxPayment.Controls.Add(this.buttonGroupBoxTemizlePayment);
            this.groupBoxPayment.Controls.Add(this.checkBoxGroupBoxPayment);
            this.groupBoxPayment.Controls.Add(this.textBoxGroupBoxPaymentBonusCardSelect);
            this.groupBoxPayment.Controls.Add(this.buttonGroupBoxPaymentOdenisEt);
            this.groupBoxPayment.Controls.Add(this.buttonGroupBoxPaymentBonusCardSelect);
            this.groupBoxPayment.Controls.Add(this.label17);
            this.groupBoxPayment.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPayment.Location = new System.Drawing.Point(12, 442);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(339, 164);
            this.groupBoxPayment.TabIndex = 62;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Ödəniş";
            // 
            // textBoxGroupBoxPaymentCustomer
            // 
            this.textBoxGroupBoxPaymentCustomer.Enabled = false;
            this.textBoxGroupBoxPaymentCustomer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGroupBoxPaymentCustomer.Location = new System.Drawing.Point(78, 49);
            this.textBoxGroupBoxPaymentCustomer.Name = "textBoxGroupBoxPaymentCustomer";
            this.textBoxGroupBoxPaymentCustomer.Size = new System.Drawing.Size(175, 21);
            this.textBoxGroupBoxPaymentCustomer.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(17, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 15);
            this.label13.TabIndex = 60;
            this.label13.Text = "Musteri :";
            // 
            // textBoxGroupBoxPaymentValue
            // 
            this.textBoxGroupBoxPaymentValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGroupBoxPaymentValue.Location = new System.Drawing.Point(77, 77);
            this.textBoxGroupBoxPaymentValue.Name = "textBoxGroupBoxPaymentValue";
            this.textBoxGroupBoxPaymentValue.Size = new System.Drawing.Size(55, 21);
            this.textBoxGroupBoxPaymentValue.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(16, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 15);
            this.label14.TabIndex = 58;
            this.label14.Text = "Məbləğ :";
            // 
            // buttonGroupBoxTemizlePayment
            // 
            this.buttonGroupBoxTemizlePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroupBoxTemizlePayment.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGroupBoxTemizlePayment.Image = ((System.Drawing.Image)(resources.GetObject("buttonGroupBoxTemizlePayment.Image")));
            this.buttonGroupBoxTemizlePayment.Location = new System.Drawing.Point(77, 104);
            this.buttonGroupBoxTemizlePayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGroupBoxTemizlePayment.Name = "buttonGroupBoxTemizlePayment";
            this.buttonGroupBoxTemizlePayment.Size = new System.Drawing.Size(100, 27);
            this.buttonGroupBoxTemizlePayment.TabIndex = 55;
            this.buttonGroupBoxTemizlePayment.Text = "Təmizlə";
            this.buttonGroupBoxTemizlePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGroupBoxTemizlePayment.UseVisualStyleBackColor = true;
            this.buttonGroupBoxTemizlePayment.Click += new System.EventHandler(this.buttonGroupBoxTemizlePayment_Click);
            // 
            // checkBoxGroupBoxPayment
            // 
            this.checkBoxGroupBoxPayment.AutoSize = true;
            this.checkBoxGroupBoxPayment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxGroupBoxPayment.Location = new System.Drawing.Point(259, 26);
            this.checkBoxGroupBoxPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxGroupBoxPayment.Name = "checkBoxGroupBoxPayment";
            this.checkBoxGroupBoxPayment.Size = new System.Drawing.Size(78, 19);
            this.checkBoxGroupBoxPayment.TabIndex = 57;
            this.checkBoxGroupBoxPayment.Text = "Avtomatik";
            this.checkBoxGroupBoxPayment.UseVisualStyleBackColor = true;
            this.checkBoxGroupBoxPayment.CheckedChanged += new System.EventHandler(this.checkBoxGroupBoxPayment_CheckedChanged);
            // 
            // textBoxGroupBoxPaymentBonusCardSelect
            // 
            this.textBoxGroupBoxPaymentBonusCardSelect.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGroupBoxPaymentBonusCardSelect.Location = new System.Drawing.Point(78, 21);
            this.textBoxGroupBoxPaymentBonusCardSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGroupBoxPaymentBonusCardSelect.Name = "textBoxGroupBoxPaymentBonusCardSelect";
            this.textBoxGroupBoxPaymentBonusCardSelect.Size = new System.Drawing.Size(175, 23);
            this.textBoxGroupBoxPaymentBonusCardSelect.TabIndex = 56;
            this.textBoxGroupBoxPaymentBonusCardSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGroupBoxPaymentBonusCardSelect_KeyPress);
            // 
            // buttonGroupBoxPaymentOdenisEt
            // 
            this.buttonGroupBoxPaymentOdenisEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroupBoxPaymentOdenisEt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGroupBoxPaymentOdenisEt.Image = global::WindowsForm.Properties.Resources.add_payment_16px;
            this.buttonGroupBoxPaymentOdenisEt.Location = new System.Drawing.Point(183, 104);
            this.buttonGroupBoxPaymentOdenisEt.Name = "buttonGroupBoxPaymentOdenisEt";
            this.buttonGroupBoxPaymentOdenisEt.Size = new System.Drawing.Size(100, 27);
            this.buttonGroupBoxPaymentOdenisEt.TabIndex = 48;
            this.buttonGroupBoxPaymentOdenisEt.Text = " Ödəniş et";
            this.buttonGroupBoxPaymentOdenisEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGroupBoxPaymentOdenisEt.UseVisualStyleBackColor = true;
            this.buttonGroupBoxPaymentOdenisEt.Click += new System.EventHandler(this.buttonGroupBoxPaymentOdenisEt_Click);
            // 
            // buttonGroupBoxPaymentBonusCardSelect
            // 
            this.buttonGroupBoxPaymentBonusCardSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroupBoxPaymentBonusCardSelect.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGroupBoxPaymentBonusCardSelect.Image = global::WindowsForm.Properties.Resources.bonus_card_16px_2;
            this.buttonGroupBoxPaymentBonusCardSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGroupBoxPaymentBonusCardSelect.Location = new System.Drawing.Point(78, 21);
            this.buttonGroupBoxPaymentBonusCardSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGroupBoxPaymentBonusCardSelect.Name = "buttonGroupBoxPaymentBonusCardSelect";
            this.buttonGroupBoxPaymentBonusCardSelect.Size = new System.Drawing.Size(175, 23);
            this.buttonGroupBoxPaymentBonusCardSelect.TabIndex = 54;
            this.buttonGroupBoxPaymentBonusCardSelect.Text = "Bonus kart seç";
            this.buttonGroupBoxPaymentBonusCardSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGroupBoxPaymentBonusCardSelect.UseVisualStyleBackColor = true;
            this.buttonGroupBoxPaymentBonusCardSelect.Click += new System.EventHandler(this.buttonGroupBoxPaymentBonusCardSelect_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(20, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 40;
            this.label17.Text = "Barkod :";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(713, 567);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 16);
            this.label15.TabIndex = 65;
            this.label15.Text = "Verilən cəmi bonuslar :";
            // 
            // labelTotalMadeBonus
            // 
            this.labelTotalMadeBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalMadeBonus.AutoSize = true;
            this.labelTotalMadeBonus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalMadeBonus.ForeColor = System.Drawing.Color.Red;
            this.labelTotalMadeBonus.Location = new System.Drawing.Point(858, 567);
            this.labelTotalMadeBonus.Name = "labelTotalMadeBonus";
            this.labelTotalMadeBonus.Size = new System.Drawing.Size(14, 16);
            this.labelTotalMadeBonus.TabIndex = 64;
            this.labelTotalMadeBonus.Text = "#";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(357, 551);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(211, 16);
            this.label18.TabIndex = 67;
            this.label18.Text = "Bonus kartla ediən cəmi ödənişlər :";
            // 
            // labelTotalBonusCardSales
            // 
            this.labelTotalBonusCardSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalBonusCardSales.AutoSize = true;
            this.labelTotalBonusCardSales.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalBonusCardSales.ForeColor = System.Drawing.Color.Red;
            this.labelTotalBonusCardSales.Location = new System.Drawing.Point(574, 551);
            this.labelTotalBonusCardSales.Name = "labelTotalBonusCardSales";
            this.labelTotalBonusCardSales.Size = new System.Drawing.Size(14, 16);
            this.labelTotalBonusCardSales.TabIndex = 66;
            this.labelTotalBonusCardSales.Text = "#";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(412, 567);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(159, 16);
            this.label20.TabIndex = 69;
            this.label20.Text = "Aktiv olan cəmi ödənişlər :";
            this.label20.Visible = false;
            // 
            // labelTotalActiveBonusCardSales
            // 
            this.labelTotalActiveBonusCardSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalActiveBonusCardSales.AutoSize = true;
            this.labelTotalActiveBonusCardSales.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalActiveBonusCardSales.ForeColor = System.Drawing.Color.Red;
            this.labelTotalActiveBonusCardSales.Location = new System.Drawing.Point(574, 567);
            this.labelTotalActiveBonusCardSales.Name = "labelTotalActiveBonusCardSales";
            this.labelTotalActiveBonusCardSales.Size = new System.Drawing.Size(14, 16);
            this.labelTotalActiveBonusCardSales.TabIndex = 68;
            this.labelTotalActiveBonusCardSales.Text = "#";
            this.labelTotalActiveBonusCardSales.Visible = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(937, 643);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.labelTotalActiveBonusCardSales);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.labelTotalBonusCardSales);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelTotalMadeBonus);
            this.Controls.Add(this.groupBoxPayment);
            this.Controls.Add(this.groupBoxBonusCardSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.labelTotalBonus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.groupBoxBonus);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "HomeForm";
            this.Text = "Bonus səhifəsi";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.groupBoxBonus.ResumeLayout(false);
            this.groupBoxBonus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.groupBoxBonusCardSearch.ResumeLayout(false);
            this.groupBoxBonusCardSearch.PerformLayout();
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.TextBox textBoxAxtar;
       // private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.CheckBox checkBoxBonusCard;
        private System.Windows.Forms.TextBox textBoxBonusCardSelect;
        private System.Windows.Forms.Button buttonTemizleBonus;
        private System.Windows.Forms.Button buttonBonusCardSelect;
        private System.Windows.Forms.GroupBox groupBoxBonus;
        private System.Windows.Forms.Button buttonTetbiqEt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGuzest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.GroupBox groupBoxBonusCardSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelGBTotalBonusCardSales;
        private System.Windows.Forms.Label labelTotalBonus;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxDays;
        private System.Windows.Forms.ComboBox comboBoxYears;
        private System.Windows.Forms.Button buttonAxtar;
        private System.Windows.Forms.ComboBox comboBoxMonths;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelGBTotalBonusMade;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.TextBox textBoxGroupBoxPaymentCustomer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxGroupBoxPaymentValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonGroupBoxTemizlePayment;
        private System.Windows.Forms.CheckBox checkBoxGroupBoxPayment;
        private System.Windows.Forms.TextBox textBoxGroupBoxPaymentBonusCardSelect;
        private System.Windows.Forms.Button buttonGroupBoxPaymentOdenisEt;
        private System.Windows.Forms.Button buttonGroupBoxPaymentBonusCardSelect;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelTotalMadeBonus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelTotalBonusCardSales;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelTotalActiveBonusCardSales;
    }
}
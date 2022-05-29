
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.groupBoxMusteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
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
            this.buttonTemizleBonusCard.Location = new System.Drawing.Point(74, 133);
            this.buttonTemizleBonusCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTemizleBonusCard.Name = "buttonTemizleBonusCard";
            this.buttonTemizleBonusCard.Size = new System.Drawing.Size(88, 27);
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
            this.textBoxValue.Location = new System.Drawing.Point(77, 105);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(175, 22);
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
            this.buttonElaveEt.Image = global::WindowsForm.Properties.Resources.bonus_card_16px;
            this.buttonElaveEt.Location = new System.Drawing.Point(168, 133);
            this.buttonElaveEt.Name = "buttonElaveEt";
            this.buttonElaveEt.Size = new System.Drawing.Size(85, 27);
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
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(937, 494);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.groupBoxMusteri);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.groupBoxMusteri.ResumeLayout(false);
            this.groupBoxMusteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
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
    }
}
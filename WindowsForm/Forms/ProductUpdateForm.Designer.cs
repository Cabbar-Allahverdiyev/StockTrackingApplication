
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
            this.GroupBoxVarOlanMehsul = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TextBoxVarOlanAciqlama = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxVarOlanTedarikci = new System.Windows.Forms.ComboBox();
            this.comboBoxVarOlanMarka = new System.Windows.Forms.ComboBox();
            this.comboBoxVarOlanKateqoriya = new System.Windows.Forms.ComboBox();
            this.LabelMiqdarVB = new System.Windows.Forms.Label();
            this.ButtonVarOlanYenile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxVarOlanSatisQiymet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxVarOlanAlisQiymet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxVarOlanStokaElaveEdilecekMiqdar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxVarOlanBarkodNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxVarOlanMehsulAdi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewFormPrdouctList = new System.Windows.Forms.DataGridView();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBoxVarOlanMehsul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormPrdouctList)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxVarOlanMehsul
            // 
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label17);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.TextBoxVarOlanAciqlama);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label15);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.comboBoxVarOlanTedarikci);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.comboBoxVarOlanMarka);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.comboBoxVarOlanKateqoriya);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.LabelMiqdarVB);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.ButtonVarOlanYenile);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label7);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxVarOlanSatisQiymet);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label8);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxVarOlanAlisQiymet);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label9);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label10);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxVarOlanStokaElaveEdilecekMiqdar);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label11);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxVarOlanBarkodNo);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label12);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxVarOlanMehsulAdi);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label13);
            this.GroupBoxVarOlanMehsul.Location = new System.Drawing.Point(21, 40);
            this.GroupBoxVarOlanMehsul.Name = "GroupBoxVarOlanMehsul";
            this.GroupBoxVarOlanMehsul.Size = new System.Drawing.Size(265, 329);
            this.GroupBoxVarOlanMehsul.TabIndex = 3;
            this.GroupBoxVarOlanMehsul.TabStop = false;
            this.GroupBoxVarOlanMehsul.Text = "Var olan mehsul";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 257);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 15);
            this.label17.TabIndex = 27;
            this.label17.Text = "Aciqlama:";
            // 
            // TextBoxVarOlanAciqlama
            // 
            this.TextBoxVarOlanAciqlama.Location = new System.Drawing.Point(96, 254);
            this.TextBoxVarOlanAciqlama.Name = "TextBoxVarOlanAciqlama";
            this.TextBoxVarOlanAciqlama.Size = new System.Drawing.Size(164, 23);
            this.TextBoxVarOlanAciqlama.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 15);
            this.label15.TabIndex = 25;
            this.label15.Text = "Tedarikci:";
            // 
            // comboBoxVarOlanTedarikci
            // 
            this.comboBoxVarOlanTedarikci.FormattingEnabled = true;
            this.comboBoxVarOlanTedarikci.Location = new System.Drawing.Point(96, 109);
            this.comboBoxVarOlanTedarikci.Name = "comboBoxVarOlanTedarikci";
            this.comboBoxVarOlanTedarikci.Size = new System.Drawing.Size(162, 23);
            this.comboBoxVarOlanTedarikci.TabIndex = 24;
            // 
            // comboBoxVarOlanMarka
            // 
            this.comboBoxVarOlanMarka.FormattingEnabled = true;
            this.comboBoxVarOlanMarka.Location = new System.Drawing.Point(96, 80);
            this.comboBoxVarOlanMarka.Name = "comboBoxVarOlanMarka";
            this.comboBoxVarOlanMarka.Size = new System.Drawing.Size(162, 23);
            this.comboBoxVarOlanMarka.TabIndex = 23;
            // 
            // comboBoxVarOlanKateqoriya
            // 
            this.comboBoxVarOlanKateqoriya.FormattingEnabled = true;
            this.comboBoxVarOlanKateqoriya.Location = new System.Drawing.Point(96, 51);
            this.comboBoxVarOlanKateqoriya.Name = "comboBoxVarOlanKateqoriya";
            this.comboBoxVarOlanKateqoriya.Size = new System.Drawing.Size(162, 23);
            this.comboBoxVarOlanKateqoriya.TabIndex = 22;
            // 
            // LabelMiqdarVB
            // 
            this.LabelMiqdarVB.AutoSize = true;
            this.LabelMiqdarVB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelMiqdarVB.ForeColor = System.Drawing.Color.Firebrick;
            this.LabelMiqdarVB.Location = new System.Drawing.Point(5, 283);
            this.LabelMiqdarVB.Name = "LabelMiqdarVB";
            this.LabelMiqdarVB.Size = new System.Drawing.Size(19, 21);
            this.LabelMiqdarVB.TabIndex = 21;
            this.LabelMiqdarVB.Text = "#";
            // 
            // ButtonVarOlanYenile
            // 
            this.ButtonVarOlanYenile.Location = new System.Drawing.Point(174, 283);
            this.ButtonVarOlanYenile.Name = "ButtonVarOlanYenile";
            this.ButtonVarOlanYenile.Size = new System.Drawing.Size(84, 23);
            this.ButtonVarOlanYenile.TabIndex = 3;
            this.ButtonVarOlanYenile.Text = "Yenile";
            this.ButtonVarOlanYenile.UseVisualStyleBackColor = true;
            this.ButtonVarOlanYenile.Click += new System.EventHandler(this.ButtonVarOlanYenile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Satis qiymeti:";
            // 
            // textBoxVarOlanSatisQiymet
            // 
            this.textBoxVarOlanSatisQiymet.Location = new System.Drawing.Point(96, 225);
            this.textBoxVarOlanSatisQiymet.Name = "textBoxVarOlanSatisQiymet";
            this.textBoxVarOlanSatisQiymet.Size = new System.Drawing.Size(164, 23);
            this.textBoxVarOlanSatisQiymet.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Alis qiymeti:";
            // 
            // textBoxVarOlanAlisQiymet
            // 
            this.textBoxVarOlanAlisQiymet.Location = new System.Drawing.Point(96, 196);
            this.textBoxVarOlanAlisQiymet.Name = "textBoxVarOlanAlisQiymet";
            this.textBoxVarOlanAlisQiymet.Size = new System.Drawing.Size(164, 23);
            this.textBoxVarOlanAlisQiymet.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Miqdar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mehsul adi:";
            // 
            // textBoxVarOlanStokaElaveEdilecekMiqdar
            // 
            this.textBoxVarOlanStokaElaveEdilecekMiqdar.Location = new System.Drawing.Point(96, 167);
            this.textBoxVarOlanStokaElaveEdilecekMiqdar.Name = "textBoxVarOlanStokaElaveEdilecekMiqdar";
            this.textBoxVarOlanStokaElaveEdilecekMiqdar.Size = new System.Drawing.Size(164, 23);
            this.textBoxVarOlanStokaElaveEdilecekMiqdar.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Marka:";
            // 
            // textBoxVarOlanBarkodNo
            // 
            this.textBoxVarOlanBarkodNo.Enabled = false;
            this.textBoxVarOlanBarkodNo.Location = new System.Drawing.Point(96, 22);
            this.textBoxVarOlanBarkodNo.Name = "textBoxVarOlanBarkodNo";
            this.textBoxVarOlanBarkodNo.Size = new System.Drawing.Size(164, 23);
            this.textBoxVarOlanBarkodNo.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Kategoriya:";
            // 
            // textBoxVarOlanMehsulAdi
            // 
            this.textBoxVarOlanMehsulAdi.Location = new System.Drawing.Point(96, 138);
            this.textBoxVarOlanMehsulAdi.Name = "textBoxVarOlanMehsulAdi";
            this.textBoxVarOlanMehsulAdi.Size = new System.Drawing.Size(164, 23);
            this.textBoxVarOlanMehsulAdi.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "BarkodNo:";
            // 
            // dataGridViewFormPrdouctList
            // 
            this.dataGridViewFormPrdouctList.AllowUserToAddRows = false;
            this.dataGridViewFormPrdouctList.AllowUserToDeleteRows = false;
            this.dataGridViewFormPrdouctList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFormPrdouctList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewFormPrdouctList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormPrdouctList.Location = new System.Drawing.Point(308, 40);
            this.dataGridViewFormPrdouctList.Name = "dataGridViewFormPrdouctList";
            this.dataGridViewFormPrdouctList.ReadOnly = true;
            this.dataGridViewFormPrdouctList.RowTemplate.Height = 25;
            this.dataGridViewFormPrdouctList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFormPrdouctList.Size = new System.Drawing.Size(598, 418);
            this.dataGridViewFormPrdouctList.TabIndex = 4;
            this.dataGridViewFormPrdouctList.DoubleClick += new System.EventHandler(this.dataGridViewFormPrdouctList_DoubleClick);
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Location = new System.Drawing.Point(761, 11);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(145, 23);
            this.textBoxAxtar.TabIndex = 8;
            this.textBoxAxtar.TextChanged += new System.EventHandler(this.textBoxAxtar_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Axtar:";
            // 
            // ProductUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 480);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFormPrdouctList);
            this.Controls.Add(this.GroupBoxVarOlanMehsul);
            this.Name = "ProductUpdateForm";
            this.Text = "ProductUpdateForm";
            this.Load += new System.EventHandler(this.ProductUpdateForm_Load);
            this.GroupBoxVarOlanMehsul.ResumeLayout(false);
            this.GroupBoxVarOlanMehsul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormPrdouctList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxVarOlanMehsul;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TextBoxVarOlanAciqlama;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxVarOlanTedarikci;
        private System.Windows.Forms.ComboBox comboBoxVarOlanMarka;
        private System.Windows.Forms.ComboBox comboBoxVarOlanKateqoriya;
        private System.Windows.Forms.Label LabelMiqdarVB;
        private System.Windows.Forms.Button ButtonVarOlanYenile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxVarOlanSatisQiymet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxVarOlanAlisQiymet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxVarOlanStokaElaveEdilecekMiqdar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxVarOlanBarkodNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxVarOlanMehsulAdi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewFormPrdouctList;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.Label label1;
    }
}
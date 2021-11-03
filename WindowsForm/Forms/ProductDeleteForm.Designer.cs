
namespace WindowsForm.Forms
{
    partial class ProductDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDeleteForm));
            this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
            this.buttonSil = new System.Windows.Forms.Button();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBoxVarOlanMehsul = new System.Windows.Forms.GroupBox();
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
            this.textBoxVarOlanStokaElaveEdilecekMiqdar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxVarOlanBarkodNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxVarOlanMehsulAdi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
            this.GroupBoxVarOlanMehsul.SuspendLayout();
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
            this.dataGridViewProductList.Location = new System.Drawing.Point(283, 52);
            this.dataGridViewProductList.Name = "dataGridViewProductList";
            this.dataGridViewProductList.ReadOnly = true;
            this.dataGridViewProductList.RowTemplate.Height = 25;
            this.dataGridViewProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductList.Size = new System.Drawing.Size(432, 386);
            this.dataGridViewProductList.TabIndex = 1;
            this.dataGridViewProductList.DoubleClick += new System.EventHandler(this.dataGridViewFormPrdouctList_DoubleClick);
            // 
            // buttonSil
            // 
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSil.Image = ((System.Drawing.Image)(resources.GetObject("buttonSil.Image")));
            this.buttonSil.Location = new System.Drawing.Point(175, 282);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(85, 23);
            this.buttonSil.TabIndex = 5;
            this.buttonSil.Text = " Sil";
            this.buttonSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(570, 24);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(145, 22);
            this.textBoxAxtar.TabIndex = 8;
            this.textBoxAxtar.TextChanged += new System.EventHandler(this.textBoxAxtar_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(519, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Axtar:";
            // 
            // GroupBoxVarOlanMehsul
            // 
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label17);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.TextBoxVarOlanAciqlama);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label15);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.buttonSil);
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
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxVarOlanStokaElaveEdilecekMiqdar);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label11);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxVarOlanBarkodNo);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label12);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.textBoxVarOlanMehsulAdi);
            this.GroupBoxVarOlanMehsul.Controls.Add(this.label13);
            this.GroupBoxVarOlanMehsul.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxVarOlanMehsul.Location = new System.Drawing.Point(12, 52);
            this.GroupBoxVarOlanMehsul.Name = "GroupBoxVarOlanMehsul";
            this.GroupBoxVarOlanMehsul.Size = new System.Drawing.Size(265, 329);
            this.GroupBoxVarOlanMehsul.TabIndex = 9;
            this.GroupBoxVarOlanMehsul.TabStop = false;
            this.GroupBoxVarOlanMehsul.Text = "Var olan mehsul";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 257);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 14);
            this.label17.TabIndex = 27;
            this.label17.Text = "Aciqlama:";
            // 
            // TextBoxVarOlanAciqlama
            // 
            this.TextBoxVarOlanAciqlama.Enabled = false;
            this.TextBoxVarOlanAciqlama.Location = new System.Drawing.Point(96, 254);
            this.TextBoxVarOlanAciqlama.Name = "TextBoxVarOlanAciqlama";
            this.TextBoxVarOlanAciqlama.Size = new System.Drawing.Size(164, 22);
            this.TextBoxVarOlanAciqlama.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 14);
            this.label15.TabIndex = 25;
            this.label15.Text = "Tedarikci:";
            // 
            // comboBoxVarOlanTedarikci
            // 
            this.comboBoxVarOlanTedarikci.Enabled = false;
            this.comboBoxVarOlanTedarikci.FormattingEnabled = true;
            this.comboBoxVarOlanTedarikci.Location = new System.Drawing.Point(96, 109);
            this.comboBoxVarOlanTedarikci.Name = "comboBoxVarOlanTedarikci";
            this.comboBoxVarOlanTedarikci.Size = new System.Drawing.Size(162, 22);
            this.comboBoxVarOlanTedarikci.TabIndex = 24;
            // 
            // comboBoxVarOlanMarka
            // 
            this.comboBoxVarOlanMarka.Enabled = false;
            this.comboBoxVarOlanMarka.FormattingEnabled = true;
            this.comboBoxVarOlanMarka.Location = new System.Drawing.Point(96, 80);
            this.comboBoxVarOlanMarka.Name = "comboBoxVarOlanMarka";
            this.comboBoxVarOlanMarka.Size = new System.Drawing.Size(162, 22);
            this.comboBoxVarOlanMarka.TabIndex = 23;
            // 
            // comboBoxVarOlanKateqoriya
            // 
            this.comboBoxVarOlanKateqoriya.Enabled = false;
            this.comboBoxVarOlanKateqoriya.FormattingEnabled = true;
            this.comboBoxVarOlanKateqoriya.Location = new System.Drawing.Point(96, 51);
            this.comboBoxVarOlanKateqoriya.Name = "comboBoxVarOlanKateqoriya";
            this.comboBoxVarOlanKateqoriya.Size = new System.Drawing.Size(162, 22);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "Satis qiymeti:";
            // 
            // textBoxVarOlanSatisQiymet
            // 
            this.textBoxVarOlanSatisQiymet.Enabled = false;
            this.textBoxVarOlanSatisQiymet.Location = new System.Drawing.Point(96, 225);
            this.textBoxVarOlanSatisQiymet.Name = "textBoxVarOlanSatisQiymet";
            this.textBoxVarOlanSatisQiymet.Size = new System.Drawing.Size(164, 22);
            this.textBoxVarOlanSatisQiymet.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 14);
            this.label8.TabIndex = 19;
            this.label8.Text = "Alis qiymeti:";
            // 
            // textBoxVarOlanAlisQiymet
            // 
            this.textBoxVarOlanAlisQiymet.Enabled = false;
            this.textBoxVarOlanAlisQiymet.Location = new System.Drawing.Point(96, 196);
            this.textBoxVarOlanAlisQiymet.Name = "textBoxVarOlanAlisQiymet";
            this.textBoxVarOlanAlisQiymet.Size = new System.Drawing.Size(164, 22);
            this.textBoxVarOlanAlisQiymet.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "Miqdar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 14);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mehsul adi:";
            // 
            // textBoxVarOlanStokaElaveEdilecekMiqdar
            // 
            this.textBoxVarOlanStokaElaveEdilecekMiqdar.Enabled = false;
            this.textBoxVarOlanStokaElaveEdilecekMiqdar.Location = new System.Drawing.Point(96, 167);
            this.textBoxVarOlanStokaElaveEdilecekMiqdar.Name = "textBoxVarOlanStokaElaveEdilecekMiqdar";
            this.textBoxVarOlanStokaElaveEdilecekMiqdar.Size = new System.Drawing.Size(164, 22);
            this.textBoxVarOlanStokaElaveEdilecekMiqdar.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 14);
            this.label11.TabIndex = 16;
            this.label11.Text = "Marka:";
            // 
            // textBoxVarOlanBarkodNo
            // 
            this.textBoxVarOlanBarkodNo.Location = new System.Drawing.Point(96, 22);
            this.textBoxVarOlanBarkodNo.Name = "textBoxVarOlanBarkodNo";
            this.textBoxVarOlanBarkodNo.Size = new System.Drawing.Size(164, 22);
            this.textBoxVarOlanBarkodNo.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 14);
            this.label12.TabIndex = 15;
            this.label12.Text = "Kategoriya:";
            // 
            // textBoxVarOlanMehsulAdi
            // 
            this.textBoxVarOlanMehsulAdi.Enabled = false;
            this.textBoxVarOlanMehsulAdi.Location = new System.Drawing.Point(96, 138);
            this.textBoxVarOlanMehsulAdi.Name = "textBoxVarOlanMehsulAdi";
            this.textBoxVarOlanMehsulAdi.Size = new System.Drawing.Size(164, 22);
            this.textBoxVarOlanMehsulAdi.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 14);
            this.label13.TabIndex = 14;
            this.label13.Text = "BarkodNo:";
            // 
            // ProductDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupBoxVarOlanMehsul);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewProductList);
            this.Name = "ProductDeleteForm";
            this.Text = "Məhsul silmə səhifəsi";
            this.Load += new System.EventHandler(this.ProductDeleteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).EndInit();
            this.GroupBoxVarOlanMehsul.ResumeLayout(false);
            this.GroupBoxVarOlanMehsul.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductList;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupBoxVarOlanMehsul;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TextBoxVarOlanAciqlama;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxVarOlanTedarikci;
        private System.Windows.Forms.ComboBox comboBoxVarOlanMarka;
        private System.Windows.Forms.ComboBox comboBoxVarOlanKateqoriya;
        private System.Windows.Forms.Label LabelMiqdarVB;
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
    }
}
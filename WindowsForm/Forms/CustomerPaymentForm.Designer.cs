
namespace WindowsForm.Forms
{
    partial class CustomerPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPaymentForm));
            this.dataGridViewPaymentList = new System.Windows.Forms.DataGridView();
            this.groupBoxPaymentAdd = new System.Windows.Forms.GroupBox();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttoElaveEt = new System.Windows.Forms.Button();
            this.ButtonSalesFormSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMusteriInPaymentAdd = new System.Windows.Forms.ComboBox();
            this.textBoxMeblegInPaymentAdd = new System.Windows.Forms.TextBox();
            this.groupBoxCancelPayment = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMusteriInCancelPayment = new System.Windows.Forms.TextBox();
            this.textBoxCustomerPaymentIdInCancelPayment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSaticiInCancelPayment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMeblegInCancelPayment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTarixInCancelPayment = new System.Windows.Forms.TextBox();
            this.checkBoxOdenisLegvEdilsin = new System.Windows.Forms.CheckBox();
            this.buttonTetbiqEt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentList)).BeginInit();
            this.groupBoxPaymentAdd.SuspendLayout();
            this.groupBoxCancelPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPaymentList
            // 
            this.dataGridViewPaymentList.AllowUserToAddRows = false;
            this.dataGridViewPaymentList.AllowUserToDeleteRows = false;
            this.dataGridViewPaymentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPaymentList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.dataGridViewPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaymentList.Location = new System.Drawing.Point(257, 39);
            this.dataGridViewPaymentList.Name = "dataGridViewPaymentList";
            this.dataGridViewPaymentList.ReadOnly = true;
            this.dataGridViewPaymentList.RowTemplate.Height = 25;
            this.dataGridViewPaymentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPaymentList.Size = new System.Drawing.Size(690, 458);
            this.dataGridViewPaymentList.TabIndex = 2;
            this.dataGridViewPaymentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaymentList_CellDoubleClick);
            // 
            // groupBoxPaymentAdd
            // 
            this.groupBoxPaymentAdd.Controls.Add(this.buttonTemizle);
            this.groupBoxPaymentAdd.Controls.Add(this.buttoElaveEt);
            this.groupBoxPaymentAdd.Controls.Add(this.ButtonSalesFormSil);
            this.groupBoxPaymentAdd.Controls.Add(this.label2);
            this.groupBoxPaymentAdd.Controls.Add(this.label1);
            this.groupBoxPaymentAdd.Controls.Add(this.comboBoxMusteriInPaymentAdd);
            this.groupBoxPaymentAdd.Controls.Add(this.textBoxMeblegInPaymentAdd);
            this.groupBoxPaymentAdd.Location = new System.Drawing.Point(12, 34);
            this.groupBoxPaymentAdd.Name = "groupBoxPaymentAdd";
            this.groupBoxPaymentAdd.Size = new System.Drawing.Size(239, 146);
            this.groupBoxPaymentAdd.TabIndex = 3;
            this.groupBoxPaymentAdd.TabStop = false;
            this.groupBoxPaymentAdd.Enter += new System.EventHandler(this.groupBoxPayment_Enter);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.Image")));
            this.buttonTemizle.Location = new System.Drawing.Point(52, 80);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(88, 23);
            this.buttonTemizle.TabIndex = 20;
            this.buttonTemizle.Text = "Təmizlə";
            this.buttonTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTemizle.UseVisualStyleBackColor = true;
            // 
            // buttoElaveEt
            // 
            this.buttoElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoElaveEt.Image = ((System.Drawing.Image)(resources.GetObject("buttoElaveEt.Image")));
            this.buttoElaveEt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoElaveEt.Location = new System.Drawing.Point(145, 80);
            this.buttoElaveEt.Name = "buttoElaveEt";
            this.buttoElaveEt.Size = new System.Drawing.Size(88, 23);
            this.buttoElaveEt.TabIndex = 21;
            this.buttoElaveEt.Text = "Əlavə et";
            this.buttoElaveEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttoElaveEt.UseVisualStyleBackColor = true;
            this.buttoElaveEt.Click += new System.EventHandler(this.buttoElaveEt_Click);
            // 
            // ButtonSalesFormSil
            // 
            this.ButtonSalesFormSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalesFormSil.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSalesFormSil.Image")));
            this.ButtonSalesFormSil.Location = new System.Drawing.Point(145, 109);
            this.ButtonSalesFormSil.Name = "ButtonSalesFormSil";
            this.ButtonSalesFormSil.Size = new System.Drawing.Size(88, 23);
            this.ButtonSalesFormSil.TabIndex = 19;
            this.ButtonSalesFormSil.Text = "Sil";
            this.ButtonSalesFormSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSalesFormSil.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Məbləğ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Müştəri :";
            // 
            // comboBoxMusteriInPaymentAdd
            // 
            this.comboBoxMusteriInPaymentAdd.FormattingEnabled = true;
            this.comboBoxMusteriInPaymentAdd.Location = new System.Drawing.Point(71, 21);
            this.comboBoxMusteriInPaymentAdd.Name = "comboBoxMusteriInPaymentAdd";
            this.comboBoxMusteriInPaymentAdd.Size = new System.Drawing.Size(162, 25);
            this.comboBoxMusteriInPaymentAdd.TabIndex = 4;
            // 
            // textBoxMeblegInPaymentAdd
            // 
            this.textBoxMeblegInPaymentAdd.Location = new System.Drawing.Point(71, 52);
            this.textBoxMeblegInPaymentAdd.Name = "textBoxMeblegInPaymentAdd";
            this.textBoxMeblegInPaymentAdd.Size = new System.Drawing.Size(162, 22);
            this.textBoxMeblegInPaymentAdd.TabIndex = 4;
            this.textBoxMeblegInPaymentAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMebleg_KeyPress);
            // 
            // groupBoxCancelPayment
            // 
            this.groupBoxCancelPayment.Controls.Add(this.buttonTetbiqEt);
            this.groupBoxCancelPayment.Controls.Add(this.checkBoxOdenisLegvEdilsin);
            this.groupBoxCancelPayment.Controls.Add(this.label7);
            this.groupBoxCancelPayment.Controls.Add(this.textBoxTarixInCancelPayment);
            this.groupBoxCancelPayment.Controls.Add(this.label6);
            this.groupBoxCancelPayment.Controls.Add(this.textBoxMeblegInCancelPayment);
            this.groupBoxCancelPayment.Controls.Add(this.label5);
            this.groupBoxCancelPayment.Controls.Add(this.textBoxSaticiInCancelPayment);
            this.groupBoxCancelPayment.Controls.Add(this.textBoxCustomerPaymentIdInCancelPayment);
            this.groupBoxCancelPayment.Controls.Add(this.label3);
            this.groupBoxCancelPayment.Controls.Add(this.label4);
            this.groupBoxCancelPayment.Controls.Add(this.textBoxMusteriInCancelPayment);
            this.groupBoxCancelPayment.Location = new System.Drawing.Point(12, 186);
            this.groupBoxCancelPayment.Name = "groupBoxCancelPayment";
            this.groupBoxCancelPayment.Size = new System.Drawing.Size(239, 238);
            this.groupBoxCancelPayment.TabIndex = 22;
            this.groupBoxCancelPayment.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Müştəri :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id :";
            // 
            // textBoxMusteriInCancelPayment
            // 
            this.textBoxMusteriInCancelPayment.Enabled = false;
            this.textBoxMusteriInCancelPayment.Location = new System.Drawing.Point(71, 52);
            this.textBoxMusteriInCancelPayment.Name = "textBoxMusteriInCancelPayment";
            this.textBoxMusteriInCancelPayment.Size = new System.Drawing.Size(162, 22);
            this.textBoxMusteriInCancelPayment.TabIndex = 4;
            // 
            // textBoxCustomerPaymentIdInCancelPayment
            // 
            this.textBoxCustomerPaymentIdInCancelPayment.Enabled = false;
            this.textBoxCustomerPaymentIdInCancelPayment.Location = new System.Drawing.Point(71, 24);
            this.textBoxCustomerPaymentIdInCancelPayment.Name = "textBoxCustomerPaymentIdInCancelPayment";
            this.textBoxCustomerPaymentIdInCancelPayment.Size = new System.Drawing.Size(162, 22);
            this.textBoxCustomerPaymentIdInCancelPayment.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Satıcı :";
            // 
            // textBoxSaticiInCancelPayment
            // 
            this.textBoxSaticiInCancelPayment.Enabled = false;
            this.textBoxSaticiInCancelPayment.Location = new System.Drawing.Point(71, 80);
            this.textBoxSaticiInCancelPayment.Name = "textBoxSaticiInCancelPayment";
            this.textBoxSaticiInCancelPayment.Size = new System.Drawing.Size(162, 22);
            this.textBoxSaticiInCancelPayment.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Məbləğ :";
            // 
            // textBoxMeblegInCancelPayment
            // 
            this.textBoxMeblegInCancelPayment.Enabled = false;
            this.textBoxMeblegInCancelPayment.Location = new System.Drawing.Point(71, 108);
            this.textBoxMeblegInCancelPayment.Name = "textBoxMeblegInCancelPayment";
            this.textBoxMeblegInCancelPayment.Size = new System.Drawing.Size(162, 22);
            this.textBoxMeblegInCancelPayment.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tarix :";
            // 
            // textBoxTarixInCancelPayment
            // 
            this.textBoxTarixInCancelPayment.Enabled = false;
            this.textBoxTarixInCancelPayment.Location = new System.Drawing.Point(71, 136);
            this.textBoxTarixInCancelPayment.Name = "textBoxTarixInCancelPayment";
            this.textBoxTarixInCancelPayment.Size = new System.Drawing.Size(162, 22);
            this.textBoxTarixInCancelPayment.TabIndex = 27;
            // 
            // checkBoxOdenisLegvEdilsin
            // 
            this.checkBoxOdenisLegvEdilsin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxOdenisLegvEdilsin.Location = new System.Drawing.Point(9, 164);
            this.checkBoxOdenisLegvEdilsin.Name = "checkBoxOdenisLegvEdilsin";
            this.checkBoxOdenisLegvEdilsin.Size = new System.Drawing.Size(141, 21);
            this.checkBoxOdenisLegvEdilsin.TabIndex = 37;
            this.checkBoxOdenisLegvEdilsin.Text = "Odenis ləğv edilsin";
            this.checkBoxOdenisLegvEdilsin.UseVisualStyleBackColor = true;
            // 
            // buttonTetbiqEt
            // 
            this.buttonTetbiqEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTetbiqEt.Image = global::WindowsForm.Properties.Resources.ok_16px;
            this.buttonTetbiqEt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTetbiqEt.Location = new System.Drawing.Point(145, 191);
            this.buttonTetbiqEt.Name = "buttonTetbiqEt";
            this.buttonTetbiqEt.Size = new System.Drawing.Size(88, 25);
            this.buttonTetbiqEt.TabIndex = 38;
            this.buttonTetbiqEt.Text = "      Tətbiq et";
            this.buttonTetbiqEt.UseVisualStyleBackColor = true;
            this.buttonTetbiqEt.Click += new System.EventHandler(this.buttonTetbiqEt_Click);
            // 
            // CustomerPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(959, 510);
            this.Controls.Add(this.groupBoxCancelPayment);
            this.Controls.Add(this.groupBoxPaymentAdd);
            this.Controls.Add(this.dataGridViewPaymentList);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CustomerPaymentForm";
            this.Text = "CustomerPaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentList)).EndInit();
            this.groupBoxPaymentAdd.ResumeLayout(false);
            this.groupBoxPaymentAdd.PerformLayout();
            this.groupBoxCancelPayment.ResumeLayout(false);
            this.groupBoxCancelPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPaymentList;
        private System.Windows.Forms.GroupBox groupBoxPaymentAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMusteriInPaymentAdd;
        private System.Windows.Forms.TextBox textBoxMeblegInPaymentAdd;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttoElaveEt;
        private System.Windows.Forms.Button ButtonSalesFormSil;
        private System.Windows.Forms.GroupBox groupBoxCancelPayment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTarixInCancelPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMeblegInCancelPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSaticiInCancelPayment;
        private System.Windows.Forms.TextBox textBoxCustomerPaymentIdInCancelPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMusteriInCancelPayment;
        private System.Windows.Forms.CheckBox checkBoxOdenisLegvEdilsin;
        private System.Windows.Forms.Button buttonTetbiqEt;
    }
}
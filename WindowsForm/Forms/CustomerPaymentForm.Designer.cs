
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
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.textBoxMebleg = new System.Windows.Forms.TextBox();
            this.comboBoxMusteri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttoElaveEt = new System.Windows.Forms.Button();
            this.ButtonSalesFormSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentList)).BeginInit();
            this.groupBoxPayment.SuspendLayout();
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
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.buttonTemizle);
            this.groupBoxPayment.Controls.Add(this.buttoElaveEt);
            this.groupBoxPayment.Controls.Add(this.ButtonSalesFormSil);
            this.groupBoxPayment.Controls.Add(this.label2);
            this.groupBoxPayment.Controls.Add(this.label1);
            this.groupBoxPayment.Controls.Add(this.comboBoxMusteri);
            this.groupBoxPayment.Controls.Add(this.textBoxMebleg);
            this.groupBoxPayment.Location = new System.Drawing.Point(12, 34);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(239, 262);
            this.groupBoxPayment.TabIndex = 3;
            this.groupBoxPayment.TabStop = false;
            // 
            // textBoxMebleg
            // 
            this.textBoxMebleg.Location = new System.Drawing.Point(112, 96);
            this.textBoxMebleg.Name = "textBoxMebleg";
            this.textBoxMebleg.Size = new System.Drawing.Size(121, 22);
            this.textBoxMebleg.TabIndex = 4;
            this.textBoxMebleg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMebleg_KeyPress);
            // 
            // comboBoxMusteri
            // 
            this.comboBoxMusteri.FormattingEnabled = true;
            this.comboBoxMusteri.Location = new System.Drawing.Point(112, 65);
            this.comboBoxMusteri.Name = "comboBoxMusteri";
            this.comboBoxMusteri.Size = new System.Drawing.Size(121, 25);
            this.comboBoxMusteri.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Müştəri :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Məbləğ :";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.Image")));
            this.buttonTemizle.Location = new System.Drawing.Point(52, 124);
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
            this.buttoElaveEt.Location = new System.Drawing.Point(145, 124);
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
            this.ButtonSalesFormSil.Location = new System.Drawing.Point(145, 153);
            this.ButtonSalesFormSil.Name = "ButtonSalesFormSil";
            this.ButtonSalesFormSil.Size = new System.Drawing.Size(88, 23);
            this.ButtonSalesFormSil.TabIndex = 19;
            this.ButtonSalesFormSil.Text = "Sil";
            this.ButtonSalesFormSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSalesFormSil.UseVisualStyleBackColor = true;
            // 
            // CustomerPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(959, 510);
            this.Controls.Add(this.groupBoxPayment);
            this.Controls.Add(this.dataGridViewPaymentList);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CustomerPaymentForm";
            this.Text = "CustomerPaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentList)).EndInit();
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPaymentList;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMusteri;
        private System.Windows.Forms.TextBox textBoxMebleg;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttoElaveEt;
        private System.Windows.Forms.Button ButtonSalesFormSil;
    }
}
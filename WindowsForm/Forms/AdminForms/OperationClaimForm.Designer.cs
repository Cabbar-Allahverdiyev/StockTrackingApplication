
namespace WindowsForm.Forms.AdminForms
{
    partial class OperationClaimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationClaimForm));
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAxtar = new System.Windows.Forms.TextBox();
            this.dataGridViewUserClaims = new System.Windows.Forms.DataGridView();
            this.groupBoxOperationClaim = new System.Windows.Forms.GroupBox();
            this.buttonDuzelt = new System.Windows.Forms.Button();
            this.ButtonSalesFormSil = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonElaveEt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxIstifadeci = new System.Windows.Forms.ComboBox();
            this.comboBoxSelahiyyet = new System.Windows.Forms.ComboBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserClaims)).BeginInit();
            this.groupBoxOperationClaim.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRefresh.ErrorImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Image = global::WindowsForm.Properties.Resources.refreshBlack_16px_;
            this.pictureBoxRefresh.InitialImage = global::WindowsForm.Properties.Resources.exitWhite;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(869, 12);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefresh.TabIndex = 39;
            this.pictureBoxRefresh.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Image = global::WindowsForm.Properties.Resources.searchFerqliBlack_16px;
            this.label12.Location = new System.Drawing.Point(699, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "     ";
            // 
            // textBoxAxtar
            // 
            this.textBoxAxtar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxtar.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAxtar.Location = new System.Drawing.Point(728, 12);
            this.textBoxAxtar.Name = "textBoxAxtar";
            this.textBoxAxtar.Size = new System.Drawing.Size(135, 22);
            this.textBoxAxtar.TabIndex = 37;
            // 
            // dataGridViewUserClaims
            // 
            this.dataGridViewUserClaims.AllowUserToAddRows = false;
            this.dataGridViewUserClaims.AllowUserToDeleteRows = false;
            this.dataGridViewUserClaims.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUserClaims.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.dataGridViewUserClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserClaims.Location = new System.Drawing.Point(339, 40);
            this.dataGridViewUserClaims.Name = "dataGridViewUserClaims";
            this.dataGridViewUserClaims.ReadOnly = true;
            this.dataGridViewUserClaims.RowTemplate.Height = 25;
            this.dataGridViewUserClaims.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUserClaims.Size = new System.Drawing.Size(555, 491);
            this.dataGridViewUserClaims.TabIndex = 36;
            // 
            // groupBoxOperationClaim
            // 
            this.groupBoxOperationClaim.Controls.Add(this.buttonDuzelt);
            this.groupBoxOperationClaim.Controls.Add(this.ButtonSalesFormSil);
            this.groupBoxOperationClaim.Controls.Add(this.buttonTemizle);
            this.groupBoxOperationClaim.Controls.Add(this.buttonElaveEt);
            this.groupBoxOperationClaim.Controls.Add(this.label3);
            this.groupBoxOperationClaim.Controls.Add(this.label2);
            this.groupBoxOperationClaim.Controls.Add(this.label1);
            this.groupBoxOperationClaim.Controls.Add(this.comboBoxIstifadeci);
            this.groupBoxOperationClaim.Controls.Add(this.comboBoxSelahiyyet);
            this.groupBoxOperationClaim.Controls.Add(this.textBoxId);
            this.groupBoxOperationClaim.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxOperationClaim.Location = new System.Drawing.Point(12, 34);
            this.groupBoxOperationClaim.Name = "groupBoxOperationClaim";
            this.groupBoxOperationClaim.Size = new System.Drawing.Size(297, 189);
            this.groupBoxOperationClaim.TabIndex = 40;
            this.groupBoxOperationClaim.TabStop = false;
            // 
            // buttonDuzelt
            // 
            this.buttonDuzelt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDuzelt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDuzelt.Image = global::WindowsForm.Properties.Resources.editBlack_16px_2;
            this.buttonDuzelt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDuzelt.Location = new System.Drawing.Point(108, 148);
            this.buttonDuzelt.Name = "buttonDuzelt";
            this.buttonDuzelt.Size = new System.Drawing.Size(88, 25);
            this.buttonDuzelt.TabIndex = 26;
            this.buttonDuzelt.Text = "Düzəlt";
            this.buttonDuzelt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDuzelt.UseVisualStyleBackColor = true;
            // 
            // ButtonSalesFormSil
            // 
            this.ButtonSalesFormSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalesFormSil.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSalesFormSil.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSalesFormSil.Image")));
            this.ButtonSalesFormSil.Location = new System.Drawing.Point(201, 148);
            this.ButtonSalesFormSil.Name = "ButtonSalesFormSil";
            this.ButtonSalesFormSil.Size = new System.Drawing.Size(88, 25);
            this.ButtonSalesFormSil.TabIndex = 25;
            this.ButtonSalesFormSil.Text = "Sil";
            this.ButtonSalesFormSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSalesFormSil.UseVisualStyleBackColor = true;
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTemizle.Image = global::WindowsForm.Properties.Resources.TemizleBlack;
            this.buttonTemizle.Location = new System.Drawing.Point(108, 117);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(88, 25);
            this.buttonTemizle.TabIndex = 24;
            this.buttonTemizle.Text = "Təmizlə";
            this.buttonTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTemizle.UseVisualStyleBackColor = true;
            // 
            // buttonElaveEt
            // 
            this.buttonElaveEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElaveEt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonElaveEt.Image = global::WindowsForm.Properties.Resources.elaveEtBlack;
            this.buttonElaveEt.Location = new System.Drawing.Point(201, 117);
            this.buttonElaveEt.Name = "buttonElaveEt";
            this.buttonElaveEt.Size = new System.Drawing.Size(88, 25);
            this.buttonElaveEt.TabIndex = 11;
            this.buttonElaveEt.Text = "Əlavə et";
            this.buttonElaveEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonElaveEt.UseVisualStyleBackColor = true;
            this.buttonElaveEt.Click += new System.EventHandler(this.buttonElaveEt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Səlahiyyət :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "Istifadeci :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id :";
            // 
            // comboBoxIstifadeci
            // 
            this.comboBoxIstifadeci.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxIstifadeci.FormattingEnabled = true;
            this.comboBoxIstifadeci.Location = new System.Drawing.Point(108, 53);
            this.comboBoxIstifadeci.Name = "comboBoxIstifadeci";
            this.comboBoxIstifadeci.Size = new System.Drawing.Size(181, 22);
            this.comboBoxIstifadeci.TabIndex = 2;
            // 
            // comboBoxSelahiyyet
            // 
            this.comboBoxSelahiyyet.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSelahiyyet.FormattingEnabled = true;
            this.comboBoxSelahiyyet.Location = new System.Drawing.Point(108, 86);
            this.comboBoxSelahiyyet.Name = "comboBoxSelahiyyet";
            this.comboBoxSelahiyyet.Size = new System.Drawing.Size(181, 22);
            this.comboBoxSelahiyyet.TabIndex = 3;
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxId.Location = new System.Drawing.Point(108, 21);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(181, 22);
            this.textBoxId.TabIndex = 1;
            // 
            // OperationClaimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(906, 543);
            this.Controls.Add(this.groupBoxOperationClaim);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxAxtar);
            this.Controls.Add(this.dataGridViewUserClaims);
            this.Name = "OperationClaimForm";
            this.Text = "OperationClaimForm";
            this.Load += new System.EventHandler(this.OperationClaimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserClaims)).EndInit();
            this.groupBoxOperationClaim.ResumeLayout(false);
            this.groupBoxOperationClaim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAxtar;
        private System.Windows.Forms.DataGridView dataGridViewUserClaims;
        private System.Windows.Forms.GroupBox groupBoxOperationClaim;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonElaveEt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxIstifadeci;
        private System.Windows.Forms.ComboBox comboBoxSelahiyyet;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonDuzelt;
        private System.Windows.Forms.Button ButtonSalesFormSil;
    }
}
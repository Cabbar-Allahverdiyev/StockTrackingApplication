
namespace WindowsForm.Forms.SettingForms
{
    partial class BonusCardSettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIGeneralInterestRate = new System.Windows.Forms.TextBox();
            this.groupBoxGeneralSettingsOfTheBonusCard = new System.Windows.Forms.GroupBox();
            this.groupBoxWeeklySettingsOfTheBonusCard = new System.Windows.Forms.GroupBox();
            this.comboBoxWhichDays = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWeeklyInterestRate = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxGeneralSettingsOfTheBonusCard.SuspendLayout();
            this.groupBoxWeeklySettingsOfTheBonusCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ümumi Faiz dərəcəsi :";
            // 
            // textBoxIGeneralInterestRate
            // 
            this.textBoxIGeneralInterestRate.Location = new System.Drawing.Point(155, 15);
            this.textBoxIGeneralInterestRate.Name = "textBoxIGeneralInterestRate";
            this.textBoxIGeneralInterestRate.Size = new System.Drawing.Size(53, 22);
            this.textBoxIGeneralInterestRate.TabIndex = 1;
            this.textBoxIGeneralInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIGeneralInterestRate_KeyPress);
            // 
            // groupBoxGeneralSettingsOfTheBonusCard
            // 
            this.groupBoxGeneralSettingsOfTheBonusCard.Controls.Add(this.label1);
            this.groupBoxGeneralSettingsOfTheBonusCard.Controls.Add(this.textBoxIGeneralInterestRate);
            this.groupBoxGeneralSettingsOfTheBonusCard.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGeneralSettingsOfTheBonusCard.Name = "groupBoxGeneralSettingsOfTheBonusCard";
            this.groupBoxGeneralSettingsOfTheBonusCard.Size = new System.Drawing.Size(214, 49);
            this.groupBoxGeneralSettingsOfTheBonusCard.TabIndex = 2;
            this.groupBoxGeneralSettingsOfTheBonusCard.TabStop = false;
            this.groupBoxGeneralSettingsOfTheBonusCard.Text = "Bonus kartın ümumi tənzimləmələri";
            // 
            // groupBoxWeeklySettingsOfTheBonusCard
            // 
            this.groupBoxWeeklySettingsOfTheBonusCard.Controls.Add(this.comboBoxWhichDays);
            this.groupBoxWeeklySettingsOfTheBonusCard.Controls.Add(this.label3);
            this.groupBoxWeeklySettingsOfTheBonusCard.Controls.Add(this.label2);
            this.groupBoxWeeklySettingsOfTheBonusCard.Controls.Add(this.textBoxWeeklyInterestRate);
            this.groupBoxWeeklySettingsOfTheBonusCard.Location = new System.Drawing.Point(12, 67);
            this.groupBoxWeeklySettingsOfTheBonusCard.Name = "groupBoxWeeklySettingsOfTheBonusCard";
            this.groupBoxWeeklySettingsOfTheBonusCard.Size = new System.Drawing.Size(262, 80);
            this.groupBoxWeeklySettingsOfTheBonusCard.TabIndex = 3;
            this.groupBoxWeeklySettingsOfTheBonusCard.TabStop = false;
            this.groupBoxWeeklySettingsOfTheBonusCard.Text = "Bonus kartın həftəlik tənzimləmələri";
            // 
            // comboBoxWhichDays
            // 
            this.comboBoxWhichDays.FormattingEnabled = true;
            this.comboBoxWhichDays.Location = new System.Drawing.Point(155, 12);
            this.comboBoxWhichDays.Name = "comboBoxWhichDays";
            this.comboBoxWhichDays.Size = new System.Drawing.Size(101, 22);
            this.comboBoxWhichDays.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Faiz dərəcəsi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hansı günlərə aid olsun :";
            // 
            // textBoxWeeklyInterestRate
            // 
            this.textBoxWeeklyInterestRate.Location = new System.Drawing.Point(155, 40);
            this.textBoxWeeklyInterestRate.Name = "textBoxWeeklyInterestRate";
            this.textBoxWeeklyInterestRate.Size = new System.Drawing.Size(53, 22);
            this.textBoxWeeklyInterestRate.TabIndex = 1;
            this.textBoxWeeklyInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWeeklyInterestRate_KeyPress);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Image = global::WindowsForm.Properties.Resources.save_all_16px;
            this.buttonSave.Location = new System.Drawing.Point(664, 383);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(124, 25);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "  Yadda saxla";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // BonusCardSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxWeeklySettingsOfTheBonusCard);
            this.Controls.Add(this.groupBoxGeneralSettingsOfTheBonusCard);
            this.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "BonusCardSettingForm";
            this.Text = "Tənzimləmələr";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBoxGeneralSettingsOfTheBonusCard.ResumeLayout(false);
            this.groupBoxGeneralSettingsOfTheBonusCard.PerformLayout();
            this.groupBoxWeeklySettingsOfTheBonusCard.ResumeLayout(false);
            this.groupBoxWeeklySettingsOfTheBonusCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIGeneralInterestRate;
        private System.Windows.Forms.GroupBox groupBoxGeneralSettingsOfTheBonusCard;
        private System.Windows.Forms.GroupBox groupBoxWeeklySettingsOfTheBonusCard;
        private System.Windows.Forms.ComboBox comboBoxWhichDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWeeklyInterestRate;
        private System.Windows.Forms.Button buttonSave;
    }
}
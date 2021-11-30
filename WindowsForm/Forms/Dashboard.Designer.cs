
namespace WindowsForm.Forms
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.buttonSuppliers = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.buttonStatistic = new System.Windows.Forms.Button();
            this.buttonScan = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonMinimized = new System.Windows.Forms.Button();
            this.buttonMaximized = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.myDMCategory = new WindowsForm.MyControls.MyDropdownMenu(this.components);
            this.kateqoriyalariSiralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elaveEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.myDMProduct = new WindowsForm.MyControls.MyDropdownMenu(this.components);
            this.məhsullarıSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.məhsulSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.məhsulYeniləToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.məhsulƏlavəEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myDMSales = new WindowsForm.MyControls.MyDropdownMenu(this.components);
            this.satislariSiralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myDMUser = new WindowsForm.MyControls.MyDropdownMenu(this.components);
            this.istifadəçiləriSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istifadəçiƏlavəEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istifadəçiləriYeniləToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istifadəçiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myDMStatistic = new WindowsForm.MyControls.MyDropdownMenu(this.components);
            this.günlükToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.həftəlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.illikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myDMScan = new WindowsForm.MyControls.MyDropdownMenu(this.components);
            this.kameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTitleBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.myDMCategory.SuspendLayout();
            this.myDMProduct.SuspendLayout();
            this.myDMSales.SuspendLayout();
            this.myDMUser.SuspendLayout();
            this.myDMStatistic.SuspendLayout();
            this.myDMScan.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.LightCoral;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(1323, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(35, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(6, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(120, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Dashboard";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(0, 626);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(180, 68);
            this.btnExit.TabIndex = 15;
            this.btnExit.Tag = "Exit";
            this.btnExit.Text = "   Çıxış";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonSuppliers
            // 
            this.buttonSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.buttonSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSuppliers.FlatAppearance.BorderSize = 0;
            this.buttonSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuppliers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSuppliers.ForeColor = System.Drawing.Color.White;
            this.buttonSuppliers.Image = ((System.Drawing.Image)(resources.GetObject("buttonSuppliers.Image")));
            this.buttonSuppliers.Location = new System.Drawing.Point(0, 544);
            this.buttonSuppliers.Name = "buttonSuppliers";
            this.buttonSuppliers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonSuppliers.Size = new System.Drawing.Size(180, 68);
            this.buttonSuppliers.TabIndex = 14;
            this.buttonSuppliers.Tag = "Suppliers";
            this.buttonSuppliers.Text = "   Tədarikçilər";
            this.buttonSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSuppliers.UseVisualStyleBackColor = false;
            this.buttonSuppliers.Click += new System.EventHandler(this.buttonSuppliers_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.buttonUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUsers.ForeColor = System.Drawing.Color.White;
            this.buttonUsers.Image = ((System.Drawing.Image)(resources.GetObject("buttonUsers.Image")));
            this.buttonUsers.Location = new System.Drawing.Point(0, 476);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonUsers.Size = new System.Drawing.Size(180, 68);
            this.buttonUsers.TabIndex = 13;
            this.buttonUsers.Tag = "Users";
            this.buttonUsers.Text = "   İstifadəçilər";
            this.buttonUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonCategories
            // 
            this.buttonCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.buttonCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCategories.FlatAppearance.BorderSize = 0;
            this.buttonCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategories.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCategories.ForeColor = System.Drawing.Color.White;
            this.buttonCategories.Image = ((System.Drawing.Image)(resources.GetObject("buttonCategories.Image")));
            this.buttonCategories.Location = new System.Drawing.Point(0, 408);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonCategories.Size = new System.Drawing.Size(180, 68);
            this.buttonCategories.TabIndex = 12;
            this.buttonCategories.Tag = "Categories";
            this.buttonCategories.Text = "   Categories";
            this.buttonCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCategories.UseVisualStyleBackColor = false;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.buttonStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStatistic.FlatAppearance.BorderSize = 0;
            this.buttonStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistic.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStatistic.ForeColor = System.Drawing.Color.White;
            this.buttonStatistic.Image = ((System.Drawing.Image)(resources.GetObject("buttonStatistic.Image")));
            this.buttonStatistic.Location = new System.Drawing.Point(0, 340);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonStatistic.Size = new System.Drawing.Size(180, 68);
            this.buttonStatistic.TabIndex = 11;
            this.buttonStatistic.Tag = "Statistic";
            this.buttonStatistic.Text = "   Statistika";
            this.buttonStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStatistic.UseVisualStyleBackColor = false;
            this.buttonStatistic.Click += new System.EventHandler(this.buttonStatistic_Click);
            // 
            // buttonScan
            // 
            this.buttonScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.buttonScan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonScan.FlatAppearance.BorderSize = 0;
            this.buttonScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonScan.ForeColor = System.Drawing.Color.White;
            this.buttonScan.Image = ((System.Drawing.Image)(resources.GetObject("buttonScan.Image")));
            this.buttonScan.Location = new System.Drawing.Point(0, 272);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonScan.Size = new System.Drawing.Size(180, 68);
            this.buttonScan.TabIndex = 10;
            this.buttonScan.Tag = "Scan";
            this.buttonScan.Text = "   Scan";
            this.buttonScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonScan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonScan.UseVisualStyleBackColor = false;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.buttonSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSales.FlatAppearance.BorderSize = 0;
            this.buttonSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSales.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSales.ForeColor = System.Drawing.Color.White;
            this.buttonSales.Image = ((System.Drawing.Image)(resources.GetObject("buttonSales.Image")));
            this.buttonSales.Location = new System.Drawing.Point(0, 204);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonSales.Size = new System.Drawing.Size(180, 68);
            this.buttonSales.TabIndex = 9;
            this.buttonSales.Tag = "Sales";
            this.buttonSales.Text = "   Satışlar";
            this.buttonSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSales.UseVisualStyleBackColor = false;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(1268, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 23);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1292, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 23);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.buttonMinimized);
            this.panelTitleBar.Controls.Add(this.buttonMaximized);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.button5);
            this.panelTitleBar.Controls.Add(this.button4);
            this.panelTitleBar.Controls.Add(this.buttonExit);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.Black;
            this.panelTitleBar.Location = new System.Drawing.Point(180, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(754, 68);
            this.panelTitleBar.TabIndex = 4;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // buttonMinimized
            // 
            this.buttonMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimized.BackColor = System.Drawing.Color.White;
            this.buttonMinimized.FlatAppearance.BorderSize = 0;
            this.buttonMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimized.ForeColor = System.Drawing.Color.Black;
            this.buttonMinimized.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimized.Image")));
            this.buttonMinimized.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinimized.Location = new System.Drawing.Point(664, 0);
            this.buttonMinimized.Name = "buttonMinimized";
            this.buttonMinimized.Size = new System.Drawing.Size(27, 23);
            this.buttonMinimized.TabIndex = 7;
            this.buttonMinimized.UseVisualStyleBackColor = false;
            this.buttonMinimized.Click += new System.EventHandler(this.buttonMinimized_Click);
            // 
            // buttonMaximized
            // 
            this.buttonMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximized.BackColor = System.Drawing.Color.White;
            this.buttonMaximized.FlatAppearance.BorderSize = 0;
            this.buttonMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximized.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximized.Image")));
            this.buttonMaximized.Location = new System.Drawing.Point(688, 0);
            this.buttonMaximized.Name = "buttonMaximized";
            this.buttonMaximized.Size = new System.Drawing.Size(35, 23);
            this.buttonMaximized.TabIndex = 6;
            this.buttonMaximized.UseVisualStyleBackColor = false;
            this.buttonMaximized.Click += new System.EventHandler(this.buttonMaximized_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(719, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.buttonProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProducts.FlatAppearance.BorderSize = 0;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProducts.ForeColor = System.Drawing.Color.White;
            this.buttonProducts.Image = ((System.Drawing.Image)(resources.GetObject("buttonProducts.Image")));
            this.buttonProducts.Location = new System.Drawing.Point(0, 136);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonProducts.Size = new System.Drawing.Size(180, 68);
            this.buttonProducts.TabIndex = 8;
            this.buttonProducts.Tag = "Products";
            this.buttonProducts.Text = "   Məhsullar";
            this.buttonProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProducts.UseVisualStyleBackColor = false;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(0, 68);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(180, 68);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Tag = "Home";
            this.buttonHome.Text = "   Əsas sahifə";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panelLogo.Controls.Add(this.buttonMenu);
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 68);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonMenu
            // 
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.buttonMenu.IconColor = System.Drawing.Color.White;
            this.buttonMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMenu.IconSize = 32;
            this.buttonMenu.Location = new System.Drawing.Point(134, 11);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(40, 45);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.buttonSuppliers);
            this.panelMenu.Controls.Add(this.buttonUsers);
            this.panelMenu.Controls.Add(this.buttonCategories);
            this.panelMenu.Controls.Add(this.buttonStatistic);
            this.panelMenu.Controls.Add(this.buttonScan);
            this.panelMenu.Controls.Add(this.buttonSales);
            this.panelMenu.Controls.Add(this.buttonProducts);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 694);
            this.panelMenu.TabIndex = 3;
            // 
            // myDMCategory
            // 
            this.myDMCategory.IsMainMenu = false;
            this.myDMCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kateqoriyalariSiralaToolStripMenuItem,
            this.elaveEtToolStripMenuItem,
            this.yenileToolStripMenuItem,
            this.silToolStripMenuItem});
            this.myDMCategory.MenuItemHeight = 25;
            this.myDMCategory.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.myDMCategory.Name = "myDropdownMenu3";
            this.myDMCategory.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.myDMCategory.Size = new System.Drawing.Size(177, 92);
            // 
            // kateqoriyalariSiralaToolStripMenuItem
            // 
            this.kateqoriyalariSiralaToolStripMenuItem.Name = "kateqoriyalariSiralaToolStripMenuItem";
            this.kateqoriyalariSiralaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.kateqoriyalariSiralaToolStripMenuItem.Text = "Kateqoriyalari sirala";
            this.kateqoriyalariSiralaToolStripMenuItem.Click += new System.EventHandler(this.kateqoriyalariSiralaToolStripMenuItem_Click);
            // 
            // elaveEtToolStripMenuItem
            // 
            this.elaveEtToolStripMenuItem.Name = "elaveEtToolStripMenuItem";
            this.elaveEtToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.elaveEtToolStripMenuItem.Text = "Elave et";
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(180, 68);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(754, 626);
            this.panelDesktopPane.TabIndex = 5;
            // 
            // myDMProduct
            // 
            this.myDMProduct.IsMainMenu = false;
            this.myDMProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.məhsullarıSıralaToolStripMenuItem,
            this.məhsulSilToolStripMenuItem,
            this.məhsulYeniləToolStripMenuItem,
            this.məhsulƏlavəEtToolStripMenuItem,
            this.markalarToolStripMenuItem});
            this.myDMProduct.MenuItemHeight = 25;
            this.myDMProduct.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.myDMProduct.Name = "myDMProduct";
            this.myDMProduct.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.myDMProduct.Size = new System.Drawing.Size(160, 114);
            // 
            // məhsullarıSıralaToolStripMenuItem
            // 
            this.məhsullarıSıralaToolStripMenuItem.Name = "məhsullarıSıralaToolStripMenuItem";
            this.məhsullarıSıralaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.məhsullarıSıralaToolStripMenuItem.Text = "Məhsulları sırala";
            this.məhsullarıSıralaToolStripMenuItem.Click += new System.EventHandler(this.məhsullarıSıralaToolStripMenuItem_Click);
            // 
            // məhsulSilToolStripMenuItem
            // 
            this.məhsulSilToolStripMenuItem.Name = "məhsulSilToolStripMenuItem";
            this.məhsulSilToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.məhsulSilToolStripMenuItem.Text = "Məhsul sil";
            this.məhsulSilToolStripMenuItem.Click += new System.EventHandler(this.məhsulSilToolStripMenuItem_Click);
            // 
            // məhsulYeniləToolStripMenuItem
            // 
            this.məhsulYeniləToolStripMenuItem.Name = "məhsulYeniləToolStripMenuItem";
            this.məhsulYeniləToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.məhsulYeniləToolStripMenuItem.Text = "Məhsul yenilə";
            this.məhsulYeniləToolStripMenuItem.Click += new System.EventHandler(this.məhsulYeniləToolStripMenuItem_Click);
            // 
            // məhsulƏlavəEtToolStripMenuItem
            // 
            this.məhsulƏlavəEtToolStripMenuItem.Name = "məhsulƏlavəEtToolStripMenuItem";
            this.məhsulƏlavəEtToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.məhsulƏlavəEtToolStripMenuItem.Text = "Məhsul əlavə et";
            this.məhsulƏlavəEtToolStripMenuItem.Click += new System.EventHandler(this.məhsulƏlavəEtToolStripMenuItem_Click);
            // 
            // markalarToolStripMenuItem
            // 
            this.markalarToolStripMenuItem.Name = "markalarToolStripMenuItem";
            this.markalarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.markalarToolStripMenuItem.Text = "Markalar";
            this.markalarToolStripMenuItem.Click += new System.EventHandler(this.markalarToolStripMenuItem_Click);
            // 
            // myDMSales
            // 
            this.myDMSales.IsMainMenu = false;
            this.myDMSales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satislariSiralaToolStripMenuItem});
            this.myDMSales.MenuItemHeight = 25;
            this.myDMSales.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.myDMSales.Name = "myDMSales";
            this.myDMSales.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.myDMSales.Size = new System.Drawing.Size(145, 26);
            // 
            // satislariSiralaToolStripMenuItem
            // 
            this.satislariSiralaToolStripMenuItem.Name = "satislariSiralaToolStripMenuItem";
            this.satislariSiralaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.satislariSiralaToolStripMenuItem.Text = "Satislari sirala";
            this.satislariSiralaToolStripMenuItem.Click += new System.EventHandler(this.satislariSiralaToolStripMenuItem_Click);
            // 
            // myDMUser
            // 
            this.myDMUser.IsMainMenu = false;
            this.myDMUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istifadəçiləriSıralaToolStripMenuItem,
            this.istifadəçiƏlavəEtToolStripMenuItem,
            this.istifadəçiləriYeniləToolStripMenuItem,
            this.istifadəçiSilToolStripMenuItem});
            this.myDMUser.MenuItemHeight = 25;
            this.myDMUser.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.myDMUser.Name = "myDMUser";
            this.myDMUser.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.myDMUser.Size = new System.Drawing.Size(172, 92);
            // 
            // istifadəçiləriSıralaToolStripMenuItem
            // 
            this.istifadəçiləriSıralaToolStripMenuItem.Name = "istifadəçiləriSıralaToolStripMenuItem";
            this.istifadəçiləriSıralaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.istifadəçiləriSıralaToolStripMenuItem.Text = "İstifadəçiləri sırala";
            this.istifadəçiləriSıralaToolStripMenuItem.Click += new System.EventHandler(this.istifadəçiləriSıralaToolStripMenuItem_Click);
            // 
            // istifadəçiƏlavəEtToolStripMenuItem
            // 
            this.istifadəçiƏlavəEtToolStripMenuItem.Name = "istifadəçiƏlavəEtToolStripMenuItem";
            this.istifadəçiƏlavəEtToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.istifadəçiƏlavəEtToolStripMenuItem.Text = "İstifadəçi əlavə et";
            this.istifadəçiƏlavəEtToolStripMenuItem.Click += new System.EventHandler(this.istifadəçiƏlavəEtToolStripMenuItem_Click);
            // 
            // istifadəçiləriYeniləToolStripMenuItem
            // 
            this.istifadəçiləriYeniləToolStripMenuItem.Name = "istifadəçiləriYeniləToolStripMenuItem";
            this.istifadəçiləriYeniləToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.istifadəçiləriYeniləToolStripMenuItem.Text = "İstifadəçiləri yenilə";
            this.istifadəçiləriYeniləToolStripMenuItem.Click += new System.EventHandler(this.istifadəçiləriYeniləToolStripMenuItem_Click);
            // 
            // istifadəçiSilToolStripMenuItem
            // 
            this.istifadəçiSilToolStripMenuItem.Name = "istifadəçiSilToolStripMenuItem";
            this.istifadəçiSilToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.istifadəçiSilToolStripMenuItem.Text = "İstifadəçi sil";
            this.istifadəçiSilToolStripMenuItem.Click += new System.EventHandler(this.istifadəçiSilToolStripMenuItem_Click);
            // 
            // myDMStatistic
            // 
            this.myDMStatistic.IsMainMenu = false;
            this.myDMStatistic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.günlükToolStripMenuItem,
            this.həftəlikToolStripMenuItem,
            this.aylıqToolStripMenuItem,
            this.illikToolStripMenuItem});
            this.myDMStatistic.MenuItemHeight = 25;
            this.myDMStatistic.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.myDMStatistic.Name = "myDMStatistic";
            this.myDMStatistic.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.myDMStatistic.Size = new System.Drawing.Size(116, 92);
            // 
            // günlükToolStripMenuItem
            // 
            this.günlükToolStripMenuItem.Name = "günlükToolStripMenuItem";
            this.günlükToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.günlükToolStripMenuItem.Text = "Günlük";
            this.günlükToolStripMenuItem.Click += new System.EventHandler(this.günlükToolStripMenuItem_Click);
            // 
            // həftəlikToolStripMenuItem
            // 
            this.həftəlikToolStripMenuItem.Name = "həftəlikToolStripMenuItem";
            this.həftəlikToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.həftəlikToolStripMenuItem.Text = "Həftəlik";
            this.həftəlikToolStripMenuItem.Click += new System.EventHandler(this.həftəlikToolStripMenuItem_Click);
            // 
            // aylıqToolStripMenuItem
            // 
            this.aylıqToolStripMenuItem.Name = "aylıqToolStripMenuItem";
            this.aylıqToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.aylıqToolStripMenuItem.Text = "Aylıq";
            this.aylıqToolStripMenuItem.Click += new System.EventHandler(this.aylıqToolStripMenuItem_Click);
            // 
            // illikToolStripMenuItem
            // 
            this.illikToolStripMenuItem.Name = "illikToolStripMenuItem";
            this.illikToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.illikToolStripMenuItem.Text = "İllik";
            this.illikToolStripMenuItem.Click += new System.EventHandler(this.illikToolStripMenuItem_Click);
            // 
            // myDMScan
            // 
            this.myDMScan.IsMainMenu = false;
            this.myDMScan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kameraToolStripMenuItem,
            this.lazerToolStripMenuItem});
            this.myDMScan.MenuItemHeight = 25;
            this.myDMScan.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.myDMScan.Name = "myDMScan";
            this.myDMScan.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.myDMScan.Size = new System.Drawing.Size(181, 70);
            // 
            // kameraToolStripMenuItem
            // 
            this.kameraToolStripMenuItem.Name = "kameraToolStripMenuItem";
            this.kameraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kameraToolStripMenuItem.Text = "Kamera";
            this.kameraToolStripMenuItem.Click += new System.EventHandler(this.kameraToolStripMenuItem_Click);
            // 
            // lazerToolStripMenuItem
            // 
            this.lazerToolStripMenuItem.Name = "lazerToolStripMenuItem";
            this.lazerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lazerToolStripMenuItem.Text = "Lazer";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 694);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(900, 448);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Resize += new System.EventHandler(this.Dashboard_Resize);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.myDMCategory.ResumeLayout(false);
            this.myDMProduct.ResumeLayout(false);
            this.myDMSales.ResumeLayout(false);
            this.myDMUser.ResumeLayout(false);
            this.myDMStatistic.ResumeLayout(false);
            this.myDMScan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button buttonSuppliers;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Button buttonStatistic;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton buttonMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonMinimized;
        private System.Windows.Forms.Button buttonMaximized;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private MyControls.MyDropdownMenu myDMCategory;
        private System.Windows.Forms.ToolStripMenuItem kateqoriyalariSiralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elaveEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Panel panelDesktopPane;
        private MyControls.MyDropdownMenu myDMProduct;
        private System.Windows.Forms.ToolStripMenuItem məhsullarıSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem məhsulSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem məhsulYeniləToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem məhsulƏlavəEtToolStripMenuItem;
        private MyControls.MyDropdownMenu myDMSales;
        private MyControls.MyDropdownMenu myDMUser;
        private System.Windows.Forms.ToolStripMenuItem istifadəçiləriSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istifadəçiƏlavəEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istifadəçiləriYeniləToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istifadəçiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satislariSiralaToolStripMenuItem;
        private MyControls.MyDropdownMenu myDMStatistic;
        private System.Windows.Forms.ToolStripMenuItem günlükToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem həftəlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem illikToolStripMenuItem;
        private MyControls.MyDropdownMenu myDMScan;
        private System.Windows.Forms.ToolStripMenuItem kameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lazerToolStripMenuItem;
    }
}
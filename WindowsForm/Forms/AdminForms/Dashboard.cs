using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.MyControls;

namespace WindowsForm.Forms.AdminForms
{
    public partial class Dashboard : Form
    {
        IUserService _userService;
        IOperationClaimForFormsService _operationClaimService;
        IUserOperationClaimForFormsService _userOperationClaimService;
        IProductService _productService;
        IBrandService _brandService;
        ICategoryService _categoryService;
        ICustomerService _customerService;
        ICustomerBalanceService _customerBalanceService;
        ICustomerPaymentService _customerPaymentService;
        ICartService _cartService;
        IDebtService _debtService;
        ISaleWinFormService _saleWinFormService;
        ISupplierService _supplierService;
        IBonusCardService _bonusCardService;
        IFormSettingService _formSettingService;
        //OperationClaimForFormsManager _operationClaimManager=new OperationClaimForFormsManager(new EfOperationClaimForFormsDal());
        //UserOperationClaimForFormsManager _userOperationClaimForFormsManager = new UserOperationClaimForFormsManager(new EfUserOperationClaimForFormsDal());
        private Form activateForm;
        //private Button currentButton;
        private Size formSize;

        public Dashboard(IUserService userService
            , IOperationClaimForFormsService operationClaimService
            , IUserOperationClaimForFormsService userOperationClaimForFormsService
            , IProductService productService
            , IBrandService brandService
            , ICategoryService categoryService
            , ICustomerService customerService
            , ICustomerBalanceService customerBalanceService
            , ICustomerPaymentService customerPaymentService
            , ICartService cartService
            , IDebtService debtService, ISaleWinFormService saleWinFormService, ISupplierService supplierService, IBonusCardService bonusCardService, IFormSettingService formSettingService)
        {
            _userService = userService;
            _operationClaimService = operationClaimService;
            _userOperationClaimService = userOperationClaimForFormsService;
            _productService = productService;
            _brandService = brandService;
            _categoryService = categoryService;
            _customerService = customerService;
            _customerBalanceService = customerBalanceService;
            _customerPaymentService = customerPaymentService;
            _cartService = cartService;
            _debtService = debtService;
            _saleWinFormService = saleWinFormService;
            _supplierService = supplierService;
            _bonusCardService = bonusCardService;
            _formSettingService = formSettingService;


            InitializeComponent();
            this.Padding = new Padding();
            CollapseMenu();
            this.BackColor = Color.FromArgb(41, 128, 185);
            //user dashboard formdada var
            IDataResult<User> getUser = _userService.GetById(LoginForm.UserId);
            labelFirstName.Text = getUser.Data.FirstName;
            labelLastName.Text = getUser.Data.LastName;

            DisableButton();

            //WM_NCCALCSIZE
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Dashboard_Load(object sender, EventArgs e)
        {
            buttonHome_Click(sender, e);
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }

            base.WndProc(ref m);
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            FormControllers formController = new FormControllers();
            formController.AdjustForm(this);
        }



        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    //bura yeiden bax
                    previousBtn.BackColor = Color.FromArgb(41, 128, 185);
                    //previousBtn.BackColor = Color.FromArgb(152, 161, 155);
                    // previousBtn.BackColor = Color.FromArgb(152, 158, 161);
                    // previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        //<Exit Maximized Minimized Buttons>----------------------------->

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(253, 33, 45);
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
        }

        //Menu Items button------------------------------------->
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalesForm(_categoryService
                                        , _brandService
                                        , _supplierService
                                        , _productService
                                        , _cartService
                                        , _customerService
                                        , _saleWinFormService
                                        , _debtService
                                        ,_bonusCardService), sender);
            
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(myDMProduct, sender);
            // myDMProduct.Show(buttonProducts, buttonProducts.Width, 0);

        }


        private void buttonSales_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(myDMSales, sender);
            // myDMSales.Show(buttonSales, myDMSales.Width - buttonProducts.Width, buttonSales.Height);


        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(myDMCategory, sender);
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(myDMScan, sender);
        }

        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(myDMStatistic, sender);
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(myDMUser, sender);
        }

        private void buttonOther_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(myDMOther, sender);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(myDMSettings, sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MyControl.CloseYesNo(this, new LoginForm(_userOperationClaimService
                                                    , _userService
                                                    , _operationClaimService
                                                    , _productService
                                                    , _categoryService
                                                    , _customerService
                                                    , _customerBalanceService
                                                    , _customerPaymentService
                                                    , _cartService
                                                    , _debtService
                                                    , _saleWinFormService
                                                    , _supplierService
                                                    , _brandService
                                                    ,_bonusCardService
                                                    ,_formSettingService));


        }

        //Dropdown menu---------------------------------->
        //Product--------------------------------------->

        private void sıralaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProductList(_productService, _brandService, _categoryService, _supplierService), sender);
        }


        private void əlavəEtToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProductAdd(_productService, _brandService, _categoryService, _supplierService), sender);
        }

        private void yeniləToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductUpdateForm(_productService, _brandService, _categoryService, _supplierService), sender);
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductDeleteForm(_productService, _brandService, _categoryService, _supplierService), sender);
        }

        //Brand_______________________>
        private void əlavəEtToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBrand(_brandService), sender);
        }

        private void yeniləVəSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BrandUpdateAndDeleteForm(_brandService), sender);
        }

        //Supplier_____________________>
        private void əlavəEtToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SupplierForm(_supplierService), sender);
        }

        private void yeniləVəSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SupplierUpdateForm(_supplierService), sender);
        }
       
        //Sales-------------------------------------------->
        private void satislariSiralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSalesList(_productService, _saleWinFormService), sender);
        }

        //Istifadeci--------------------------------------------->
        private void istifadəçiləriSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUserListed(_userService), sender);
        }

        private void istifadəçiƏlavəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUserAdd(_userService, _operationClaimService, _userOperationClaimService), sender);
        }

        private void istifadəçiləriYeniləToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserUpdateForm(_userService), sender);
        }

        private void istifadəçiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserDeleteForm(_userService), sender);
        }

        //Categories------------------------------------------>

        private void kateqoriyalariSiralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCategory(_categoryService), sender);
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CategoryUpdateAndDeleteForm(_categoryService), sender);
        }

        private void elaveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCategory(_categoryService), sender);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CategoryUpdateAndDeleteForm(_categoryService), sender);
        }


        //Scan------------------------------------------------->

        private void kameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CameraBarcodeScanner(), sender);
        }

        private void lazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new USBBarcodeScannerForm(), sender);
        }


        //Statistic--------------------------------------------->
        private void günlükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new(), sender);
        }

        private void həftəlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // OpenChildForm(new(), sender);
        }

        private void aylıqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // OpenChildForm(new(), sender);
        }

        private void illikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // OpenChildForm(new(), sender);
        }

        //Others--------------------------------->
        private void musterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerForm(_customerService), sender);
        }

        private void musteriOdenisleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerPaymentForm(_userService, _customerPaymentService, _customerService), sender);

        }

        private void selahiyyetlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForms.OperationClaimForm(_userService, _operationClaimService, _userOperationClaimService), sender);

        }

        //Bonus Kart__________________________>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.BonusCardAddForm(_bonusCardService,_customerService),sender);

        }

        //Parametrler --------------------------->
        private void bonusKartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SettingForms.BonusCardSettingForm(_formSettingService), sender);
        }


        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse Menu
            {
                panelMenu.Width = 100;
                pictureBoxLogo.Visible = false;
                buttonMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else //Expand Menu
            {
                panelMenu.Width = 230;
                pictureBoxLogo.Visible = true;
                buttonMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "  " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }

        }

        private void Open_DropdownMenu(MyDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev)
                => DropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width, 0);
        }

        private void Open_DropdownMenu2(MyDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev)
                => DropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width - dropdownMenu.Width, control.Height);
        }

        private void DropdownMenu_VisibleChanged(object sender, EventArgs ev, Control ctrl)
        {
            MyDropdownMenu dropdownMenu = (MyDropdownMenu)sender;
            if (!DesignMode)
            {
                if (dropdownMenu.Visible)
                    //ctrl.BackColor = Color.FromArgb(159, 161, 224);
                    ctrl.BackColor = Color.FromArgb(149, 192, 220);
                else ctrl.BackColor = Color.FromArgb(41, 128, 185);

                //if (dropdownMenu.Visible)
                //    ctrl.BackColor = Color.FromArgb(72, 52, 182);
                //else ctrl.BackColor = Color.FromArgb(98, 102, 244);
                //ctrl.BackColor = Color.FromArgb(72, 52, 182);
                //else ctrl.BackColor = Color.FromArgb(24, 24, 36);
            }
        }





        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

       


















































        //private void ActivateButton(object btnSender)
        //{
        //    if (btnSender != null)
        //    {
        //        if (currentButton.Equals((MyDropdownMenu)btnSender))
        //        {
        //            DisableButton();
        //            //Color color = SelectThemeColor();
        //            currentButton = (Button)btnSender;
        //            //currentButton.BackColor = color;
        //           // currentButton.ForeColor = Color.White;
        //           // currentButton.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        //            //panelTitleBar.BackColor = color;
        //           // panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
        //            //ThemeColor.PrimaryColor = color;
        //            //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
        //            buttonCloseChildForm.Visible = true;

        //        }
        //    }
        //}






    }
}

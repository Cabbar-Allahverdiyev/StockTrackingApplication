using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Windows.Forms;
using WindowsForm.Utilities.BarcodeScanner.BarcodeGenerate;
using WindowsForm.Utilities.BarcodeScanner.BarcodeGenerate.MessagingToolkitGenerator;
using WindowsForm.Utilities.BarcodeScanner.BarcodeGenerate.NetBarcodes;

namespace WindowsForm
{
    static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 


        [STAThread]
        static void Main()
        {

            //IProductService _productService;
            //IBrandService _brandService;
            //ICategoryService _categoryService;
            //ICustomerService _customerService;
            //ICustomerBalanceService _customerBalanceService;
            //ICustomerPaymentService _customerPaymentService;
            //ICartService _cartService;
            ////ISaleService _saleService;
            //IDebtService _debtService;
            //ISaleWinFormService _saleWinFormService;
            //ISupplierService _supplierService;
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IUserDal _userDal = new EfUserDal();
            IUserOperationClaimForFormsDal _userOperationClaimForFormsDal = new EfUserOperationClaimForFormsDal();
            IOperationClaimForFormsDal _operationClaimForFormsDal = new EfOperationClaimForFormsDal();
            IProductDal _productDal = new EfProductDal();
            IBrandDal _brandDal = new EfBrandDal();
            ICategoryDal _categoryDal = new EfCategoryDal();
            ICustomerBalanceDal _customerBalanceDal = new EfCustomerBalanceDal();
            ICustomerDal _customerDal = new EfCustomerDal();
            ICustomerPaymentDal _customerPaymentDal = new EfCustomerPaymentDal();
            ICartDal _cartDal = new EfCartDal();
            ISaleDal _saleWinFormDal = new EfSaleDal();
            IDebtDal _debtDal = new EfDebtDal();
            ISupplierDal _supplierDal = new EfSupplierDal();
            IBonusCardOperationDal _bonusCardOperationDal = new EfBonusCardOperationDal();
            IBonusCardDal _bonusCardDal = new EfBonusCardDal();
            IFormSettingDal _formSettingDal = new EfFormSettingDal();
            ILogDal _logDal = new EfLogDal();

            IUserService _userService = new UserManager(_userDal);
            IOperationClaimForFormsService _operationClaimForFormsService = new OperationClaimForFormsManager(_operationClaimForFormsDal);
            IUserOperationClaimForFormsService _userOperationClaimForFormsService = new UserOperationClaimForFormsManager(
                _userOperationClaimForFormsDal,
                _userService,
                _operationClaimForFormsService);
            
            IProductService _productService = new ProductManager(_productDal);
            IBrandService _brandService = new BrandManager(_brandDal);
            ICategoryService _categoryService = new CategoryManager(_categoryDal);
            ICustomerBalanceService _customerBalanceService = new CustomerBalanceManager(_customerBalanceDal);
            ICustomerService _customerService = new CustomerManager(_customerDal, _customerBalanceService, _bonusCardDal);
            ICustomerPaymentService _customerPaymentService = new CustomerPaymentManager(_customerPaymentDal, _customerBalanceService);
            ICartService _cartService = new CartManager(_cartDal);
            ISaleService _saleService = new SaleManager(_saleWinFormDal, _productService);
            IDebtService _debtService = new DebtManager(_debtDal, _customerBalanceService);
            ISupplierService _supplierService = new SupplierManager(_supplierDal);
            IBonusCardOperationService _bonusCardOperationService = new BonusCardOperationManager(_bonusCardOperationDal, _userService);
            IBonusCardService _bonusCardService = new BonusCardManager(_bonusCardDal, _customerService, _bonusCardOperationService);

            IFormSettingService _formSettingService = new FormSettingManager(_formSettingDal);
            IBarcodeGenerator _barcodeGenerator = new NetBarcodeGenerator(_productService);
            ILoggerService _loggerService = new LoggerManager(_logDal);
            //Application.Run(new Forms.SettingForms.BonusCardSettingForm(formSettingManager));
            //Application.Run(new Forms.DebtForm(_debtService,_customerService,_customerBalanceService));

            //Application.Run(new Forms.LoginForm(_userOperationClaimForFormsService, _userService, _operationClaimForFormsService, _productService
            //   , _categoryService, _customerService, _customerBalanceService, _customerPaymentService, _cartService, _debtService, _saleService, _supplierService
            //   , _brandService, _bonusCardService, _formSettingService, _bonusCardOperationService
            //   , _barcodeGenerator, _loggerService));

            Application.Run(new BonusCardSystem.Forms.BonusCardSystemLoginForm(_userOperationClaimForFormsService,
                                                                               _userService,
                                                                               _operationClaimForFormsService,
                                                                               _productService,
                                                                               _categoryService,
                                                                               _customerService,
                                                                               _customerBalanceService,
                                                                               _customerPaymentService,
                                                                               _cartService,
                                                                               _debtService,    
                                                                               _saleService,
                                                                               _supplierService,
                                                                               _brandService,
                                                                               _bonusCardService,
                                                                               _formSettingService,
                                                                               _bonusCardOperationService,
                                                                               _barcodeGenerator));

            //Application.Run(new Forms.FormUserAdd(_userService,_operationClaimForFormsService,_userOperationClaimForFormsService,_formSettingService));

            //Application.Run(new Forms.FormProductAdd(_productService,_brandService,_categoryService,_supplierService,_formSettingService));

            //Application.Run(new Forms.AutomaticBarcodeGenerateForm(_barcodeGenerator,_formSettingService));


        }
    }
}

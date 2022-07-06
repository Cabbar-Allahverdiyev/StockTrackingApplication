using Business.Abstract;
using Business.Concrete;
using Business.Constants.Messages;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;

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
            IUserOperationClaimForFormsDal _userOperationClaimForFormsDal=new EfUserOperationClaimForFormsDal();
            IOperationClaimForFormsDal _operationClaimForFormsDal = new EfOperationClaimForFormsDal();
            IProductDal _productDal = new EfProductDal();
            IBrandDal _brandDal = new EfBrandDal();
            ICategoryDal _categoryDal = new EfCategoryDal();
            ICustomerBalanceDal _customerBalanceDal = new EfCustomerBalanceDal();
            ICustomerDal _customerDal = new EfCustomerDal();
            ICustomerPaymentDal _customerPaymentDal = new EfCustomerPaymentDal();
            ICartDal _cartDal=new EfCartDal();
            ISaleWinFormDal _saleWinFormDal=new EfSaleWinFormDal();
            IDebtDal _debtDal=new EfDebtDal();
            ISupplierDal _supplierDal=new EfSupplierDal();
            IBonusCardOperationDal _bonusCardOperationDal=new EfBonusCardOperationDal();
            IBonusCardDal _bonusCardDal=new EfBonusCardDal();
            IFormSettingDal _formSettingDal=new EfFormSettingDal();

            IUserService _userService = new UserManager(_userDal);
            IUserOperationClaimForFormsService _userOperationClaimForFormsService = new UserOperationClaimForFormsManager(_userOperationClaimForFormsDal);
            IOperationClaimForFormsService _operationClaimForFormsService = new OperationClaimForFormsManager(_operationClaimForFormsDal);
            IProductService _productService = new ProductManager(_productDal);
            IBrandService _brandService = new BrandManager(_brandDal);
            ICategoryService _categoryService = new CategoryManager(_categoryDal);
            ICustomerBalanceService _customerBalanceService = new CustomerBalanceManager(_customerBalanceDal);
            ICustomerService _customerService = new CustomerManager(_customerDal, _customerBalanceService,_bonusCardDal);
            ICustomerPaymentService _customerPaymentService = new CustomerPaymentManager(_customerPaymentDal, _customerBalanceService);
            ICartService _cartService = new CartManager(_cartDal);
            ISaleWinFormService _saleService = new SaleWinFormManager(_saleWinFormDal, _productService);
            IDebtService _debtService = new DebtManager(_debtDal, _customerBalanceService);
            ISupplierService _supplierService = new SupplierManager(_supplierDal);
            IBonusCardOperationService _bonusCardOperationService = new BonusCardOperationManager(_bonusCardOperationDal,_userService);
            IBonusCardService _bonusCardService = new BonusCardManager(_bonusCardDal, _customerService,_bonusCardOperationService);

            IFormSettingService _formSettingService = new FormSettingManager(_formSettingDal);
            //Application.Run(new Forms.SettingForms.BonusCardSettingForm(formSettingManager));
            //Application.Run(new Forms.DebtForm(_debtService,_customerService,_customerBalanceService));

            //Application.Run(new Forms.LoginForm(_userOperationClaimForFormsService, _userService, _operationClaimForFormsService, _productService
            //   , _categoryService, _customerService, _customerBalanceService, _customerPaymentService, _cartService, _debtService, _saleService, _supplierService
            //   , _brandService, _bonusCardService, _formSettingService, _bonusCardOperationService));

            //Application.Run(new BonusCardSystem.Forms.BonusCardSystemLoginForm(userOperationClaimForFormsManager, userManager, operationClaimForFormsManager, productManager
            //    , categoryManager, customerManager, customerBalanceManager, customerPaymentManager, cartManager, debtManager, saleManager, supplierManager
            //    , brandManager, bonusCardManager, formSettingManager, bonusCardOperationManager));

            //   Application.Run(new Forms.FormUserAdd(userManager, operationClaimForFormsManager, userOperationClaimForFormsManager,formSettingManager));

            Application.Run(new Forms.CustomerForm(_customerService));
        }
    }
}

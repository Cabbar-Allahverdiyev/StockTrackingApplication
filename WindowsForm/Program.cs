using Business.Abstract;
using Business.Concrete;
using Business.Constants.Messages;
using Core.Utilities.Security.JWT;
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

            UserManager userManager = new UserManager(new EfUserDal());
            UserOperationClaimForFormsManager userOperationClaimForFormsManager = new UserOperationClaimForFormsManager(new EfUserOperationClaimForFormsDal());
            OperationClaimForFormsManager operationClaimForFormsManager = new OperationClaimForFormsManager(new EfOperationClaimForFormsDal());
            ProductManager productManager = new ProductManager(new EfProductDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            CustomerBalanceManager customerBalanceManager = new CustomerBalanceManager(new EfCustomerBalanceDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal(), customerBalanceManager);
            CustomerPaymentManager customerPaymentManager = new CustomerPaymentManager(new EfCustomerPaymentDal(), customerBalanceManager);
            CartManager cartManager = new CartManager(new EfCartDal());
            SaleWinFormManager saleManager = new SaleWinFormManager(new EfSaleWinFormDal(), productManager);
            DebtManager debtManager = new DebtManager(new EfDebtDal(), customerBalanceManager);
            SupplierManager supplierManager = new SupplierManager(new EfSupplierDal());
            BonusCardOperationManager bonusCardOperationManager = new BonusCardOperationManager(new EfBonusCardOperationDal(),userManager);
            BonusCardManager bonusCardManager = new BonusCardManager(new EfBonusCardDal(), customerManager,bonusCardOperationManager);

            FormSettingManager formSettingManager = new FormSettingManager(new EfFormSettingDal());
            //Application.Run(new Forms.SettingForms.BonusCardSettingForm(formSettingManager));

            Application.Run(new Forms.LoginForm(userOperationClaimForFormsManager, userManager, operationClaimForFormsManager, productManager
                , categoryManager, customerManager, customerBalanceManager, customerPaymentManager, cartManager, debtManager, saleManager, supplierManager
                , brandManager, bonusCardManager, formSettingManager));

            //Application.Run(new BonusCardSystem.Forms.BonusCardSystemLoginForm(userOperationClaimForFormsManager, userManager, operationClaimForFormsManager, productManager
            //    , categoryManager, customerManager, customerBalanceManager, customerPaymentManager, cartManager, debtManager, saleManager, supplierManager
            //    , brandManager, bonusCardManager, formSettingManager,bonusCardOperationManager));



        }
    }
}

using Business.Concrete;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs.CartDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.ValidatorControllers;
using USB_Barcode_Scanner;
using WindowsForm.Utilities.Search.Concrete.ProductSearch;
using WindowsForm.MyControls;
using WindowsForm.Core.Constants.SelectionItem;
using System.Reflection;
using Business.Abstract;
using System.Linq;
using Entities.DTOs.ProductDtos;

namespace WindowsForm.Forms
{
    public partial class SalesForm : Form
    {
        int staticUserId = LoginForm.UserId;
        private int _cartId = 0;
        ICategoryService _categoryService;
        IBrandService _brandService;
        ISupplierService _supplierService;

        public SalesForm(ICategoryService categoryService,
                            IBrandService brandService,
                            ISupplierService supplierService)
        {
            _categoryService = categoryService;
            _brandService = brandService;
            _supplierService = supplierService;
            InitializeComponent();
            TotalPriceLabelWrite();


            MyControl myControl = new MyControl();
            myControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);

            //myControl.WritePlaceholdersForTextBoxSearchByProductName(textBoxAxtarBarcodeNumber);

            BarcodeScanner barcodeScanner = new BarcodeScanner(textBoxBarkodNo);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;


        }


        private void SalesForm_Load(object sender, EventArgs e)
        {
            ProductListRefesh();
            CartListRefesh();
            GroupBoxMehsulControlClear();
            CategoryWriteComboBox();
            BrandWriteComboBox();
            SupplierWriteComboBox();
            ProductListRefesh();
            //TextBoxController.ClearAllTextBoxesAndCmboBoxesByGroupBox(groupBoxFilter);
        }

        ProductManager _productManager = new ProductManager(new EfProductDal());
        CartManager _cartManager = new CartManager(new EfCartDal());
        CustomerManager _customerManager = new CustomerManager(new EfCustomerDal(), new CustomerBalanceManager(new EfCustomerBalanceDal()));
        SaleWinFormManager _saleWinFormManager = new SaleWinFormManager(new EfSaleWinFormDal(), new ProductManager(new EfProductDal()));
        DebtManager _debtManager = new DebtManager(new EfDebtDal(), new CustomerBalanceManager(new EfCustomerBalanceDal()));

        CartValidationTool cartValidationTool = new CartValidationTool();
        SaleValidationTool saleValidationTool = new SaleValidationTool();
        ProductViewDashboardDetailsSearch detailsSearch = new ProductViewDashboardDetailsSearch();





        private void ButtonSalesFormYenile_Click(object sender, EventArgs e)
        {

        }

        private void ButtonX_Click(object sender, EventArgs e)
        {
            RemoveCart();
            Application.Exit();
        }

        private void ButtonSalesFormSil_Click(object sender, EventArgs e)
        {

            try
            {
                Cart cart = new Cart();
                CartAddDto cartAddDto = _cartManager.GetCartAddDetailByBarcodeNumber(textBoxBarkodNo.Text).Data;

                if (cartAddDto != null)
                {
                    cart.Id = cartAddDto.CartId;
                    if (cartAddDto.Quantity <= 1 || textBoxMiqdar.Text == "" || cartAddDto.Quantity <= Convert.ToInt32(textBoxMiqdar.Text))
                    {
                        IResult result = _cartManager.Delete(cart);
                        if (!result.Success)
                        {
                            FormsMessage.ErrorMessage(result.Message);
                            return;
                        }

                    }
                    else
                    {
                        cart.ProductId = int.Parse(textBoxProductId.Text);
                        cart.UserId = cartAddDto.UserId;
                        cart.Quantity = cartAddDto.Quantity - Convert.ToInt32(textBoxMiqdar.Text);
                        cart.SoldPrice = cartAddDto.SoldPrice;
                        CalculateTotalPrice(cart.Quantity, cart.SoldPrice);
                        cart.TotalPrice = Convert.ToDecimal(textBoxCem.Text);
                        //  CartValidation(cart);
                        IResult result = _cartManager.Update(cart);
                        if (!result.Success)
                        {
                            FormsMessage.WarningMessage(result.Message);
                            return;
                        }

                    }
                }

                GroupBoxMehsulControlClear();
                TotalPriceLabelWrite();
                CartListRefesh();
            }
            catch (ArgumentNullException ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex) +
                      " ( Hansısa dəyər boşdur zəhmət olmasa bütün dəyərləri yenidən yoxlayın ) ");
                return;
            }
            catch (FormatException ex)
            {

                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex) +
                     " ( Daxil edilən dəyərlərin hansısa yerləşdiyi xananın formatına uyğun deyil zəhmət olmasa bütün dəyərləri yenidən gözdən keçirin ) ");
                return;
            }
            catch (NullReferenceException ex)
            {

                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex) +
                    " ( Daxil edilən dəyərlərin hansısa yerləşdiyi xananın formatına uyğun deyil və ya referans boşdur zəhmət olmasa bütün dəyərləri yenidən gözdən keçirin ) ");
                return;
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }


        }

        private void ButonSalesFormSatisIptal_Click(object sender, EventArgs e)
        {

            RemoveCart();
            CartListRefesh();
            TotalPriceLabelWrite();
            GroupBoxMehsulControlClear();
            FormsMessage.InformationMessage(SaleMessages.SaleCancel);


        }

        private void buttonSec_Click(object sender, EventArgs e)
        {
            CustomerListForm customerListForm = new CustomerListForm();
            customerListForm.ShowDialog();
            textBoxCustomerId.Text = SelectedCustomerForSalesForm.Id.ToString();
            IDataResult<Customer> result = _customerManager.GetById(SelectedCustomerForSalesForm.Id);
            if (!result.Success)
            {
                FormsMessage.ErrorMessage(result.Message);
                return;
            }

            textBoxAd.Text = result.Data.FirstName;
            textBoxSoyad.Text = result.Data.LastName;
            textBoxTelefon.Text = result.Data.PhoneNumber;
            FormsMessage.SuccessMessage(result.Message);

        }

        
        private void buttonBorcElaveEt_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCustomerId.Text == "")
                {
                    FormsMessage.WarningMessage(BaseMessages.SelectValue);
                    return;
                }
                int customerId = int.Parse(textBoxCustomerId.Text);

                Debt debt = new Debt();
                IDataResult<List<Cart>> carts = _cartManager.GetAllByUserId(staticUserId);
                IResult debtAdded;
                IResult productUpdated;
                List<string> messages = new List<string>();
                string resultMessage = "";
                string newResultMessage = "";
                if (carts.Data.Count != 0)
                {
                    foreach (Cart cart in carts.Data)
                    {

                        Product product = _productManager.GetById(cart.ProductId).Data;
                        product.UnitsInStock -= cart.Quantity;
                        debt.ProductId = cart.ProductId;
                        debt.CustomerId = customerId;
                        debt.SoldPrice = cart.SoldPrice;
                        debt.Quantity = cart.Quantity;

                        debtAdded = _debtManager.Add(debt);
                        productUpdated = _productManager.Update(product);
                        if (!debtAdded.Success || !productUpdated.Success)
                        {
                            messages.Add(product.BarcodeNumber + " - " + product.ProductName + " : " + debtAdded.Message + " & " + productUpdated.Message);

                        }
                        messages.Add(product.ProductName + " : " + debtAdded.Message + " & " + productUpdated.Message);


                    }
                    foreach (string message in messages)
                    {
                        resultMessage += $" {message} {newResultMessage} |";
                    }
                    FormsMessage.SuccessMessage(resultMessage);


                    //GroupBoxIstifadeciControlClear();
                }
                else
                {
                    FormsMessage.InformationMessage(CartMessages.ProductNotFound);
                    return;
                }
                RemoveCart();
                CartListRefesh();
                ProductListRefesh();
                GroupBoxMehsulControlClear();
                TotalPriceLabelWrite();
            }
            catch (Exception ex)
            {

                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }

        private void buttoElaveEt_Click(object sender, EventArgs e)
        {

            try
            {
                bool isBarcodeNumberExists = false;

                if (textBoxProductId.Text == "")
                {
                    FormsMessage.ErrorMessage(ProductMessages.SureFillInFields);
                    return;
                }
                Cart cart = new Cart();
                IResult cartUpdated;
                IResult cartAdded;

                cart.ProductId = int.Parse(textBoxProductId.Text);
                cart.SoldPrice = textBoxQiymet.Text == "" ? decimal.Parse(textBoxMaxQiymet.Text) : decimal.Parse(textBoxQiymet.Text);
                cart.Quantity = int.Parse(textBoxMiqdar.Text);
                cart.TotalPrice = decimal.Parse(textBoxCem.Text);
                cart.UserId = staticUserId;
                if (!cartValidationTool.IsValid(cart))
                {
                    return;
                }

                IsBarcodeNumberExists(int.Parse(textBoxProductId.Text), out isBarcodeNumberExists);
                if (isBarcodeNumberExists == true)
                {
                    CartAddDto cartAddDto = _cartManager.GetCartAddDetailByProductId(int.Parse(textBoxProductId.Text)).Data;
                    cart.Id = cartAddDto.CartId;
                    cart.Quantity = textBoxMiqdar.Text.Equals("1") ? cartAddDto.Quantity + int.Parse(textBoxMiqdar.Text) : int.Parse(textBoxMiqdar.Text);
                    cart.SoldPrice = decimal.Parse(textBoxQiymet.Text == "" ? textBoxMaxQiymet.Text : textBoxQiymet.Text);
                    cart.TotalPrice = cart.SoldPrice * cart.Quantity;
                    cartUpdated = _cartManager.Update(cart);
                    if (!cartUpdated.Success)
                    {
                        FormsMessage.WarningMessage(cartUpdated.Message);
                        return;
                    }
                    FormsMessage.SuccessMessage(cartUpdated.Message);
                }
                else
                {
                    cartAdded = _cartManager.Add(cart);
                    if (!cartAdded.Success)
                    {
                        FormsMessage.WarningMessage(cartAdded.Message);
                        return;
                    }
                    FormsMessage.SuccessMessage(CartMessages.ProductAdded);
                }

                CartListRefesh();
                TotalPriceLabelWrite();
                GroupBoxMehsulControlClear();
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }

        }

        private void buttonDuzelt_Click(object sender, EventArgs e)
        {
            try
            {

                Cart cart = _cartManager.GetById(_cartId).Data;

                if (textBoxMiqdar.Text == "")
                {
                    FormsMessage.WarningMessage(FormsTextMessages.QuantityIsBlank);
                    return;
                }

                cart.Quantity = int.Parse(textBoxMiqdar.Text);

                cart.SoldPrice = textBoxQiymet.Text == "" ? decimal.Parse(textBoxMaxQiymet.Text) : decimal.Parse(textBoxQiymet.Text);
                cart.TotalPrice = cart.Quantity * cart.SoldPrice;

                IResult updatedCart = _cartManager.Update(cart);
                if (!updatedCart.Success)
                {
                    FormsMessage.ErrorMessage(updatedCart.Message);
                    return;
                }
                FormsMessage.SuccessMessage(updatedCart.Message);

                CartListRefesh();
                TotalPriceLabelWrite();
                GroupBoxMehsulControlClear();
            }
            catch (NullReferenceException ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex) + " ( Referans boşdur, bir dəyər seçildiyindən əmin olun (Qeyd : Səbətdəki bir dəyəri seçdiyinzdən əmin olun) )");
                return;
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            GroupBoxMehsulControlClear();

        }

        private void ButtonSalesFormSatisEtmek_Click(object sender, EventArgs e)
        {
            try
            {
                SaleWinForm saleWinForm = new SaleWinForm();
                IDataResult<List<Cart>> carts = _cartManager.GetAllByUserId(staticUserId);
                IResult saleWinFormAdded;
                IResult productUpdated;
                List<string> messages = new List<string>();
                string resultMessage = "";
                string newResultMessage = "";
                if (carts.Data.Count != 0)
                {
                    foreach (Cart cart in carts.Data)
                    {

                        Product product = _productManager.GetById(cart.ProductId).Data;
                        product.UnitsInStock -= cart.Quantity;
                        saleWinForm.Id = 0;
                        saleWinForm.ProductId = cart.ProductId;
                        saleWinForm.UserId = cart.UserId;
                        saleWinForm.SoldPrice = cart.SoldPrice;
                        saleWinForm.Quantity = cart.Quantity;

                        if (!saleValidationTool.IsValid(saleWinForm))
                        {
                            return;
                        }

                        saleWinFormAdded = _saleWinFormManager.Add(saleWinForm);
                        productUpdated = _productManager.Update(product);
                        if (!saleWinFormAdded.Success || !productUpdated.Success)
                        {
                            messages.Add(product.BarcodeNumber + " - " + product.ProductName + " : " + saleWinFormAdded.Message + " & " + productUpdated.Message);

                        }
                        messages.Add(product.ProductName + " : " + saleWinFormAdded.Message + " & " + productUpdated.Message);


                    }
                    foreach (string message in messages)
                    {
                        resultMessage += $" {message} {newResultMessage} |";
                    }
                    FormsMessage.SuccessMessage(resultMessage);


                    //GroupBoxIstifadeciControlClear();
                }
                else
                {
                    FormsMessage.InformationMessage(CartMessages.ProductNotFound);
                    return;
                }
                RemoveCart();
                CartListRefesh();
                ProductListRefesh();
                GroupBoxMehsulControlClear();
                TotalPriceLabelWrite();
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }

        }

        private void buttonAxtar_Click(object sender, EventArgs e)
        {
            ComboBoxSelectedValue();
        }


        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            ProductListRefesh();
            CartListRefesh();
            TextBoxController.ClearAllTextBoxesAndCmboBoxesByGroupBox(groupBoxFilter);
        }

        //Text Changed -------------------->
        private void textBoxMiqdar_TextChanged(object sender, EventArgs e)
        {
            CemWrite();

        }

        private void textBoxQiymet_TextChanged(object sender, EventArgs e)
        {
            CemWrite();


        }

        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            //string searchText = textBoxAxtar.Text;
            //List<ProductViewDashboardDetailDto> result = _productManager.GetAllProductViewDasboardDetails().Data
            //                                         .Where(p => p.MehsulAdi.ToLower().Contains(searchText.ToLower()))
            //                                         .ToList();
            //dataGridViewProductList.DataSource = result;
            detailsSearch.GetDataWriteGridView(textBoxAxtar.Text, dataGridViewProductList);
        }



        //Double Click----------------------------------->


        private void dataGridViewCartList_DoubleClick(object sender, EventArgs e)
        {
            GroupBoxMehsulControlClear();
            _cartId = 0;
            if (dataGridViewCartList.CurrentRow == null)
            {
                FormsMessage.WarningMessage(BaseMessages.SelectedValueIsNull);
                return;
            }
            _cartId = int.Parse(dataGridViewCartList.CurrentRow.Cells["Id"].Value.ToString());
            textBoxProductId.Text = dataGridViewCartList.CurrentRow.Cells["ProductId"].Value.ToString();

            CartDto cartDto = _cartManager.GetCartDtoDetailByProductId(Convert.ToInt32(textBoxProductId.Text)).Data;
            textBoxBarkodNo.Text = cartDto.BarcodeNumber.ToString();
            textBoxMehsulAdi.Text = cartDto.ProductName.ToString();
            textBoxMaxQiymet.Text = cartDto.UnitPrice.ToString();

            textBoxQiymet.Text = dataGridViewCartList.CurrentRow.Cells["Qiymet"].Value.ToString();
            textBoxMiqdar.Text = dataGridViewCartList.CurrentRow.Cells["Miqdar"].Value.ToString();
            textBoxCem.Text = dataGridViewCartList.CurrentRow.Cells["Cem"].Value.ToString();
        }

        private void DataGridViewSalesForm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GroupBoxMehsulControlClear();
            if (dataGridViewProductList.CurrentRow == null)
            {
                FormsMessage.WarningMessage(BaseMessages.SelectedValueIsNull);
                return;
            }
            textBoxProductId.Text = dataGridViewProductList.CurrentRow.Cells["ProductId"].Value.ToString();
            textBoxBarkodNo.Text = dataGridViewProductList.CurrentRow.Cells["BarcodeNomresi"].Value.ToString();
            textBoxMehsulAdi.Text = dataGridViewProductList.CurrentRow.Cells["MehsulAdi"].Value.ToString();
            textBoxMaxQiymet.Text = dataGridViewProductList.CurrentRow.Cells["Qiymet"].Value.ToString();
            CemWrite();
        }



        //Key Press--------------------------------------->
        private void textBoxBarkodNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MyControl.MakeTextBoxNumberBox(e);


            if (checkBoxBarkodNo.Checked == true)
            {

                return;
            }
            string barcodeNumber = textBoxBarkodNo.Text;


            if (barcodeNumber.Length >= 13)
            {
                FindByBarcodeNumberAndAddToCart(barcodeNumber);

            }
        }


        private void textBoxMaxQiymet_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyControl.MakeTextBoxDecimalBox(sender, e);
        }

        private void textBoxQiymet_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyControl.MakeTextBoxDecimalBox(sender, e);
        }

        private void textBoxMiqdar_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyControl.MakeTextBoxNumberBox(e);
        }



        //Elave metodlar--------------------------->

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            textBoxBarkodNo.Text = e.Barcode;
        }

        private void CalculateTotalPrice(int quantity, decimal price)
        {
            if (quantity <= 0 || price <= 0)
            {
                textBoxCem.Text = "";
                return;
            }
            else
            {

                textBoxCem.Text = (price * quantity).ToString();

                return;
            }
        }


        private void GroupBoxMehsulControlClear()
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBoxMehsul);
            textBoxMiqdar.Text = "1";
        }

        private void IsBarcodeNumberExists(int productId, out bool isBarcodeNumberExists)
        {
            IDataResult<CartAddDto> result = _cartManager.GetCartAddDetailByProductId(productId);
            // IDataResult<CartAddDto> result = _cartManager.GetCartAddDetailByBarcodeNumber(Convert.ToInt32(textBoxBarkodNo.Text));
            if (result.Success)
            {
                isBarcodeNumberExists = true;
                return;
            }
            isBarcodeNumberExists = false;
            return;
        }


        private void RemoveCart()
        {
            Cart cart = new Cart();
            cart.UserId = staticUserId;    //Mutleq Dinamiklesdir
            _cartManager.ByUserIdAllRemove(cart.UserId);



        }

        private void CartListRefesh()
        {
            dataGridViewCartList.DataSource = _cartManager.GetAllCartViewDetailsByUserId(staticUserId).Data;
        }

        private void ProductListRefesh()
        {
            dataGridViewProductList.DataSource = _productManager.GetAllProductViewDasboardDetails().Data;
        }


        private decimal TotalCartPriceCalculation()
        {
            decimal tolalPrice = 0;
            decimal price;
            List<Cart> carts = _cartManager.GetAllByUserId(staticUserId).Data;

            foreach (Cart cart in carts)
            {
                price = cart.TotalPrice;
                tolalPrice += price;
            }
            return tolalPrice;
        }
        private void TotalPriceLabelWrite()
        {
            LabelSalesFormUmuniCem_qiymet.Text = TotalCartPriceCalculation().ToString();
        }

        private void CemWrite()
        {
            try
            {
                CalculateTotalPrice(int.Parse(textBoxMiqdar.Text), decimal.Parse(textBoxQiymet.Text == "" ? textBoxMaxQiymet.Text : textBoxQiymet.Text));
            }
            catch (Exception)
            {
                textBoxCem.Text = "";
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBarkodNo.Checked == false)
            {
                checkBoxBarkodNo.Text = "Avtomatik";
                buttonBarkodNoAxtar.Visible = false;
            }
            else
            {
                checkBoxBarkodNo.Text = "Manual";
                buttonBarkodNoAxtar.Visible = true;
            }
        }

        private void textBoxBarkodNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBarkodNoAxtar_Click(object sender, EventArgs e)
        {
            FindByBarcodeNumberAndAddToCart(textBoxBarkodNo.Text);
        }

        private void FindByBarcodeNumberAndAddToCart(string barcodeNumber)
        {

            try
            {
                IResult cartAdded;
                IResult cartUpdated;
                bool isbarcodeExists = false;

                IDataResult<Product> result = _productManager.GetByProductBarcodeNumber(barcodeNumber);
                if (result.Success == false)
                {
                    FormsMessage.WarningMessage(result.Message);
                    GroupBoxMehsulControlClear(); //bura yeniden bax
                    return;
                }
                // GroupBoxMehsulControlClear();
                Cart cart = new Cart();
                cart.ProductId = result.Data.Id;
                cart.UserId = staticUserId; //sonra dinamiklesdir
                cart.Quantity = 1;
                cart.SoldPrice = result.Data.UnitPrice;
                cart.TotalPrice = cart.Quantity * cart.SoldPrice;

                if (!cartValidationTool.IsValid(cart))
                {
                    return;
                }



                IsBarcodeNumberExists(cart.ProductId, out isbarcodeExists);
                if (isbarcodeExists == true)
                {
                    Cart getCart = _cartManager.GetByProductId(cart.ProductId).Data;
                    cart.Id = getCart.Id;
                    cart.Quantity = getCart.Quantity + 1;
                    cart.TotalPrice = cart.SoldPrice * cart.Quantity;
                    cartUpdated = _cartManager.Update(cart);
                    if (!cartUpdated.Success)
                    {
                        FormsMessage.WarningMessage(cartUpdated.Message);
                        return;
                    }
                    // FormsMessage.SuccessMessage(cartUpdated.Message);
                }
                else
                {

                    cartAdded = _cartManager.Add(cart);
                    if (!cartAdded.Success)
                    {
                        FormsMessage.WarningMessage(cartAdded.Message);
                        return;
                    }
                    //FormsMessage.SuccessMessage(CartMessages.ProductAdded);
                }
                GroupBoxMehsulControlClear();
                CartListRefesh();

                TotalPriceLabelWrite();
            }
            catch (Exception ex)
            {

                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }

        }


        public void CategoryWriteComboBox()
        {
            List<Category> categories = _categoryService.GetAll().Data;
            comboBoxCategoryList.DataSource = categories;
            comboBoxCategoryList.DisplayMember = "CategoryName";
            comboBoxCategoryList.ValueMember = "Id";
            comboBoxCategoryList.Text = "";
        }

        public void BrandWriteComboBox()
        {
            List<Brand> brands = _brandService.GetAll().Data;
            comboBoxBrandList.DataSource = brands;
            comboBoxBrandList.DisplayMember = "BrandName";
            comboBoxBrandList.ValueMember = "Id";
            comboBoxBrandList.Text = "";
        }

        public void SupplierWriteComboBox()
        {
            List<Supplier> suppliers = _supplierService.GetAll().Data;
            comboBoxSupplierList.DataSource = suppliers;
            comboBoxSupplierList.DisplayMember = "CompanyName";
            comboBoxSupplierList.ValueMember = "Id";
            comboBoxSupplierList.Text = "";
        }


       

       
        public void ComboBoxSelectedValue()
        {
            List<ProductViewDashboardDetailDto> data = _productManager.GetAllProductViewDasboardDetails().Data;
            if (comboBoxCategoryList.Text == "" && comboBoxSupplierList.Text == "" && comboBoxBrandList.Text == "")
            {
                dataGridViewProductList.DataSource = data;
                return;
            }
            else if (comboBoxCategoryList.Text != "" && comboBoxSupplierList.Text == "" && comboBoxBrandList.Text == "")
            {
                dataGridViewProductList.DataSource = data.Where(p => p.Kateqoriya == comboBoxCategoryList.Text).ToList();
            }
            else if (comboBoxCategoryList.Text == "" && comboBoxSupplierList.Text != "" && comboBoxBrandList.Text == "")
            {
                dataGridViewProductList.DataSource = data.Where(p => p.TedarikciSirket == comboBoxSupplierList.Text).ToList();
            }
            else if (comboBoxCategoryList.Text == "" && comboBoxSupplierList.Text == "" && comboBoxBrandList.Text != "")
            {
                dataGridViewProductList.DataSource = data.Where(p => p.Marka == comboBoxBrandList.Text).ToList();
            }
            else if (comboBoxCategoryList.Text != "" && comboBoxSupplierList.Text != "" && comboBoxBrandList.Text == "")
            {
                dataGridViewProductList.DataSource = data.Where(p => p.Kateqoriya == comboBoxCategoryList.Text)
                                                    .Where(p => p.TedarikciSirket == comboBoxSupplierList.Text)
                                                    .ToList();
            }
            else if (comboBoxCategoryList.Text != "" && comboBoxSupplierList.Text == "" && comboBoxBrandList.Text != "")
            {
                dataGridViewProductList.DataSource = data.Where(p => p.Kateqoriya == comboBoxCategoryList.Text)
                                                   .Where(p => p.Marka == comboBoxBrandList.Text)
                                                   .ToList();
            }
            else if (comboBoxCategoryList.Text == "" && comboBoxSupplierList.Text != "" && comboBoxBrandList.Text != "")
            {
                dataGridViewProductList.DataSource = data.Where(p => p.TedarikciSirket == comboBoxSupplierList.Text)
                                                   .Where(p => p.Marka == comboBoxBrandList.Text)
                                                   .ToList();
            }
            else if (comboBoxCategoryList.Text != "" && comboBoxSupplierList.Text != "" && comboBoxBrandList.Text != "")
            {
                dataGridViewProductList.DataSource = data.Where(p => p.Kateqoriya == comboBoxCategoryList.Text)
                                                   .Where(p => p.TedarikciSirket == comboBoxSupplierList.Text)
                                                   .Where(p => p.Marka == comboBoxBrandList.Text)
                                                   .ToList();
            }
        }


    }
}

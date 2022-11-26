using Business.Constants.Messages;
using Core.Utilities.Results;
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
using WindowsForm.Core.Controllers.Concrete.ValidatorControllers;
using USB_Barcode_Scanner;
using WindowsForm.Utilities.Search.Concrete.ProductSearch;
using WindowsForm.MyControls;
using System.Reflection;
using Business.Abstract;
using System.Linq;
using Entities.DTOs.ProductDtos;
using Entities.DTOs.BonusCardDtos;
using Business.ValidationRules.FluentValidation.SaleValidators;
using WindowsForm.Utilities.Helpers.Calculators;
using Business.ValidationRules.FluentValidation;
using WindowsForm.BonusCardSystem.CommonMethods;
using Entities.Concrete.ForForms;
using WindowsForm.Utilities.Helpers.Receipts;

namespace WindowsForm.Forms
{
    public partial class SalesForm : Form
    {
        private int UserId;
        private int CartId;
        private int BonusCardId;
        private int CustomerId;
        private ReceiptDto receiptDto=new ReceiptDto();

        private List<ProductViewDashboardDetailDto> _dataProduct;

        ICategoryService _categoryService;
        IBrandService _brandService;
        ISupplierService _supplierService;
        IProductService _productService;
        ICartService _cartService;
        ICustomerService _customerService;
        ISaleService _saleService;
        IDebtService _debtService;
        IBonusCardService _bonusCardService;
        IFormSettingService _formSettingService;
        IUserService _userService;

        private MyControl _myControl;
        private BonusCardCommonMethod _bonusCardCommonMethod;
        private readonly IReceiptOperation _receiptOperation;
        IDataResult<CartListDtoForReceipt> cartsFromReceipt;

        public SalesForm(ICategoryService categoryService
                            , IBrandService brandService
                            , ISupplierService supplierService
                            , IProductService productService
                            , ICartService cartService
                            , ICustomerService customerService
                            , ISaleService saleWinFormService
                            , IDebtService debtService
                            , IBonusCardService bonusCardService
                            , IFormSettingService formSettingService,
                            IReceiptOperation receiptOperation,
                            IUserService userService)
        {
            _userService = userService;
            _productService = productService;
            _cartService = cartService;
            _customerService = customerService;
            _saleService = saleWinFormService;
            _debtService = debtService;
            _categoryService = categoryService;
            _brandService = brandService;
            _supplierService = supplierService;
            _bonusCardService = bonusCardService;
            _formSettingService = formSettingService;


            _dataProduct = _productService.GetAllProductViewDasboardDetail().Data;
            _myControl = new MyControl(_formSettingService);
            _receiptOperation = receiptOperation;
            InitializeComponent();
            UserId = LoginForm.UserId;
            TotalPriceLabelWrite();
            MyControl.WritePlaceholdersForTextBoxSearch(textBoxAxtar);
            BarcodeScanner barcodeScanner = new BarcodeScanner(textBoxBarkodNo);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
            CartId = 0;
            BonusCardId = 0;
            BonusCardSelectForm.BonusCardId = 0;
            CustomerId = 0;
            _bonusCardCommonMethod = new BonusCardCommonMethod(_bonusCardService, _myControl, _formSettingService);
        }


        private void SalesForm_Load(object sender, EventArgs e)
        {
            ProductListRefesh();
            CartListRefesh();
            GroupBoxMehsulControlClear();
            CategoryWriteComboBox();
            BrandWriteComboBox();
            SupplierWriteComboBox();
            buttonBonusCardSelect.Visible = false;

        }

        ProductViewDashboardDetailsSearch detailsSearch = new ProductViewDashboardDetailsSearch();

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
                CartAddDto cartAddDto = _cartService.GetCartAddDetailByBarcodeNumber(textBoxBarkodNo.Text).Data;

                if (cartAddDto != null)
                {
                    cart.Id = cartAddDto.CartId;
                    if (cartAddDto.Quantity <= 1 || textBoxMiqdar.Text == "" || cartAddDto.Quantity <= Convert.ToInt32(textBoxMiqdar.Text))
                    {
                        IResult result = _cartService.Delete(cart);
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
                        IResult result = _cartService.Update(cart);
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

        private void buttonTemizleBonusCard_Click(object sender, EventArgs e)
        {
            BonusCardId = 0;
            textBoxBonusCardSelect.Text = "";
            textBoxBonusCardCustomerName.Text = "";
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
            //CustomerListForm customerListForm = new CustomerListForm(_customerService);
            //customerListForm.ShowDialog();
            //textBoxCustomerId.Text = SelectedCustomerForSalesForm.Id.ToString();
            //IDataResult<Customer> result = _customerService.GetById(SelectedCustomerForSalesForm.Id);
            CustomerId = 0;
            CustomerSelectForm customerSelectForm = new CustomerSelectForm(_customerService);
            customerSelectForm.ShowDialog();
            if (CustomerSelectForm.CustomerId == 0)
            {
                FormsMessage.WarningMessage(FormsTextMessages.IdBlank);
                return;
            }
            CustomerId = CustomerSelectForm.CustomerId;
            textBoxCustomerId.Text = CustomerId.ToString();
            IDataResult<Customer> result = _customerService.GetById(CustomerId);
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
                IDataResult<List<Cart>> carts = _cartService.GetAllByUserId(UserId);
                IResult debtAdded;
                IResult productUpdated;
                List<string> messages = new List<string>();
                string resultMessage = "";
                string newResultMessage = "";
                if (carts.Data.Count != 0)
                {
                    foreach (Cart cart in carts.Data)
                    {

                        Product product = _productService.GetById(cart.ProductId).Data;
                        product.UnitsInStock -= cart.Quantity;
                        debt.ProductId = cart.ProductId;
                        debt.CustomerId = customerId;
                        debt.SoldPrice = cart.SoldPrice;
                        debt.Quantity = cart.Quantity;

                        debtAdded = _debtService.Add(debt);
                        productUpdated = _productService.Update(product);
                        if (!debtAdded.Success || !productUpdated.Success)
                        {
                            messages.Add(product.BarcodeNumber + " - " + product.ProductName + " : " + debtAdded.Message + " & " + productUpdated.Message);
                            foreach (string message in messages)
                            {
                                resultMessage += $" {message} {newResultMessage} |";
                            }
                            FormsMessage.ErrorMessage(resultMessage);
                            return;
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
                GroupBoxMusteriControlClear();
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
                cart.UserId = UserId;
                if (!FormValidationTool.IsValid(new CartValidator(), cart))
                {
                    return;
                }

                IsBarcodeNumberExists(int.Parse(textBoxProductId.Text), out isBarcodeNumberExists);
                if (isBarcodeNumberExists == true)
                {
                    CartAddDto cartAddDto = _cartService.GetCartAddDetailByProductId(int.Parse(textBoxProductId.Text)).Data;
                    cart.Id = cartAddDto.CartId;
                    cart.Quantity = cartAddDto.Quantity + int.Parse(textBoxMiqdar.Text);
                    cart.SoldPrice = decimal.Parse(textBoxQiymet.Text == "" ? textBoxMaxQiymet.Text : textBoxQiymet.Text);
                    cart.TotalPrice = cart.SoldPrice * cart.Quantity;
                    cartUpdated = _cartService.Update(cart);
                    if (!cartUpdated.Success)
                    {
                        FormsMessage.WarningMessage(cartUpdated.Message);
                        return;
                    }
                    FormsMessage.SuccessMessage(cartUpdated.Message);
                }
                else
                {
                    cartAdded = _cartService.Add(cart);
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

                Cart cart = _cartService.GetById(CartId).Data;

                if (textBoxMiqdar.Text == "")
                {
                    FormsMessage.WarningMessage(FormsTextMessages.QuantityIsBlank);
                    return;
                }

                cart.Quantity = int.Parse(textBoxMiqdar.Text);

                cart.SoldPrice = textBoxQiymet.Text == "" ? decimal.Parse(textBoxMaxQiymet.Text) : decimal.Parse(textBoxQiymet.Text);
                cart.TotalPrice = cart.Quantity * cart.SoldPrice;

                IResult updatedCart = _cartService.Update(cart);
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
                Sale saleWinForm = new Sale();
                IDataResult<List<Cart>> carts = _cartService.GetAllByUserId(UserId);
                cartsFromReceipt = _cartService.GetAllCartListDtoForReceiptByUserId(UserId);
                IResult saleWinFormAdded;
                IResult productUpdated;
                IDataResult<decimal> bonusCardIncreased = null;
                List<string> messages = new List<string>();
                string resultMessage = "";
                string newResultMessage = "";
                decimal totalPrice = 0;

                if (carts.Data.Count != 0)
                {
                    foreach (Cart cart in carts.Data)
                    {

                        Product product = _productService.GetById(cart.ProductId).Data;
                        product.UnitsInStock -= cart.Quantity;
                        saleWinForm.Id = 0;
                        saleWinForm.ProductId = cart.ProductId;
                        saleWinForm.UserId = cart.UserId;
                        saleWinForm.SoldPrice = cart.SoldPrice;
                        saleWinForm.Quantity = cart.Quantity;

                        if (!FormValidationTool.IsValid(new CreateSaleValidator(), saleWinForm))
                        {
                            return;
                        }

                        saleWinFormAdded = _saleService.Add(saleWinForm);
                        productUpdated = _productService.Update(product);

                        if (!saleWinFormAdded.Success || !productUpdated.Success)
                        {
                            messages.Add(product.BarcodeNumber + " - " + product.ProductName + " : " + saleWinFormAdded.Message + " & " + productUpdated.Message);

                        }
                        messages.Add(product.ProductName + " : " + saleWinFormAdded.Message + " & " + productUpdated.Message);
                        totalPrice += saleWinForm.SoldPrice * saleWinForm.Quantity;

                    }
                    foreach (string message in messages)
                    {
                        resultMessage += $" {message} {newResultMessage} |";
                    }

                    if (BonusCardId != 0)
                    {
                        decimal interestedAdvantage = AdvantageCalculator.WhatIsAdvantageToday(_formSettingService);
                        bonusCardIncreased = _bonusCardService.IncreaseBalance(BonusCardId
                            , UserId
                            , totalPrice
                            , interestedAdvantage);
                        if (!bonusCardIncreased.Success)
                        {
                            FormsMessage.WarningMessage(bonusCardIncreased.Message);

                        }
                        else
                        {
                            FormsMessage.SuccessMessage(bonusCardIncreased.Message);
                        }

                    }
                    TextBoxController.ClearAllTextBoxesByGroupBox(groupBoxMusteri);
                    FormsMessage.SuccessMessage(resultMessage);
                    //GroupBoxIstifadeciControlClear();
                }
                else
                {
                    FormsMessage.InformationMessage(CartMessages.ProductNotFound);
                    return;
                }
                RemoveCart();
               
                if (checkBoxPrintReceipt.Checked == true)
                {
                    decimal? value;
                    try {  value = bonusCardIncreased.Data; }
                    catch (NullReferenceException)
                    {
                        value = 0;
                    }

                    receiptDto = new ReceiptDto(_userService, _bonusCardService,
                                                          UserId,
                                                          BonusCardId,
                                                          value
                                                         );
                    IResult printReceipt = _receiptOperation.PrintReceipt(printPreviewDialogReceipt, printDocReceipt);
                    if (!printReceipt.Success)
                    {
                        FormsMessage.WarningMessage(printReceipt.Message);
                        return;
                    }
                }
                CartListRefesh();
                ProductListRefesh();
                GroupBoxMehsulControlClear();
                TotalPriceLabelWrite();
                buttonTemizleBonusCard_Click(sender, e);
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }

        }

        private void buttonAxtar_Click(object sender, EventArgs e)
        {
            ComboBoxSelectedValue(dataGridViewProductList, comboBoxCategoryList.Text, comboBoxSupplierList.Text, comboBoxBrandList.Text);
        }


        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            ProductListRefesh();
            CartListRefesh();
            TextBoxController.ClearAllTextBoxesAndCmboBoxesByGroupBox(groupBoxFilter);
        }

        private void buttonBonusCardSelect_Click(object sender, EventArgs e)
        {
            BonusCardSelectForm bonusCardSelectForm = new BonusCardSelectForm(_bonusCardService);
            bonusCardSelectForm.ShowDialog();
            IDataResult<BonusCardForFormsDto> getBonusCard = _bonusCardService.GetBonusCardForFormsDetailById(BonusCardSelectForm.BonusCardId);
            if (!getBonusCard.Success)
            {
                FormsMessage.WarningMessage(getBonusCard.Message);
                return;
            }
            BonusCardId = BonusCardSelectForm.BonusCardId;
            textBoxBonusCardCustomerName.Text = getBonusCard.Data.Ad + " " + getBonusCard.Data.Soyad;
        }

        private void buttonBarkodNoAxtar_Click(object sender, EventArgs e)
        {
            FindByBarcodeNumberAndAddToCart(textBoxBarkodNo.Text);
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
            List<ProductViewDashboardDetailDto> data = _productService.GetAllProductViewDasboardDetail().Data;
            detailsSearch.GetDataWriteGridView(data, textBoxAxtar.Text, dataGridViewProductList);
        }

        //Checked changed--------------------------->
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

        private void checkBoxBonusCard_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBonusCard.Checked == false)
            {
                checkBoxBonusCard.Text = "Avtomatik";
                buttonBonusCardSelect.Visible = false;
                textBoxBonusCardSelect.Visible = true;
            }
            else
            {
                checkBoxBonusCard.Text = "Manual";
                buttonBonusCardSelect.Visible = true;
                textBoxBonusCardSelect.Visible = false;
            }
        }

        private void checkBoxPrintReceipt_CheckedChanged(object sender, EventArgs e)
        {
            // FormSetting formSetting = _formSettingService.GetByName();
            if (checkBoxPrintReceipt.Checked == false)
            {

            }
            else
            {

            }
        }


        //Double Click----------------------------------->


        private void dataGridViewCartList_DoubleClick(object sender, EventArgs e)
        {
            GroupBoxMehsulControlClear();
            CartId = 0;
            if (dataGridViewCartList.CurrentRow == null)
            {
                FormsMessage.WarningMessage(BaseMessages.SelectedValueIsNull);
                return;
            }
            CartId = int.Parse(dataGridViewCartList.CurrentRow.Cells["Id"].Value.ToString());
            textBoxProductId.Text = dataGridViewCartList.CurrentRow.Cells["ProductId"].Value.ToString();

            CartDto cartDto = _cartService.GetCartDtoDetailByProductId(Convert.ToInt32(textBoxProductId.Text)).Data;
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

        private void textBoxBonusCardSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            _bonusCardCommonMethod.BonusCardSelectByTextBox(textBoxBonusCardSelect,
                                                            textBoxBonusCardCustomerName,
                                                            ref BonusCardId,
                                                             e,
                                                             out _);
            //try
            //{
            //    _myControl.MakeTextBoxNumberBox(e);
            //    string barcodeNumber = textBoxBonusCardSelect.Text;
            //    if (barcodeNumber.Length >= 13)
            //    {
            //        IDataResult<BonusCardForFormsDto> getBonusCard = _bonusCardService.GetBonusCardForFormsDetailByBarcodeNumber(barcodeNumber);
            //        if (!getBonusCard.Success)
            //        {
            //            FormsMessage.WarningMessage(getBonusCard.Message);
            //            return;
            //        }
            //        BonusCardId = getBonusCard.Data.BonusCardId;
            //        textBoxBonusCardCustomerName.Text = getBonusCard.Data.Ad + " " + getBonusCard.Data.Soyad;
            //        FormsMessage.SuccessMessage(getBonusCard.Message);

            //    }
            //}
            //catch (Exception ex)
            //{
            //    FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
            //    return;
            //}
        }

        private void textBoxMaxQiymet_KeyPress(object sender, KeyPressEventArgs e)
        {
            _myControl.MakeTextBoxDecimalBox(sender, e);
        }

        private void textBoxQiymet_KeyPress(object sender, KeyPressEventArgs e)
        {
            _myControl.MakeTextBoxDecimalBox(sender, e);
        }

        private void textBoxMiqdar_KeyPress(object sender, KeyPressEventArgs e)
        {
            _myControl.MakeTextBoxNumberBox(e);
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

        private void GroupBoxMusteriControlClear()
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBoxMusteri);
        }

        private void GroupBoxMehsulControlClear()
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBoxMehsul);
            textBoxMiqdar.Text = "1";
        }

        private void IsBarcodeNumberExists(int productId, out bool isBarcodeNumberExists)
        {
            IDataResult<CartAddDto> result = _cartService.GetCartAddDetailByProductId(productId);
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
            cart.UserId = UserId;
            _cartService.ByUserIdAllRemove(cart.UserId);
        }

        private void CartListRefesh()
        {
            dataGridViewCartList.DataSource = _cartService.GetAllCartViewDetailsByUserId(UserId).Data;
            MyControl.MakeDataGridViewCurrentColumnCurrentColor(dataGridViewCartList, "AlisQiymeti", Color.Yellow);
            MyControl.MakeDataGridViewCurrentColumnCurrentColor(dataGridViewCartList, "Qiymet", Color.Green);
            MyControl.MakeDataGridViewCurrentColumnCurrentColor(dataGridViewCartList, "Cem", Color.Red);
        }

        private void ProductListRefesh()
        {
            _dataProduct = _productService.GetAllProductViewDasboardDetail().Data;
            dataGridViewProductList.DataSource = _dataProduct;
            MyControl.MakeDataGridViewCurrentColumnCurrentColor(dataGridViewProductList, "AlisQiymet", Color.Yellow);
            MyControl.MakeDataGridViewCurrentColumnCurrentColor(dataGridViewProductList, "Qiymet", Color.Green);
        }


        private decimal TotalCartPriceCalculation()
        {
            decimal tolalPrice = 0;
            decimal price;
            List<Cart> carts = _cartService.GetAllByUserId(UserId).Data;
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



        private void textBoxBarkodNo_TextChanged(object sender, EventArgs e)
        {

        }



        private void FindByBarcodeNumberAndAddToCart(string barcodeNumber)
        {

            try
            {
                IResult cartAdded;
                IResult cartUpdated;
                bool isbarcodeExists = false;

                IDataResult<Product> result = _productService.GetByBarcodeNumber(barcodeNumber);
                if (result.Success == false)
                {
                    FormsMessage.WarningMessage(result.Message);
                    GroupBoxMehsulControlClear(); //bura yeniden bax
                    return;
                }
                // GroupBoxMehsulControlClear();
                Cart cart = new Cart();
                cart.ProductId = result.Data.Id;
                cart.UserId = UserId; //sonra dinamiklesdir
                cart.Quantity = 1;
                cart.SoldPrice = result.Data.UnitPrice;
                cart.TotalPrice = cart.Quantity * cart.SoldPrice;

                if (!FormValidationTool.IsValid(new CartValidator(), cart))
                {
                    return;
                }



                IsBarcodeNumberExists(cart.ProductId, out isbarcodeExists);
                if (isbarcodeExists == true)
                {
                    Cart getCart = _cartService.GetByProductId(cart.ProductId).Data;
                    cart.Id = getCart.Id;
                    cart.Quantity = getCart.Quantity + 1;
                    cart.TotalPrice = cart.SoldPrice * cart.Quantity;
                    cartUpdated = _cartService.Update(cart);
                    if (!cartUpdated.Success)
                    {
                        FormsMessage.WarningMessage(cartUpdated.Message);
                        return;
                    }
                }
                else
                {

                    cartAdded = _cartService.Add(cart);
                    if (!cartAdded.Success)
                    {
                        FormsMessage.WarningMessage(cartAdded.Message);
                        return;
                    }
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





        public void ComboBoxSelectedValue(DataGridView dataGridView
                                            , string cmbCategoryText, string cmbSupplierText, string cmbBrandText)
        {
            List<ProductViewDashboardDetailDto> data = _productService.GetAllProductViewDasboardDetail().Data;
            if (cmbCategoryText == "" && cmbSupplierText == "" && cmbBrandText == "")
            {
                dataGridView.DataSource = data;
                return;
            }
            else if (cmbCategoryText != "" && cmbSupplierText == "" && cmbBrandText == "")
            {
                dataGridView.DataSource = data.Where(p => p.Kateqoriya == cmbCategoryText).ToList();
            }
            else if (cmbCategoryText == "" && cmbSupplierText != "" && cmbBrandText == "")
            {
                dataGridView.DataSource = data.Where(p => p.TedarikciSirket == cmbSupplierText).ToList();
            }
            else if (cmbCategoryText == "" && cmbSupplierText == "" && cmbBrandText != "")
            {
                dataGridView.DataSource = data.Where(p => p.Marka == cmbBrandText).ToList();
            }
            else if (cmbCategoryText != "" && cmbSupplierText != "" && cmbBrandText == "")
            {
                dataGridView.DataSource = data.Where(p => p.Kateqoriya == cmbCategoryText)
                                                    .Where(p => p.TedarikciSirket == cmbSupplierText)
                                                    .ToList();
            }
            else if (cmbCategoryText != "" && cmbSupplierText == "" && cmbBrandText != "")
            {
                dataGridView.DataSource = data.Where(p => p.Kateqoriya == cmbCategoryText)
                                                   .Where(p => p.Marka == cmbBrandText)
                                                   .ToList();
            }
            else if (cmbCategoryText == "" && cmbSupplierText != "" && cmbBrandText != "")
            {
                dataGridView.DataSource = data.Where(p => p.TedarikciSirket == cmbSupplierText)
                                                   .Where(p => p.Marka == cmbBrandText)
                                                   .ToList();
            }
            else if (cmbCategoryText != "" && cmbSupplierText != "" && cmbBrandText != "")
            {
                dataGridView.DataSource = data.Where(p => p.Kateqoriya == cmbCategoryText)
                                                   .Where(p => p.TedarikciSirket == cmbSupplierText)
                                                   .Where(p => p.Marka == cmbBrandText)
                                                   .ToList();
            }
        }

        private void textBoxBonusCardSelect_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBonusCardCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        //Print Page
        private void printDocReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // IDataResult<CartListDtoForReceipt> carts = _cartService.GetAllCartListDtoForReceiptByUserId(UserId);
            _receiptOperation.PrepareAReceipt(e, printDocReceipt, cartsFromReceipt, receiptDto);
        }
    }
}

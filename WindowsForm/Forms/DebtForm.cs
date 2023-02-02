using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.DebtDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsForm.MyControls;

namespace WindowsForm.Forms
{
    public partial class DebtForm : Form
    {
        private readonly IDebtService _debtService;
        private readonly ICustomerService _customerService;
        private readonly ICustomerBalanceService _customerBalanceService;
        

        private List<DebtDto> _dataDebt;
        public DebtForm(IDebtService debtService,
                        ICustomerService customerService,
                        ICustomerBalanceService customerBalanceService)
        {
            _debtService = debtService;
            _customerService = customerService;
            _customerBalanceService = customerBalanceService;
            InitializeComponent();
            DebtsRefresh();
            GetCustomerWriteComboBoxCustomers();
        }

        private void buttonAxtar_Click(object sender, EventArgs e)
        {
            IResult rules = BusinessRules.Run(GetDebtsBySelectedCustomer(),
                                              GetDebtsBySelectedType(),
                                              GetDebtsBySelectedDate(),
                                              GetDebtsBySelectedCustomerAndType());
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            DebtsRefresh();
        }
        private void DebtsRefresh() 
        {
            _dataDebt = _debtService.GetAllDebtDetail().Data;
            dataGridViewList.DataSource = _dataDebt;
        }

        private void GetCustomerWriteComboBoxCustomers()
        {

            List<Customer> customers = _customerService.GetAll().Data;
            List<Customer> getCustomers = new List<Customer>();
            List<CustomerBalance> balances=_customerBalanceService.GetAll().Data.Where(b=>b.Debt>0).ToList();
            foreach (var cus in customers)
            {
                foreach (var bal in balances)
                {
                    if (cus.Id==bal.CustomerId)
                    {
                        getCustomers.Add(cus);
                    }
                }
            }
            comboBoxCustomerList.DataSource = getCustomers;
            comboBoxCustomerList.DisplayMember = "LastName";
            comboBoxCustomerList.ValueMember = "Id";
        }

        private IResult GetDebtsBySelectedCustomer()
        {

            if (comboBoxCustomerList.Text == "")
            {
                return new ErrorResult();
            }
            else if (comboBoxCustomerList.Text != "" && comboBoxTypeList.Text == "" && comboBoxDateList.Text == "")
            {
                dataGridViewList.DataSource = _debtService.GetAllByCustomerId(Convert.ToInt32(comboBoxCustomerList.SelectedValue)).Data;
                return new SuccessResult();
            }
            return new SuccessResult();

        }

        private IResult GetDebtsBySelectedType()
        {
            if (comboBoxTypeList.Text == "")
            {
                return new ErrorResult();
            }
            else if (comboBoxCustomerList.Text == "" && comboBoxTypeList.Text != "" && comboBoxDateList.Text == "")
            {
                dataGridViewList.DataSource = _debtService.GetAll().Data;
                return new SuccessResult();
            }
            return new SuccessResult();
        }
        private IResult GetDebtsBySelectedDate()
        {
            if (comboBoxDateList.Text == "")
            {
                return new ErrorResult();
            }
            else if (comboBoxCustomerList.Text == "" && comboBoxTypeList.Text == "" && comboBoxDateList.Text != "")
            {
                dataGridViewList.DataSource = _debtService.GetAll().Data;
                return new SuccessResult();
            }
            return new SuccessResult();
        }

        private IResult GetDebtsBySelectedCustomerAndType()
        {
            if (comboBoxCustomerList.Text == ""&& comboBoxTypeList.Text=="")
            {
                return new ErrorResult();
            }
            else if (comboBoxCustomerList.Text != "" && comboBoxTypeList.Text != "" && comboBoxDateList.Text == "")
            {
                //dataGridViewList.DataSource = _debtService.GetAllByCustomerId(Convert.ToInt32(comboBoxCustomerList.SelectedValue))
                //    .Data
                //    .Where();
                return new SuccessResult();
            }
            return new SuccessResult();
        }

        }
}

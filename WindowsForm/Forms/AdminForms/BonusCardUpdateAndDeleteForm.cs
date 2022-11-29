using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.BonusCardDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Core.Constants.Messages;
using WindowsForm.Core.Controllers.Concrete;
using WindowsForm.Core.Controllers.Concrete.ValidatorControllers;
using WindowsForm.Utilities.Search.Concrete.BonusCardSearch;

namespace WindowsForm.Forms.AdminForms
{
    public partial class BonusCardUpdateAndDeleteForm : Form
    {
        IBonusCardService _bonusCardService;

        List<BonusCardForFormsDto> _dataBonusCardForFormsDetail;

        BonusCardSearch bonusCardSearch;
        public BonusCardUpdateAndDeleteForm(IBonusCardService bonusCardService)
        {
            _bonusCardService = bonusCardService;
            bonusCardSearch = new BonusCardSearch();
            _dataBonusCardForFormsDetail = _bonusCardService.GetAllBonusCardForFormsDetail().Data;
            InitializeComponent();
        }

        //Load
        private void BonusCardUpdateAndDeleteForm_Load(object sender, EventArgs e)
        {
            BonusCardRefresh();
        }

        //Click
        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            BonusCardRefresh();
        }


        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            TextBoxController.ClearAllTextBoxesByGroupBox(groupBoxMusteri);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                BonusCard bonusCard = new BonusCard();
                bonusCard.Id = textBoxBonusCardId.Text == "" ? 0 : int.Parse(textBoxBonusCardId.Text);
                DialogResult dialogResult = MessageBox.Show("Bonus kartı yeniləmək isdədiyinzdən əminmisiniz?", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    IDataResult<BonusCard> getCard = _bonusCardService.GetById(bonusCard.Id);
                    if (!getCard.Success)
                    {
                        FormsMessage.WarningMessage(getCard.Message);
                        return;
                    }
                    bonusCard = getCard.Data;
                    bonusCard.BarcodeNumber=textBoxBonusCardBarcode.Text==""
                        ?getCard.Data.BarcodeNumber
                        : textBoxBonusCardBarcode.Text;
                    bonusCard.InterestAdvantage = decimal.Parse(textBoxGuzest.Text);
                    if (!FormValidationTool.IsValid(new BonusCardValidator(), bonusCard))
                    {
                        return;
                    }
                    IResult result = _bonusCardService.Update(bonusCard);
                    if (!result.Success)
                    {
                        FormsMessage.WarningMessage(result.Message);
                        return;
                    }
                    FormsMessage.SuccessMessage(result.Message);
                    BonusCardRefresh();
                    TextBoxController.ClearAllTextBoxesByGroupBox(groupBoxMusteri);
                }
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
            
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                BonusCard bonusCard = new BonusCard();
                bonusCard.Id = int.Parse(textBoxBonusCardId.Text);
                DialogResult dialogResult = MessageBox.Show("Bonus kartı silmək isdədiyinzdən əminmisiniz?", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    IResult result = _bonusCardService.Delete(bonusCard);
                    if (!result.Success)
                    {
                        FormsMessage.WarningMessage(result.Message);
                        return;
                    }
                    FormsMessage.SuccessMessage(result.Message);
                }
                BonusCardRefresh();
                TextBoxController.ClearAllTextBoxesByGroupBox(groupBoxMusteri);
            }
            catch (Exception ex)
            {
                FormsMessage.ErrorMessage(BaseMessages.ExceptionMessage(this.Name, MethodBase.GetCurrentMethod().Name, ex));
                return;
            }
            
        }

        //Text Changed
        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {

            bonusCardSearch.GetDataWriteGridView(_dataBonusCardForFormsDetail
                , textBoxAxtar.Text, dataGridViewList);
        }


        //Cell Double Click
        private void dataGridViewList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxBonusCardId.Text = dataGridViewList.CurrentRow.Cells["BonusCardId"].Value.ToString();
            textBoxBonusCardBarcode.Text = dataGridViewList.CurrentRow.Cells["BarkodNomresi"].Value.ToString();
            textBoxAd.Text = dataGridViewList.CurrentRow.Cells["Ad"].Value.ToString();
            textBoxSoyad.Text = dataGridViewList.CurrentRow.Cells["Soyad"].Value.ToString();
            textBoxBalance.Text = dataGridViewList.CurrentRow.Cells["Balans"].Value.ToString();
            textBoxGuzest.Text = dataGridViewList.CurrentRow.Cells["MusteriGuzesti"].Value.ToString();
        }

        //Elave
        private void BonusCardRefresh()
        {
            _dataBonusCardForFormsDetail = _bonusCardService.GetAllBonusCardForFormsDetail().Data;
            dataGridViewList.DataSource = _dataBonusCardForFormsDetail;// _bonusCardService.GetAllBonusCardForFormsDetail().Data;
        }

    }
}

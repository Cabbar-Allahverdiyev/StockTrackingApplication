using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
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
using WindowsForm.Utilities.Search.Concrete.BonusCardSearch;

namespace WindowsForm.Forms.AdminForms
{
    public partial class BonusCardUpdateAndDeleteForm : Form
    {
        IBonusCardService _bonusCardService;
        public BonusCardUpdateAndDeleteForm(IBonusCardService bonusCardService)
        {
            _bonusCardService = bonusCardService;
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
            BonusCard bonusCard = new BonusCard();
            bonusCard.Id = int.Parse(textBoxBonusCardId.Text);
            DialogResult dialogResult = MessageBox.Show("Bonus kartı yeniləmək isdədiyinzdən əminmisiniz?","Diqqət",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            //switch (dialogResult)
            //{
             
            //    case DialogResult.Yes:
            //        IResult result = _bonusCardService.Update(bonusCard);
            //        if (!result.Success)
            //        {
            //            FormsMessage.WarningMessage(result.Message);
            //            return;
            //        }
            //        FormsMessage.SuccessMessage(result.Message);
            //        break;
            //    case DialogResult.No:
            //        break;
            //    default:
            //        break;
            //}
            if (dialogResult==DialogResult.Yes)
            {
                IDataResult<BonusCard> getCard = _bonusCardService.GetById(bonusCard.Id);
                if (!getCard.Success)
                {
                    FormsMessage.WarningMessage(getCard.Message);
                    return;
                }
                bonusCard = getCard.Data;
                bonusCard.InterestAdvantage=decimal.Parse(textBoxGuzest.Text);

                BonusCardValidationTool bonusCardValidationTool = new BonusCardValidationTool();
                if (!bonusCardValidationTool.IsValid(bonusCard))
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

        private void buttonSil_Click(object sender, EventArgs e)
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

        //Text Changed
        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            BonusCardSearch bonusCardSearch = new BonusCardSearch();
            bonusCardSearch.GetDataWriteGridView(_bonusCardService.GetBonusCardForFormsDetails().Data
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
            dataGridViewList.DataSource = _bonusCardService.GetBonusCardForFormsDetails().Data;
        }

    }
}

using Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsForm.Utilities.Search.Concrete.BonusCardSearch;

namespace WindowsForm.Forms
{
    public partial class BonusCardSelectForm : Form
    {
        IBonusCardService _bonusCardService;

        public static int BonusCardId { get; set; }
        public BonusCardSelectForm(IBonusCardService bonusCardService)
        {
            _bonusCardService = bonusCardService;
            InitializeComponent();
        }


        //Load
        private void BonusCardSelectForm_Load(object sender, EventArgs e)
        {
            BonusCardRefresh();
        }
        private void groupBoxMusteri_Enter(object sender, EventArgs e)
        {

        }


        //Click
        private void buttonSec_Click(object sender, EventArgs e)
        {
            BonusCardId = int.Parse(textBoxBonusCardId.Text);
            this.Hide();
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            BonusCardRefresh();
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

        //Text Changed
        private void textBoxAxtar_TextChanged(object sender, EventArgs e)
        {
            BonusCardSearch bonusCardSearch = new BonusCardSearch();
            bonusCardSearch.GetDataWriteGridView(_bonusCardService.GetBonusCardForFormsDetails().Data
                ,textBoxAxtar.Text,dataGridViewList);
        }
        //Elave
        private void BonusCardRefresh()
        {
            dataGridViewList.DataSource = _bonusCardService.GetBonusCardForFormsDetails().Data;
        }
    }
}

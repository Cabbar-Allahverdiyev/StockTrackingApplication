using Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Forms
{
    public partial class BonusCardSelectForm : Form
    {
        IBonusCardService _bonusCardService;
        public BonusCardSelectForm(IBonusCardService bonusCardService)
        {
            _bonusCardService = bonusCardService;
            InitializeComponent();
        }

        private void BonusCardSelectForm_Load(object sender, EventArgs e)
        {
            BonusCardRefresh();
        }
        private void groupBoxMusteri_Enter(object sender, EventArgs e)
        {

        }

        private void BonusCardRefresh()
        {
            dataGridViewList.DataSource = _bonusCardService.GetBonusCardForFormsDetails().Data;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jrasmussen1F1
{
    public partial class frmConverterV2 : Form
    {
        public frmConverterV2()
        {
            InitializeComponent();
        }

        private void frmConverterV2_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            txtRate.Text = "0.722626";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtCurrency.Focus();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            txtRate.Text = "0.722626";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtCurrency.Focus();
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            txtRate.Text = "0.0141321";
            lblCurrency.Text = btnBhutan.Text + ": ";
            txtCurrency.Focus();
        }

        private void btnCanada_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnGermany.BackgroundImage = picGermanyDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            txtRate.Text = "0.75518";
            lblCurrency.Text = btnCanada.Text + ": ";
            txtCurrency.Focus();
        }

        private void btnGermany_Click(object sender, EventArgs e)
        {
            btnGermany.BackgroundImage = picGermany.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            txtRate.Text = "1.13303";
            lblCurrency.Text = btnGermany.Text + ": ";
            txtCurrency.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSD.Text = (
                Convert.ToDecimal(txtCurrency.Text)
                * Convert.ToDecimal(txtRate.Text)




                ).ToString("0.00");
        }

        private void txtCurencey_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtUSD.Text;
            txtTotalUSD.Text = (
                 Convert.ToDecimal(txtUSD.Text)
                 + Convert.ToDecimal(txtTotalUSD.Text)


                ).ToString("0.00");
            txtCurrency.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = ("0.00");
            txtUSD.Text = ("0.00");
            txtTotalUSD.Text = ("0.00");
            lblEquation.Text = ("+ 0.00");
            txtCurrency.Focus();
        }
    }
}

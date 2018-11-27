using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jrasmussen1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtAmountBhutan.Text = "0.00";
            txtAmountCanada.Text = "0.00";
            txtAmountEuro.Text = "0.00";
            txtRateAustralia.Text = "0.722626";
            txtRateBhutan.Text = "0.0141321";
            txtRateCanada.Text = "0.75518";
            txtRateEuro.Text = "1.13303";
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                Convert.ToDecimal(txtAmountAustralia.Text)
                * Convert.ToDecimal(txtRateAustralia.Text)
                ).ToString("0.00");
        }

        private void bhutanTextChanged(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (
                   Convert.ToDecimal(txtAmountBhutan.Text)
                   * Convert.ToDecimal(txtRateBhutan.Text)
                   ).ToString("0.00");

        }

        private void canadaTextChanged(object sender, EventArgs e)
        {
            txtUSDCanada.Text = (
                   Convert.ToDecimal(txtAmountCanada.Text)
                   * Convert.ToDecimal(txtRateCanada.Text)
                   ).ToString("0.00");

        }

        private void germanyTextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
                   Convert.ToDecimal(txtAmountEuro.Text)
                   * Convert.ToDecimal(txtRateEuro.Text)
                   ).ToString("0.00");

        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDAustralia.Text)
                +
                Convert.ToDecimal(txtUSDBhutan.Text)
                +
                Convert.ToDecimal(txtUSDCanada.Text)
                +
                Convert.ToDecimal(txtUSDEuro.Text)
                ).ToString("0.00");
                
        }
    }
}

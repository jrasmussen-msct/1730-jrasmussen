using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jrasmussen1E1
{
    public partial class Form1 : Form
private void btnCalculate_Click(object sender, EventArgs e)
    {

    }        public Form1()
    {
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Convert.ToDecimal(txtAverage.Text) = (
           Convert.ToDecimal(txtTest2.Text)
          +Convert.ToDecimal(txtTest1.Text)
          + Convert.ToDecimal(txtTest3.Text)
        /3).ToString("0.00");
        }
}
    }

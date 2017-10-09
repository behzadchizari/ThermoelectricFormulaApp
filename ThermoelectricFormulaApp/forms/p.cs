using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThermoelectricFormulaApp.forms
{
    public partial class p : Form
    {
        public p()
        {
            InitializeComponent();
        }
        public double P { get; set; }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double sp1, sn1, sp2, sn2, I, T1, T2, R1;
            string result = "";
            if (double.TryParse(txtSp1.Text, out sp1) &&
                double.TryParse(txtSn1.Text, out sn1) &&
                double.TryParse(txtSp2.Text, out sp2) &&
                double.TryParse(txtSn2.Text, out sn2) &&
                double.TryParse(txtI.Text, out I) &&
                double.TryParse(txtT1.Text, out T1) &&
                double.TryParse(txtT2.Text, out T2) &&
                double.TryParse(txtR1.Text, out R1))
            {
                P = ((sp1 - sn1) * I * T1) - ((sp2 - sn2) * I * T2) - (Math.Pow(I, 2) * R1);
                result = P.ToString();
            }
            else
            {
                result = "Check Inputs";
            }
            lblResult.Text = $"P = {result}";
        }

    }
}

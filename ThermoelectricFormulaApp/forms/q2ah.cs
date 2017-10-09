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
    public partial class q2ah : Form
    {
        public q2ah()
        {
            InitializeComponent();
        }
        public double q2 { get; set; }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            double cc, mc, r, tco, tci;
            string result = "";
            if (double.TryParse(txtCc.Text, out cc) &&
                double.TryParse(txtMc.Text, out mc) &&
                double.TryParse(txtR.Text, out r) &&
                double.TryParse(txtTco.Text, out tco) &&
                double.TryParse(txtTci.Text, out tci))
            {
                q2 = (cc*mc*(tco-tci)/r);
                result = q2.ToString();
            }
            else
            {
                result = "Check Inputs";
            }
            lblResult.Text = $"q2 = {result}";
        }
    }
}

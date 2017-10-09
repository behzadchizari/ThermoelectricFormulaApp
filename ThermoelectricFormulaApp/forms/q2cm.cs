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
    public partial class q2cm : Form
    {
        public q2cm()
        {
            InitializeComponent();
        }
        public double  q2 { get; set; }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            double h2, A2, T2, tco,tci;
            string result = "";
            if (double.TryParse(txth2.Text, out h2) &&
                double.TryParse(txtA2.Text, out A2) &&
                double.TryParse(txtT2.Text, out T2) &&
                double.TryParse(txtTco.Text, out tco) &&
                double.TryParse(txtTci.Text, out tci))
            {
                q2 = h2 * A2 * (T2 - ((tco+tci)/2));
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

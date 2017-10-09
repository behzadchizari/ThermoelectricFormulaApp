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
    public partial class q1ha : Form
    {
        public q1ha()
        {
            InitializeComponent();
        }
        public double q1 { get; set; }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            double h1, A1, tfi, tfo;
            string result = "";
            if (double.TryParse(txtH1.Text, out h1) &&
                double.TryParse(txtA1.Text, out A1) &&
                double.TryParse(txtTfi.Text, out tfi) &&
                double.TryParse(txtTfo.Text, out tfo))
            {
                q1 = h1 * A1 * ((tfi + tfo) / 2);
                result = q1.ToString();
            }
            else
            {
                result = "Check Inputs";
            }
            lblResult.Text = $"q1 = {result}";
        }
    }
}

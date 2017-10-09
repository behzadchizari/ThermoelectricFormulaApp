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
    public partial class q1cm : Form
    {
        public q1cm()
        {
            InitializeComponent();
        }
        public double q1 { get; set; }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            double cf, mf, tfi, tfo;
            string result = "";
            if (double.TryParse(txtCf.Text, out cf) &&
                double.TryParse(txtMf.Text, out mf) &&
                double.TryParse(txtTfi.Text, out tfi) &&
                double.TryParse(txtTfo.Text, out tfo))
            {
                q1 = cf * mf * ((tfi + tfo) / 2);
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

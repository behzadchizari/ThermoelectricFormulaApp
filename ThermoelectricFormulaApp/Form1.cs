using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThermoelectricFormulaApp.forms;
namespace ThermoelectricFormulaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double q1 { get; set; }
        public double q2 { get; set; }
        public double p { get; set; }
        public double n{ get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            var q1ha = new q1ha();
            q1ha.Show();
            q1ha.Closed += (s, args) => { this.q1 = q1ha.q1; lblq1.Text = $"q1 = {q1ha.q1.ToString()} "; };
        }
        

        private void button2_Click(object sender, EventArgs e)
        {

            var q1cm = new q1cm();
            q1cm.Show();
            q1cm.Closed += (s, args) => { this.q1 = q1cm.q1;  lblq1.Text = $"q1 = {q1cm.q1.ToString()} "; };

        }

        private void button3_Click(object sender, EventArgs e)
        {

            var q2cm = new q2cm();
            q2cm.Show();
            q2cm.Closed += (s, args) => { this.q2 = q2cm.q2; lblq2.Text = $"q2 = {q2cm.q2.ToString()} "; };
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var q2ah = new q2ah();
            q2ah.Show();
            q2ah.Closed += (s, args) => { this.q2 = q2ah.q2; lblq2.Text = $"q2 = {q2ah.q2.ToString()} "; };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var p = new p();
            p.Show();
            p.Closed += (s, args) => { this.p = p.P; lblP.Text = $"p = {p.P.ToString()} "; };
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbln.Text = $"η = {this.p / this.q1}";
        }
    }
}

namespace ThermoelectricFormulaApp.forms
{
    partial class q2cm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.txtTco = new System.Windows.Forms.TextBox();
            this.txtTci = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txth2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtT2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(156, 176);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 34;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(55, 171);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 33;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // txtA2
            // 
            this.txtA2.Location = new System.Drawing.Point(111, 53);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(165, 20);
            this.txtA2.TabIndex = 32;
            // 
            // txtTco
            // 
            this.txtTco.Location = new System.Drawing.Point(111, 106);
            this.txtTco.Name = "txtTco";
            this.txtTco.Size = new System.Drawing.Size(165, 20);
            this.txtTco.TabIndex = 31;
            // 
            // txtTci
            // 
            this.txtTci.Location = new System.Drawing.Point(111, 133);
            this.txtTci.Name = "txtTci";
            this.txtTci.Size = new System.Drawing.Size(165, 20);
            this.txtTci.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "t_ci :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "t_co :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "A2 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "h2 :";
            // 
            // txth2
            // 
            this.txth2.Location = new System.Drawing.Point(111, 22);
            this.txth2.Name = "txth2";
            this.txth2.Size = new System.Drawing.Size(165, 20);
            this.txth2.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "T2 :";
            // 
            // txtT2
            // 
            this.txtT2.Location = new System.Drawing.Point(111, 79);
            this.txtT2.Name = "txtT2";
            this.txtT2.Size = new System.Drawing.Size(165, 20);
            this.txtT2.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThermoelectricFormulaApp.Properties.Resources.Capture2;
            this.pictureBox1.Location = new System.Drawing.Point(55, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // q2cm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 371);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtA2);
            this.Controls.Add(this.txtT2);
            this.Controls.Add(this.txtTco);
            this.Controls.Add(this.txtTci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txth2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "q2cm";
            this.Text = "q2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.TextBox txtTco;
        private System.Windows.Forms.TextBox txtTci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txth2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtT2;
    }
}
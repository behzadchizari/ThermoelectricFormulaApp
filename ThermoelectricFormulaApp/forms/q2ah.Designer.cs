namespace ThermoelectricFormulaApp.forms
{
    partial class q2ah
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
            this.txtMc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTci = new System.Windows.Forms.TextBox();
            this.txtTco = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(156, 187);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 47;
            // 
            // txtMc
            // 
            this.txtMc.Location = new System.Drawing.Point(111, 64);
            this.txtMc.Name = "txtMc";
            this.txtMc.Size = new System.Drawing.Size(165, 20);
            this.txtMc.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mc :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Cc :";
            // 
            // txtCc
            // 
            this.txtCc.Location = new System.Drawing.Point(111, 33);
            this.txtCc.Name = "txtCc";
            this.txtCc.Size = new System.Drawing.Size(165, 20);
            this.txtCc.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "t_co :";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(55, 182);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 46;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "t_ci :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "r :";
            // 
            // txtTci
            // 
            this.txtTci.Location = new System.Drawing.Point(111, 120);
            this.txtTci.Name = "txtTci";
            this.txtTci.Size = new System.Drawing.Size(165, 20);
            this.txtTci.TabIndex = 42;
            // 
            // txtTco
            // 
            this.txtTco.Location = new System.Drawing.Point(111, 93);
            this.txtTco.Name = "txtTco";
            this.txtTco.Size = new System.Drawing.Size(165, 20);
            this.txtTco.TabIndex = 44;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(111, 150);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(165, 20);
            this.txtR.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThermoelectricFormulaApp.Properties.Resources.Capture3;
            this.pictureBox1.Location = new System.Drawing.Point(55, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // q2ah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 371);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtMc);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtTco);
            this.Controls.Add(this.txtTci);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCc);
            this.Controls.Add(this.pictureBox1);
            this.Name = "q2ah";
            this.Text = "q2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtMc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTci;
        private System.Windows.Forms.TextBox txtTco;
        private System.Windows.Forms.TextBox txtR;
    }
}
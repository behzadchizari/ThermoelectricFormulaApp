namespace ThermoelectricFormulaApp.forms
{
    partial class q1cm
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
            this.txtMf = new System.Windows.Forms.TextBox();
            this.txtTfi = new System.Windows.Forms.TextBox();
            this.txtTfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCf = new System.Windows.Forms.TextBox();
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
            this.lblResult.TabIndex = 23;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(55, 171);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 22;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // txtMf
            // 
            this.txtMf.Location = new System.Drawing.Point(111, 76);
            this.txtMf.Name = "txtMf";
            this.txtMf.Size = new System.Drawing.Size(165, 20);
            this.txtMf.TabIndex = 21;
            // 
            // txtTfi
            // 
            this.txtTfi.Location = new System.Drawing.Point(111, 106);
            this.txtTfi.Name = "txtTfi";
            this.txtTfi.Size = new System.Drawing.Size(165, 20);
            this.txtTfi.TabIndex = 20;
            // 
            // txtTfo
            // 
            this.txtTfo.Location = new System.Drawing.Point(111, 133);
            this.txtTfo.Name = "txtTfo";
            this.txtTfo.Size = new System.Drawing.Size(165, 20);
            this.txtTfo.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "t_fo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "t_fi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mf :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cf :";
            // 
            // txtCf
            // 
            this.txtCf.Location = new System.Drawing.Point(111, 45);
            this.txtCf.Name = "txtCf";
            this.txtCf.Size = new System.Drawing.Size(165, 20);
            this.txtCf.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThermoelectricFormulaApp.Properties.Resources.Capture1;
            this.pictureBox1.Location = new System.Drawing.Point(55, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // q1cm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 371);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtMf);
            this.Controls.Add(this.txtTfi);
            this.Controls.Add(this.txtTfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCf);
            this.Controls.Add(this.pictureBox1);
            this.Name = "q1cm";
            this.Text = "q1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtMf;
        private System.Windows.Forms.TextBox txtTfi;
        private System.Windows.Forms.TextBox txtTfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCf;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
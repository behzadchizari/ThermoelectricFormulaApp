namespace ThermoelectricFormulaApp.forms
{
    partial class q1ha
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
            this.txtH1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTfo = new System.Windows.Forms.TextBox();
            this.txtTfi = new System.Windows.Forms.TextBox();
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtH1
            // 
            this.txtH1.Location = new System.Drawing.Point(98, 62);
            this.txtH1.Name = "txtH1";
            this.txtH1.Size = new System.Drawing.Size(165, 20);
            this.txtH1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "h1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A1 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "t_fi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "t_fo :";
            // 
            // txtTfo
            // 
            this.txtTfo.Location = new System.Drawing.Point(98, 150);
            this.txtTfo.Name = "txtTfo";
            this.txtTfo.Size = new System.Drawing.Size(165, 20);
            this.txtTfo.TabIndex = 7;
            // 
            // txtTfi
            // 
            this.txtTfi.Location = new System.Drawing.Point(98, 123);
            this.txtTfi.Name = "txtTfi";
            this.txtTfi.Size = new System.Drawing.Size(165, 20);
            this.txtTfi.TabIndex = 8;
            // 
            // txtA1
            // 
            this.txtA1.Location = new System.Drawing.Point(98, 93);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(165, 20);
            this.txtA1.TabIndex = 9;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(42, 188);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 10;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(143, 193);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThermoelectricFormulaApp.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(42, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // q1ha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 371);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtA1);
            this.Controls.Add(this.txtTfi);
            this.Controls.Add(this.txtTfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtH1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "q1ha";
            this.Text = "q1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtH1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTfo;
        private System.Windows.Forms.TextBox txtTfi;
        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblResult;
    }
}
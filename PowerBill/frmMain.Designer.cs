namespace PowerBill
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.lblkWh1Prompt = new System.Windows.Forms.Label();
            this.lblkWh2Prompt = new System.Windows.Forms.Label();
            this.txtkWh1 = new System.Windows.Forms.TextBox();
            this.txtkWh2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCharge = new System.Windows.Forms.Label();
            this.picPowerCompany = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPowerCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radIndustrial);
            this.groupBox1.Controls.Add(this.radCommercial);
            this.groupBox1.Controls.Add(this.radResidential);
            this.groupBox1.Location = new System.Drawing.Point(38, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select customer type";
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Location = new System.Drawing.Point(414, 41);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(111, 29);
            this.radIndustrial.TabIndex = 2;
            this.radIndustrial.TabStop = true;
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Location = new System.Drawing.Point(210, 41);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(137, 29);
            this.radCommercial.TabIndex = 1;
            this.radCommercial.TabStop = true;
            this.radCommercial.Text = "Commercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Location = new System.Drawing.Point(17, 41);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(128, 29);
            this.radResidential.TabIndex = 0;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // lblkWh1Prompt
            // 
            this.lblkWh1Prompt.AutoSize = true;
            this.lblkWh1Prompt.Location = new System.Drawing.Point(43, 283);
            this.lblkWh1Prompt.Name = "lblkWh1Prompt";
            this.lblkWh1Prompt.Size = new System.Drawing.Size(110, 25);
            this.lblkWh1Prompt.TabIndex = 2;
            this.lblkWh1Prompt.Text = "Used khW:";
            // 
            // lblkWh2Prompt
            // 
            this.lblkWh2Prompt.AutoSize = true;
            this.lblkWh2Prompt.Location = new System.Drawing.Point(43, 341);
            this.lblkWh2Prompt.Name = "lblkWh2Prompt";
            this.lblkWh2Prompt.Size = new System.Drawing.Size(140, 25);
            this.lblkWh2Prompt.TabIndex = 3;
            this.lblkWh2Prompt.Text = "Off-peak khW:";
            // 
            // txtkWh1
            // 
            this.txtkWh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkWh1.Location = new System.Drawing.Point(183, 277);
            this.txtkWh1.Name = "txtkWh1";
            this.txtkWh1.Size = new System.Drawing.Size(128, 34);
            this.txtkWh1.TabIndex = 4;
            // 
            // txtkWh2
            // 
            this.txtkWh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkWh2.Location = new System.Drawing.Point(183, 335);
            this.txtkWh2.Name = "txtkWh2";
            this.txtkWh2.Size = new System.Drawing.Size(128, 34);
            this.txtkWh2.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(71, 416);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(151, 39);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(234, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 41);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(396, 417);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total Charge:";
            // 
            // lblCharge
            // 
            this.lblCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharge.Location = new System.Drawing.Point(462, 278);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(128, 32);
            this.lblCharge.TabIndex = 10;
            this.lblCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPowerCompany
            // 
            this.picPowerCompany.Image = ((System.Drawing.Image)(resources.GetObject("picPowerCompany.Image")));
            this.picPowerCompany.Location = new System.Drawing.Point(443, 40);
            this.picPowerCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPowerCompany.Name = "picPowerCompany";
            this.picPowerCompany.Size = new System.Drawing.Size(109, 111);
            this.picPowerCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPowerCompany.TabIndex = 0;
            this.picPowerCompany.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "PowerBill Calculator";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtkWh2);
            this.Controls.Add(this.txtkWh1);
            this.Controls.Add(this.lblkWh2Prompt);
            this.Controls.Add(this.lblkWh1Prompt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picPowerCompany);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Power Company Charges";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPowerCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.Label lblkWh1Prompt;
        private System.Windows.Forms.Label lblkWh2Prompt;
        private System.Windows.Forms.TextBox txtkWh1;
        private System.Windows.Forms.TextBox txtkWh2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.PictureBox picPowerCompany;
        private System.Windows.Forms.Label label2;
    }
}


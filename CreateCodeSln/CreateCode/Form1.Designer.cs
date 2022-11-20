namespace CreateCode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtEntryCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCodeList = new System.Windows.Forms.Button();
            this.lblGenerateResult = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCheckResult = new System.Windows.Forms.Label();
            this.btnGnr = new System.Windows.Forms.Button();
            this.txtCofC = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(16, 65);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(159, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate 1000 Code";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(22, 65);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(159, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check Code";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtEntryCode
            // 
            this.txtEntryCode.Location = new System.Drawing.Point(22, 34);
            this.txtEntryCode.Name = "txtEntryCode";
            this.txtEntryCode.PlaceholderText = "Entry Code";
            this.txtEntryCode.Size = new System.Drawing.Size(159, 23);
            this.txtEntryCode.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCofC);
            this.groupBox1.Controls.Add(this.btnGnr);
            this.groupBox1.Controls.Add(this.btnCodeList);
            this.groupBox1.Controls.Add(this.lblGenerateResult);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generating Operation";
            // 
            // btnCodeList
            // 
            this.btnCodeList.Location = new System.Drawing.Point(16, 100);
            this.btnCodeList.Name = "btnCodeList";
            this.btnCodeList.Size = new System.Drawing.Size(159, 23);
            this.btnCodeList.TabIndex = 3;
            this.btnCodeList.Text = "Code List";
            this.btnCodeList.UseVisualStyleBackColor = true;
            this.btnCodeList.Visible = false;
            this.btnCodeList.Click += new System.EventHandler(this.btnCodeList_Click);
            // 
            // lblGenerateResult
            // 
            this.lblGenerateResult.AutoEllipsis = true;
            this.lblGenerateResult.AutoSize = true;
            this.lblGenerateResult.Location = new System.Drawing.Point(16, 152);
            this.lblGenerateResult.Name = "lblGenerateResult";
            this.lblGenerateResult.Size = new System.Drawing.Size(0, 15);
            this.lblGenerateResult.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCheckResult);
            this.groupBox2.Controls.Add(this.btnCheck);
            this.groupBox2.Controls.Add(this.txtEntryCode);
            this.groupBox2.Location = new System.Drawing.Point(228, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 189);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Checking Operation";
            // 
            // lblCheckResult
            // 
            this.lblCheckResult.AutoEllipsis = true;
            this.lblCheckResult.AutoSize = true;
            this.lblCheckResult.Location = new System.Drawing.Point(6, 106);
            this.lblCheckResult.Name = "lblCheckResult";
            this.lblCheckResult.Size = new System.Drawing.Size(0, 15);
            this.lblCheckResult.TabIndex = 4;
            // 
            // btnGnr
            // 
            this.btnGnr.Location = new System.Drawing.Point(112, 33);
            this.btnGnr.Name = "btnGnr";
            this.btnGnr.Size = new System.Drawing.Size(63, 23);
            this.btnGnr.TabIndex = 4;
            this.btnGnr.Text = "Generate Code";
            this.btnGnr.UseVisualStyleBackColor = true;
            this.btnGnr.Click += new System.EventHandler(this.btnGnr_Click);
            // 
            // txtCofC
            // 
            this.txtCofC.Location = new System.Drawing.Point(16, 33);
            this.txtCofC.Name = "txtCofC";
            this.txtCofC.PlaceholderText = "Count of Code";
            this.txtCofC.Size = new System.Drawing.Size(90, 23);
            this.txtCofC.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 216);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Campaign Code";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtEntryCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGenerateResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCheckResult;
        private System.Windows.Forms.Button btnCodeList;
        private System.Windows.Forms.TextBox txtCofC;
        private System.Windows.Forms.Button btnGnr;
    }
}

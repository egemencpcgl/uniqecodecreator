namespace CreateCode
{
    partial class GeneratedCodePage
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
            this.lstCode = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstCode
            // 
            this.lstCode.FormattingEnabled = true;
            this.lstCode.ItemHeight = 15;
            this.lstCode.Location = new System.Drawing.Point(0, 0);
            this.lstCode.Name = "lstCode";
            this.lstCode.Size = new System.Drawing.Size(315, 469);
            this.lstCode.TabIndex = 0;
            // 
            // GeneratedCodePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 470);
            this.Controls.Add(this.lstCode);
            this.Name = "GeneratedCodePage";
            this.Text = "GeneratedCodePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCode;
    }
}
namespace ATMEmulator
{
    partial class EnterPincode
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
            this.WelcomeTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeTextBox
            // 
            this.WelcomeTextBox.AutoSize = true;
            this.WelcomeTextBox.Location = new System.Drawing.Point(72, 77);
            this.WelcomeTextBox.Name = "WelcomeTextBox";
            this.WelcomeTextBox.Size = new System.Drawing.Size(13, 13);
            this.WelcomeTextBox.TabIndex = 0;
            this.WelcomeTextBox.Text = "d";
            // 
            // EnterPincode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 310);
            this.Controls.Add(this.WelcomeTextBox);
            this.Name = "EnterPincode";
            this.Text = "Enter Pincode";
            this.Load += new System.EventHandler(this.EnterPincode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeTextBox;
    }
}
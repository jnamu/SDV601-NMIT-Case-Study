namespace Enrolment_2._1
{
    partial class FrmMOEStudent
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
            this.lblLoan = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.lblFullTime = new System.Windows.Forms.Label();
            this.chkFullTime = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Location = new System.Drawing.Point(23, 127);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(64, 13);
            this.lblLoan.TabIndex = 12;
            this.lblLoan.Text = "Loan Amt. $";
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(126, 124);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(100, 20);
            this.txtLoan.TabIndex = 13;
            // 
            // lblFullTime
            // 
            this.lblFullTime.AutoSize = true;
            this.lblFullTime.Location = new System.Drawing.Point(29, 151);
            this.lblFullTime.Name = "lblFullTime";
            this.lblFullTime.Size = new System.Drawing.Size(49, 13);
            this.lblFullTime.TabIndex = 14;
            this.lblFullTime.Text = "Full Time";
            // 
            // chkFullTime
            // 
            this.chkFullTime.AutoSize = true;
            this.chkFullTime.Location = new System.Drawing.Point(126, 151);
            this.chkFullTime.Name = "chkFullTime";
            this.chkFullTime.Size = new System.Drawing.Size(15, 14);
            this.chkFullTime.TabIndex = 15;
            this.chkFullTime.UseVisualStyleBackColor = true;
            // 
            // FrmMOEStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(469, 261);
            this.Controls.Add(this.chkFullTime);
            this.Controls.Add(this.lblFullTime);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.lblLoan);
            this.Name = "FrmMOEStudent";
            this.Text = "MOE Student";
            this.Controls.SetChildIndex(this.lblLoan, 0);
            this.Controls.SetChildIndex(this.txtLoan, 0);
            this.Controls.SetChildIndex(this.lblFullTime, 0);
            this.Controls.SetChildIndex(this.chkFullTime, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.Label lblFullTime;
        private System.Windows.Forms.CheckBox chkFullTime;
    }
}

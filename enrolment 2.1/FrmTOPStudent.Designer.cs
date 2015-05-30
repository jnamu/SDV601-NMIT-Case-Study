namespace Enrolment_2._1
{
    partial class FrmTOPStudent
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtReferral = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Referral Agency";
            // 
            // txtReferral
            // 
            this.txtReferral.Location = new System.Drawing.Point(126, 150);
            this.txtReferral.Name = "txtReferral";
            this.txtReferral.Size = new System.Drawing.Size(100, 20);
            this.txtReferral.TabIndex = 13;
            // 
            // FrmTOPStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(469, 261);
            this.Controls.Add(this.txtReferral);
            this.Controls.Add(this.label6);
            this.Name = "FrmTOPStudent";
            this.Text = "TOP Student";
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtReferral, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReferral;
    }
}

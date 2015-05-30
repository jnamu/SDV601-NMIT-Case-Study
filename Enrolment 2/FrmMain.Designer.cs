namespace Enrolment_2
{
    partial class FrmMain
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
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnModStudent = new System.Windows.Forms.Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Location = new System.Drawing.Point(15, 21);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(106, 23);
            this.btnCreateStudent.TabIndex = 0;
            this.btnCreateStudent.Text = "Create Student";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // btnModStudent
            // 
            this.btnModStudent.Location = new System.Drawing.Point(15, 50);
            this.btnModStudent.Name = "btnModStudent";
            this.btnModStudent.Size = new System.Drawing.Size(106, 23);
            this.btnModStudent.TabIndex = 1;
            this.btnModStudent.Text = "Modify Student";
            this.btnModStudent.UseVisualStyleBackColor = true;
            this.btnModStudent.Click += new System.EventHandler(this.btnModStudent_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.Location = new System.Drawing.Point(12, 95);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(135, 48);
            this.lblStudent.TabIndex = 2;
            this.lblStudent.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(188, 120);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.btnModStudent);
            this.Controls.Add(this.btnCreateStudent);
            this.Name = "FrmMain";
            this.Text = "NMIT Enrolment System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnModStudent;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnClose;
    }
}


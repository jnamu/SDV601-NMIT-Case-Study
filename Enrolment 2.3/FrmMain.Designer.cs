namespace Enrolment_2._3
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudent.Location = new System.Drawing.Point(12, 55);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(173, 63);
            this.lblStudent.TabIndex = 2;
            this.lblStudent.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 95);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Location = new System.Drawing.Point(12, 12);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(111, 25);
            this.btnManageStudents.TabIndex = 4;
            this.btnManageStudents.Text = "Manage Students";
            this.btnManageStudents.UseVisualStyleBackColor = true;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.btnManageStudents);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStudent);
            this.Name = "FrmMain";
            this.Text = "NMIT Enrolment System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnManageStudents;
    }
}


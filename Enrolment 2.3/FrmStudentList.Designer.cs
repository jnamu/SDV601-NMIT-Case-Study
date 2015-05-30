namespace Enrolment_2._3
{
    partial class FrmStudentList
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
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnModStudent = new System.Windows.Forms.Button();
            this.cboStudentType = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSortChoice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(12, 77);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(259, 121);
            this.lstStudents.TabIndex = 0;
            this.lstStudents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstStudents_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DOB";
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Location = new System.Drawing.Point(13, 246);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(106, 23);
            this.btnCreateStudent.TabIndex = 4;
            this.btnCreateStudent.Text = "Create Student";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // btnModStudent
            // 
            this.btnModStudent.Location = new System.Drawing.Point(13, 275);
            this.btnModStudent.Name = "btnModStudent";
            this.btnModStudent.Size = new System.Drawing.Size(106, 23);
            this.btnModStudent.TabIndex = 5;
            this.btnModStudent.Text = "Modify Student";
            this.btnModStudent.UseVisualStyleBackColor = true;
            this.btnModStudent.Click += new System.EventHandler(this.btnModStudent_Click);
            // 
            // cboStudentType
            // 
            this.cboStudentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudentType.FormattingEnabled = true;
            this.cboStudentType.Location = new System.Drawing.Point(150, 246);
            this.cboStudentType.Name = "cboStudentType";
            this.cboStudentType.Size = new System.Drawing.Size(121, 21);
            this.cboStudentType.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(196, 275);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(14, 304);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteStudent.TabIndex = 8;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(14, 216);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(105, 23);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Find Student";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(150, 216);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sort By::";
            // 
            // cboSortChoice
            // 
            this.cboSortChoice.FormattingEnabled = true;
            this.cboSortChoice.Location = new System.Drawing.Point(150, 13);
            this.cboSortChoice.Name = "cboSortChoice";
            this.cboSortChoice.Size = new System.Drawing.Size(121, 21);
            this.cboSortChoice.TabIndex = 12;
            this.cboSortChoice.SelectedIndexChanged += new System.EventHandler(this.cboSortChoice_SelectedIndexChanged);
            // 
            // FrmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 342);
            this.Controls.Add(this.cboSortChoice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboStudentType);
            this.Controls.Add(this.btnModStudent);
            this.Controls.Add(this.btnCreateStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstStudents);
            this.Name = "FrmStudentList";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.FrmStudentList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnModStudent;
        private System.Windows.Forms.ComboBox cboStudentType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSortChoice;
    }
}
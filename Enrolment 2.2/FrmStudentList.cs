using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment_2._2
{
    public partial class FrmStudentList : Form
    {
        public FrmStudentList()
        {
            InitializeComponent();
            cboStudentType.DataSource = ClsStudent.StudentType;
            cboStudentType.SelectedIndex = 0;
        }

        private void updateDisplay()
        {
            lstStudents.DataSource = null;
            lstStudents.DataSource = ClsInstitute.StudentList;
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            ClsStudent lcStudent = ClsStudent.NewStudent(cboStudentType.SelectedIndex);
            if (lcStudent != null && lcStudent.ViewEdit())
            {
                ClsInstitute.StudentList.Add(lcStudent);
                updateDisplay();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModStudent_Click(object sender, EventArgs e)
        {
            editStudent();
        }

        private void editStudent()
        {
            ClsStudent lcStudent = (ClsStudent)lstStudents.SelectedItem;
            lcStudent.ViewEdit();
            updateDisplay();
        }

        private void lstStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editStudent();
        }


        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex > -1)  // something selected!
            {
                ClsStudent lcStudent = (ClsStudent)lstStudents.SelectedItem;
                string message = "Are you sure that you would like to delete student " + lcStudent.Name;
                const string caption = "Deleting Student";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

                // If the yes button was pressed ... 
                if (result == DialogResult.Yes)
                {
                    ClsInstitute.StudentList.RemoveAt(lstStudents.SelectedIndex);  // more efficient
//                    ClsInstitute.StudentList.Remove(lcStudent);  // alt
                    updateDisplay();
                }
                else
                {
//                    Close();
                }
            }
        }
    }
}


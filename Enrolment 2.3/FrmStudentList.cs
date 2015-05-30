using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment_2._3
{
    public partial class FrmStudentList : Form
    {
        public FrmStudentList()
        {
            InitializeComponent();
            cboStudentType.DataSource = ClsStudent.StudentType;
            cboStudentType.SelectedIndex = 0;
            cboSortChoice.DataSource = _SortStrings;
            cboSortChoice.SelectedIndex = 0;
        }

        private IComparer<ClsStudent>[] _Comparer = { new ClsNameComparer(), new ClsDOBComparer() };
        private readonly string[] _SortStrings = {"Name", "DOB" };

        class ClsDOBComparer : IComparer<ClsStudent>
        {
            public int Compare(ClsStudent prStudentX, ClsStudent prStudentY)
            {
                return prStudentX.DOB.Date.CompareTo(prStudentY.DOB.Date);
            }
        }

        class ClsNameComparer :IComparer<ClsStudent>
        {
            public int Compare(ClsStudent prStudentX, ClsStudent prStudentY)
            {
                return prStudentX.Name.CompareTo(prStudentY.Name);
            }
        }

        private void updateDisplay()
        {
            List<ClsStudent> lcStudentList = ClsInstitute.StudentList.Values.ToList();
            lcStudentList.Sort(_Comparer[cboSortChoice.SelectedIndex]);
            lstStudents.DataSource = lcStudentList;
//            lstStudents.DataSource = ClsInstitute.StudentList.Values.ToList<ClsStudent>();
            //lstStudents.DataSource = null;
            //lstStudents.DataSource = ClsInstitute.StudentList;
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            ClsStudent lcStudent = ClsStudent.NewStudent(cboStudentType.SelectedIndex);
            if (lcStudent != null && lcStudent.ViewEdit())
            {
                ClsInstitute.StudentList.Add(lcStudent.ID, lcStudent);
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
                ClsStudent lcStudent = (ClsStudent) lstStudents.SelectedItem;
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
                string caption = "Deleting Student";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

                // If the yes button was pressed ... 
                if (result == DialogResult.Yes)
                {
                    ClsInstitute.StudentList.Remove(lcStudent.ID);// Delete from parent
                    //ClsInstitute.StudentList.RemoveAt(lstStudents.SelectedIndex);  // more efficient
                    //ClsInstitute.StudentList.Remove(lcStudent);  // alt
                    updateDisplay();
                }
                else
                {
//                    Close();
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ClsStudent lcStudent;
            if (ClsInstitute.StudentList.TryGetValue(txtID.Text,out lcStudent))
            {
                lstStudents.SelectedItem = lcStudent;
            }
        }

        private void FrmStudentList_Load(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void cboSortChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplay();
        }
    }
}


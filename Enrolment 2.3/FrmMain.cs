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
    public partial class FrmMain : Form
    {
        private FrmStudentList _StudentListForm = new FrmStudentList();
//        private ClsStudent _Student;
//        private FrmStudent _StudentForm; //  = new FrmStudent();
//        private FrmStudent _MOEStudentForm = new FrmMOEStudent();
//        private FrmStudent _IntStudentForm = new FrmInternationalStudent();
//        private FrmStudent _TOPStudentForm = new FrmTOPStudent();
//        private string[] StudentType = { "MOE (local)", "International", "TOP" };

        public FrmMain()
        {
            InitializeComponent();
            try
            {
                ClsInstitute.Retrieve();
                UpdatelblStudent();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void UpdatelblStudent()
        {
            lblStudent.Text = string.Format("{0} Student(s) \nTotal Balance: {1:C}",
                    ClsInstitute.StudentList.Count, ClsInstitute.TotalBalance());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            ClsInstitute.Save();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            _StudentListForm.ShowDialog();
            UpdatelblStudent();
        }

        //private void btnCreateStudent_Click(object sender, EventArgs e)
        //{
        //    //if (cboStudentType.SelectedIndex == 0)
        //    //{
        //    //    _StudentForm = _MOEStudentForm;
        //    //    _Student = new ClsMOEStudent();
        //    //}
        //    //if (cboStudentType.SelectedIndex == 1)
        //    //{
        //    //    _StudentForm = _IntStudentForm;
        //    //    _Student = new ClsInternationalStudent();
        //    //}
        //    //else
        //    //{
        //    //    _StudentForm = _TOPStudentForm;
        //    //    _Student = new ClsTopStudent();
        //    //}
        //    ClsStudent lcStudent = ClsStudent.NewStudent(cboStudentType.SelectedIndex);
        //    editStudent(lcStudent);
        //}

        //private void editStudent (ClsStudent prStudent)
        //{
        //    if (prStudent != null && prStudent.ViewEdit())
        //    {
        //        _Student = prStudent;
        //        lblStudent.Text = "Student:\n" + _Student.ToString();
        //    }

        //}

        //private void btnModStudent_Click(object sender, EventArgs e)
        //{
        //    if (_Student == null)
        //        MessageBox.Show("You must create a student before you can modify a student");
        //    else
        //        editStudent(_Student);
        //}    
    }
}

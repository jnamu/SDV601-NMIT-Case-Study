using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment_2
{
    public partial class FrmMain : Form
    {
        private ClsStudent _Student;
        private FrmStudent _StudentForm = new FrmStudent();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            _Student = new ClsStudent();
            editStudent();
        }

        private void editStudent ()
        {
            if(_Student != null &&
               _StudentForm.ShowDialog(_Student) == DialogResult.OK)
            {
                lblStudent.Text = "Student:\n" + _Student.ToString();
            }
        }

        private void btnModStudent_Click(object sender, EventArgs e)
        {
            if (_Student == null)
                MessageBox.Show("You must create a student before you can modify a student");
            else
                editStudent();
        }    
    }
}

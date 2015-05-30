using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Enrolment_2._2
{
    public partial class FrmInternationalStudent : Enrolment_2._2.FrmStudent
    {
        public FrmInternationalStudent()
        {
            InitializeComponent();
        }

        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsInternationalStudent lcStudent = (ClsInternationalStudent)_Student;
            txtCountry.Text = lcStudent.Country;
            txtIELTS.Text = Convert.ToString(lcStudent.IELTS);
        }

        protected override void pushData()
        {
            base.pushData();
            ClsInternationalStudent lcStudent = (ClsInternationalStudent)_Student;
            lcStudent.Country = txtCountry.Text;
            lcStudent.IELTS = Convert.ToInt16(txtIELTS.Text);
        }

        private void FrmInternationalStudent_Load(object sender, EventArgs e)
        {

        }
    }
}

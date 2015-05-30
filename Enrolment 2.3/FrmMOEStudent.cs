using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Enrolment_2._3
{
    public partial class FrmMOEStudent : Enrolment_2._3.FrmStudent
    {
        public FrmMOEStudent()
        {
            InitializeComponent();
        }

        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsMOEStudent lcStudent = (ClsMOEStudent) _Student;
            txtLoan.Text = Convert.ToString(lcStudent.LoanAmount);
            chkFullTime.Checked = lcStudent.FullTime;
        }

        protected override void pushData()
        {
            base.pushData();
            ClsMOEStudent lcStudent = (ClsMOEStudent)_Student;
            lcStudent.LoanAmount = Convert.ToDecimal(txtLoan.Text);
            lcStudent.FullTime = chkFullTime.Checked;
        }
    }
}

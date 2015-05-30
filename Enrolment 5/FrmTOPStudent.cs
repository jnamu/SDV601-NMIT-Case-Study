using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Enrolment_2.Enrolment_5
{
    public partial class FrmTOPStudent : Enrolment_2.Enrolment_5.FrmStudent
    {
        public FrmTOPStudent()
        {
            InitializeComponent();
        }

        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsTopStudent lcStudent = (ClsTopStudent)_Student;
            txtReferral.Text = lcStudent.Referral;
        }

        protected override void pushData()
        {
            base.pushData();
            ClsTopStudent lcStudent = (ClsTopStudent)_Student;
            lcStudent.Referral = txtReferral.Text;
        }
    }
}
